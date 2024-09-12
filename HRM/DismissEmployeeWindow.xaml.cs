using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HRM
{
    /// <summary>
    /// Логика взаимодействия для DismissEmployeeWindow.xaml
    /// </summary>
    public partial class DismissEmployeeWindow : Window
    {
        private int selectedId = 0;
        public DismissEmployeeWindow()
        {
            InitializeComponent();
            loadEmployees();
        }

        private void loadEmployees()
        {
            employeeGrid.ItemsSource = Helper.context.employees.Where(empl => empl.compania == datas.emp.compania).ToList();
        }

        private void dismissEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            employees employee = Helper.context.employees.Where(empl => empl.id == selectedId).FirstOrDefault();

            rating newRating = new rating()
            {
                srok_vipolnenie_zadach = duration.Text,
                kachestvo_rabot = quality.Text,
                zaverchenieZadach = completion.Text,
                itog = summary.Text,
                id_sotrud = employee.id,
            };

            Helper.context.rating.Add(newRating);

            employee.compania = null;
            Helper.context.SaveChanges();
            employeeGrid.ItemsSource = null;
            loadEmployees();
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
