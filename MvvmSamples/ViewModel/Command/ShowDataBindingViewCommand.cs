//  --------------------------------------------------------------------------------------
// MvvmSamples.ShowDataBindingViewCommand.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using MvvmSamples.Core;
using MvvmSamples.DataBinding;
using MvvmSamples.DataBinding.View;

namespace MvvmSamples.ViewModel.Command
{
    public class ShowDataBindingViewCommand : CommandBase
    {
        protected override void ExecuteInternal(object parameter)
        {
            var view = new DataBindingView();
            var viewModel = new DataBindingViewModel();
            view.DataContext = viewModel;
            view.Show();
        }
    }
}