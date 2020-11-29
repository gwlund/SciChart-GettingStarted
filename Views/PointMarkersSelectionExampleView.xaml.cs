using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using SciChart.Charting.Model.DataSeries;

namespace SciChart_GettingStarted.Views
{
    //Using point meta data
    //https://www.scichart.com/documentation/win/current/webframe.html#DataSeries%20PointMetadata%20API.html
    public class MyMetadata : IPointMetadata
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsSelected { get; set; }
        public string PointId { get; set; }
    }
    /// <summary>
    /// Interaction logic for PointMarkersSelectionExampleView.xaml
    /// </summary>
    public partial class PointMarkersSelectionExampleView : Window
    {
        public PointMarkersSelectionExampleView()
        {
            InitializeComponent();
        }

        private void PointMarkersSelectionExampleView_OnLoaded(object sender, RoutedEventArgs e)
        {
            // Create a DataSeries of type X=double, Y=double
            var dataSeries1 = new XyDataSeries<double, double> {SeriesName = "Green"};
            var dataSeries2 = new XyDataSeries<double, double> {SeriesName = "Blue"};
            var dataSeries3 = new XyDataSeries<double, double> {SeriesName = "Yellow"};

            // Attach DataSeries to RenderableSeries
            lineRenderSeries1.DataSeries = dataSeries1;
            lineRenderSeries2.DataSeries = dataSeries2;
            lineRenderSeries3.DataSeries = dataSeries3;

            // Generate data
            var count = 200;
            //var data1 = DataManager.Instance.GetSinewave(100, 55, count);
            //var data3 = DataManager.Instance.GetSinewave(50, 20, count);
            var data1 = new Data();
            var data3 = new Data();

            for (int i = 0; i < count; i++)
            {
                
                data1.Add("Sin", i, Math.Sin(i * 0.1));
                data3.Add("Cos", i, Math.Cos(i * 0.5));
            }

            // Append data to series
            using (sciChart.SuspendUpdates())
            {

                dataSeries1.Append(data1.XData, data1.YData, data1.XData.Select((d) => new MyMetadata {IsSelected = false, PointId = "Sine"}));

                dataSeries3.Append(data3.XData, data3.YData, data3.XData.Select((d) => new MyMetadata {IsSelected = false, PointId = "Cos"}));

                //for (int i = 0; i < count; i += 4)
                //{
                //    dataSeries2.Append(data1.XData[i], i++, new MyMetadata {IsSelected = false});
                //}
            }

            // Zoom out to the extents of data
            sciChart.ZoomExtents();
        }

        
    }

    internal class Data
    {

        public List<double> XData  = new List<double>();
        public List<double> YData = new List<double>();
        public string ProfileSet;

        public Data()
        {
        }

        public void Add(string id, double x, double y)
        {
            XData.Add(x);
            YData.Add(y);
            ProfileSet = id;
        }
    }
}
