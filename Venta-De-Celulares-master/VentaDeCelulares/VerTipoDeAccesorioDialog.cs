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
    public partial class VerTipoDeAccesorioDialog : Form
    {
        private void CargarTabla()
        {
            var cl = new TipoDeAccesorioLógica();

            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripción");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Id, oItem.Tipo, oItem.Descripción });
            }
            dataGridView1.DataSource = dt;
        }

        public VerTipoDeAccesorioDialog()
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
