using System;

namespace Cursos
{
    public class Curso
    {
        public int Grado { get; set; }

        public Curso()
        {
        }
    }

    public class CursoPreEscolar : Curso
    {

        public CursoPreEscolar()
        {

        }

    }

    public class CursoBasica : Curso
    {

        public CursoBasica()
        {

        }

    }

    public class CursoBachillerato : Curso
    {

        public CursoBachillerato()
        {

        }

    }

    public class CursosPreEscolar 
    { 

        public CursoPreEscolar[] Curso { get; set; }

        public CursosPreEscolar()
        {

            Curso = new CursoPreEscolar[2];

            for (int i = 0; i < Curso.Length; i++)
            {
                Curso[i] = new CursoPreEscolar();
            }

        }

        public void ListarCursos()
        {
            for(int i=0; i<Curso.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        Console.WriteLine("Primero de preescolar");
                        break;
                    case 1:
                        Console.WriteLine("Segundo de preescolar");
                        break;
                }
            }
        }

    }

    public class CursosBasica
    {

        public CursoBasica[] Curso { get; set; }

        public CursosBasica()
        {

            Curso[10] = new CursoBasica();
        }

    }

    public class CursosBachillerato
    {

        public CursoBachillerato[] Curso { get; set; }

        public CursosBachillerato()
        {

            Curso[10] = new CursoBachillerato();
        }

    }


}
