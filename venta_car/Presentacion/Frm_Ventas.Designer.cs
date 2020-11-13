namespace Presentacion
{
    partial class Frm_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas));
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.paneldetalle = new System.Windows.Forms.Panel();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_Factura = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.panelcompra = new System.Windows.Forms.Panel();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.MaskedTextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txttotal2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.paneldetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panelcompra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(12, 12);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(833, 178);
            this.dgvVenta.TabIndex = 0;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // paneldetalle
            // 
            this.paneldetalle.Controls.Add(this.nudCantidad);
            this.paneldetalle.Controls.Add(this.btn_Factura);
            this.paneldetalle.Controls.Add(this.txtPrecio);
            this.paneldetalle.Controls.Add(this.label7);
            this.paneldetalle.Controls.Add(this.label6);
            this.paneldetalle.Controls.Add(this.label15);
            this.paneldetalle.Controls.Add(this.Btn_quitar);
            this.paneldetalle.Controls.Add(this.label12);
            this.paneldetalle.Controls.Add(this.btn_añadir);
            this.paneldetalle.Controls.Add(this.txtModelo);
            this.paneldetalle.Controls.Add(this.label4);
            this.paneldetalle.Controls.Add(this.txtMarca);
            this.paneldetalle.Controls.Add(this.btnBuscarProd);
            this.paneldetalle.Location = new System.Drawing.Point(445, 213);
            this.paneldetalle.Name = "paneldetalle";
            this.paneldetalle.Size = new System.Drawing.Size(373, 190);
            this.paneldetalle.TabIndex = 4;
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(287, 153);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(38, 22);
            this.nudCantidad.TabIndex = 67;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // btn_Factura
            // 
            this.btn_Factura.Enabled = false;
            this.btn_Factura.Location = new System.Drawing.Point(250, 108);
            this.btn_Factura.Name = "btn_Factura";
            this.btn_Factura.Size = new System.Drawing.Size(75, 23);
            this.btn_Factura.TabIndex = 43;
            this.btn_Factura.Text = "Factura";
            this.btn_Factura.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPrecio.Location = new System.Drawing.Point(82, 136);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(90, 25);
            this.txtPrecio.TabIndex = 66;
            this.txtPrecio.Text = "0.00";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(225, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(20, 143);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Precio:";
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.Location = new System.Drawing.Point(250, 65);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.Btn_quitar.TabIndex = 44;
            this.Btn_quitar.Text = "Quitar";
            this.Btn_quitar.UseVisualStyleBackColor = true;
            this.Btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Marca";
            // 
            // btn_añadir
            // 
            this.btn_añadir.Enabled = false;
            this.btn_añadir.Location = new System.Drawing.Point(250, 21);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(75, 23);
            this.btn_añadir.TabIndex = 42;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtModelo.Location = new System.Drawing.Point(82, 101);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 50;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Producto:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMarca.Location = new System.Drawing.Point(82, 62);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 51;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProd.Enabled = false;
            this.btnBuscarProd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProd.Image")));
            this.btnBuscarProd.Location = new System.Drawing.Point(97, 13);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(35, 31);
            this.btnBuscarProd.TabIndex = 18;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // panelcompra
            // 
            this.panelcompra.Controls.Add(this.txttelefono);
            this.panelcompra.Controls.Add(this.label9);
            this.panelcompra.Controls.Add(this.txtcedula);
            this.panelcompra.Controls.Add(this.btn_Limpiar);
            this.panelcompra.Controls.Add(this.txtEmail);
            this.panelcompra.Controls.Add(this.btn_Cancelar);
            this.panelcompra.Controls.Add(this.btnBuscarCliente);
            this.panelcompra.Controls.Add(this.label1);
            this.panelcompra.Controls.Add(this.btn_Nuevo);
            this.panelcompra.Controls.Add(this.label3);
            this.panelcompra.Controls.Add(this.label2);
            this.panelcompra.Controls.Add(this.label8);
            this.panelcompra.Controls.Add(this.txtnombre);
            this.panelcompra.Location = new System.Drawing.Point(12, 213);
            this.panelcompra.Name = "panelcompra";
            this.panelcompra.Size = new System.Drawing.Size(373, 242);
            this.panelcompra.TabIndex = 3;
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttelefono.Location = new System.Drawing.Point(85, 110);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.Mask = ">####-####";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "No Cedula:";
            // 
            // txtcedula
            // 
            this.txtcedula.Enabled = false;
            this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtcedula.Location = new System.Drawing.Point(85, 143);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtcedula.Mask = ">###-######-####L";
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 45;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Enabled = false;
            this.btn_Limpiar.Location = new System.Drawing.Point(226, 148);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 24;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(85, 190);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 44;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(226, 105);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 25;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.Enabled = false;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(85, 10);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(35, 31);
            this.btnBuscarCliente.TabIndex = 37;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cliente:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(226, 70);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Telefono:";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnombre.Location = new System.Drawing.Point(85, 78);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Txttotal2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtIVA);
            this.panel1.Controls.Add(this.txtSubtotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(181, 62);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(204, 26);
            this.txtDescuento.TabIndex = 62;
            this.txtDescuento.Text = "0.00";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(73, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "Descuento:";
            // 
            // Txttotal2
            // 
            this.Txttotal2.Enabled = false;
            this.Txttotal2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttotal2.Location = new System.Drawing.Point(493, 59);
            this.Txttotal2.Margin = new System.Windows.Forms.Padding(2);
            this.Txttotal2.Name = "Txttotal2";
            this.Txttotal2.Size = new System.Drawing.Size(204, 26);
            this.Txttotal2.TabIndex = 60;
            this.Txttotal2.Text = "0.00";
            this.Txttotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(422, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 59;
            this.label13.Text = "Total:";
            // 
            // TxtIVA
            // 
            this.TxtIVA.Enabled = false;
            this.TxtIVA.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIVA.Location = new System.Drawing.Point(488, 13);
            this.TxtIVA.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.Size = new System.Drawing.Size(204, 26);
            this.TxtIVA.TabIndex = 58;
            this.TxtIVA.Text = "0.00";
            this.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(219, 16);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(165, 26);
            this.txtSubtotal.TabIndex = 57;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(433, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "IVA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(87, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 18);
            this.label14.TabIndex = 55;
            this.label14.Text = "SubTotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(465, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Fecha:";
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtfecha.Location = new System.Drawing.Point(527, 418);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 64;
            this.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneldetalle);
            this.Controls.Add(this.panelcompra);
            this.Controls.Add(this.dgvVenta);
            this.Name = "Frm_Ventas";
            this.Text = "Frm_Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.paneldetalle.ResumeLayout(false);
            this.paneldetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panelcompra.ResumeLayout(false);
            this.panelcompra.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Panel paneldetalle;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btn_Factura;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_añadir;
        public System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Panel panelcompra;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox txtcedula;
        private System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txttotal2;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtfecha;
    }
}