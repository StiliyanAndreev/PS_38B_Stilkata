using System.Linq;
using System.Windows.Controls;
using WelcomeExtended.Loggers1;

namespace UI.Components
{
    public partial class StudentsList : UserControl
    {
        public StudentsList()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            using (var context = new DatabaseContext()) 
            {
                var records = context.Users.ToList(); 
                students.ItemsSource = records;
            }
        }
    }
}
