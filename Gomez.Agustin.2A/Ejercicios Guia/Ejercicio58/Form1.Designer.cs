namespace Ejercicio58
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.abrirArchivostxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivosdatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosDeTextotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosDeDatosdatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.guardarToolStripMenuItem1,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivostxtToolStripMenuItem,
            this.abrirArchivosdatToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Enabled = false;
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosDeTextotxtToolStripMenuItem,
            this.archivosDeDatosdatToolStripMenuItem});
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "0 caracteres";
            // 
            // abrirArchivostxtToolStripMenuItem
            // 
            this.abrirArchivostxtToolStripMenuItem.Name = "abrirArchivostxtToolStripMenuItem";
            this.abrirArchivostxtToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.abrirArchivostxtToolStripMenuItem.Text = "Archivos de texto (.txt)";
            this.abrirArchivostxtToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivostxtToolStripMenuItem_Click);
            // 
            // abrirArchivosdatToolStripMenuItem
            // 
            this.abrirArchivosdatToolStripMenuItem.Name = "abrirArchivosdatToolStripMenuItem";
            this.abrirArchivosdatToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.abrirArchivosdatToolStripMenuItem.Text = "Archivos de datos (.dat)";
            this.abrirArchivosdatToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivosdatToolStripMenuItem_Click);
            // 
            // archivosDeTextotxtToolStripMenuItem
            // 
            this.archivosDeTextotxtToolStripMenuItem.Name = "archivosDeTextotxtToolStripMenuItem";
            this.archivosDeTextotxtToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.archivosDeTextotxtToolStripMenuItem.Text = "Archivos de texto (.txt)";
            this.archivosDeTextotxtToolStripMenuItem.Click += new System.EventHandler(this.archivosDeTextotxtToolStripMenuItem_Click);
            // 
            // archivosDeDatosdatToolStripMenuItem
            // 
            this.archivosDeDatosdatToolStripMenuItem.Name = "archivosDeDatosdatToolStripMenuItem";
            this.archivosDeDatosdatToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.archivosDeDatosdatToolStripMenuItem.Text = "Archivos de datos (.dat)";
            this.archivosDeDatosdatToolStripMenuItem.Click += new System.EventHandler(this.archivosDeDatosdatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivostxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivosdatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosDeTextotxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosDeDatosdatToolStripMenuItem;
    }
}

