using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class VerClientesDialog : Form
    {
        private void CargarTabla()
        {
            ClienteLógica cl = new ClienteLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Primer apellido");
            dt.Columns.Add("Cédula");
            dt.Columns.Add("Correo electrónico");
            dt.Columns.Add("Dirección");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Género");
            dt.Columns.Add("Edad");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Nombres, oItem.PrimerApellido,
                oItem.Cédula, oItem.CorreoElectrónico, oItem.Dirección,
                oItem.Teléfono, oItem.Género, oItem.Edad });
            }
            dataGridView1.DataSource = dt;
        }

        public VerClientesDialog()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
