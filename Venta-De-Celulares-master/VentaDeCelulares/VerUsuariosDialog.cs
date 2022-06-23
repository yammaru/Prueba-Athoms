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
    public partial class VerUsuariosDialog : Form
    {
        private void cargarTabla()
        {
            UsuarioLógica cl = new UsuarioLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Contraseña");
            dt.Columns.Add("Rol");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] { oItem.Nombre, oItem.Contraseña, oItem.Rol });
            }
            dataGridView1.DataSource = dt;
        }

        public VerUsuariosDialog()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
