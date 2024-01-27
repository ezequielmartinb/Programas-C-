using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Domicilio
    {
        private string direccion;
        private int numero;

        public Domicilio(string direccion, int numero)
        {
            this.direccion = direccion;
            this.numero = numero;
        }

        public string Direccion { get => direccion; }
        public int Numero { get => numero; }

        public string MostrarDireccion(Domicilio unDomicilio)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Domicilio: {unDomicilio.Direccion + " " + unDomicilio.Numero}");

            return sb.ToString();
        }
    }
}
