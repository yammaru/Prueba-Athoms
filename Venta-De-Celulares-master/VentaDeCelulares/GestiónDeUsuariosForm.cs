using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class GestiónDeUsuariosForm : MetroFramework.Forms.MetroForm
    {
        private UsuarioRepository ur = new UsuarioRepository();

        public void CargarRoles()
        {
            IList<string> tipos = new List<string>
            {
                "Administrador",
                "Regular"
            };
            RolesComboBox.DataSource = tipos;
        }
        public GestiónDeUsuariosForm()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerUsuariosDialog().Visible = true;
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Usuario GetUsuario()
        {
            Usuario u = new Usuario();
            u.Nombre = NombreTextBox.Text;
            u.Contraseña = ContraseñaTextbox.Text;
            u.Rol = RolesComboBox.Text.Equals("Administrador") ? '1' : '2';
            return u;
        }

        private void b_registrar_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextbox.Text == "" || NombreTextBox.Text == "")
            {

                MessageBox.Show("faltan datos");

            }
            else
            {
                if (ContraseñaTextbox.Text.Length <= 20 && ContraseñaTextbox.Text.Length >= 8 && NombreTextBox.Text.Length <= 20 && NombreTextBox.Text.Length >= 2)
                {

                    if (ur.Insert(GetUsuario()) == 0)
                    {
                        MessageBox.Show("El registro falló");
                    }
                    else
                    {
                        MessageBox.Show("Registro exitoso");
                    }

                }
                else { 
                    MessageBox.Show("los caracteres permitidos en nombre son de 2 a 20, encontraseña son de 8 a 20, porfavor verificar"); 
                }
                
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            Usuario u = ur.GetBy("Nombre", NombreTextBox.Text);
            if (u == null)
            {
                MessageBox.Show("Este usuario no extá registrado");
            }
            else
            {
                if (ur.Delete(u.Id) == 0)
                {
                    MessageBox.Show("Falló la eliminación");
                }
                else
                {
                    MessageBox.Show("Eliminación exitosa");
                }
            }
        }

        private void b_modificar_Click(object sender, EventArgs e)
        {
            Usuario u = ur.GetBy("Nombre", NombreTextBox.Text);
            if (u == null)
            {
                MessageBox.Show("Este usuario no extá registrado");
            }
            else
            {
                if (ur.Update(u.Id, GetUsuario()) == 0)
                {
                    MessageBox.Show("Falló la actualización");
                }
                else
                {
                    MessageBox.Show("Actualización exitosa");
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);

        }

        private void RolesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
