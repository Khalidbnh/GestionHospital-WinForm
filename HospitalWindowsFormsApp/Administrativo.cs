﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    internal class Administrativo : Persona
    {
        public string Puesto { get; set; }

        public Administrativo(string nombre,string age, string movil, string puesto) : base(nombre,age, movil)
        {
            this.Puesto = puesto;
        }

        public override string ToString()
        {
            return base.ToString() + $"de Puesto: {Puesto}";
        }
    }
}
