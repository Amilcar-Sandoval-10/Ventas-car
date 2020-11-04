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
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_compra
            // 
            this.btn_compra.Enabled = false;
            this.btn_compra.Location = new System.Drawing.Point(51, 96);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(75, 23);
            this.btn_compra.TabIndex = 0;
            this.btn_compra.Text = "Compra";
            this.btn_compra.UseVisualStyleBackColor = true;
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.Enabled = false;
            this.btn_Proveedores.Location = new System.Drawing.Point(51, 152);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btn_Proveedores.TabIndex = 1;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // Frm_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.btn_compra);
            this.Name = "Frm_Presentacion";
            this.Text = "Frm_Presentacion";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn_compra;
        public System.Windows.Forms.Button btn_Proveedores;
    }
}