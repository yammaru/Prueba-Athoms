namespace VentaDeCelulares
{
    partial class GestiónDeUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiónDeUsuariosForm));
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.b_modificar = new MetroFramework.Controls.MetroButton();
            this.b_eliminar = new MetroFramework.Controls.MetroButton();
            this.b_registrar = new MetroFramework.Controls.MetroButton();
            this.b_cancelar = new MetroFramework.Controls.MetroButton();
            this.RolesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(111, 114);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(150, 20);
            this.NombreTextBox.TabIndex = 5;
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // ContraseñaTextbox
            // 
            this.ContraseñaTextbox.Location = new System.Drawing.Point(111, 140);
            this.ContraseñaTextbox.Name = "ContraseñaTextbox";
            this.ContraseñaTextbox.Size = new System.Drawing.Size(150, 20);
            this.ContraseñaTextbox.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.verUsuariosToolStripMenuItem.Text = "Ver usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Contraseña";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(28, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Rol";
            // 
            // b_modificar
            // 
            this.b_modificar.Location = new System.Drawing.Point(292, 354);
            this.b_modificar.Name = "b_modificar";
            this.b_modificar.Size = new System.Drawing.Size(75, 23);
            this.b_modificar.TabIndex = 17;
            this.b_modificar.Text = "Modificar";
            this.b_modificar.UseSelectable = true;
            this.b_modificar.Click += new System.EventHandler(this.b_modificar_Click);
            // 
            // b_eliminar
            // 
            this.b_eliminar.Location = new System.Drawing.Point(373, 354);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(75, 23);
            this.b_eliminar.TabIndex = 18;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.UseSelectable = true;
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_registrar
            // 
            this.b_registrar.Location = new System.Drawing.Point(211, 354);
            this.b_registrar.Name = "b_registrar";
            this.b_registrar.Size = new System.Drawing.Size(75, 23);
            this.b_registrar.TabIndex = 19;
            this.b_registrar.Text = "Registrar";
            this.b_registrar.UseSelectable = true;
            this.b_registrar.Click += new System.EventHandler(this.b_registrar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Location = new System.Drawing.Point(454, 354);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 20;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseSelectable = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // RolesComboBox
            // 
            this.RolesComboBox.FormattingEnabled = true;
            this.RolesComboBox.ItemHeight = 23;
            this.RolesComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.RolesComboBox.Location = new System.Drawing.Point(111, 166);
            this.RolesComboBox.Name = "RolesComboBox";
            this.RolesComboBox.Size = new System.Drawing.Size(150, 29);
            this.RolesComboBox.TabIndex = 21;
            this.RolesComboBox.UseSelectable = true;
            this.RolesComboBox.SelectedIndexChanged += new System.EventHandler(this.RolesComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 261);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(579, 368);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "Volver";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // GestiónDeUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 382);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RolesComboBox);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_registrar);
            this.Controls.Add(this.b_eliminar);
            this.Controls.Add(this.b_modificar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ContraseñaTextbox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestiónDeUsuariosForm";
            this.Text = "Gestión de usuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton b_modificar;
        private MetroFramework.Controls.MetroButton b_eliminar;
        private MetroFramework.Controls.MetroButton b_registrar;
        private MetroFramework.Controls.MetroButton b_cancelar;
        private MetroFramework.Controls.MetroComboBox RolesComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}