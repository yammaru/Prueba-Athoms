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

        public void MetroButton2_Click(object sender, EventArgs e)
        {
            if(CédulaTextBox.Text ==""|| TeléfonoTextBox.Text == "" ||EdadTextBox.Text==""||NombresTextBox.Text==""){
            
                MessageBox.Show("faltan datos");

            }
            else
            {
                if (NombresTextBox.Text.Length<2 || NombresTextBox.Text.Length > 35)
                {

                    MessageBox.Show("Error en Nombre, se aceptan de 2 a 35 caracteres.");

                }
                else
                {
                    if (cl.Insert(GetCliente()) == 0)
                    {
                        MessageBox.Show("El registro falló");
                        return;
                    }
                    MessageBox.Show("Registro exitoso");
                    LimpiarCampo();
                }
               
            }
         
          
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
            GéneroComboBox.Text = "";
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
           

            Cliente c = cl.GetCedula(CédulaTextBox.Text);
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
            Cliente c = null;
            c = cl.GetBy("Teléfono",CédulaTextBox.Text);
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
            if (CédulaTextBox.Text == "" || TeléfonoTextBox.Text == "" || EdadTextBox.Text == "" || NombresTextBox.Text == "")
            {

                MessageBox.Show("faltan datos");

            }
            else
            {
                if (NombresTextBox.Text.Length < 2 || NombresTextBox.Text.Length > 35)
                {

                    MessageBox.Show("Error en Nombre, se aceptan de 2 a 35 caracteres.");

                }
                else
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
            }
        }

        private void CédulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cliente c = null;
            Validar.SoloNumeros(e);
            c = cl.GetBy("Cédula", CédulaTextBox.Text);
            if ( CédulaTextBox.Text.Length == 8)
            {
               
                e.Handled = true;
                MessageBox.Show("nos se puede mas de 8 caracteres");
               
                if (c == null)
                {
                    MessageBox.Show("Este cliente no está registrado");
                }
                else
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
            if (TeléfonoTextBox.Text.Length == 10 /*|| TeléfonoTextBox.Text.Length == 7*/)
            {
                e.Handled = true;
                MessageBox.Show("nos se puede mas de 10 caracteres");
                Cliente c = cl.GetBy("Cédula", CédulaTextBox.Text);
                if (c == null)
                {
                    MessageBox.Show("Este cliente no está registrado");
                }
                else
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
        }

        private void EdadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            LimpiarCampo();
        }

        private void CédulaTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
