using System.Configuration;
using System.Data;
using System.Windows;

namespace wpfmuti3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Aluno Aluno_ { get; set; }

        public App()
        {
            InitializeComponent();
            Aluno_ = new Aluno();
        }

    }

}
