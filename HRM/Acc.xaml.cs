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
using System.Linq;
namespace HRM
{
    /// <summary>
    /// Логика взаимодействия для Acc.xaml
    /// </summary>
    public partial class Acc : Window
    {
        
        public Acc()
        {
            
            InitializeComponent();
            
            
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabItem_Initialized(object sender, EventArgs e)
        {
            var query = from res in Helper.context.resume
                        where res.id_sotrud == datas.emp.id
                        select res;
             
            DataContext = query.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new resumeAdd().Show();
        }

        private void Sohr_Click(object sender, RoutedEventArgs e)
        {
            Helper.context.SaveChanges();
        }

        private void Delete_Click1(object sender, RoutedEventArgs e)
        {
            var query = from res in Helper.context.resume
                        where res.id_sotrud == datas.emp.id
                        select res;
            resume resum = query.FirstOrDefault();
            Helper.context.resume.Remove(resum);
            Helper.context.SaveChanges() ;
        }
    }
}
