using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    public class Paciente : Persona
    {
        public string Enfermedad { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        private Medico _medicoasignado;
        public Medico MedicoAsignados
        {
            get { return _medicoasignado; }
            set
            {
                _medicoasignado = value;

                if (_medicoasignado != null)
                {
                    _medicoasignado.Pacientes.Add(this);
                }
            }
        }


        public Paciente(string nombre,int age, string movil, string enfermedad, double peso, double altura, Medico medicoasignado) : base(nombre,age, movil)
        {
            this.Enfermedad = enfermedad;
            this.Altura = altura;
            this.Peso = peso;
            this.MedicoAsignados = medicoasignado;
        }


        public override string ToString()
        {
            return base.ToString() + $" de enfermedad: {Enfermedad} de Peso {Peso} y de altura {Altura}";
        }
    }
}
