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
using System.Windows.Shapes;
using SciChart.Charting.ChartModifiers;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Annotations;
using SciChart.Charting.Visuals.Axes;

namespace SciChart.Tutorial
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindowOption2 : Window
    {
        public MainWindowOption2()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            // Create XyDataSeries to host data for our charts
            var scatterData = new XyDataSeries<double, double>();
            var lineData = new XyDataSeries<double, double>();

            for (int i = 0; i < 1000; i++)
            {
                lineData.Append(i, Math.Sin(i * 0.1));
                scatterData.Append(i, Math.Cos(i * 0.1));
            }
            // Assign dataseries to RenderSeries
            LineSeries.DataSeries = lineData;
            ScatterSeries.DataSeries = scatterData;
        }
    }
}
