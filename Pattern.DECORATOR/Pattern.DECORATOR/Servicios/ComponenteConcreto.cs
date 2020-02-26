using Pattern.DECORATOR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DECORATOR.Servicios
{
    public class ComponenteConcreto : IOperacion
    {             
        public void ObtenerDescripcion()
        {
            Console.Write("Guardar CxP");
        }
    }
}
