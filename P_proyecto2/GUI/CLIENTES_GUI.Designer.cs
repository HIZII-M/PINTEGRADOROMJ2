namespace P_proyecto2.GUI
{
    partial class CLIENTES_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelclie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapeclie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnameclie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidclie = new System.Windows.Forms.TextBox();
            this.dgv_clie = new System.Windows.Forms.DataGridView();
            this.btn_addclie = new System.Windows.Forms.Button();
            this.btn_updateclie = new System.Windows.Forms.Button();
            this.btn_deletclie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txttelclie);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtapeclie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnameclie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtidclie);
            this.panel1.Location = new System.Drawing.Point(33, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 239);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Telefono";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txttelclie
            // 
            this.txttelclie.Location = new System.Drawing.Point(128, 181);
            this.txttelclie.Name = "txttelclie";
            this.txttelclie.Size = new System.Drawing.Size(194, 26);
            this.txttelclie.TabIndex = 21;
            this.txttelclie.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellidos";
            // 
            // txtapeclie
            // 
            this.txtapeclie.Location = new System.Drawing.Point(128, 133);
            this.txtapeclie.Name = "txtapeclie";
            this.txtapeclie.Size = new System.Drawing.Size(257, 26);
            this.txtapeclie.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombres";
            // 
            // txtnameclie
            // 
            this.txtnameclie.Location = new System.Drawing.Point(128, 88);
            this.txtnameclie.Name = "txtnameclie";
            this.txtnameclie.Size = new System.Drawing.Size(257, 26);
            this.txtnameclie.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID";
            // 
            // txtidclie
            // 
            this.txtidclie.Location = new System.Drawing.Point(70, 19);
            this.txtidclie.Name = "txtidclie";
            this.txtidclie.ReadOnly = true;
            this.txtidclie.Size = new System.Drawing.Size(107, 26);
            this.txtidclie.TabIndex = 13;
            // 
            // dgv_clie
            // 
            this.dgv_clie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clie.Location = new System.Drawing.Point(33, 302);
            this.dgv_clie.Name = "dgv_clie";
            this.dgv_clie.RowHeadersWidth = 62;
            this.dgv_clie.RowTemplate.Height = 28;
            this.dgv_clie.Size = new System.Drawing.Size(877, 242);
            this.dgv_clie.TabIndex = 8;
            this.dgv_clie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emple_CellContentClick);
            this.dgv_clie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_clie_CellMouseClick);
            // 
            // btn_addclie
            // 
            this.btn_addclie.Location = new System.Drawing.Point(1044, 423);
            this.btn_addclie.Name = "btn_addclie";
            this.btn_addclie.Size = new System.Drawing.Size(174, 35);
            this.btn_addclie.TabIndex = 9;
            this.btn_addclie.Text = "Agregar cliente";
            this.btn_addclie.UseVisualStyleBackColor = true;
            this.btn_addclie.Click += new System.EventHandler(this.btn_addclie_Click);
            // 
            // btn_updateclie
            // 
            this.btn_updateclie.Location = new System.Drawing.Point(1044, 476);
            this.btn_updateclie.Name = "btn_updateclie";
            this.btn_updateclie.Size = new System.Drawing.Size(174, 35);
            this.btn_updateclie.TabIndex = 10;
            this.btn_updateclie.Text = "Actualizar cliente";
            this.btn_updateclie.UseVisualStyleBackColor = true;
            this.btn_updateclie.Click += new System.EventHandler(this.btn_updateclie_Click);
            // 
            // btn_deletclie
            // 
            this.btn_deletclie.Location = new System.Drawing.Point(1044, 526);
            this.btn_deletclie.Name = "btn_deletclie";
            this.btn_deletclie.Size = new System.Drawing.Size(174, 35);
            this.btn_deletclie.TabIndex = 11;
            this.btn_deletclie.Text = "Eliminar Cliente";
            this.btn_deletclie.UseVisualStyleBackColor = true;
            this.btn_deletclie.Click += new System.EventHandler(this.btn_deletclie_Click);
            // 
            // CLIENTES_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 1017);
            this.Controls.Add(this.btn_deletclie);
            this.Controls.Add(this.btn_updateclie);
            this.Controls.Add(this.btn_addclie);
            this.Controls.Add(this.dgv_clie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CLIENTES_GUI";
            this.Text = "CLIENTES_GUI";
            this.Load += new System.EventHandler(this.CLIENTES_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttelclie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapeclie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnameclie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidclie;
        private System.Windows.Forms.DataGridView dgv_clie;
        private System.Windows.Forms.Button btn_addclie;
        private System.Windows.Forms.Button btn_updateclie;
        private System.Windows.Forms.Button btn_deletclie;
    }
}