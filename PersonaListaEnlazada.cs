using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    internal class PersonaListaEnlazada
    {
        private Nodo primero;


        public PersonaListaEnlazada()
        {
            primero = null;
        }

        public void AgregarPersona(Persona personaDatos)
        {
            Nodo nuevoNodo = new Nodo(personaDatos);
            nuevoNodo.Siguiente = primero;
            primero = nuevoNodo;
        }

        public void ImprimirLista()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.PersonaDatos.Nombre}, Edad: {actual.PersonaDatos.Edad}");
                actual = actual.Siguiente;
            }
        }




    }
}
