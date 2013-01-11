﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zetbox.ConfigEditor.ViewModels;

namespace Zetbox.ConfigEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WindowViewModel vmdl;
        public MainWindow()
        {
            InitializeComponent();
            vmdl = new WindowViewModel();
            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                vmdl.Open(args[1]);
            }
            this.DataContext = vmdl;
        }
    }
}
