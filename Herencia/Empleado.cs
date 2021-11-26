using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Empleado:Persona
    {
        public int NumDespacho { get; set; }
        public int AñoEntrada { get; set; }
        public Empleado(string Apellidos, string Nombres, int CI, string Estado, int NumDespacho, int AñoEntrada) : base(Apellidos, Nombres, CI, Estado)
        {
            this.NumDespacho = NumDespacho;
            this.AñoEntrada = AñoEntrada;
        }
        public void CambiarDespacho()
        {
            int NewDespacho;
            Console.WriteLine("Ingrese el numero de despacho a cambiar: ");
            NewDespacho = Convert.ToInt32(Console.ReadLine());
            NumDespacho = NewDespacho;
            Console.WriteLine("Su nuevo despacho es: " + NumDespacho);
        }
    }
}
