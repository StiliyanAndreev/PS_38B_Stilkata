using WelcomeExtended.Model;
using Welcome.Others;
using Microsoft.Extensions.Logging;
using WelcomeExtended.Loggers;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                var logger = new DatabaseLogger("UserActions", context);


                Console.WriteLine("Choose an action:");
                Console.WriteLine("1️⃣ List Users");
                Console.WriteLine("2️⃣ Add User");
                Console.WriteLine("3️⃣ Delete User");
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    var users = context.Users.ToList();
                    foreach (var user in users)
                    {
                        Console.WriteLine($"ID: {user.Id}, Name: {user.Names}, Role: {user.Role}");
                    }
                    logger.Log(LogLevel.Information, new EventId(1), "Listed all users", null, (state, ex) => state.ToString());
                }
                else if (choice == "2")
                {
                    Console.Write("Enter Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    var password = Console.ReadLine();

                    var newUser = new DatabaseUser(name, password, UserRolesEnum.STUDENT, "000000", $"{name}@example.com");
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    logger.Log(LogLevel.Information, new EventId(2), $"Added user: {name}", null, (state, ex) => state.ToString());
                    Console.WriteLine(" User Added!");
                }
                else if (choice == "3")
                {
                    Console.Write("Enter User Name to Delete: ");
                    var name = Console.ReadLine();
                    var user = context.Users.FirstOrDefault(u => u.Names == name);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        logger.Log(LogLevel.Information, new EventId(3), $"Deleted user: {name}", null, (state, ex) => state.ToString());
                        Console.WriteLine(" User Deleted!");
                    }
                    else
                    {
                        Console.WriteLine(" User Not Found!");
                    }
                }
            }
        }
    }
}
