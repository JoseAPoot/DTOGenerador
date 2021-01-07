
namespace DTOGenerador
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBDs = new System.Windows.Forms.Panel();
            this.lstBDs = new System.Windows.Forms.CheckedListBox();
            this.lblBDs = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblConexion = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.panelTablas = new System.Windows.Forms.Panel();
            this.lstTablas = new System.Windows.Forms.CheckedListBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBDs.SuspendLayout();
            this.panelTablas.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panelCabecera.Controls.Add(this.btnAcerca);
            this.panelCabecera.Controls.Add(this.pictureBox1);
            this.panelCabecera.Controls.Add(this.btnSalir);
            this.panelCabecera.Controls.Add(this.lblTitulo);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(870, 40);
            this.panelCabecera.TabIndex = 5;
            this.panelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCabecera_MouseDown);
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnAcerca.FlatAppearance.BorderSize = 0;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Image = ((System.Drawing.Image)(resources.GetObject("btnAcerca.Image")));
            this.btnAcerca.Location = new System.Drawing.Point(793, 3);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(30, 30);
            this.btnAcerca.TabIndex = 13;
            this.btnAcerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcerca.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(829, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(39, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 17);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "DTOGenerador";
            // 
            // panelBDs
            // 
            this.panelBDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBDs.Controls.Add(this.lstBDs);
            this.panelBDs.Controls.Add(this.lblBDs);
            this.panelBDs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBDs.Location = new System.Drawing.Point(12, 121);
            this.panelBDs.Name = "panelBDs";
            this.panelBDs.Size = new System.Drawing.Size(202, 415);
            this.panelBDs.TabIndex = 12;
            // 
            // lstBDs
            // 
            this.lstBDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lstBDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBDs.CheckOnClick = true;
            this.lstBDs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBDs.ForeColor = System.Drawing.Color.Silver;
            this.lstBDs.FormattingEnabled = true;
            this.lstBDs.Location = new System.Drawing.Point(0, 31);
            this.lstBDs.Name = "lstBDs";
            this.lstBDs.Size = new System.Drawing.Size(200, 382);
            this.lstBDs.TabIndex = 14;
            this.lstBDs.SelectedIndexChanged += new System.EventHandler(this.LstBDs_SelectedIndexChanged);
            // 
            // lblBDs
            // 
            this.lblBDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.lblBDs.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBDs.Location = new System.Drawing.Point(0, 0);
            this.lblBDs.Name = "lblBDs";
            this.lblBDs.Size = new System.Drawing.Size(200, 34);
            this.lblBDs.TabIndex = 13;
            this.lblBDs.Text = "Base de Datos";
            this.lblBDs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.ForeColor = System.Drawing.Color.Silver;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "MS SQL Server",
            "MySQL (Experimental)"});
            this.cboTipo.Location = new System.Drawing.Point(23, 74);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(167, 25);
            this.cboTipo.TabIndex = 30;
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConexion.Location = new System.Drawing.Point(20, 56);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(65, 17);
            this.lblConexion.TabIndex = 29;
            this.lblConexion.Text = "Conexión";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConectar.Location = new System.Drawing.Point(760, 57);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(91, 42);
            this.btnConectar.TabIndex = 28;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Silver;
            this.txtContrasena.Location = new System.Drawing.Point(568, 74);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(167, 25);
            this.txtContrasena.TabIndex = 24;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContrasena.Location = new System.Drawing.Point(565, 56);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(77, 17);
            this.lblContrasena.TabIndex = 27;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(388, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 25);
            this.txtUsuario.TabIndex = 23;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(385, 56);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtServidor
            // 
            this.txtServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServidor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.ForeColor = System.Drawing.Color.Silver;
            this.txtServidor.Location = new System.Drawing.Point(208, 74);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(167, 25);
            this.txtServidor.TabIndex = 22;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServidor.Location = new System.Drawing.Point(205, 56);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(59, 17);
            this.lblServidor.TabIndex = 25;
            this.lblServidor.Text = "Servidor";
            // 
            // panelTablas
            // 
            this.panelTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTablas.Controls.Add(this.lstTablas);
            this.panelTablas.Controls.Add(this.lblTablas);
            this.panelTablas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTablas.Location = new System.Drawing.Point(220, 121);
            this.panelTablas.Name = "panelTablas";
            this.panelTablas.Size = new System.Drawing.Size(202, 415);
            this.panelTablas.TabIndex = 31;
            // 
            // lstTablas
            // 
            this.lstTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lstTablas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTablas.CheckOnClick = true;
            this.lstTablas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTablas.ForeColor = System.Drawing.Color.Silver;
            this.lstTablas.FormattingEnabled = true;
            this.lstTablas.Location = new System.Drawing.Point(0, 31);
            this.lstTablas.Name = "lstTablas";
            this.lstTablas.Size = new System.Drawing.Size(200, 382);
            this.lstTablas.TabIndex = 12;
            this.lstTablas.SelectedIndexChanged += new System.EventHandler(this.LstTablas_SelectedIndexChanged);
            // 
            // lblTablas
            // 
            this.lblTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.lblTablas.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTablas.Location = new System.Drawing.Point(0, 0);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(200, 34);
            this.lblTablas.TabIndex = 13;
            this.lblTablas.Text = "Tablas";
            this.lblTablas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtResultado);
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Location = new System.Drawing.Point(428, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 415);
            this.panel3.TabIndex = 32;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(3, 34);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(426, 376);
            this.txtResultado.TabIndex = 7;
            this.txtResultado.Text = "";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.lblResultado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(0, -3);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(430, 34);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(870, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTablas);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.panelBDs);
            this.Controls.Add(this.panelCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTOGenerador";
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBDs.ResumeLayout(false);
            this.panelTablas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBDs;
        private System.Windows.Forms.Label lblBDs;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Panel panelTablas;
        private System.Windows.Forms.CheckedListBox lstTablas;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckedListBox lstBDs;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Button btnAcerca;
    }
}

