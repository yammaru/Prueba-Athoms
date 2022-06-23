namespace VentaDeCelulares
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeAccesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ConsecutivoLabel = new MetroFramework.Controls.MetroLabel();
            this.FechaLabel = new MetroFramework.Controls.MetroLabel();
            this.CédulaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RefArtículoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.tb_cantidad = new MetroFramework.Controls.MetroTextBox();
            this.VueltasTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PagoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TotalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NombreTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NombreProductoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónClientesToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.verVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónClientesToolStripMenuItem
            // 
            this.gestiónClientesToolStripMenuItem.Name = "gestiónClientesToolStripMenuItem";
            this.gestiónClientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.gestiónClientesToolStripMenuItem.Text = "Clientes";
            this.gestiónClientesToolStripMenuItem.Click += new System.EventHandler(this.gestiónClientesToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celularesToolStripMenuItem,
            this.accesoriosToolStripMenuItem,
            this.tipoDeAccesoriosToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // celularesToolStripMenuItem
            // 
            this.celularesToolStripMenuItem.Name = "celularesToolStripMenuItem";
            this.celularesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.celularesToolStripMenuItem.Text = "Celulares";
            this.celularesToolStripMenuItem.Click += new System.EventHandler(this.celularesToolStripMenuItem_Click);
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            this.accesoriosToolStripMenuItem.Click += new System.EventHandler(this.accesoriosToolStripMenuItem_Click_1);
            // 
            // tipoDeAccesoriosToolStripMenuItem
            // 
            this.tipoDeAccesoriosToolStripMenuItem.Name = "tipoDeAccesoriosToolStripMenuItem";
            this.tipoDeAccesoriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tipoDeAccesoriosToolStripMenuItem.Text = "Tipo de accesorios";
            this.tipoDeAccesoriosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeAccesoriosToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.verVentasToolStripMenuItem.Text = "Ver ventas";
            this.verVentasToolStripMenuItem.Click += new System.EventHandler(this.verVentasToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(331, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 146);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(250, 313);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Aceptar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(169, 313);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(298, 201);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(27, 23);
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = ">>";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(688, 257);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Total";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(688, 286);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Pago";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(688, 315);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Vueltas";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 234);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Nombre";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 205);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Referencia del Articulo";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 176);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(126, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Nombre Del Cliente";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 143);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Identificacion Del Cliente ";
            // 
            // ConsecutivoLabel
            // 
            this.ConsecutivoLabel.AutoSize = true;
            this.ConsecutivoLabel.Location = new System.Drawing.Point(14, 101);
            this.ConsecutivoLabel.Name = "ConsecutivoLabel";
            this.ConsecutivoLabel.Size = new System.Drawing.Size(30, 19);
            this.ConsecutivoLabel.TabIndex = 31;
            this.ConsecutivoLabel.Text = "000";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(123, 101);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(69, 38);
            this.FechaLabel.TabIndex = 32;
            this.FechaLabel.Text = "17/10/2017\r\n";
            // 
            // CédulaTextBox
            // 
            // 
            // 
            // 
            this.CédulaTextBox.CustomButton.Image = null;
            this.CédulaTextBox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.CédulaTextBox.CustomButton.Name = "";
            this.CédulaTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CédulaTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CédulaTextBox.CustomButton.TabIndex = 1;
            this.CédulaTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CédulaTextBox.CustomButton.UseSelectable = true;
            this.CédulaTextBox.CustomButton.Visible = false;
            this.CédulaTextBox.Lines = new string[0];
            this.CédulaTextBox.Location = new System.Drawing.Point(176, 143);
            this.CédulaTextBox.MaxLength = 32767;
            this.CédulaTextBox.Name = "CédulaTextBox";
            this.CédulaTextBox.PasswordChar = '\0';
            this.CédulaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CédulaTextBox.SelectedText = "";
            this.CédulaTextBox.SelectionLength = 0;
            this.CédulaTextBox.SelectionStart = 0;
            this.CédulaTextBox.ShortcutsEnabled = true;
            this.CédulaTextBox.Size = new System.Drawing.Size(116, 23);
            this.CédulaTextBox.TabIndex = 33;
            this.CédulaTextBox.UseSelectable = true;
            this.CédulaTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CédulaTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CédulaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CédulaTextBox_KeyPress);
            // 
            // RefArtículoTextBox
            // 
            // 
            // 
            // 
            this.RefArtículoTextBox.CustomButton.Image = null;
            this.RefArtículoTextBox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.RefArtículoTextBox.CustomButton.Name = "";
            this.RefArtículoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RefArtículoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RefArtículoTextBox.CustomButton.TabIndex = 1;
            this.RefArtículoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RefArtículoTextBox.CustomButton.UseSelectable = true;
            this.RefArtículoTextBox.CustomButton.Visible = false;
            this.RefArtículoTextBox.Lines = new string[0];
            this.RefArtículoTextBox.Location = new System.Drawing.Point(176, 201);
            this.RefArtículoTextBox.MaxLength = 32767;
            this.RefArtículoTextBox.Name = "RefArtículoTextBox";
            this.RefArtículoTextBox.PasswordChar = '\0';
            this.RefArtículoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RefArtículoTextBox.SelectedText = "";
            this.RefArtículoTextBox.SelectionLength = 0;
            this.RefArtículoTextBox.SelectionStart = 0;
            this.RefArtículoTextBox.ShortcutsEnabled = true;
            this.RefArtículoTextBox.Size = new System.Drawing.Size(116, 23);
            this.RefArtículoTextBox.TabIndex = 34;
            this.RefArtículoTextBox.UseSelectable = true;
            this.RefArtículoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RefArtículoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RefArtículoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RefArtículoTextBox_KeyPress);
            // 
            // tb_cantidad
            // 
            // 
            // 
            // 
            this.tb_cantidad.CustomButton.Image = null;
            this.tb_cantidad.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.tb_cantidad.CustomButton.Name = "";
            this.tb_cantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_cantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_cantidad.CustomButton.TabIndex = 1;
            this.tb_cantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_cantidad.CustomButton.UseSelectable = true;
            this.tb_cantidad.CustomButton.Visible = false;
            this.tb_cantidad.Lines = new string[0];
            this.tb_cantidad.Location = new System.Drawing.Point(176, 259);
            this.tb_cantidad.MaxLength = 32767;
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.PasswordChar = '\0';
            this.tb_cantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_cantidad.SelectedText = "";
            this.tb_cantidad.SelectionLength = 0;
            this.tb_cantidad.SelectionStart = 0;
            this.tb_cantidad.ShortcutsEnabled = true;
            this.tb_cantidad.Size = new System.Drawing.Size(149, 23);
            this.tb_cantidad.TabIndex = 35;
            this.tb_cantidad.UseSelectable = true;
            this.tb_cantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_cantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cantidad_KeyPress);
            // 
            // VueltasTextBox
            // 
            // 
            // 
            // 
            this.VueltasTextBox.CustomButton.Image = null;
            this.VueltasTextBox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.VueltasTextBox.CustomButton.Name = "";
            this.VueltasTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VueltasTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VueltasTextBox.CustomButton.TabIndex = 1;
            this.VueltasTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VueltasTextBox.CustomButton.UseSelectable = true;
            this.VueltasTextBox.CustomButton.Visible = false;
            this.VueltasTextBox.Lines = new string[0];
            this.VueltasTextBox.Location = new System.Drawing.Point(764, 311);
            this.VueltasTextBox.MaxLength = 32767;
            this.VueltasTextBox.Name = "VueltasTextBox";
            this.VueltasTextBox.PasswordChar = '\0';
            this.VueltasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VueltasTextBox.SelectedText = "";
            this.VueltasTextBox.SelectionLength = 0;
            this.VueltasTextBox.SelectionStart = 0;
            this.VueltasTextBox.ShortcutsEnabled = true;
            this.VueltasTextBox.Size = new System.Drawing.Size(119, 23);
            this.VueltasTextBox.TabIndex = 36;
            this.VueltasTextBox.UseSelectable = true;
            this.VueltasTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VueltasTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PagoTextBox
            // 
            // 
            // 
            // 
            this.PagoTextBox.CustomButton.Image = null;
            this.PagoTextBox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.PagoTextBox.CustomButton.Name = "";
            this.PagoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PagoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PagoTextBox.CustomButton.TabIndex = 1;
            this.PagoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PagoTextBox.CustomButton.UseSelectable = true;
            this.PagoTextBox.CustomButton.Visible = false;
            this.PagoTextBox.Lines = new string[0];
            this.PagoTextBox.Location = new System.Drawing.Point(764, 282);
            this.PagoTextBox.MaxLength = 32767;
            this.PagoTextBox.Name = "PagoTextBox";
            this.PagoTextBox.PasswordChar = '\0';
            this.PagoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PagoTextBox.SelectedText = "";
            this.PagoTextBox.SelectionLength = 0;
            this.PagoTextBox.SelectionStart = 0;
            this.PagoTextBox.ShortcutsEnabled = true;
            this.PagoTextBox.Size = new System.Drawing.Size(119, 23);
            this.PagoTextBox.TabIndex = 37;
            this.PagoTextBox.UseSelectable = true;
            this.PagoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PagoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TotalTextBox
            // 
            // 
            // 
            // 
            this.TotalTextBox.CustomButton.Image = null;
            this.TotalTextBox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.TotalTextBox.CustomButton.Name = "";
            this.TotalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalTextBox.CustomButton.TabIndex = 1;
            this.TotalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalTextBox.CustomButton.UseSelectable = true;
            this.TotalTextBox.CustomButton.Visible = false;
            this.TotalTextBox.Lines = new string[] {
        "0"};
            this.TotalTextBox.Location = new System.Drawing.Point(764, 253);
            this.TotalTextBox.MaxLength = 32767;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.PasswordChar = '\0';
            this.TotalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalTextBox.SelectedText = "";
            this.TotalTextBox.SelectionLength = 0;
            this.TotalTextBox.SelectionStart = 0;
            this.TotalTextBox.ShortcutsEnabled = true;
            this.TotalTextBox.Size = new System.Drawing.Size(119, 23);
            this.TotalTextBox.TabIndex = 38;
            this.TotalTextBox.Text = "0";
            this.TotalTextBox.UseSelectable = true;
            this.TotalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NombreTextBox
            // 
            // 
            // 
            // 
            this.NombreTextBox.CustomButton.Image = null;
            this.NombreTextBox.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.NombreTextBox.CustomButton.Name = "";
            this.NombreTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NombreTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NombreTextBox.CustomButton.TabIndex = 1;
            this.NombreTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NombreTextBox.CustomButton.UseSelectable = true;
            this.NombreTextBox.CustomButton.Visible = false;
            this.NombreTextBox.Lines = new string[0];
            this.NombreTextBox.Location = new System.Drawing.Point(176, 172);
            this.NombreTextBox.MaxLength = 32767;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.PasswordChar = '\0';
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NombreTextBox.SelectedText = "";
            this.NombreTextBox.SelectionLength = 0;
            this.NombreTextBox.SelectionStart = 0;
            this.NombreTextBox.ShortcutsEnabled = true;
            this.NombreTextBox.Size = new System.Drawing.Size(149, 23);
            this.NombreTextBox.TabIndex = 39;
            this.NombreTextBox.UseSelectable = true;
            this.NombreTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NombreTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NombreProductoTextBox
            // 
            // 
            // 
            // 
            this.NombreProductoTextBox.CustomButton.Image = null;
            this.NombreProductoTextBox.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.NombreProductoTextBox.CustomButton.Name = "";
            this.NombreProductoTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NombreProductoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NombreProductoTextBox.CustomButton.TabIndex = 1;
            this.NombreProductoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NombreProductoTextBox.CustomButton.UseSelectable = true;
            this.NombreProductoTextBox.CustomButton.Visible = false;
            this.NombreProductoTextBox.Lines = new string[0];
            this.NombreProductoTextBox.Location = new System.Drawing.Point(176, 230);
            this.NombreProductoTextBox.MaxLength = 32767;
            this.NombreProductoTextBox.Name = "NombreProductoTextBox";
            this.NombreProductoTextBox.PasswordChar = '\0';
            this.NombreProductoTextBox.ReadOnly = true;
            this.NombreProductoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NombreProductoTextBox.SelectedText = "";
            this.NombreProductoTextBox.SelectionLength = 0;
            this.NombreProductoTextBox.SelectionStart = 0;
            this.NombreProductoTextBox.ShortcutsEnabled = true;
            this.NombreProductoTextBox.Size = new System.Drawing.Size(149, 23);
            this.NombreProductoTextBox.TabIndex = 40;
            this.NombreProductoTextBox.UseSelectable = true;
            this.NombreProductoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NombreProductoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(14, 263);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.NombreProductoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.PagoTextBox);
            this.Controls.Add(this.VueltasTextBox);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.RefArtículoTextBox);
            this.Controls.Add(this.CédulaTextBox);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.ConsecutivoLabel);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem verVentasToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel ConsecutivoLabel;
        private MetroFramework.Controls.MetroLabel FechaLabel;
        private MetroFramework.Controls.MetroTextBox CédulaTextBox;
        private MetroFramework.Controls.MetroTextBox RefArtículoTextBox;
        private MetroFramework.Controls.MetroTextBox tb_cantidad;
        private MetroFramework.Controls.MetroTextBox VueltasTextBox;
        private MetroFramework.Controls.MetroTextBox PagoTextBox;
        private MetroFramework.Controls.MetroTextBox TotalTextBox;
        private MetroFramework.Controls.MetroTextBox NombreTextBox;
        private MetroFramework.Controls.MetroTextBox NombreProductoTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ToolStripMenuItem celularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeAccesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}