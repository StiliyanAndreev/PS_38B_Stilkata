using System.Windows;

namespace EasyMVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM(); // Set ViewModel as DataContext
        }
    }
}
