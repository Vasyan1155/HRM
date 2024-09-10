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
using System.Windows.Shapes;

namespace HRM
{
    /// <summary>
    /// Логика взаимодействия для Login_registration.xaml
    /// </summary>
    public partial class Login_registration : Window
    {
        public Login_registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from vl in Helper.context.employees
                        where vl.login == loginText.Text && vl.password == PasswordText.Text
                        select vl;
            if (query.Any()) {
                datas.emp = query.FirstOrDefault();
                new Acc().Show();
                this.Close();
                
            }
            else 
            {
                MessageBox.Show("Неверные данные для входа");
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new RegWindow().Show();
        }
    }
}
