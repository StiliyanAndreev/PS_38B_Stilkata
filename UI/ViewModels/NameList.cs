using System.Collections.ObjectModel;
using System.ComponentModel;

namespace UI.ViewModels
{
    public class NamesList : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _selectedName;

        public NamesList()
        {
            Names = new ObservableCollection<string>();
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string SelectedName
        {
            get => _selectedName;
            set
            {
                _selectedName = value;
                OnPropertyChanged(nameof(SelectedName));
            }
        }

        public ObservableCollection<string> Names { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
