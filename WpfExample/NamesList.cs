using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfExample
{
    public class NamesList : INotifyPropertyChanged
    {
        private string _firstName = "";
        private string _lastName = "";
        private string _selectedName;
        public RemoveCommand RemoveNameCommand { get; }


        public NamesList()
        {
            Names = new ObservableCollection<string>();
            AddNameCommand = new AddCommand(this);
            RemoveNameCommand = new RemoveCommand();
        }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string SelectedName
        {
            get => _selectedName;
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    OnPropertyChanged("SelectedName");
                }
            }
        }

        public ObservableCollection<string> Names { get; private set; }

        public AddCommand AddNameCommand { get; }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
