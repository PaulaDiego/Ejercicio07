using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    public class FicheroService
    {
        public static void GuardaNumero(int c)
        {
            FicheroUtil FicheroUtil = new FicheroUtil();
            FicheroUtil.AlmacenarDatos(c, "miFichero.txt");
        }

    }
}
