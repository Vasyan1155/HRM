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
    /// Логика взаимодействия для AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        private int selectedId = 0;
        public AddEmployeeWindow()
        {
            InitializeComponent();
            loadResumes();
        }

        private void loadResumes()
        {
            resumesGrid.ItemsSource = Helper.context.resume.ToList();
        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            resume resume1 = Helper.context.resume.Where(resume => resume.id == selectedId).FirstOrDefault();
            employees employee = Helper.context.employees.Where(empl => empl.id == resume1.id_sotrud).FirstOrDefault();

            employee.compania = datas.emp.compania;
            Helper.context.SaveChanges();
            MessageBox.Show("Сотрудник успешно добавлен");
        }

        private void resumesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRow = resumesGrid.SelectedItem as resume;

            if (selectedRow != null)
            {
                selectedId = selectedRow.id;
            }
        }
    }
}
