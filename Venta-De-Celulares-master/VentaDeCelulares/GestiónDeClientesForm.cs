using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class GestiónDeClientesForm : MetroFramework.Forms.MetroForm
    {
        private ClienteLógica cl = new ClienteLógica();

        public GestiónDeClientesForm()
        {
            InitializeComponent();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerClientesDialog().Visible = true;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (cl.Insert(GetCliente()) == 0)
            {
                MessageBox.Show("El registro falló");
                return;
            }
            MessageBox.Show("Registro exitoso");
            LimpiarCampo();
        }

        private Cliente GetCliente()
        {
            Cliente c = new Cliente();

            c.Cédula = CédulaTextBox.Text;
            c.Nombres = NombresTextBox.Text;
            c.PrimerApellido = ApellidosTextBox.Text;
            c.SegundoApellido = "";
            c.Edad = int.Parse(EdadTextBox.Text);
            c.CorreoElectrónico = CorreoElectrónicoTextBox.Text;
            c.Dirección = DirecciónTextBox.Text;
            c.Teléfono = TeléfonoTextBox.Text;
            c.Género = GéneroComboBox.Text == "Masculino" ? 'M' : 'F';

            return c;
        }

        private void LimpiarCampo()
        {
            CédulaTextBox.Text = "";
            NombresTextBox.Text = "";
            ApellidosTextBox.Text = "";
            EdadTextBox.Text = "";
            CorreoElectrónicoTextBox.Text = "";
            DirecciónTextBox.Text = "";
            TeléfonoTextBox.Text = "";
            GéneroComboBox.Text = "Masculino";
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            ClienteLógica cl = new ClienteLógica();

            Cliente c = cl.GetBy("Cédula", CédulaTextBox.Text);
            if (c == null)
            {
                MessageBox.Show("Este cliente no está registrado");
            } else
            {
                cl.Delete(c.Id);
                MessageBox.Show("Eliminación correcta");
                LimpiarCampo();
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Cliente c = cl.GetBy("Cédula", CédulaTextBox.Text);
            if (c == null)
            {
                MessageBox.Show("Este cliente no está registrado");
            } else
            {
                CédulaTextBox.Text = c.Cédula;
                NombresTextBox.Text = c.Nombres;
                ApellidosTextBox.Text = c.PrimerApellido;
                EdadTextBox.Text = c.Edad.ToString();
                CorreoElectrónicoTextBox.Text = c.CorreoElectrónico;
                DirecciónTextBox.Text = c.Dirección;
                TeléfonoTextBox.Text = c.Teléfono;
                GéneroComboBox.Text = c.Género == 'M' ? "Masculino" : "Femenino";
            }
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            var c = cl.GetBy("Cédula", CédulaTextBox.Text);
            if (c == null)
            {
                MessageBox.Show("Esta persona no existe");
            }
            else
            {
                cl.Update(GetCliente(), c.Id);
            }
        }

        private void CédulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void ApellidosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TeléfonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void EdadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
