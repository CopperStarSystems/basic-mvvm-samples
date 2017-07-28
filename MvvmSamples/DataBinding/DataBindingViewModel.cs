//  --------------------------------------------------------------------------------------
// MvvmSamples.DataBindingViewModel.cs
// 2017/07/19
//  --------------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using MvvmSamples.Core;

namespace MvvmSamples.DataBinding
{
    public class DataBindingViewModel : ViewModelBase
    {
        PersonViewModel localSelectedPerson;
        private PersonViewModel selectedPerson;
        private string selectedString;
        private string simpleBindingExample;

        private string updateSourceTriggerExample;

        public DataBindingViewModel()
        {
            SimpleBindingExample = "Enter Some Text...";
            BasicItemsSourceExample =
                new ObservableCollection<string> {"First Item", "Second Item", "Third Item"};
            People = new ObservableCollection<PersonViewModel>
                     {
                         new PersonViewModel
                         {
                             BirthDate
                                 = DateTime
                                     .Today,
                             FirstName
                                 = "Person 1 First",
                             LastName
                                 = "Person 1 Last"
                         },
                         new PersonViewModel
                         {
                             BirthDate
                                 = DateTime
                                     .Today
                                     .AddMonths(
                                         -6),
                             FirstName
                                 = "Person 2 First",
                             LastName
                                 = "Person 2 Last"
                         },
                         new PersonViewModel
                         {
                             BirthDate
                                 = DateTime
                                     .Today
                                     .AddYears(
                                         -5),
                             FirstName
                                 = "Person 3 First",
                             LastName
                                 = "Person 3 Last"
                         }
                     };
        }

        public ObservableCollection<string> BasicItemsSourceExample { get; }

        public PersonViewModel LocalSelectedPerson
        {
            get => localSelectedPerson;
            set
            {
                localSelectedPerson = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<PersonViewModel> People { get; }

        public PersonViewModel SelectedPerson
        {
            get => selectedPerson;
            set
            {
                selectedPerson = value;
                RaisePropertyChanged();
            }
        }

        public string SelectedString
        {
            get => selectedString;
            set
            {
                selectedString = value;
                RaisePropertyChanged();
            }
        }

        public string SimpleBindingExample
        {
            get => simpleBindingExample;
            set
            {
                simpleBindingExample = value;
                RaisePropertyChanged();
            }
        }

        public string UpdateSourceTriggerExample
        {
            get => updateSourceTriggerExample;
            set
            {
                updateSourceTriggerExample = value;
                RaisePropertyChanged();
            }
        }
    }
}