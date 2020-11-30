using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SciChart_GettingStarted.Commands;

namespace SciChart_GettingStarted.ViewModels
{
    public class NavigationViewModel: ViewModelBase
    {
        public ICommand TestOldCommand
        {
            get;
            private set;
        }
        public NavigationViewModel()
        {
           TestOldCommand = new TestOldCommand(this);   
        }


        public ICommand TestCommand
        {
            get { return new ActionCommand(action => Test()); }
        }

        public void Test()
        {
            //TODO: update
        }
    }
}
