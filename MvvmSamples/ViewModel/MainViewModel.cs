//  --------------------------------------------------------------------------------------
// MvvmSamples.MainViewModel.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System.Windows.Input;
using MvvmSamples.Core;
using MvvmSamples.ViewModel.Command;

namespace MvvmSamples.ViewModel
{
    // In a production application, there would be a corresponding IMainViewModel interface
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ShowDataBindingViewCommand = new ShowDataBindingViewCommand();
        }

        public ICommand ShowDataBindingViewCommand { get; }
    }
}