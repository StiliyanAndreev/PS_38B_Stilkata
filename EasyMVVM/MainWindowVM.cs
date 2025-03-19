using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EasyMVVM
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<string> _backingProperty;
        private Model _model;

        public MainWindowVM()
        {
            _model = new Model(); // Create Model instance
            BoundProperty = _model.GetData(); // Bind Model data to ViewModel
        }

        public ObservableCollection<string> BoundProperty
        {
            get { return _backingProperty; }
            set
            {
                _backingProperty = value;
                PropChanged("BoundProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void PropChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
