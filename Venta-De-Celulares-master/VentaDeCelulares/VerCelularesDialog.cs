using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class fr_celulares : Form
    {
        private void cargarTabla()
        {
            CelularLógica cl = new CelularLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Referencia");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Color");
            dt.Columns.Add("Almacenamiento");
            dt.Columns.Add("RAM");
            dt.Columns.Add("Resolución");
            dt.Columns.Add("Tipo");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Referencia, oItem.Nombre,
                oItem.Precio, oItem.Descripción, oItem.Cantidad, oItem.Marca.Nombre, oItem.Color.Nombre,
                oItem.Almacenamiento, oItem.RAM, oItem.MegapixelesEnLaCámara, oItem.Tipo == Entity.TipoDeCelular.INTELIGENTE ? "Inteligente" : "Regular" });
            }
            dataGridView1.DataSource = dt;
        }

        public fr_celulares()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
