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
    public partial class VerMarcasDialog : Form
    {
        private void CargarTabla()
        {
            MarcaLógica cl = new MarcaLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Id, oItem.Nombre });
            }
            dataGridView1.DataSource = dt;
        }

        public VerMarcasDialog()
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
