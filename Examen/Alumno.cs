using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    internal abstract class Alumno
    {
        public string? nombre;
        public string? numeroCuenta;
        public string? email;
        
        public abstract void imprimir();

        public abstract bool validar();

    }

}
