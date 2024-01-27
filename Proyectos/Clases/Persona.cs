using System.Runtime.CompilerServices;
using System.Text;

namespace Clases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad;
        private string genero;
        private string nacionalidad;

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public DateTime FechaNacimiento { get => fechaNacimiento; }
        public int Edad { get => edad; }
        public string Genero { get => genero; }
        public string Nacionalidad { get => nacionalidad; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string genero, string nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = ObtenerEdad(fechaNacimiento);
            this.genero = genero;
            this.nacionalidad = nacionalidad;
        }

        private static int ObtenerEdad(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Today;
            int edad;

            if (fecha > fechaActual)
            {
                return -1;
            }
            else
            {
                edad = fechaActual.Year - fecha.Year;
                if (fecha.Month > fechaActual.Month)
                {
                    edad--;
                }
                return edad;
            }
        }
        public string Mostrar(Persona p1)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Apellido: {p1.Apellido}");
            sb.AppendLine($"Nombre: {p1.Nombre}");
            sb.AppendLine($"Fecha Nacimiento: {p1.FechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Edad: {p1.Edad} años");
            sb.AppendLine($"Genero: {p1.Genero}");
            sb.Append($"Nacionalidad: {p1.Nacionalidad}");

            return sb.ToString();
        }
    }





}