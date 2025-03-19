using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Names => _user.Names;
        public UserRolesEnum Role => _user.Role;
        public string FacultyNumber => _user.FacultyNumber;
        public string Email => _user.Email;
        public string EncryptedPassword => _user.Password;


    }
}
