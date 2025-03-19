using System;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string ToReadableString(this User user)
        {
            return $"ID: {user.Id}, Name: {user.Names}, Role: {user.Role}, Faculty: {user.FacultyNumber}, Email: {user.Email}, Expires: {user.Expires}";
        }

        public static bool IsValidCredentials(this UserData userData, string name, string password) 
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("The Name cannot be empty");
            if (string.IsNullOrEmpty(password)) throw new ArgumentException("The Password cannot be empty");

            return userData.GetUser(name, password) != null;
        }

        public static User? FetchUser(this UserData userData, string name, string password) 
        {
            return userData.GetUser(name, password) ?? null; 
        }
    }
}
