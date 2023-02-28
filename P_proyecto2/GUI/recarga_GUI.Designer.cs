namespace P_proyecto2.GUI
{
    partial class recarga_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recarga_GUI));
            this.salir = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BackgroundImage = global::P_proyecto2.Properties.Resources.salirboton;
            this.salir.Location = new System.Drawing.Point(596, 463);
            this.salir.Margin = new System.Windows.Forms.Padding(0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(139, 41);
            this.salir.TabIndex = 1;
            this.salir.UseVisualStyleBackColor = false;
            // 
            // fondo
            // 
            this.fondo.Dock = System.Windows.Forms.DockStyle.Top;
            this.fondo.Image = ((System.Drawing.Image)(resources.GetObject("fondo.Image")));
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(852, 595);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            this.fondo.Click += new System.EventHandler(this.fondo_Click);
            // 
            // recarga_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recarga_GUI";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.recarga_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Button salir;
    }
}