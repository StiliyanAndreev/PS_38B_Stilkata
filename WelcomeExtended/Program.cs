using System;
using Welcome.Model;
using Welcome.Others;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers; // Ensure correct namespace is included

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();

            // Adding test users
            userData.AddUser(new User(0, "Student1", "pass123", UserRolesEnum.STUDENT, "123456", "student1@example.com"));
            userData.AddUser(new User(0, "Student2", "123", UserRolesEnum.STUDENT, "654321", "student2@example.com"));
            userData.AddUser(new User(0, "Teacher", "1234", UserRolesEnum.PROFESSOR, "111111", "teacher@example.com"));
            userData.AddUser(new User(0, "Admin", "12345", UserRolesEnum.ADMIN, "000000", "admin@example.com"));

            Console.Write("🔑 Enter username: ");
            string? username = Console.ReadLine();

            Console.Write("🔒 Enter password: ");
            string? password = Console.ReadLine();

            try
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    if (userData.IsValidCredentials(username, password)) // Use correct method name
                    {
                        var user = userData.FetchUser(username, password); // Use correct method name
                        if (user != null)
                        {
                            Console.Clear();
                            Console.WriteLine("\n=========================================");
                            Console.WriteLine("            LOGIN SUCCESSFUL!        ");
                            Console.WriteLine("=========================================\n");

                            Console.WriteLine($" User Details:");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine($" ID:        {user.Id}");
                            Console.WriteLine($" Name:      {user.Names}");
                            Console.WriteLine($" Role:      {user.Role}");
                            Console.WriteLine($" Faculty:   {user.FacultyNumber}");
                            Console.WriteLine($" Email:     {user.Email}");
                            Console.WriteLine($" Expires:   {user.Expires}");
                            Console.WriteLine("-----------------------------------------\n");

                            Console.WriteLine("✅ You are now logged in!");
                        }
                        else
                        {
                            Console.WriteLine("\n❌ User not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n🚫 Invalid credentials. Please try again.");
                    }
                }
                else
                {
                    throw new Exception("⚠️ Username or password cannot be empty.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❗ Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
