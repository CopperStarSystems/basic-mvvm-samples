//  --------------------------------------------------------------------------------------
// MvvmSamples.CanExecuteCommand.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using System.Windows.Input;

namespace MvvmSamples.Command
{
    public class CanExecuteCommand : ICommand
    {
        readonly CommandViewModel commandViewModel;

        public CanExecuteCommand(CommandViewModel commandViewModel)
        {
            this.commandViewModel = commandViewModel;
            commandViewModel.PropertyChanged += (s, e) =>
                                                {
                                                    if (e.PropertyName ==
                                                        "AllowCanExecuteCommandToExecute")
                                                        OnCanExecuteChanged();
                                                };
        }

        public bool CanExecute(object parameter)
        {
            return commandViewModel.AllowCanExecuteCommandToExecute;
        }

        public void Execute(object parameter)
        {
            // Do nothing.
        }

        public event EventHandler CanExecuteChanged;

        protected virtual void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}