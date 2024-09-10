using System;
using System.Windows;
using System.Linq;


namespace HRM
{
    /// <summary>
    /// Логика взаимодействия для CreateVacancyWindow.xaml
    /// </summary>
    public partial class CreateVacancyWindow : Window
    {
        private DB dbContext = new DB();
        public CreateVacancyWindow()
        {
            InitializeComponent();
        }

        private void createVacancyButton_Click(object sender, RoutedEventArgs e)
        {
            vacancy newVacancy = new vacancy
            {
                name_vacancy = vacancyName.Text,
                zp = Convert.ToInt32(vacancySalary.Text),
                opicanie_vacancy = vacancyComment.Text
            };

            dbContext.vacancy.Add(newVacancy);
            dbContext.SaveChanges();

        }
    }
}
