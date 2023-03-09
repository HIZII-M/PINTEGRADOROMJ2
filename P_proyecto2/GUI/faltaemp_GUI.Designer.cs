namespace P_proyecto2.GUI
{
    partial class faltaemp_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btn_guardemp = new System.Windows.Forms.Button();
            this.btn_regemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta a un nuevo usuario ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(129, 87);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(107, 26);
            this.txtmatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(123, 156);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(232, 26);
            this.txtname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos";
            // 
            // txtapellid
            // 
            this.txtapellid.Location = new System.Drawing.Point(470, 156);
            this.txtapellid.Name = "txtapellid";
            this.txtapellid.Size = new System.Drawing.Size(257, 26);
            this.txtapellid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "EMAIL";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(123, 214);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(306, 26);
            this.txtemail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(123, 269);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(194, 26);
            this.txttel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contraseña";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(148, 323);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(194, 26);
            this.txtpassword.TabIndex = 11;
            // 
            // btn_guardemp
            // 
            this.btn_guardemp.Location = new System.Drawing.Point(225, 380);
            this.btn_guardemp.Name = "btn_guardemp";
            this.btn_guardemp.Size = new System.Drawing.Size(107, 41);
            this.btn_guardemp.TabIndex = 15;
            this.btn_guardemp.Text = "Agregar";
            this.btn_guardemp.UseVisualStyleBackColor = true;
            this.btn_guardemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_regemp
            // 
            this.btn_regemp.Location = new System.Drawing.Point(362, 380);
            this.btn_regemp.Name = "btn_regemp";
            this.btn_regemp.Size = new System.Drawing.Size(107, 41);
            this.btn_regemp.TabIndex = 16;
            this.btn_regemp.Text = "Regresar";
            this.btn_regemp.UseVisualStyleBackColor = true;
            this.btn_regemp.Click += new System.EventHandler(this.btn_regemp_Click);
            // 
            // faltaemp_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 432);
            this.Controls.Add(this.btn_regemp);
            this.Controls.Add(this.btn_guardemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtapellid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label1);
            this.Name = "faltaemp_GUI";
            this.Text = "faltaemp_GUI";
            this.Load += new System.EventHandler(this.faltaemp_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btn_guardemp;
        private System.Windows.Forms.Button btn_regemp;
    }
}