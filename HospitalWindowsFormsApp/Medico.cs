using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    internal class Medico : Persona
    {
        public string Especialidad { get; set; }
        public List<Paciente> Pacientes { get; set; }

        public Medico(string nombre,int age, string movil, string espescialidad) : base(nombre, age, movil)
        {
            this.Especialidad = espescialidad;
            this.Pacientes = new List<Paciente>();
        }


        public override string ToString()
        {
            return base.ToString() + $" de Especialidad: {Especialidad}";
        }
    }
}
