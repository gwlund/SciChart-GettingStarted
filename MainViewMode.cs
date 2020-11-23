using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciChart.Data.Model;

namespace SciChart_GettingStarted
{
    public class MainViewModel : BindableObject
    {
        private string _test;
        private string _chartTitle = "Chart Title";
        private string _xAxisTitle = "XAxis";
        private string _yAxisTitle = "YAxis";

        public MainViewModel()
        {
            TestString = "Hello MVVM World!";
        }
        public string TestString
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("TestString");
            }
        }

        public string ChartTitle
        {
            get { return _chartTitle; }
            set
            {
                _chartTitle = value;
                OnPropertyChanged("ChartTitle");
            }
        }
        public string XAxisTitle
        {
            get { return _xAxisTitle; }
            set
            {
                _xAxisTitle = value;
                OnPropertyChanged("XAxisTitle");
            }
        }
        public string YAxisTitle
        {
            get { return _yAxisTitle; }
            set
            {
                _yAxisTitle = value;
                OnPropertyChanged("YAxisTitle");
            }
        }
    }
}
