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
    /// Interaction logic for resumeAdd.xaml
    /// </summary>
    public partial class resumeAdd : Window
    {
        public resumeAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from res in Helper.context.resume
                        where res.id == datas.emp.id
                        select res.id;
            if (!query.Any())
            {
                resume res = new resume()
                {

                    f = f.Text,
                    i = i.Text,
                    o = o.Text,
                    mail = mail.Text,
                    vozract = Convert.ToInt32(vozract.Text),
                    education = education.Text,
                    opisanie = opisanie.Text,
                    id_sotrud = datas.emp.id
                };
                Helper.context.resume.Add(res);
                Helper.context.SaveChanges();
                this.Close();
            }else
            {
                MessageBox.Show("Резюме уже добавлено!");
                this.Close();
            }
        }
    }
}
