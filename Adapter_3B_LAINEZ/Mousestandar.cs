using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_3B_LAINEZ
{
    public class Mousestandar : Mouse
    {
        public override void conectar()
        {
            Console.WriteLine("conectando mouse...");
        }

        public override void desconectar()
        {
            Console.WriteLine("desconectando mouse...");
        }
    }
}
