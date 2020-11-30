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
        public NavigationViewModel()
        {
           TestOldCommand = new TestOldCommand(this);   
        }

        public ICommand TestOldCommand
        {
            get;
            private set;
        }

        private ActionCommand testNewCommand;

        public ICommand TestNewCommand
        {
            get
            {
                if (testNewCommand == null)
                {
                    testNewCommand = new ActionCommand(param=>this.Test(), param=> this.CanTest());
                }

                return testNewCommand;
            }
        }

        public void Test()
        {
            //TODO: update
        }

        private bool CanTest()
        {
            return true;
        }
    }
}
