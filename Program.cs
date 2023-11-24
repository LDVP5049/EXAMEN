
namespace EXAMEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonaListaEnlazada lista = new PersonaListaEnlazada();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Datos de la persona");

                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Persona nuevaPersona = new Persona(nombre, edad);
                lista.AgregarPersona(nuevaPersona);
            }
            Console.WriteLine("\nLista de personas:");
            lista.ImprimirLista();
        }
    }
}