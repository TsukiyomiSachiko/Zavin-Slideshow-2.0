﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Media.Animation;

namespace Zavin.Slideshow.wpf
{
    /// <summary>
    /// Interaction logic for WeekGraphPage.xaml
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public partial class WeekGraphPage : Page
    {
        private readonly ObservableCollection<ProductionData> _production = new ObservableCollection<ProductionData>();

        private readonly ObservableCollection<ProductionDataViewModel> _productionViewModel = new ObservableCollection<ProductionDataViewModel>();
        public WeekGraphPage()
        {
            InitializeComponent();

            var tmp = _mainController.GetProduction(DateTime.Now.Year, false);

            foreach (var item in tmp)
            {
                _production.Add(new ProductionData (item.Week, item.Burned, item.Wasta));
                if (item.Burned >= 280)
                {
                    AxisModifier.Maximum = 350;
                }
            }

            foreach (var prod in _production)
            {
                _productionViewModel.Add(new ProductionDataViewModel(prod));
            }
        }

        readonly MainController _mainController = new MainController();

        private void BarGraphAnimations()
        {

            // Set animation on Bar Graph upon loading of the window.

            //Animation for Production and Aanvoer.
            var moveAnimation =
                new DoubleAnimation
                {
                    From = MainChart.TransformToAncestor(this).Transform(new Point(0, 0)).Y,
                    To = MainChart.ActualHeight / 1.57,
                    Duration = TimeSpan.FromMilliseconds(4000)
                };
            BarSeriesProductie.BeginAnimation(HeightProperty, moveAnimation);
            BarSeriesAanvoer.BeginAnimation(HeightProperty, moveAnimation);

        }

        private void WeekGraphPage1_Loaded(object sender, RoutedEventArgs e)
        {
            BarGraphAnimations();

            ((ColumnSeries)MainChart.Series[0]).ItemsSource = _productionViewModel;

            ((ColumnSeries)MainChart.Series[1]).ItemsSource = _mainController.GetAcaf(DateTime.Now.Year, false);

            var currentWeek = DatabaseController.GetCurrentWeek(DateTime.Now);

            LabelAfgelopenWeek.Content = "Totaal Afgelopen week: " + _mainController.GetProduction(DateTime.Now.Year, false)[currentWeek - 1].Burned;
            labelHuidigeWeek.Content = "Totaal Huidige week: " + _mainController.GetProduction(DateTime.Now.Year, false)[currentWeek].Burned;
        }
       
    }
}
