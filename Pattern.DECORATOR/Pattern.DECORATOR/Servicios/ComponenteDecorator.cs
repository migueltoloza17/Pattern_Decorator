using Pattern.DECORATOR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.DECORATOR.Servicios
{
    public abstract class ComponenteDecorator : IOperacion
    {        
        protected IOperacion _operacion;
        public ComponenteDecorator(IOperacion operacion) { _operacion = operacion; }
        public abstract void ObtenerDescripcion();
    }
}
