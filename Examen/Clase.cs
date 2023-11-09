using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Clase : Alumno
    {
        public string? nombreClase;
        public string? horaClase;
        public string? nombreCatedratico;
      

        public override void imprimir()


        {
            Console.WriteLine("Nombre del alumno: " + nombre);
            Console.WriteLine("Numero de cuenta: " + numeroCuenta);
            Console.WriteLine("Correo: " + email);
            Console.WriteLine("Nombre de la clase: " + nombreClase);
            Console.WriteLine("Hora de la clase: " + horaClase);
            Console.WriteLine("Nombre del catedratico: " + nombreCatedratico);
          
        }

        public override bool validar()
        {
            throw new NotImplementedException();
        }
    }
}