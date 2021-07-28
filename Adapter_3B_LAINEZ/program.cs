using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_3B_LAINEZ
{
    class Program
    {
        static void Main(String[] args)
        {
            Mouse mouse1 = new Mousestandar();
            mouse1.conectar();
            mouse1.desconectar();

            Mouse mouse2 = new MouseInalambricoAdapter();
            mouse2.conectar();
            mouse2.desconectar();

            Console.ReadKey();
        }

    }
}
