//  --------------------------------------------------------------------------------------
// MvvmSamples.CountInvocationsCommand.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using System.Windows.Input;

namespace MvvmSamples.Command
{
    public class CountInvocationsCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            InvocationCount++;
            InvocationCountChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler CanExecuteChanged;

        public event EventHandler InvocationCountChanged;

        public int InvocationCount { get; private set; }
    }
}