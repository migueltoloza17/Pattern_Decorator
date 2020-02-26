using Pattern.DECORATOR.Interfaces;
using Pattern.DECORATOR.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DECORATOR
{
    class Program
    {
        static void Main(string[] args)
        {           
            ComponenteA compa;
            ComponenteB compb;

            Console.WriteLine("Modificacion 1");
            compa = new ComponenteA(new ComponenteConcreto());
            compa.ObtenerDescripcion();

            Console.WriteLine("Modificacion 2");
            compb = new ComponenteB(new ComponenteConcreto());
            compb.ObtenerDescripcion();

            Console.WriteLine("Modificacion 3");
            compa = new ComponenteA(new ComponenteConcreto());
            compb = new ComponenteB(compa);
            compb.ObtenerDescripcion();
        }
    }
}
