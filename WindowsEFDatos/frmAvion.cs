using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void btinsertar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(txtcapacidad.Text), Denominacion = txtdenominacion.Text };
            int filasAfectadas = AdmAvion.Insertar(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert Ok");
                MostrarAviones();
            }
        }
        private void MostrarAviones()
        {
            GridAviones.DataSource = AdmAvion.Listar();
        }

        private void txtdenominacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { IdAvion = Convert.ToInt32(txtid.Text) };

            int filasAfectadas = AdmAvion.Eliminar(avion.IdAvion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarAviones();
            }
        }

        private void bttraer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);

            Avion avion = AdmAvion.TraerUno(id);
            MessageBox.Show(Convert.ToString("Capacidad: "+avion.Capacidad+"\nDenominación: "+avion.Denominacion+ "\nLinea Aerea: "+avion.LineaAerea));
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(txtcapacidad.Text), Denominacion = txtdenominacion.Text, IdAvion = Convert.ToInt32(txtid.Text) };

            int filasAfectadas = AdmAvion.Editar(avion);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Edicion ok");
                MostrarAviones();
            }
        }
    }
}
