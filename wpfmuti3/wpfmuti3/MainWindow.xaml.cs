using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

//MAIN --> VIEW
namespace wpfmuti3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private App app;

        public MainWindow()
        {
            InitializeComponent();
            app = App.Current as App;
            app.Aluno_.lerficheiro();
            tbnumero.Text = app.Aluno_.Numero;
            tbnome.Text = app.Aluno_.Nome;
            tbcurso.Text = app.Aluno_.Curso;

        }
        private void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            SecondaryWindow secondary = new SecondaryWindow();

            if(secondary.ShowDialog() == true)
            {
                tbnumero.Text = app.Aluno_.Numero;
                tbnome.Text = app.Aluno_.Nome;
                tbcurso.Text = app.Aluno_.Curso;
               
            }

        }
        private void btnsair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}