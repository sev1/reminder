﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Fligern.UsefulReminder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        ApplicationController appController;
        protected override void OnStartup(StartupEventArgs e)
        {
            appController = new ApplicationController();
            appController.Initialize();
            base.OnStartup(e);
        }
    }
}
