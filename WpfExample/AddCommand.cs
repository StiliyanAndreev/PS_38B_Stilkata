using System;
using System.Windows.Input;

namespace WpfExample
{
    public class AddCommand : ICommand
    {
        private NamesList _nameList;

        public AddCommand(NamesList nameList)
        {
            _nameList = nameList;
        }

        public void Execute(object parameter)
        {
            string newName = $"{_nameList.FirstName} {_nameList.LastName}";
            _nameList.Names.Add(newName);
            _nameList.FirstName = _nameList.LastName = "";
        }

        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;
    }
}
