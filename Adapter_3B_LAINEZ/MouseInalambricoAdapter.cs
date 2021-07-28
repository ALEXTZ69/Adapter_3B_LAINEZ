using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_3B_LAINEZ
{
    class MouseInalambricoAdapter : Mouse
    {
        MouseInalambrico mouseInalambrico = new MouseInalambrico();

        public override void conectar()
        {
            mouseInalambrico.encender();
            mouseInalambrico.emparejar();
        }

        public override void desconectar()
        {
            mouseInalambrico.apagar();
            mouseInalambrico.desemparejar();
        }
    }
}
