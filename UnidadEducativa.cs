using Personas;
using System.Security.Cryptography;
using Cursos;

namespace UnidadEducativa
{
    public class UnidadEdu
    {

        public Profesor[] Profesores { get; set; }

        public CursosPreEscolar cursosPreEscolar { get; set; }

        public CursosBasica cursosBasica { get; set; }

        public CursosBachillerato cursosBachillerato { get; set; }

        public UnidadEdu()
        {

            cursosPreEscolar = new CursosPreEscolar();

            Console.WriteLine("En el constructor de UnidadEducativa");
            Console.WriteLine("Cuantos profesores va a tener:");
            int CantProfesores = int.Parse(Console.ReadLine());

            Profesores = new Profesor[CantProfesores];


            for (int i = 0; i < CantProfesores; i++)
            {
                Profesores[i] = new Profesor();
            }

        }

        public void ListarProfesores()
        {
            /*for(int i = 0;i < Profesores.Length;i++)
            {
                Console.WriteLine(i + " " + Profesores[i].Nombre);
            }*/

            int i = 0;
            foreach(var profesor in Profesores)
            {
                Console.WriteLine((++i)+" "+profesor.Nombre+" "+ profesor.ObtEstadoAntiguedad());

            }
        }

    }
}