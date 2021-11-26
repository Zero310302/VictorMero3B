using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class PersonalServicio : Empleado
    {
        public string Seccion { get; set; }
        public PersonalServicio(string Apellidos, string Nombres, int CI, string Estado, int NumDespacho, int AñoEntrada, string Seccion) : base(Apellidos, Nombres, CI, Estado, NumDespacho, AñoEntrada)
        {
            this.Seccion = Seccion;
        }
        public void MostrarDatosEmpleado()
        {
            Console.WriteLine("*************");
            Console.WriteLine("EMPLEADO");
            Console.WriteLine("*************");
            Console.WriteLine("Apellido: " + Apellidos);
            Console.WriteLine("Nombre: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Número Despacho: " + NumDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoEntrada);
            Console.WriteLine("Seccion Asignada: " + Seccion);
            Console.WriteLine("*************");
        }
        public void CambioSeccion()
        {
            string NewSeccion;
            Console.WriteLine("Ingrese la seccion a cambiar: ");
            NewSeccion = Convert.ToString(Console.ReadLine());
            Seccion = NewSeccion;
            Console.WriteLine("Sección nueva: " + Seccion);
        }
        public void DatosEmpleadoActualizados()
        {
            Console.WriteLine("\n*************");
            Console.WriteLine("EMPLEADO");
            Console.WriteLine("*************");
            Console.WriteLine("Apellido: " + Apellidos);
            Console.WriteLine("Nombre: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Número Despacho: " + NumDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoEntrada);
            Console.WriteLine("Seccion Asignada: " + Seccion);
            Console.WriteLine("*************");
        }
    }
}
