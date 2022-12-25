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
    public partial class GestiónDeCelularesForm : MetroFramework.Forms.MetroForm
    {
        CelularLógica cl = new CelularLógica();

        public GestiónDeCelularesForm()
        {
            InitializeComponent();
            CargarMarcas();
            CargarColores();
            CargarTipos();
            cargarTabla();
        }

        private void bt_volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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

        /*    ColoresComboBox.DataSource = colores;
            ColoresComboBox.DisplayMember = "Nombre";
            ColoresComboBox.ValueMember = "Id";
        */
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

        private void Bt_registrar_Click(object sender, EventArgs e)
        {
            if (
                    NombreTextBox.Text != ""&&
                    DescripciónTextBox.Text != ""&&
                    PrecioTextBox.Text != ""&&
                    CantidadTextBox.Text != ""&&
                    AlmacenamientoTextBox.Text != ""&&
                    RamTextBox.Text !=""&&
                    ResoluciónTextBox.Text !=""
                )
            {
                if (CantidadTextBox.Text.Length > 10 || CantidadTextBox.Text.Length < 1)
                {

                  
                    MessageBox.Show("nos se puede mas de 10 caracteres ni menos de 1");

                }
                else
                {
                    if (AlmacenamientoTextBox.Text.Length > 4 || AlmacenamientoTextBox.Text.Length < 1)
                    {


                        MessageBox.Show("el almacenamiento deben estar entra 1 y 9999");

                    }
                    else
                    {

                        if ( ResoluciónTextBox.Text.Length > 3 || ResoluciónTextBox.Text.Length <= 1)
                        {


                            MessageBox.Show("los MP de la camara deben estar entra 1 y 999");

                        }
                        else
                        {
                            if (PrecioTextBox.Text.Length > 7 || PrecioTextBox.Text.Length < 1)
                            {


                                MessageBox.Show("nos se puede un valor mas de 9999999 caracteres ni menos de 1");
                               
                            }
                            else
                            {
                                if (RamTextBox.Text.Length > 2 || RamTextBox.Text.Length < 1)
                                {


                                    MessageBox.Show("nos se puede ram mas de 99 caracteres ni menos de 1");

                                }
                                else
                                {
                                    if (DescripciónTextBox.Text.Length > 4 || DescripciónTextBox.Text.Length < 1)
                                    {


                                        MessageBox.Show("nos se puede una pantalla mas de 9999 caracteres ni menos de 1");

                                    }
                                    else
                                    {
                                        Celular c = cl.GetBy("cantidad", CantidadTextBox.Text);

                                        if (c == null)
                                        {

                                            if (cl.Insert(GetCelular()) == 0) { 
                                                MessageBox.Show("Error registrado"); 
                                            }
                                            else
                                            {
                                                MessageBox.Show("Registro exitoso");
                                                LimpiarCampos();
                                                cargarTabla();
                                            }
                                        }
                                    }  
                                }
                            }
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        
           /* else
            {
                if (cl.Delete(c.Id) == 0) MessageBox.Show("La eliminación falló");
                else
                {
                    MessageBox.Show("Eliminación correcta");
                    LimpiarCampos();
                }
            }
           */
        }

        private void LimpiarCampos()
        {
            NombreTextBox.Text = "";
            DescripciónTextBox.Text = "";
            PrecioTextBox.Text = "";
            CantidadTextBox.Text = "";
            AlmacenamientoTextBox.Text = "";
            RamTextBox.Text = "";
            ResoluciónTextBox.Text = "";
            ReferenciaTextBox.Text = "";
        }

          /*   private void MetroButton1_Click(object sender, EventArgs e)
        {
            Celular c = cl.GetBy("cantidad", ReferenciaTextBox.Text);

            if (c == null) MessageBox.Show("El celular con esta referencia no existe");
            else
            {
                if (cl.Delete(c.Id) == 0) MessageBox.Show("La eliminación falló");
                else {
                    MessageBox.Show("Eliminación correcta");
                    LimpiarCampos();
                }
            }
        }*/

          /* private void MetroButton2_Click(object sender, EventArgs e)
        {
            Celular c = cl.GetBy("Referencia", ReferenciaTextBox.Text);
            if (c == null) MessageBox.Show("Este celular no existe");
            else
            {
                NombreTextBox.Text = c.Nombre;
                DescripciónTextBox.Text = c.Descripción;
                PrecioTextBox.Text = c.Precio.ToString();
                CantidadTextBox.Text = c.Cantidad.ToString();
                MarcaComboBox.SelectedValue = c.Marca.Id;
              
                TipoComboBox.SelectedText = c.Tipo == TipoDeCelular.INTELIGENTE ? "Inteligente" : "Regular";
                AlmacenamientoTextBox.Text = c.Almacenamiento.ToString();
                RamTextBox.Text = c.RAM.ToString();
                ResoluciónTextBox.Text = c.MegapixelesEnLaCámara.ToString();
            }
        }*/

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
            c.Cantidad = int.Parse(CantidadTextBox.Text);
            c.Tipo = TipoComboBox.SelectedText == "Inteligente" ? TipoDeCelular.INTELIGENTE : TipoDeCelular.REGULAR;
            c.Precio = int.Parse(PrecioTextBox.Text);
            c.Marca = mc.Get(int.Parse(MarcaComboBox.SelectedValue.ToString()));
            c.Color = lc.Get(1);

            return c;
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            var c = cl.GetBy("Referencia", ReferenciaTextBox.Text);
            if (c == null)
            {
                MessageBox.Show("Este celular no existe");
            } else
            {
                cl.Update(GetCelular(), c.Id);
                MessageBox.Show("Modificación correcta");
            }
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            new fr_celulares().Visible = true;
        }

        private void ReferenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void DescripciónTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             Validar.SoloNumeros(e);

           if (CantidadTextBox.Text.Length > 10)
            {

                e.Handled = true;
                MessageBox.Show("nos se puede mas de 8 caracteres");

            }
        }

            private void AlmacenamientoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void RamTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void ResoluciónTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void MarcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cargarTabla()
        {
            CelularLógica cl = new CelularLógica();

            DataTable dt = new DataTable();
            dt.Columns.Add("Imei");
            dt.Columns.Add("Referencia");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Pantalla");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Almacenamiento");
            dt.Columns.Add("RAM");
            dt.Columns.Add("Resolución");
            dt.Columns.Add("Tipo");
            foreach (var oItem in cl.GetAll())
            {
                dt.Rows.Add(new object[] {oItem.Cantidad, oItem.Referencia, oItem.Nombre,
                oItem.Precio, oItem.Descripción,  oItem.Marca.Nombre,
                oItem.Almacenamiento, oItem.RAM, oItem.MegapixelesEnLaCámara, oItem.Tipo == Entity.TipoDeCelular.INTELIGENTE ? "Inteligente" : "Regular" });
            }
            dataGridView1.DataSource = dt;
        }

        private void GestiónDeCelularesForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CantidadTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void Marca_Click(object sender, EventArgs e)
        {

        }

        private void TipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void ResoluciónTextBox_Click(object sender, EventArgs e)
        {

        }

        private void RamTextBox_Click(object sender, EventArgs e)
        {

        }

        private void AlmacenamientoTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
        string imei;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name=="editar")
            {
                imei = dataGridView1.CurrentRow.Cells["imei"].Value.ToString();
                fr_celulares fr = new fr_celulares(imei);
                fr.ShowDialog();
                cargarTabla();
            }
          
        }

        private void DescripciónTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void ReferenciaTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
