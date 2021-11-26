using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Estudiantes : Persona
    {
        public int Curso { get; set; }
        public Estudiantes(string Apellidos, string Nombres, int CI, string Estado, int Curso): base(Apellidos, Nombres, CI, Estado)
        {
            this.Curso = Curso;
        }

        public void MostrarDatosEst()
        {
            Console.WriteLine("*************");
            Console.WriteLine("ESTUDIANTE");
            Console.WriteLine("*************");
            Console.WriteLine("Apellido: " + Apellidos);
            Console.WriteLine("Nombre: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("*************");
        }
        public void CambiarCurso()
        {
            int NewCurso;
            Console.WriteLine("Ingrese el nuevo curso: ");
            NewCurso = Convert.ToInt32(Console.ReadLine());
            Curso = NewCurso;
            Console.WriteLine("Su nuevo curso es: " + Curso);
        } 
        public void DatosEstudiantesActualizados()
        {
            Console.WriteLine("\n*************");
            Console.WriteLine("DATOS ACTUALIZADOS");
            Console.WriteLine("ESTUDIANTE");
            Console.WriteLine("*************");
            Console.WriteLine("Apellido: " + Apellidos);
            Console.WriteLine("Nombre: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("*************");
        }
    }
}
