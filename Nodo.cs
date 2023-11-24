using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Nodo
    {
        public Persona PersonaDatos { get; set;}
        public Nodo Siguiente { get; set;}


        public Nodo(Persona personaDatos)
        {
            PersonaDatos = personaDatos;
            Siguiente = null;
        }
    }
}
