using System;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public virtual int Id { get; set; }
        public string Names { get; set; }
        private string _password;
        public UserRolesEnum Role { get; set; }
        public string FacultyNumber { get; set; }
        public string Email { get; set; }
        public DateTime Expires { get; set; }

        public string Password
        {
            get => new string(_password.Reverse().ToArray());
            set => _password = new string(value.Reverse().ToArray());
        }

        public User(int id, string names, string password, UserRolesEnum role, string facultyNumber, string email)
        {
            Id = id;
            Names = names;
            Password = password;
            Role = role;
            FacultyNumber = facultyNumber;
            Email = email;
            Expires = DateTime.Now.AddHours(1);
        }
    }
}
