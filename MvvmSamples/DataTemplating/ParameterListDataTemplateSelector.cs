//  --------------------------------------------------------------------------------------
// MvvmSamples.ParameterListDataTemplateSelector.cs
// 2017/07/20
//  --------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;
using MvvmSamples.Model;

namespace MvvmSamples.DataTemplating
{
    public class ParameterListDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var element = container as FrameworkElement;
            if (element != null && item is ParameterBase)
                if (item is TextParameter)
                    return element.FindResource(typeof(TextParameter)) as DataTemplate;
                else if (item is NumericRangedParameter)
                    return element.FindResource(
                        typeof(NumericRangedParameter)) as DataTemplate;
                else if (item is DateTimeParameter)
                    return element.FindResource(typeof(DateTimeParameter)) as DataTemplate;
                
            return null;
        }
    }
}