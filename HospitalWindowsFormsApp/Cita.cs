using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    public class Cita
    {
        public Medico MedicoAsignado { get; set; }
        public Paciente PacienteAsignado { get; set; }
        public DateTime FechaHora { get; set; }


        public Cita(Medico Medico, Paciente paciente, DateTime FechaHora)
        {
            this.MedicoAsignado = Medico;
            this.PacienteAsignado= paciente;
            this.FechaHora = FechaHora;
        }



        public override string ToString()
        {
            return $"Cita con Dr. {MedicoAsignado.Nombre} y paciente {PacienteAsignado.Nombre} en {FechaHora}";
        }
    }
}
