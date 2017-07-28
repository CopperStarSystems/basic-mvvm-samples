//  --------------------------------------------------------------------------------------
// MvvmSamples.ValueConvertersViewModel.cs
// 2017/07/20
//  --------------------------------------------------------------------------------------

using MvvmSamples.Core;

namespace MvvmSamples.ValueConverters
{
    public class ValueConvertersViewModel : ViewModelBase
    {
        bool checkboxChecked;
        string upperLowerCaseExample;

        public bool CheckboxChecked
        {
            get => checkboxChecked;
            set
            {
                checkboxChecked = value;
                RaisePropertyChanged();
            }
        }

        public string UpperLowerCaseExample
        {
            get => upperLowerCaseExample;
            set
            {
                upperLowerCaseExample = value;
                RaisePropertyChanged();
            }
        }
    }
}