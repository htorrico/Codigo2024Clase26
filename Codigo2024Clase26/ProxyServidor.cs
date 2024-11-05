using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase26
{
    public class ProxyServidor
    {
        private Servidor _servidor;

        public ProxyServidor()
        {
            _servidor = new Servidor();        
        }

        public void ProcesarSolicitudPermiso(string usuario)
        {
            if (usuario == "administrador")
            {
                Console.WriteLine($"Proxy: Acceso concedido al usuario '{usuario}'.");
                _servidor.ProcesarSolicitud();
            }
            else
            {
                Console.WriteLine($"Proxy: Acceso denegado al usuario '{usuario}'.");
            }
        }

    }
}
