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
    public partial class VerVentasDialog : Form
    {
        public void CargarTabla()
        {
            CompraLógica cl = new CompraLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Consecutivo");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Total");
            dt.Columns.Add("Cliente");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Id, oItem.Fecha, oItem.Total, oItem.Cliente.Cédula });
            }
            dataGridView1.DataSource = dt;
        }

        public VerVentasDialog()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void fr_ver_ventas_Load(object sender, EventArgs e)
        {

        }

        private void b_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
