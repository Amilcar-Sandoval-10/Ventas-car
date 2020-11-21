namespace Presentacion
{
    partial class Frm_Login
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
            this.components = new System.ComponentModel.Container();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lberror = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lbIntentos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAcceso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbcontraseña = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Vendedor",
            "Bodega",
            "Comprador"});
            this.cmbTipo.Location = new System.Drawing.Point(242, 59);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(145, 23);
            this.cmbTipo.TabIndex = 28;
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.BackColor = System.Drawing.Color.Transparent;
            this.lberror.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lberror.ForeColor = System.Drawing.Color.White;
            this.lberror.Location = new System.Drawing.Point(393, 127);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(278, 18);
            this.lberror.TabIndex = 27;
            this.lberror.Text = "Usuario ó Contraseña incorrecta";
            this.lberror.Visible = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(241, 93);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(146, 21);
            this.txtusuario.TabIndex = 24;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(241, 127);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(146, 21);
            this.txtcontraseña.TabIndex = 25;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // lbIntentos
            // 
            this.lbIntentos.AutoSize = true;
            this.lbIntentos.BackColor = System.Drawing.Color.Transparent;
            this.lbIntentos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lbIntentos.ForeColor = System.Drawing.Color.White;
            this.lbIntentos.Location = new System.Drawing.Point(447, 93);
            this.lbIntentos.Name = "lbIntentos";
            this.lbIntentos.Size = new System.Drawing.Size(79, 18);
            this.lbIntentos.TabIndex = 32;
            this.lbIntentos.Text = "Intentos";
            this.lbIntentos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "(ninguno)";
            this.label2.Location = new System.Drawing.Point(92, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "CONTRASEÑA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "TIPO DE USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "USUARIO:";
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.Location = new System.Drawing.Point(319, 209);
            this.BtnAcceso.Name = "BtnAcceso";
            this.BtnAcceso.Size = new System.Drawing.Size(82, 23);
            this.BtnAcceso.TabIndex = 33;
            this.BtnAcceso.Text = "Ingresar";
            this.BtnAcceso.UseVisualStyleBackColor = true;
            this.BtnAcceso.Click += new System.EventHandler(this.BtnAcceso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 209);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 23);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            // 
            // errorUsuario
            // 
            this.errorUsuario.ContainerControl = this;
            // 
            // cbcontraseña
            // 
            this.cbcontraseña.AutoSize = true;
            this.cbcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.cbcontraseña.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cbcontraseña.ForeColor = System.Drawing.Color.White;
            this.cbcontraseña.Location = new System.Drawing.Point(221, 168);
            this.cbcontraseña.Name = "cbcontraseña";
            this.cbcontraseña.Size = new System.Drawing.Size(192, 22);
            this.cbcontraseña.TabIndex = 26;
            this.cbcontraseña.Text = "Mostrar Contraseña";
            this.cbcontraseña.UseVisualStyleBackColor = false;
            this.cbcontraseña.CheckedChanged += new System.EventHandler(this.cbcontraseña_CheckedChanged);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(695, 294);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnAcceso);
            this.Controls.Add(this.lbIntentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.cbcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtcontraseña);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lberror;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lbIntentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAcceso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.ErrorProvider errorUsuario;
        private System.Windows.Forms.CheckBox cbcontraseña;
    }
}