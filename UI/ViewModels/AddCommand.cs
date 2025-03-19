using System;
using System.Windows.Input;

namespace UI.ViewModels
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if (parameter is NamesList namesList)
            {
                string newName = $"{namesList.FirstName} {namesList.LastName}";
                namesList.Names.Add(newName);
                namesList.FirstName = namesList.LastName = "";
            }
        }
    }
}
