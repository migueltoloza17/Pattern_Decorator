using Pattern.DECORATOR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DECORATOR.Servicios
{
    public class ComponenteB : ComponenteDecorator
    {
        public ComponenteB(IOperacion operacion) : base(operacion) { }

        public override void ObtenerDescripcion()
        {
            _operacion.ObtenerDescripcion(); Console.WriteLine(" Se envia correo a usuario");
        }
    }
}
