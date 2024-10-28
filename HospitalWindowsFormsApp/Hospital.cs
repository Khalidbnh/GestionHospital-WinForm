using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalWindowsFormsApp
{
    internal class Hospital
    {
        public List<Persona> personas { get; set; }

        public Hospital() 
        {
            personas = new List<Persona>();
        }

        //Medicos
        public void AgregarMedico(Medico m)
        {
            personas.Add(m);
        }

        public void EliminarMedico(Medico m)
        {
            personas.Remove(m);
        }

        public void ListarMedico()
        {
            foreach (Medico m in personas)
            {
                Console.WriteLine(m);
            }
        }



        //Pacientes
        public void AgregarPaciente(Paciente p)
        {
            personas.Add(p);
        }

        public void EliminarPaciente(Paciente p)
        {
            personas.Remove(p);
        }

        public void ListarPacientes(Medico m)
        {
            foreach (var p in m.Pacientes)
            {
                Console.WriteLine(p);
            }
        }


        //Administrativos
        public void AgregarAdministrativo(Administrativo a)
        {
            personas.Add(a);
        }

        public void EliminarAdministrativo(Administrativo a)
        {
            personas.Remove(a);
        }

        public void ListarAdministrativos()
        {
            foreach (Administrativo a in personas)
            {
                Console.WriteLine(a);
            }
        }


        //ADD otros Metodos
        public void ListarPersonas()
        {
            Console.WriteLine("Medicos :");
            ListarMedico();

            Console.WriteLine("Administrativos :");
            ListarAdministrativos();

            Console.WriteLine("Pacientes :");

            foreach (Paciente p in personas)
            {
                Console.WriteLine(p);
            }

        }

        //Modificar Personas
        public void ModificarPersona()
        {
            Persona persona = null;
            Console.WriteLine("Qué tipo de persona quieres modificar?");
            Console.WriteLine("1. Médico");
            Console.WriteLine("2. Administrativo");
            Console.WriteLine("3. Paciente");
            string opcion = Console.ReadLine();



            switch (opcion)
            {
                case "1":
                    Console.WriteLine("el nombre del médico que quieres modificar :");
                    string nombreM = Console.ReadLine();
                    persona = personas.Where(pe1 => pe1 is Medico me && me.Nombre == nombreM).FirstOrDefault();
                    break;

                case "2":
                    Console.WriteLine("el nombre del Administrativo que quieres modificar :");
                    string nombreA = Console.ReadLine();
                    persona = personas.Where(pe2 => pe2 is Administrativo A && A.Nombre == nombreA).FirstOrDefault();
                    break;
                case "3":
                    Console.WriteLine("el nombre del Paciente que quieres modificar :");
                    string nombrep = Console.ReadLine();
                    persona = personas.Where(pa => pa is Paciente pac && pac.Nombre == nombrep).FirstOrDefault();
                    break;

            }

            if (persona == null) { Console.WriteLine("persona no encontrada "); return; };

            /*Old version
             * if (persona is Medico m)
            {
                ModificarMedico(m);
            }

            if(persona is Administrativo a)
            {
                ModificarAdmin(a);
            }

            if (persona is Paciente p)
            {
                ModificarPaciente(p);
            }*/

            //New Version
            switch (persona)
            {
                case Medico m:
                    ModificarMedico(m);
                    break;
                case Administrativo a:
                    ModificarAdmin(a);
                    break;
                case Paciente p:
                    ModificarPaciente(p);
                    break;
            }


        }


        public void ModificarMedico(Medico M)
        {
            Console.WriteLine("Qué datos quieres modificar ?");
            Console.WriteLine("1- el telefono");
            Console.WriteLine("2- especialidad");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Nuevo numero de telefono");
                    M.Movil = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Nueva espescialidad");
                    M.Especialidad = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("elige 1 o 2");
                    break;
            }

            Console.WriteLine("Datos modificados");
        }

        public void ModificarAdmin(Administrativo A)
        {
            Console.WriteLine("Qué datos quieres modificar ?");
            Console.WriteLine("1- el telefono");
            Console.WriteLine("2- Puesto");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Nuevo numero de telefono");
                    A.Movil = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Nuevo Puesto");
                    A.Puesto = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("elige 1 o 2");
                    break;
            }

            Console.WriteLine("Datos modificados");
        }

        public void ModificarPaciente(Paciente P)
        {
            Console.WriteLine("Qué datos quieres modificar ?");
            Console.WriteLine("1- el telefono");
            Console.WriteLine("2- Edad");
            Console.WriteLine("3- Altura");
            Console.WriteLine("4- Peso");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Nuevo numero de telefono");
                    P.Movil = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Nuevo Edad");
                    P.Age = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Nueva Altura");
                    P.Altura = double.Parse(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("Nuevo Peso");
                    P.Peso = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("elige de 1 a 4");
                    break;
            }

            Console.WriteLine("Datos modificados");
        }



    }
}
