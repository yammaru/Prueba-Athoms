using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace VentaDeCelulares
{
    public partial class fr_celulares : Form
    {
        CelularLógica cl = new CelularLógica();
        public fr_celulares()
        {
            InitializeComponent();
         
           
           
        }
        int Imei2;
        public fr_celulares(string imei)
        {
            InitializeComponent();
                CargarMarcas();
       
            CargarTipos();
            label1.Text = "Editar - " +imei;
            Imei2 = Convert.ToInt32( imei);
          buscar();
        }
        private void CargarMarcas()
        {
            MarcaLógica mc = new MarcaLógica();
            IList<Marca> marcas = mc.GetAll();

            MarcaComboBox.DataSource = marcas;
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "Id";
        }
        private void buscar()
        {
            Celular c = cl.GetBy("Cantidad",Imei2);

          
            if (c == null) MessageBox.Show("Este celular no existe");
            else
            {
                NombreTextBox.Text = c.Nombre;
                DescripciónTextBox.Text = c.Descripción;
                PrecioTextBox.Text = c.Precio.ToString();
                ReferenciaTextBox.Text = c.Referencia.ToString();
                MarcaComboBox.SelectedValue = c.Marca.Id;

                TipoComboBox.SelectedText = c.Tipo == TipoDeCelular.INTELIGENTE ? "Inteligente" : "Regular";
                AlmacenamientoTextBox.Text = c.Almacenamiento.ToString();
                RamTextBox.Text = c.RAM.ToString();
                ResoluciónTextBox.Text = c.MegapixelesEnLaCámara.ToString();
            }
        }
        private void LimpiarCampos()
        {
            NombreTextBox.Text = "";
            DescripciónTextBox.Text = "";
            PrecioTextBox.Text = "";
           
            AlmacenamientoTextBox.Text = "";
            RamTextBox.Text = "";
            ResoluciónTextBox.Text = "";
        }

        private void CargarTipos()
        {
            IList<string> tipos = new List<string>
            {
                "Inteligente",
                "Regular"
            };
            TipoComboBox.DataSource = tipos;
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Celular GetCelular()
        {
            Celular c = new Celular();

            MarcaLógica mc = new MarcaLógica();
            ColorLógica lc = new ColorLógica();

            c.Referencia = ReferenciaTextBox.Text;
            c.Almacenamiento = int.Parse(AlmacenamientoTextBox.Text);
            c.MegapixelesEnLaCámara = int.Parse(ResoluciónTextBox.Text);
            c.RAM = int.Parse(RamTextBox.Text);
            c.Nombre = NombreTextBox.Text;
            c.Precio = float.Parse(PrecioTextBox.Text);
            c.Descripción = DescripciónTextBox.Text;
            c.Color = lc.Get(1);
            c.Tipo = TipoComboBox.SelectedText == "Inteligente" ? TipoDeCelular.INTELIGENTE : TipoDeCelular.REGULAR;
            c.Precio = int.Parse(PrecioTextBox.Text);
            c.Marca = mc.Get(int.Parse(MarcaComboBox.SelectedValue.ToString()));


            return c;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            if (NombreTextBox.Text == "") {
                aux++;
                MessageBox.Show("No se puede mandar datos vacios1"); }
           if( DescripciónTextBox.Text == "") { aux++; MessageBox.Show("No se puede mandar datos vacios2");  }
           if (PrecioTextBox.Text == "") {
                aux++; MessageBox.Show("No se puede mandar datos vacios3"); }
            if (ReferenciaTextBox.Text == "") { aux++; MessageBox.Show("No se puede mandar datos vacios5"); }
           if (AlmacenamientoTextBox.Text == "") { aux++; MessageBox.Show("No se puede mandar datos vaci4os"); }
            if (RamTextBox.Text == "") { aux++; MessageBox.Show("No se puede mandar datos vacios6"); }
            if(ResoluciónTextBox.Text == "") { aux++; MessageBox.Show("No se puede mandar datos vac7ios"); }
           if (aux==0) {  
                var c = cl.GetBy("Cantidad", Imei2);
                if (c == null)
                {
                    MessageBox.Show("Este celular no existe");
                }
                else
                {
                    cl.Update(GetCelular(), c.Id);
                    MessageBox.Show("Modificación correcta");
                }
            
            }
            else {
                MessageBox.Show("No se puede mandar datos vacios");
            }
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Celular c = cl.GetBy("Cantidad", Imei2);

            if (c == null) MessageBox.Show("El celular con esta referencia no existe");
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
    }
}
