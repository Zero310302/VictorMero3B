using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Persona
    {
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public int CI { get; set; }
        public string Estado { get; set; }
        public Persona(string Apellidos, string Nombres, int CI, string Estado)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.CI = CI;
            this.Estado = Estado;
        }
        public void CambiarEstado()
        {
            string NewEstado;
            Console.WriteLine("Ingrese el estado civil a cambiar: ");
            NewEstado= Convert.ToString(Console.ReadLine());
            Estado = NewEstado;
            Console.WriteLine("Estado civil actual: " + Estado);
        }
    }
}
