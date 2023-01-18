using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculo
    {

        public int Puertas { get; set; }
        public int Asientos { get; set; }

        public Vehiculo(int puertas, int asientos)
        {
            Puertas = puertas;
            Asientos = asientos;
        }

        public abstract string Frenar();
        public abstract string Acelerar();

        public abstract string Imprimir();
    }
}
