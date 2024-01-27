using Clases;

namespace ProyectoMedicina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Ezequiel", "Brañanova", new DateTime(1993, 02, 26), "Masculino", "Argentina");
            Paciente p2 = new Paciente(p1, "Accord Salud", new Domicilio("Pasaje Pedro de Mendoza", 294));

            Console.WriteLine($"{p1.Mostrar(p1)}\n");
            Console.WriteLine(p2.Mostrar(p2));
        }
    }
}