using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EasyMVVM
{
    // ViewModel implements INotifyPropertyChanged for data binding
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _entries;
        private Model _model;

        public ViewModel()
        {
            _model = new Model();
            _entries = _model.GetData();
        }

        public ObservableCollection<string> Entries
        {
            get { return _entries; }
            set
            {
                _entries = value;
                OnPropertyChanged("Entries");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
