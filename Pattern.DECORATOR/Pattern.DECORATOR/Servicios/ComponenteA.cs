using Pattern.DECORATOR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DECORATOR.Servicios
{
    public class ComponenteA : ComponenteDecorator
    {     

        public ComponenteA(IOperacion operacion) : base(operacion) { }
        
        public override void ObtenerDescripcion()
        {
            _operacion.ObtenerDescripcion(); Console.WriteLine(" Se guarda Historial de CxP");
        }
    }
}
