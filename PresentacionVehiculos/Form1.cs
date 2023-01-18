using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion(5000, 8, 2, 2);
            AutoElectrico autoElectrico = new AutoElectrico("Tesla", "BatteryG400", 2, 4);

            MessageBox.Show("Camion: " + camion.Imprimir());
            MessageBox.Show("Auto Electrico: " + autoElectrico.Imprimir());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
