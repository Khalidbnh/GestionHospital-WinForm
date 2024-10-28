using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Movil { get; set; }
        public int Age { get; set; }

        public Persona()
        {

        }

        public Persona(string nombre,int age, string movil)
        {
            this.Nombre = nombre;
            this.Movil = movil;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Nombre:  {Nombre} de edad {Age} y de movil {Movil}";
        }
    }
}
