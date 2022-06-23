using DAL;
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
    public partial class IniciarSesiónForm : MetroFramework.Forms.MetroForm
    {
        private UsuarioRepository ur = new UsuarioRepository();

        public IniciarSesiónForm()
        {
            InitializeComponent();
        }

        private void bb_iniciar_sesión_Click(object sender, EventArgs e)
        {
            Usuario u = ur.GetBy("Nombre", UsuarioTextBox.Text);
            if (u == null)
            {
                MessageBox.Show("Este usuario no está registrado");
            }
            else
            {
                if (u.Contraseña.Equals(ContraseñaTextBox.Text))
                {
                    this.Visible = false;
                    new PrincipalForm().Visible = true;
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
        }
    }
}
