using System;
using System.Linq;
using System.Windows;

namespace HRM
{
    /// <summary>
    /// Логика взаимодействия для VacancesListWindow.xaml
    /// </summary>
    public partial class VacancesListWindow : Window
    {
        private DB dbContext = new DB();
        int selectedId = 0;
        public VacancesListWindow()
        {
            InitializeComponent();
            loadVacances();
        }

        private void loadVacances()
        {
            vacanciesList.ItemsSource = dbContext.vacancy.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            CreateVacancyWindow createVacancyWindow = new CreateVacancyWindow();
            createVacancyWindow.ShowDialog();
            this.Close();
        }

        private void vacanciesList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedRow = vacanciesList.SelectedItem as vacancy;

            if (selectedRow != null)
            {
                selectedId = selectedRow.id;
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedId != 0)
            {
                try
                {
                    var vacancyToDelete = dbContext.vacancy.Find(selectedId);
                    if (vacancyToDelete != null)
                    {
                        dbContext.vacancy.Remove(vacancyToDelete);
                        dbContext.SaveChanges();
                        vacanciesList.ItemsSource = dbContext.vacancy.ToList();
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите вакансию для удаления");
            }
        }
    }
}
