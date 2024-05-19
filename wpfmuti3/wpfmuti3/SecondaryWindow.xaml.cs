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

namespace wpfmuti3
{
    public partial class SecondaryWindow : Window
    {
        private App app;

        public SecondaryWindow()
        {
            InitializeComponent();
            app = App.Current as App;
        }
        private void btnalterar_Click(object sender, RoutedEventArgs e)
        {

            app.Aluno_.Nome = txtnome.Text;
            app.Aluno_.Numero = txtnumero.Text;
            app.Aluno_.Curso = txtcurso.Text;

            app.Aluno_.WriteFile();

            this.DialogResult = true;


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();

        }

        
    }
}
