using System.Collections.ObjectModel;

namespace EasyMVVM
{
    // The Model class stores data and provides it to the ViewModel
    public class Model
    {
        private ObservableCollection<string> _data = new ObservableCollection<string>();

        public ObservableCollection<string> GetData()
        {
            // Simulate database retrieval (dummy data)
            _data.Add("First Entry");
            _data.Add("Second Entry");
            _data.Add("Third Entry");
            return _data;
        }
    }
}
