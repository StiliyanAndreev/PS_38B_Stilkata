using System;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a user with full details
            User user = new User(0, "John Doe", "password123", UserRolesEnum.STUDENT, "123456", "john.doe@example.com");

            // Create ViewModel
            UserViewModel userViewModel = new UserViewModel(user);

            // Create View
            UserView userView = new UserView(userViewModel);

            // Display Basic Information
            userView.Display();

            // Display Detailed Information
            userView.DetailedDisplay();

            Console.ReadKey(); // Prevent console from closing immediately
        }
    }
}
