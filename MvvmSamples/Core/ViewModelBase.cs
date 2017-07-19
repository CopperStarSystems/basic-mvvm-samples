//  --------------------------------------------------------------------------------------
// MvvmSamples.ViewModelBase.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmSamples.Annotations;

namespace MvvmSamples.Core
{
    public abstract class ViewModelBase : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}