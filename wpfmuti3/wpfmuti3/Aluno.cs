using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace wpfmuti3
{
    public class Aluno
    {
        //ATRIBUTOS
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }

        public Aluno()
        {

            lerficheiro();

        }
        //METODOS FILE
        public void lerficheiro()
        {
            string texto = "";
            StreamReader file = new StreamReader("fic.txt");
            texto = file.ReadToEnd();
            file.Close();
            string[] parms = texto.Split("\n");
            Numero = parms[0];
            Nome = parms[1];
            Curso = parms[2];


        }
        //METODOS FILE
        public void WriteFile()
        {

            StreamWriter file = new StreamWriter("fic.txt");
            file.WriteLine(Numero);
            file.WriteLine(Nome);
            file.WriteLine(Curso);

            file.Close();


        }



    }
}