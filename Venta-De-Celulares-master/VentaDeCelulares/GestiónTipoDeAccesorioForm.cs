using BLL;
using Entity;
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
    public partial class GestiónTipoDeAccesorioForm : Form
    {
        private static TipoDeAccesorioLógica ta = new TipoDeAccesorioLógica();

        public GestiónTipoDeAccesorioForm()
        {
            InitializeComponent();
        }

        private TipoDeAccesorio GetTipoDeAccesorio()
        {
            TipoDeAccesorio m = new TipoDeAccesorio();

            m.Tipo = textBox1.Text;
            m.Descripción = textBox2.Text;
            return m;
        }

        private void LimpiarCampo()
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ta.Insert(GetTipoDeAccesorio()) == 0)
            {
                MessageBox.Show("El registro falló");
                return;
            }
            MessageBox.Show("Registro exitoso");
            LimpiarCampo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var c = ta.GetBy("Nombre", textBox1.Text);
            if (c == null)
            {
                MessageBox.Show("Este tipo de accesorio no está registrado");
            }
            else
            {
                ta.Delete(c.Id);
                MessageBox.Show("Eliminación correcta");
                LimpiarCampo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var c = ta.GetBy("Nombre", textBox1.Text);
            if (c == null)
            {
                MessageBox.Show("Este tipo de accesorio no existe");
            }
            else
            {
                ta.Update(GetTipoDeAccesorio(), c.Id);
            }
        }

        private void verMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerTipoDeAccesorioDialog().Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
