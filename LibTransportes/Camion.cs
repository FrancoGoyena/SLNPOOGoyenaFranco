using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Vehiculo
    {
        public Camion(double capacidad, int ruedas, int puertas, int asientos) : base(puertas, asientos)
        {
            Capacidad = capacidad;
            Ruedas = ruedas;
        }

        public double Capacidad { get; set; }
        public int Ruedas { get; set; }

        public Remolque Remolque { get; set; }


        public void QuitarRemolque()
        {
            Remolque = null;
        }

        public override string Frenar()
        {
            return "Frena lentamente";
        }

        public override string Acelerar()
        {
            return "Acelera lentamente";
        }

        public override string Imprimir()
        {
            return "\nCapacidad: " + Capacidad + "\nRuedas: " + Ruedas + "\nPuertas: " + Puertas + "\nAsientos: " + Asientos;
        }
    }
}
