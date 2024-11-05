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

        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public int Edad { get; set; }


        public Persona(string nombres, 
            string apellidos, 
            string direccion, 
            string telefono,
            int edad)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            Edad = edad;

        }

        public Persona ClonarManual()
        {
            // Crea una nueva instancia de Person copiando los valores actuales
            return new Persona(Nombres,Apellidos,Direccion,Telefono,Edad);
        }
        public Persona Clonar()
        {
            // Crea una nueva instancia de Person copiando los valores actuales
            return (Persona)this.MemberwiseClone();
        }
        

    }
}
