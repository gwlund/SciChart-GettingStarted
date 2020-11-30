using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SciChart_GettingStarted.ViewModels
{
    //
    /// <summary>
    /// Delegate for command logic.  Enables View to bind commands to objects that are not part of the element tree.  Some people call this relay command
    /// </summary>
    public class ActionCommand : ICommand
    {
        readonly Action<object> execute;
        readonly Predicate<object> canExecute;
        
        private EventHandler eventHandler;

        public ActionCommand(Action<object> execute) : this(execute, null) { }

        public ActionCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                eventHandler += value;
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                eventHandler -= value;
                CommandManager.RequerySuggested -= value;
            }
        }

        public void RaiseCanExecuteChanged()
        {
            eventHandler?.Invoke(this, new EventArgs());
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
