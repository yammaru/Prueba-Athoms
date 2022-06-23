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
    public partial class GestiónDeAccesoriosForm : MetroFramework.Forms.MetroForm
    {
        private static AccesorioLógica cl = new AccesorioLógica();
        private void CargarMarcas()
        {
            MarcaLógica mc = new MarcaLógica();
            IList<Marca> marcas = mc.GetAll();
            MarcaComboBox.DataSource = marcas;
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "Id";
        }

        private void CargarColores()
        {
            ColorLógica cl = new ColorLógica();
            IList<Entity.Color> colores = cl.GetAll();

            ColorComboBox.DataSource = colores;
            ColorComboBox.DisplayMember = "Nombre";
            ColorComboBox.ValueMember = "Id";
        }

        private void CargarTipos()
        {
            TipoDeAccesorioLógica ta = new TipoDeAccesorioLógica();
            IList<TipoDeAccesorio> tipos = ta.GetAll();

            TipoComboBox.DataSource = tipos;
            TipoComboBox.DisplayMember = "Tipo";
            TipoComboBox.ValueMember = "Id";
        }

        public GestiónDeAccesoriosForm()
        {
            InitializeComponent();
            CargarMarcas();
            CargarTipos();
            CargarColores();
        }
        
        private void verArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerAccesoriosDialog().Visible = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            var c = cl.GetBy("Referencia", ReferenciaTextBox.Text);
            if (c == null)
            {
                MessageBox.Show("Este celular no existe");
            }
            else
            {
                cl.Update(GetAccesorio(), c.Id);
                MessageBox.Show("Modificación correcta");
            }
        }

        private Accesorio GetAccesorio()
        {
            var c = new Accesorio();

            MarcaLógica mc = new MarcaLógica();
            ColorLógica lc = new ColorLógica();
            TipoDeAccesorioLógica tc = new TipoDeAccesorioLógica();

            c.Referencia = ReferenciaTextBox.Text;
            c.Nombre = NombreTextBox.Text;
            c.Precio = float.Parse(PrecioTextBox.Text);
            c.Descripción = DescripciónTextBox.Text;
            c.Cantidad = int.Parse(CantidadTextBox.Text);
            c.Tipo = tc.Get(int.Parse(TipoComboBox.SelectedValue.ToString()));
            c.Precio = int.Parse(PrecioTextBox.Text);
            c.Marca = mc.Get(int.Parse(MarcaComboBox.SelectedValue.ToString()));
            c.Color = lc.Get(int.Parse(ColorComboBox.SelectedValue.ToString()));

            return c;
        }
        private void LimpiarCampos()
        {
            NombreTextBox.Text = "";
            DescripciónTextBox.Text = "";
            PrecioTextBox.Text = "";
            CantidadTextBox.Text = "";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            if (cl.Insert(GetAccesorio()) == 0) MessageBox.Show("Error registrado");
            else
            {
                MessageBox.Show("Registro exitoso");
                LimpiarCampos();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var c = cl.GetBy("Referencia", ReferenciaTextBox.Text);

            if (c == null) MessageBox.Show("El accesorio con esta referencia no existe");
            else
            {
                if (cl.Delete(c.Id) == 0) MessageBox.Show("La eliminación falló");
                else
                {
                    MessageBox.Show("Eliminación correcta");
                    LimpiarCampos();
                }
            }
        }

        private void ReferenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e); 
        }

        private void PrecioTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void DescripciónTextBox_Click(object sender, EventArgs e)
        {

        }

        private void DescripciónTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void GestiónDeAccesoriosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
