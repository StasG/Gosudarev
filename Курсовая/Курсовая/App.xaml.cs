﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Курсовая
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);
        }

        private static void GlobalExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            int exitCode = 0;
            try
            {
                Exception exception = (Exception)args.ExceptionObject;
                exitCode = exception.GetHashCode();
                MessageBox.Show("К сожалению что-то пошло не так, сообщите разработчику о данной ошибке. Приносим вам наши извинения! " + exception.Message, "Uncaught Thread Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                exitCode = -1;
            }
            finally
            {
                Environment.Exit(exitCode);
            }
        }
    }
}
