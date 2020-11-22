namespace Presentacion
{
    partial class Frm_Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Presentacion));
            this.Panel_titulo = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel_formularios = new System.Windows.Forms.Panel();
            this.Panel_menu = new System.Windows.Forms.Panel();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.btn_provedores = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.Btn_usuarios = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Panel_formularios.SuspendLayout();
            this.Panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_titulo
            // 
            this.Panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.Panel_titulo.Controls.Add(this.Label1);
            this.Panel_titulo.Controls.Add(this.btn_minimizar);
            this.Panel_titulo.Controls.Add(this.btn_cerrar);
            this.Panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.Panel_titulo.Name = "Panel_titulo";
            this.Panel_titulo.Size = new System.Drawing.Size(1366, 40);
            this.Panel_titulo.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(669, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(182, 29);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Venta Car";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1280, 1);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.btn_minimizar.TabIndex = 10;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1326, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(40, 40);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(253, 211);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Panel_formularios
            // 
            this.Panel_formularios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_formularios.Controls.Add(this.Panel_menu);
            this.Panel_formularios.Controls.Add(this.Panel_titulo);
            this.Panel_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_formularios.Location = new System.Drawing.Point(0, 0);
            this.Panel_formularios.Name = "Panel_formularios";
            this.Panel_formularios.Size = new System.Drawing.Size(1366, 768);
            this.Panel_formularios.TabIndex = 5;
            // 
            // Panel_menu
            // 
            this.Panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Panel_menu.Controls.Add(this.button1);
            this.Panel_menu.Controls.Add(this.btn_Empleado);
            this.Panel_menu.Controls.Add(this.btn_provedores);
            this.Panel_menu.Controls.Add(this.pictureBox3);
            this.Panel_menu.Controls.Add(this.Btn_salir);
            this.Panel_menu.Controls.Add(this.btn_Clientes);
            this.Panel_menu.Controls.Add(this.Btn_usuarios);
            this.Panel_menu.Controls.Add(this.btn_ventas);
            this.Panel_menu.Controls.Add(this.btn_compra);
            this.Panel_menu.Controls.Add(this.btn_Inventario);
            this.Panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_menu.Location = new System.Drawing.Point(0, 40);
            this.Panel_menu.Name = "Panel_menu";
            this.Panel_menu.Size = new System.Drawing.Size(250, 728);
            this.Panel_menu.TabIndex = 5;
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.FlatAppearance.BorderSize = 0;
            this.btn_Empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_Empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleado.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Empleado.Location = new System.Drawing.Point(3, 518);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(250, 40);
            this.btn_Empleado.TabIndex = 11;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.UseVisualStyleBackColor = true;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // btn_provedores
            // 
            this.btn_provedores.FlatAppearance.BorderSize = 0;
            this.btn_provedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_provedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_provedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_provedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_provedores.ForeColor = System.Drawing.Color.LightGray;
            this.btn_provedores.Location = new System.Drawing.Point(0, 276);
            this.btn_provedores.Name = "btn_provedores";
            this.btn_provedores.Size = new System.Drawing.Size(250, 40);
            this.btn_provedores.TabIndex = 9;
            this.btn_provedores.Text = "Proveedores";
            this.btn_provedores.UseVisualStyleBackColor = true;
            this.btn_provedores.Click += new System.EventHandler(this.btn_provedores_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_salir.Location = new System.Drawing.Point(0, 665);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(247, 40);
            this.Btn_salir.TabIndex = 4;
            this.Btn_salir.Text = "Cambiar Usuario";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.FlatAppearance.BorderSize = 0;
            this.btn_Clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Clientes.Location = new System.Drawing.Point(3, 459);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(250, 40);
            this.btn_Clientes.TabIndex = 10;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // Btn_usuarios
            // 
            this.Btn_usuarios.FlatAppearance.BorderSize = 0;
            this.Btn_usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Btn_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_usuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_usuarios.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_usuarios.Location = new System.Drawing.Point(3, 564);
            this.Btn_usuarios.Name = "Btn_usuarios";
            this.Btn_usuarios.Size = new System.Drawing.Size(250, 40);
            this.Btn_usuarios.TabIndex = 6;
            this.Btn_usuarios.Text = "Usuarios";
            this.Btn_usuarios.UseVisualStyleBackColor = true;
            this.Btn_usuarios.Click += new System.EventHandler(this.Btn_usuarios_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ventas.Location = new System.Drawing.Point(0, 340);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(250, 40);
            this.btn_ventas.TabIndex = 1;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.FlatAppearance.BorderSize = 0;
            this.btn_compra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compra.ForeColor = System.Drawing.Color.LightGray;
            this.btn_compra.Location = new System.Drawing.Point(0, 217);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(250, 40);
            this.btn_compra.TabIndex = 1;
            this.btn_compra.Text = "Compras";
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click_1);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.FlatAppearance.BorderSize = 0;
            this.btn_Inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_Inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Inventario.Location = new System.Drawing.Point(3, 399);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(250, 40);
            this.btn_Inventario.TabIndex = 8;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = true;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(3, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Empresa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Panel_formularios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Presentacion";
            this.Panel_titulo.ResumeLayout(false);
            this.Panel_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Panel_formularios.ResumeLayout(false);
            this.Panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel_titulo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btn_minimizar;
        internal System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.Panel Panel_formularios;
        internal System.Windows.Forms.Button Btn_salir;
        public System.Windows.Forms.Button btn_provedores;
        public System.Windows.Forms.Button btn_Clientes;
        public System.Windows.Forms.Button Btn_usuarios;
        public System.Windows.Forms.Button btn_ventas;
        public System.Windows.Forms.Button btn_compra;
        public System.Windows.Forms.Button btn_Inventario;
        public System.Windows.Forms.Panel Panel_menu;
        public System.Windows.Forms.Button btn_Empleado;
        public System.Windows.Forms.Button button1;
    }
}