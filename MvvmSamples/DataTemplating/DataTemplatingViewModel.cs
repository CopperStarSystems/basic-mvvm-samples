//  --------------------------------------------------------------------------------------
// MvvmSamples.DataTemplatingViewModel.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using MvvmSamples.Core;
using MvvmSamples.Model;

namespace MvvmSamples.DataTemplating
{
    public class DataTemplatingViewModel : ViewModelBase
    {
        public DataTemplatingViewModel()
        {
            SimpleItemProperties=new ObservableCollection<object>
                                 {
                                     "Hello",
                                     "World",
                                     DateTime.Now,
                                     42,
                                     DateTime.Now.AddDays(20),
                                     "Last Item",
                                     new byte[]{}
                                 };

            Parameters = new ObservableCollection<ParameterBase>
                         {
                             new NumericRangedParameter{MinValue = 1, MaxValue = 100, Value = 1},
                             new DateTimeParameter{Value = DateTime.Today.AddDays(-7)},
                             new NumericRangedParameter{MinValue = 50, MaxValue = 100, Value = 90},
                             new TextParameter{Value = "Hello Parameter."}
                         };
        }

        public ObservableCollection<object> SimpleItemProperties { get; }

        public ObservableCollection<ParameterBase> Parameters { get; }
    }
}