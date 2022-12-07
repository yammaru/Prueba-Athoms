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
    public partial class EmpleadoForm : Form
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new IniciarSesiónForm().Visible = true;
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
