using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Welcome.Model;
using Welcome.Others;


namespace WelcomeExtended.Model
{
    public class DatabaseUser : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public DatabaseUser(string names, string password, UserRolesEnum role, string facultyNumber, string email)
            : base(0, names, password, role, facultyNumber, email)
        {
        }
    }
}
