using System;
using System.Windows;
using System.Windows.Input;
using UI.Views;

namespace UI.ViewModels
{
    public class InfoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");
            NamesWindow namesWindow = new NamesWindow();
            namesWindow.Show();
        }
    }
}
