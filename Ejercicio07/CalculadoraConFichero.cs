using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    public class CalculadoraConFichero
    {
        public ICalculadora Calculadora
        {
            get;
            set;
        }

        public IFicheroService ficheroService { get; set; }

        public void SumarGuardando(int a, int b)
        {
            int c = Calculadora.Sumar(a, b);

            FicheroService.GuardaNumero(c);
        }


    }
}
