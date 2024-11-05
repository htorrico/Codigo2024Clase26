using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase26
{
    public class Logger
    {
        private string _logFilePath = "log.txt";


        // Constructor público que permite crear múltiples instancias.
        public Logger()
        {
            if (!File.Exists(_logFilePath))
            {
                File.Create(_logFilePath).Dispose();
            }
        }


        private static Logger _instance;
        public static Logger Instance
        {
            get
            {
                
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;                
            }
        }






        // Método para registrar un mensaje en el archivo.
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(_logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
