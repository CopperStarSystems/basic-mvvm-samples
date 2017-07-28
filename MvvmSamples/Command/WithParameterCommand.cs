//  --------------------------------------------------------------------------------------
// MvvmSamples.WithParameterCommand.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MvvmSamples.Annotations;

namespace MvvmSamples.Command
{
    public class WithParameterCommand : ICommand, INotifyPropertyChanged
    {
        public event EventHandler CanExecuteChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        string mostRecentCommandParameter;

        public WithParameterCommand()
        {
            MostRecentCommandParameter = "Not Executed";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MostRecentCommandParameter = parameter.ToString();
        }

        public string MostRecentCommandParameter
        {
            get => mostRecentCommandParameter;
            private set
            {
                mostRecentCommandParameter = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}