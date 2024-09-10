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
    /// Interaction logic for CreateCompanyWindow.xaml
    /// </summary>
    public partial class CreateCompanyWindow : Window
    {
        public CreateCompanyWindow()
        {
            InitializeComponent();
        }

        private void createCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            Kompania kompania = new Kompania()
            {
                name = companyName.Text
            };
            Helper.context.Kompania.Add(kompania);
            datas.emp.id_role = 1;
            Helper.context.SaveChanges();
        }
    }
}
