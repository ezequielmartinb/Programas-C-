using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Paciente : Persona
    {
        string obraSocial;
        Domicilio domicilio;

        public Paciente(string nombre, string apellido, DateTime fechaNacimiento, string genero, string nacionalidad, string obraSocial, Domicilio domicilio) : base(nombre, apellido, fechaNacimiento, genero, nacionalidad)
        {
            this.obraSocial = obraSocial;
            this.domicilio = domicilio;
        }
        public Paciente(Persona p1, string obraSocial, Domicilio domicilio) : base(p1.Nombre, p1.Apellido, p1.FechaNacimiento, p1.Genero, p1.Nacionalidad)
        {
            this.obraSocial = obraSocial;
            this.domicilio = domicilio;
        }

        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public Domicilio Domicilio { get => domicilio; set => domicilio = value; }

        public string Mostrar(Paciente p1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar(p1));
            sb.AppendLine($"{p1.domicilio.MostrarDireccion(p1.domicilio)}");
            sb.AppendLine($"Obra Social: {p1.obraSocial}");
            return sb.ToString();
        }
    }
}