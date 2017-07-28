//  --------------------------------------------------------------------------------------
// MvvmSamples.MainViewModel.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using MvvmSamples.Command;
using MvvmSamples.Core;
using MvvmSamples.DataBinding;
using MvvmSamples.DataTemplating;
using MvvmSamples.ListDataBinding;
using MvvmSamples.ValueConverters;

namespace MvvmSamples.ViewModel
{
    // In a production application, there would be a corresponding IMainViewModel interface
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            DataBindingViewModel = new DataBindingViewModel();
            DataTemplatingViewModel = new DataTemplatingViewModel();
            CommandViewModel = new CommandViewModel();
            ValueConvertersViewModel = new ValueConvertersViewModel();
            ListDataBindingViewModel = new ListDataBindingViewModel();
        }

        public CommandViewModel CommandViewModel { get; }

        public DataBindingViewModel DataBindingViewModel { get; }

        public DataTemplatingViewModel DataTemplatingViewModel { get; }

        public ValueConvertersViewModel ValueConvertersViewModel { get; }

        public ListDataBindingViewModel ListDataBindingViewModel { get; }
    }
}