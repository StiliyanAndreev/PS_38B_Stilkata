using System.Windows.Input;

namespace UI.ViewModels
{
    public class MainViewModel
    {
        public ICommand InformationCommand { get; }

        public MainViewModel()
        {
            InformationCommand = new InfoCommand();
        }
    }
}
