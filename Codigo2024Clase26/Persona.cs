using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Codigo2024Clase26
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }


        public Persona(string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }

        public Persona ManualClone()
        {
            // Crea una nueva instancia de Person copiando los valores actuales
            return new Persona(Nombres,Apellidos);
        }

    }
}
