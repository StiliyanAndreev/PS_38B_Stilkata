using System;
using System.Windows.Input;

namespace WpfExample
{
    public class RemoveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if (parameter is NamesList nameList)
            {
                var oldName = nameList.SelectedName;
                if (!string.IsNullOrEmpty(oldName))
                {
                    nameList.Names.Remove(oldName);
                    nameList.SelectedName = null;
                }
            }
        }
    }
}
