using System;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void DisplayError()
        {
            throw new Exception("Simulated error for testing.");
        }


        public void Display()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine($"User: {_viewModel.Names}");
            Console.WriteLine($"Role: {_viewModel.Role}");
        }

        public void DetailedDisplay()
        {
            Console.WriteLine("\n==== User Details ====");
            Console.WriteLine($"Name: {_viewModel.Names}");
            Console.WriteLine($"Role: {_viewModel.Role}");
            Console.WriteLine($"Faculty Number: {_viewModel.FacultyNumber}");
            Console.WriteLine($"Email: {_viewModel.Email}");
            Console.WriteLine($"Encrypted Password: {_viewModel.EncryptedPassword}");
            Console.WriteLine("=====================\n");
        }
    }
}
