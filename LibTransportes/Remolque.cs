using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Remolque
    {
        public Remolque(string tamaño, string nombre)
        {
            this.tamaño = tamaño;
            this.nombre = nombre;
        }

        public string tamaño { get; set; }
        public string nombre{ get;set; }
        public Camion Camion { get; set; }
    }
}
