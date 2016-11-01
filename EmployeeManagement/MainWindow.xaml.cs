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
using EmployeeManagement.View;
using EmployeeManagement.Model;

namespace EmployeeManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("my comment");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //if (textusername.Text == "user" && textpassword.Text == "pass123")
            //{
            //    Window1 w1 = new Window1();
            //    this.Hide();
            //    w1.Show();
            //}


            EmployeeDB db = new EmployeeDB();

            
            IEnumerable<string> productNames = from p in db.User select p.UserName;

            MessageBox.Show(productNames.ToString());
            //if (textusername.Text != string.Empty || textpassword.Text != string.Empty)
            //{
            //    var user = db.User.FirstOrDefault(a => a.UserName.Equals(textusername.Text));
            //    if (user != null)
            //    {
            //        if (user.Password.Equals(textpassword.Text))
            //        {
            //            Window1 w1 = new Window1();
            //            this.Hide();
            //            w1.Show();
            //        }
            //    }
            //    MessageBox.Show(user.UserName);

            //}
        }
	

    }
}
