using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico : Vehiculo
    {
        public AutoElectrico(string modelo, string bateria, int puertas, int asientos) : base(puertas, asientos)
        {
            Modelo = modelo;
            Bateria = bateria;
        }

        public string Modelo { get; set; }
        public string Bateria { get; set; }

        public override string Frenar()
        {
            return "Frena rapidamente";
        }

        public override string Acelerar()
        {
            return "Acelera rapidamente";
        }


        public override string Imprimir()
        {
            return "\nModelo: " + Modelo + "\nBateria: " + Bateria + "\nPuertas: " + Puertas + "\nAsientos: " + Asientos;
        }
    }
}
