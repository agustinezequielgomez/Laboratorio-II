namespace WindowsFormCosa
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(43, 90);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(188, 20);
            this.txtCadena.TabIndex = 1;
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(43, 51);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(188, 20);
            this.txtEntero.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(156, 185);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(43, 125);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(188, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Mis Cosas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtFecha;
    }
}

