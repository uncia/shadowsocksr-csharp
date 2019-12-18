using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows;

using Microsoft.Win32;

using Shadowsocks.Controller;
using Shadowsocks.Model;
using Shadowsocks.Util;
using Shadowsocks.View;

namespace Shadowsocks
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private ShadowsocksController _controller;
        private MenuViewController _viewController;
        private Mutex _instanceMutex = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            String startPath = AppDomain.CurrentDomain.BaseDirectory;
            Directory.SetCurrentDirectory(startPath);

            this._instanceMutex = new Mutex(true, $"ShadowsocksR_{Convert.ToBase64String(Encoding.UTF8.GetBytes(startPath))}");
            if (!this._instanceMutex.WaitOne(0, false))
            {
                this._instanceMutex = null;
                MessageBox.Show(I18N.GetString("Find Shadowsocks icon in your notify tray.") + "\n" +
                        I18N.GetString("If you want to start multiple Shadowsocks, make a copy in another directory."),
                        I18N.GetString("ShadowsocksR is already running."));
                Shutdown();
                return;
            }

            Utils.ReleaseMemory();

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;

            Int32 try_times = 0;
            while (Configuration.Load() == null)
            {
                if (try_times >= 5)
                {
                    MessageBox.Show(I18N.GetString("Cannot load config file."),
                        "Shadowsocksr Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    Shutdown();
                }
                try_times += 1;
            }
            if (try_times > 0)
            {
                Logging.save_to_file = false;
            }

            Logging.OpenLogFile();

            this._controller = new ShadowsocksController();
            HostMap.Instance().LoadHostFile();

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            this._viewController = new MenuViewController(this._controller);

            this._controller.Start();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            if (this._controller != null)
            {
                this._controller.Stop();
                this._controller = null;
            }
            if (this._instanceMutex != null)
            {
                this._instanceMutex.ReleaseMutex();
            }
        }

        private void SystemEvents_PowerModeChanged(Object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    if (this._controller != null)
                    {
                        System.Timers.Timer timer = new System.Timers.Timer(5 * 1000);
                        timer.Elapsed += Timer_Elapsed;
                        timer.AutoReset = false;
                        timer.Enabled = true;
                        timer.Start();
                    }
                    break;

                case PowerModes.Suspend:
                    if (this._controller != null)
                    {
                        this._controller.Stop();
                    }

                    break;
            }
        }

        private void Timer_Elapsed(Object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (this._controller != null)
                {
                    this._controller.Start();
                }
            }
            catch (Exception ex)
            {
                Logging.LogUsefulException(ex);
            }
            finally
            {
                try
                {
                    System.Timers.Timer timer = (System.Timers.Timer)sender;
                    timer.Enabled = false;
                    timer.Stop();
                    timer.Dispose();
                }
                catch (Exception ex)
                {
                    Logging.LogUsefulException(ex);
                }
            }
        }

        private static Int32 exited = 0;

        private void CurrentDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            if (Interlocked.Increment(ref exited) == 1)
            {
                Logging.Log(LogLevel.Error, e.ExceptionObject != null ? e.ExceptionObject.ToString() : "");
                MessageBox.Show(I18N.GetString("Unexpected error, ShadowsocksR will exit.") +
                    Environment.NewLine + (e.ExceptionObject != null ? e.ExceptionObject.ToString() : ""),
                    "Shadowsocks Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Shutdown();
            }
        }
    }
}