﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NotifyIcon = System.Windows.Forms.NotifyIcon;

namespace IdleRGB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public static NotifyIcon icon;

        protected override void OnStartup(StartupEventArgs e)
        {
            /*App.icon = new NotifyIcon();
            icon.Click += new EventHandler(Icon_Click);
            icon.Icon = IdleRGB.Properties.Resources.bulb;
            icon.Visible = true;*/

            ProcessIcon processIcon = new ProcessIcon();
            processIcon.Display();

            Input input = new Input();

            base.OnStartup(e);
        }
    }
}