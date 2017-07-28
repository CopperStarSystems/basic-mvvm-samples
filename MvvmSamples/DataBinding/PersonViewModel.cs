//  --------------------------------------------------------------------------------------
// MvvmSamples.PersonViewModel.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using MvvmSamples.Core;

namespace MvvmSamples.DataBinding
{
    public class PersonViewModel : ViewModelBase
    {
        private DateTime birthDate;
        private string firstName;
        private string lastName;

        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                RaisePropertyChanged();
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                RaisePropertyChanged();
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;

                RaisePropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}