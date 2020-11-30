using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciChart.Data.Model;
using SciChart_GettingStarted.ViewModels;

namespace SciChart_GettingStarted.ViewModels
{
    //TODO: SciChart examples using SciChart.Data.Model.Bindable object to provide INotifyPropertyChanged.
    //What does this buy us? and should we add to viewModelBase?
    public class PointMarkersSelectionExampleViewModel : ViewModelBase
    {
        private string _test;
        private string _chartTitle = "Chart Title";
        private string _xAxisTitle = "XAxis";
        private string _yAxisTitle = "YAxis";

        public PointMarkersSelectionExampleViewModel()
        {
            TestString = "Hello MVVM World!";
        }

        public string TestString
        {
            get { return _test; }
            set
            {
                _test = value;
                NotifyPropertyChanged();
            }
        }

        public string ChartTitle
        {
            get { return _chartTitle; }
            set
            {
                _chartTitle = value;
                NotifyPropertyChanged();
            }
        }
        public string XAxisTitle
        {
            get { return _xAxisTitle; }
            set
            {
                _xAxisTitle = value;
                NotifyPropertyChanged();
            }
        }
        public string YAxisTitle
        {
            get { return _yAxisTitle; }
            set
            {
                _yAxisTitle = value;
                NotifyPropertyChanged();
            }
        }
    }
}
