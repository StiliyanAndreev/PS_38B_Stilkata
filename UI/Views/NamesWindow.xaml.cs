using System.Windows;
using UI.ViewModels;

namespace UI.Views
{
    public partial class NamesWindow : Window
    {
        public NamesWindow()
        {
            InitializeComponent();
            DataContext = new NamesList();
        }
    }
}
