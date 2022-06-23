using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class GestiónDeMarcasForm : MetroFramework.Forms.MetroForm
    {
        private MarcaLógica cl = new MarcaLógica();

        public GestiónDeMarcasForm()
        {
            InitializeComponent();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerMarcasDialog().Visible = true;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private Marca GetMarca()
        {
            Marca m = new Marca();

            m.Nombre = textBox1.Text;
            return m;
        }

        private void LimpiarCampo()
        {
            NombreTextBox.Text = "";
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Marca c = cl.GetBy("Nombre", textBox1.Text);
            if (c == null)
            {
                MessageBox.Show("Esta marca no está registrado");
            } else
            {
                NombreTextBox.Text = c.Nombre;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (cl.Insert(GetMarca()) == 0)
            {
                MessageBox.Show("El registro falló");
                return;
            }
            MessageBox.Show("Registro exitoso");
            LimpiarCampo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marca c = cl.GetBy("Nombre", textBox1.Text);
            if (c == null)
            {
                MessageBox.Show("Esta marca no está registrado");
            }
            else
            {
                cl.Delete(c.Id);
                MessageBox.Show("Eliminación correcta");
                LimpiarCampo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var c = cl.GetBy("Nombre", textBox1.Text);
            if (c == null)
            {
                MessageBox.Show("Esta marca no existe");
            }
            else
            {
                cl.Update(GetMarca(), c.Id);
            }
        }

        private void verMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerMarcasDialog().Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
