using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SciChart_GettingStarted.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is raised when a property that calls the NotifyPropertyChanged method is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event alerting the WPF Framework to update the UI.
        /// This version allows multiple properties to be given at one time using the "params" type
        /// Ex: NotifyProperChanged(NameOf(prop1), NameOf(prop2),  ...)
        /// </summary>
        /// <param name="propertyNames">The names of the properties to update in the UI.</param>
        protected void NotifyPropertyChanged(params string[] propertyNames)
        {
            if (PropertyChanged != null)
            {
                foreach (string propertyName in propertyNames)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <summary>
        /// Raises the PropertyChanged event alerting the WPF Framework to update the UI.
        /// The [CallmemberName] decorator allows the method to be called with no arguments preventing
        /// the dreaded string call.  Ex: NotifyPropertyChanged() instead of NotifyPropertyChanged("Prop Name")
        /// </summary>
        /// <param name="propertyName">The optional name of the property to update in the UI. If this is left blank, the name will be taken from the calling member via the CallerMemberName attribute.</param>
        protected virtual void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
