using System;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");

            // Open NamesWindow after the message box
            NamesWindow namesWindow = new NamesWindow();
            namesWindow.Show();
        }
    }
}
