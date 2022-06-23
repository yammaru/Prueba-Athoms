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
    public partial class VerAccesoriosDialog : Form
    {
        public void CargarTabla()
        {
            var cl = new AccesorioLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Referencia");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Color");
            dt.Columns.Add("Tipo");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Referencia, oItem.Nombre,
                oItem.Precio, oItem.Descripción, oItem.Cantidad, oItem.Marca.Nombre, oItem.Color.Nombre,
                oItem.Tipo.Tipo });
            }
            dataGridView1.DataSource = dt;
        }
        public VerAccesoriosDialog()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
