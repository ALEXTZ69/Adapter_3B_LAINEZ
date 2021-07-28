using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_3B_LAINEZ
{
    public class MouseInalambrico
    {
        
        bool _encendido;
        bool _emparejado;

        public void encender() 
        {
            if (_encendido)
                Console.WriteLine("imposible encender un mouse encendido...");
            else
            {
                _encendido = true;
                Console.WriteLine("encendiendo mouse...");
            }
        }
        public void emparejar()
        {
            if (!_encendido)
                Console.WriteLine("imposible emparejar, primero encienda el mouse...");
            else
            {
                _emparejado = true;
                Console.WriteLine("emparejando mouse...");
            }
        }
        public void desemparejar()
        {
            if (_emparejado)
            {
                _emparejado = false;
                Console.WriteLine("desemparejando mouse...");
            }
            else
            {
                Console.WriteLine("imposible desemparejar un mouse sin estar emparejado...");
            }
        }
        public void apagar()
        {
            if (_encendido)
            {
                Console.WriteLine("apagando mouse...");
            }
                
            else
            {
                Console.WriteLine("imposible apagar un mouse apagado...");
            }
        }
    }
}
