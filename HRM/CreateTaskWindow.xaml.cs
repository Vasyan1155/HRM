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
    /// Логика взаимодействия для CreateTaskWindow.xaml
    /// </summary>
    public partial class CreateTaskWindow : Window
    {
        private int selectedId = 0;
        public CreateTaskWindow()
        {
            InitializeComponent();
            loadEmployees();
        }

        private void loadEmployees()
        {
            employeeGrid.ItemsSource = Helper.context.employees.Where(employee => employee.compania == datas.emp.compania).ToList();
        }

        private void createTaskButton_Click(object sender, RoutedEventArgs e)
        {
            task newTask = new task()
            {
                task1 = taskName.Text,
                start_time = DateTime.Now,
                end_time = Convert.ToDateTime(expTime.Text),
                id_sotrud = selectedId
            };
            Helper.context.task.Add(newTask);
            Helper.context.SaveChanges();
        }

        private void employeeGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedRow = employeeGrid.SelectedItem as employees;

            if (selectedRow != null)
            {
                selectedId = selectedRow.id;
            }
        }
    }
}
