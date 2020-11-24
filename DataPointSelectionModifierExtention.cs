using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SciChart.Charting.ChartModifiers;

namespace SciChart_GettingStarted
{
    //how to bind selectedPoints from DataPointSelectionModifier in XAML to ViewModel
    //https://www.scichart.com/questions/wpf/i-want-to-bind-selectedpointmarkers-of-datapointselectionmodifier
    public class DataPointSelectionModifierExtention : DataPointSelectionModifier
{
    public ObservableCollection<DataPointInfo> SelectedPointMarkers2
    {
        get => (ObservableCollection<DataPointInfo>)GetValue(SelectedPointMakers2Property);
        set => SetValue(SelectedPointMakers2Property, value);
    }
    public static readonly DependencyProperty SelectedPointMakers2Property =
        DependencyProperty.Register(
            nameof(SelectedPointMarkers2),
            typeof(ObservableCollection<DataPointInfo>),
            typeof(DataPointSelectionModifierExtention),
            new PropertyMetadata(new ObservableCollection<DataPointInfo>()));

    public DataPointSelectionModifierExtention()
    {
        base.SelectedPointMarkers.CollectionChanged += SelectedPointMakers_CollectionChanged;
    }

    private void SelectedPointMakers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                foreach (var item in e.NewItems.Cast<DataPointInfo>())
                {
                    this.SelectedPointMarkers2.Add(item);
                }
                break;
            case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                SelectedPointMarkers2.Clear();
                break;
            case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                foreach (var item in e.OldItems.Cast<DataPointInfo>())
                {
                    this.SelectedPointMarkers2.Remove(item);
                }
                break;
            case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
            case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
            default:
                throw new ApplicationException();
        }
    }
}
}
