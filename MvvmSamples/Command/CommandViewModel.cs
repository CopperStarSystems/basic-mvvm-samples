//  --------------------------------------------------------------------------------------
// MvvmSamples.CommandViewModel.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System.Windows.Input;
using MvvmSamples.Core;

namespace MvvmSamples.Command
{
    public class CommandViewModel : ViewModelBase
    {
        bool allowCanExecuteCommandToExecute;

        public CommandViewModel()
        {
            CountInvocationsCommand = new CountInvocationsCommand();
            WithParameterCommand = new WithParameterCommand();
            CanExecuteCommand = new CanExecuteCommand(this);
        }

        public bool AllowCanExecuteCommandToExecute
        {
            get => allowCanExecuteCommandToExecute;
            set
            {
                allowCanExecuteCommandToExecute = value;
                RaisePropertyChanged();
            }
        }

        public ICommand CanExecuteCommand { get; }

        public ICommand CountInvocationsCommand { get; }

        public ICommand WithParameterCommand { get; }
    }
}