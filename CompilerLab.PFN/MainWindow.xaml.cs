﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompilerLab.PFN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public async Task Evaluate(string input)
        {

        }

        private async void BtnEvaluate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var input = TxtInput.Text;
            await Evaluate(input);
        }
    }
}
