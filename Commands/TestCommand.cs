using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SciChart_GettingStarted.ViewModels;

namespace SciChart_GettingStarted.Commands
{
    public class TestOldCommand : ICommand
    {
        private NavigationViewModel _vm;

        public TestOldCommand(NavigationViewModel vm)
        {
            _vm = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vm.Test();
        }

        public event EventHandler CanExecuteChanged;
    }
}
