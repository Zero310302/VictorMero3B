using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Profesores : Empleado
    {
        public string Departamento { get; set; }
        public Profesores(string Apellidos, string Nombres, int CI, string Estado, int NumDespacho, int AñoEntrada, string Departamento) : base(Apellidos, Nombres, CI, Estado, NumDespacho, AñoEntrada)
        {
            this.Departamento = Departamento;
        }
        public void MostrarDatosProf()
        {
            Console.WriteLine("*************");
            Console.WriteLine("PROFESOR");
            Console.WriteLine("*************");
            Console.WriteLine("Apellido: " + Apellidos);
            Console.WriteLine("Nombre: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Despacho: " + NumDespacho);
            Console.WriteLine("Año de Incorporacion: " + AñoEntrada);
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("*************");
        }
        public void CambiarDepartamento()
        {
            string DepartamentoNuevo;
            Console.WriteLine("Ingrese el departamento a cambiar:");
            DepartamentoNuevo = Convert.ToString(Console.ReadLine());
            Departamento = DepartamentoNuevo;
            Console.WriteLine("Su nuevo departamento es: " + Departamento);
        }
        public void DatosProfesorActualizados()
        {
            Console.WriteLine("\n*************");
            Console.WriteLine("DATOS ACTUALIZADOS");
            Console.WriteLine("PROFESOR");
            Console.WriteLine("*************");
            Console.WriteLine("Apellido: " + Apellidos);
            Console.WriteLine("Nombre: " + Nombres);
            Console.WriteLine("CI: " + CI);
            Console.WriteLine("Estado Civil: " + Estado);
            Console.WriteLine("Despacho: " + NumDespacho);
            Console.WriteLine("Año Incorporacion: " + AñoEntrada);
            Console.WriteLine("Departamento: " + Departamento);
            Console.WriteLine("*************");
        }
    }
}
