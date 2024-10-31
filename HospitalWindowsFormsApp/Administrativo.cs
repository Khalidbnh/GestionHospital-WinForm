using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    public class Administrativo : Persona
    {
        public string Puesto { get; set; }

        public Administrativo(string nombre,int age, string movil, string puesto) : base(nombre,age, movil)
        {
            this.Puesto = puesto;
        }

        public override string ToString()
        {
            return base.ToString() + $"de Puesto: {Puesto}";
        }
    }
}
