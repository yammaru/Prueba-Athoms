﻿using BLL;
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
    public partial class PrincipalForm : MetroFramework.Forms.MetroForm
    {
        Cliente c = null;
        Dictionary<Artículo, int> productos = new Dictionary<Artículo, int>();

        public PrincipalForm()
        {
            InitializeComponent();
            CargarFecha();
            CargaConsecutivo();
        }

        private void gestiónClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestiónDeClientesForm().Visible = true;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestiónDeUsuariosForm().Visible = true;
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VerVentasDialog().Visible = true;
        }

        private void AgregarArtículo(Artículo a, int cantidad)
        {
            dataGridView1.Rows.Add(a.Referencia, a.Nombre, a.Precio, cantidad, cantidad * a.Precio);
        }

        public void CargarFecha()
        {
          //  FechaLabel.Text = DateTime.Now.ToShortDateString();
        }

        public void CargaConsecutivo()
        {
            ConsecutivoLabel.Text = "Factura N° "+ new CompraLógica().Count().ToString();
        }

        private void AgregarProducto(Artículo a)
        {
            if (tb_cantidad.Text=="") { 
                MessageBox.Show("No hay valor en cantidado"); 
            } else     {
            int cantidad = int.Parse(tb_cantidad.Text);
            if (a.Cantidad >= cantidad)
            {
                AgregarArtículo(a, int.Parse(tb_cantidad.Text));
                this.productos.Add(a, cantidad);
            }
            else MessageBox.Show("No hay suficientes existencias de este artículo");
            NombreProductoTextBox.Text = a.Nombre;
            }
          
        }



        private void MetroButton3_Click(object sender, EventArgs e)
        {
            CelularLógica cl = new CelularLógica();
        

            Artículo a = null;


            if ((a = cl.GetBy("Referencia", RefArtículoTextBox.Text)) != null)
            {
                AgregarProducto(a);
            }
            else
            {
                MessageBox.Show("Este artículo no está registrado");
            }
          
           
            
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestiónDeAccesoriosForm().Visible = true;
        }

        private void celularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaDeMarcaYColor())
                new GestiónDeCelularesForm().Visible = true;
        }

        private bool VerificarExistenciaDeMarcaYColor()
        {
            MarcaLógica mc = new MarcaLógica();
            ColorLógica cl = new ColorLógica();
            if (mc.Count() == 0 || cl.Count() == 0)
            {
                MessageBox.Show("Deben haber al menos una marca y un color registrado");
                return false;
            }
            return true;
        }

        private void accesoriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (VerificarExistenciaDeMarcaYColor())
                new GestiónDeAccesoriosForm().Visible = true;
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestiónDeMarcasForm().Visible = true;
        }

        private void tipoDeAccesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestiónTipoDeAccesorioForm().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if(CédulaTextBox.Text != ""){
 ClienteRepository cr = new ClienteRepository();
            var c = cr.GetBy("Teléfono", CédulaTextBox.Text);

            if (c == null)
            {
                DialogResult result = MessageBox.Show("Esta persona no está registrada,desea registrarlo?", "Cliente", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        this.Visible = false;
                        new GestiónDeClientesForm().Visible = true;
                    }
                    if (result == DialogResult.Cancel)
                    {
                        this.Visible = false;
                     
                    }
                }
            else
            {
                this.c = c;
                NombreTextBox.Text = c.Nombres + " " + c.PrimerApellido;
            }
            }

            else
            {
                MessageBox.Show("No hay datos...");
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var sub = float.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            TotalTextBox.Text = (float.Parse(TotalTextBox.Text) + sub).ToString();
        }
        
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var sub = float.Parse(e.Row.Cells[4].Value.ToString());

            CelularLógica cl = new CelularLógica();
            AccesorioLógica al = new AccesorioLógica();

            Artículo a = null;

            if ((a = cl.GetBy("Referencia", RefArtículoTextBox.Text)) != null)
                AgregarProducto(a);
            else if ((a = al.GetBy("Referencia", RefArtículoTextBox.Text)) != null)
                AgregarProducto(a);

            productos.Remove(a);

            TotalTextBox.Text = (float.Parse(TotalTextBox.Text) - sub).ToString();
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            CompraLógica cl = new CompraLógica();
            if (PagoTextBox.Text == "") { MessageBox.Show("No hay suficientes valor en pago"); }
            else
            {
                try
                {
                    float total = float.Parse(TotalTextBox.Text);
                    float pago = float.Parse(PagoTextBox.Text);

                    if (pago < total)
                    {
                        MessageBox.Show("Dinero insuficiente");
                        return;
                    }
                    if (this.c == null)
                    {
                        MessageBox.Show("Ingrese un cliente");
                        return;
                    }
                    Compra c = new Compra();

                    c.Id = cl.Count() + 1;
                    c.Fecha = DateTime.Now;
                    c.Cliente = this.c;
                    c.Total = total;
                    c.Artículos = this.productos;

                    if (cl.Insert(c) == 0)
                    {
                        MessageBox.Show("Error en la compra");
                    }
                    else
                    {
                        MessageBox.Show("Compra exitosa");
                        VueltasTextBox.Text = (pago - total).ToString();
                    }
                }
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show("Ingrese un pago correcto");
                }
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void tb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void CédulaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void RefArtículoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new IniciarSesiónForm().Visible = true;
        }

        private void ConsecutivoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}