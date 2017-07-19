//  --------------------------------------------------------------------------------------
// MvvmSamples.CommandBase.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using System.Windows.Input;

namespace MvvmSamples.Core
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ExecuteInternal(parameter);
        }

        protected abstract void ExecuteInternal(object parameter);

        protected void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}