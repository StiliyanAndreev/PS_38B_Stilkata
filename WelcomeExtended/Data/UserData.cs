using System;
using System.Collections.Generic;
using System.Linq;
using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public List<User> GetUsersLambda()
        {
            return _users.Select(u => u).ToList();
        }

        public List<User> GetUsersLinq()
        {
            return (from u in _users select u).ToList();
        }

        public User GetUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Names == username && u.Password == password);
        }

        public void SetActive(string username, DateTime validUntil)
        {
            var user = _users.FirstOrDefault(u => u.Names == username);
            if (user != null)
            {
                user.Expires = validUntil;
            }
        }

        public void AssignUserRole(string username, UserRolesEnum role)
        {
            var user = _users.FirstOrDefault(u => u.Names == username);
            if (user != null)
            {
                user.Role = role;
            }
        }
    }
}
