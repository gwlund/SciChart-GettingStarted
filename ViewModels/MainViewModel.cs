using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciChart_GettingStarted.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public PointMarkersSelectionExampleViewModel PointMarkersSelectionExampleViewModel { get; set; }
        public NavigationViewModel NavigationViewModel { get; set; }

        public MainViewModel()
        {
            //TODO: Checkout CoronaClient LoadViewModel implementation
            PointMarkersSelectionExampleViewModel = new PointMarkersSelectionExampleViewModel();
            NavigationViewModel = new NavigationViewModel();
        }
    }
}
