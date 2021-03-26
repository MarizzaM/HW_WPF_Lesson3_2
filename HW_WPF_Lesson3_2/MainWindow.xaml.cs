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

namespace HW_WPF_Lesson3_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Login ValidLogin  { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ValidLogin = new Login { Username = "ValidUser", Pass = "ValidPass" };
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxUsername.Text == ValidLogin.Username && txtBoxPass.Text == ValidLogin.Pass)
            {
                brdr.BorderBrush = new SolidColorBrush(Colors.Green);
            }
            else
            {
                brdr.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        public class Login
        {
            public string Username { get; set; }
            public string Pass { get; set; }
        }
    }

}
