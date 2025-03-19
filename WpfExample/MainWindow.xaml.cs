using System.Windows;

namespace WpfExample
{
    public partial class MainWindow : Window
    {
        private InfoCommand _infoCommand = new InfoCommand();

        public InfoCommand InformationCommand => _infoCommand;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this; // Set DataContext for binding
        }
    }
}
