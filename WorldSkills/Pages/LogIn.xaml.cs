using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorldSkills;

namespace WorldSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        TestEntities context;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context = new TestEntities();
                Users log = context.Users.FirstOrDefault(x => x.name == tbLog.Text && x.password == tbPass.Text);
                if (log!=null)
                {
                    if (log.type == 1)
                    {
                        MessageBox.Show("You're admin");
                    }
                    FrameClass._mainframe.Navigate(new PIC());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void tbLog_MouseMove(object sender, MouseEventArgs e)
        {
            tbLog.Background = Brushes.DarkGray;
        }

        private void tbLog_MouseLeave(object sender, MouseEventArgs e)
        {
            tbLog.Background = Brushes.Gray;
        }
    }
}
