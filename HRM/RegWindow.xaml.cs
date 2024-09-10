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
    
    public partial class RegWindow : Window
    {
        private DB dbContext = new DB();

        public RegWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int maxId = (from mI in Helper.context.employees
                        orderby mI.id descending
                        select mI.id).FirstOrDefault();
            
            employees employees = new employees()
            {
                id = maxId + 1,
                login = loginText.Text,
                password = PasswordText.Text
            };
            dbContext.employees.Add(employees);
            dbContext.SaveChanges();
        }
    }
}
