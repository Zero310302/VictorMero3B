using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num;
            Console.WriteLine("***************************************************");
            Console.WriteLine("Elija los datos de la persona que desea visualisar:");
            Console.WriteLine("***************************************************");
            Console.WriteLine("1. Estudiante" + "\n2. Profesor" + "\n3. Empleado Personal De Servicio");
            Console.Write("Escriba el numero: ");
            num = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");
            switch (num)
            {
                case 1: 
                    Estudiantes estudiante = new Estudiantes("Mero Arcentales", "Bryan Benjamin", 1351663859, "Soltero", 1);
                    estudiante.MostrarDatosEst();
                    estudiante.CambiarEstado();
                    estudiante.CambiarCurso();
                    Console.WriteLine("******************");
                    estudiante.DatosEstudiantesActualizados();
                    Console.WriteLine("******************");
                    break;
                case 2:
                    Profesores profesor = new Profesores("Rosado Valencia", "Ronald Joao", 1316855962, "Casado", 5555, 2015, "Fisica");
                    profesor.MostrarDatosProf();
                    profesor.CambiarEstado();
                    profesor.CambiarDespacho();
                    profesor.CambiarDepartamento();
                    Console.WriteLine("******************");
                    profesor.DatosProfesorActualizados();
                    Console.WriteLine("******************");
                    break;
                case 3:
                    PersonalServicio personal = new PersonalServicio("Mero Arcentales", "Victor Javier", 1351663917, "Divorciado", 3210, 2015, "Guardia");
                    personal.MostrarDatosEmpleado();
                    personal.CambiarEstado();
                    personal.CambiarDespacho();
                    personal.CambioSeccion();
                    Console.WriteLine("******************");
                    personal.DatosEmpleadoActualizados();
                    Console.WriteLine("******************");
                    break;
                default: Console.WriteLine("Ingrese un numero correcto"); break;
            }
        }
    }
}
