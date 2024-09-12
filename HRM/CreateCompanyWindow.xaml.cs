using System.Windows;

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
            datas.emp.compania = kompania.id;
            Helper.context.SaveChanges();
        }
    }
}
