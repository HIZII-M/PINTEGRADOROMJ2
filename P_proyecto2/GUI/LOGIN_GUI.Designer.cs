namespace P_proyecto2.GUI
{
    partial class login_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_GUI));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_olvid = new System.Windows.Forms.Label();
            this.recordar = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_p1 = new System.Windows.Forms.Button();
            this.btn_p2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usuario.Location = new System.Drawing.Point(166, 314);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(64, 20);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contraseña.Location = new System.Drawing.Point(155, 445);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(92, 20);
            this.lbl_contraseña.TabIndex = 4;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 26);
            this.textBox2.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(116)))), ((int)(((byte)(30)))));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(133, 551);
            this.btn_login.Margin = new System.Windows.Forms.Padding(1);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(141, 52);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_olvid
            // 
            this.lbl_olvid.AutoSize = true;
            this.lbl_olvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_olvid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(166)))), ((int)(((byte)(246)))));
            this.lbl_olvid.Location = new System.Drawing.Point(115, 680);
            this.lbl_olvid.Name = "lbl_olvid";
            this.lbl_olvid.Size = new System.Drawing.Size(159, 20);
            this.lbl_olvid.TabIndex = 9;
            this.lbl_olvid.Text = "Olvide mi Contraseña";
            // 
            // recordar
            // 
            this.recordar.AutoSize = true;
            this.recordar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recordar.Location = new System.Drawing.Point(133, 637);
            this.recordar.Name = "recordar";
            this.recordar.Size = new System.Drawing.Size(123, 24);
            this.recordar.TabIndex = 10;
            this.recordar.Text = "Recordarme";
            this.recordar.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::P_proyecto2.Properties.Resources.c;
            this.pictureBox4.Location = new System.Drawing.Point(67, 475);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::P_proyecto2.Properties.Resources.l;
            this.pictureBox3.Location = new System.Drawing.Point(76, 331);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(390, 680);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_p1
            // 
            this.btn_p1.Location = new System.Drawing.Point(372, 294);
            this.btn_p1.Name = "btn_p1";
            this.btn_p1.Size = new System.Drawing.Size(75, 61);
            this.btn_p1.TabIndex = 11;
            this.btn_p1.Text = "prueba";
            this.btn_p1.UseVisualStyleBackColor = true;
            this.btn_p1.Click += new System.EventHandler(this.btn_p1_Click);
            // 
            // btn_p2
            // 
            this.btn_p2.Location = new System.Drawing.Point(372, 404);
            this.btn_p2.Name = "btn_p2";
            this.btn_p2.Size = new System.Drawing.Size(75, 61);
            this.btn_p2.TabIndex = 12;
            this.btn_p2.Text = "prueba2";
            this.btn_p2.UseVisualStyleBackColor = true;
            this.btn_p2.Click += new System.EventHandler(this.btn_p2_Click);
            // 
            // login_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(458, 724);
            this.Controls.Add(this.btn_p2);
            this.Controls.Add(this.btn_p1);
            this.Controls.Add(this.recordar);
            this.Controls.Add(this.lbl_olvid);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_GUI";
            this.Opacity = 0.9D;
            this.Text = "login_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_olvid;
        private System.Windows.Forms.CheckBox recordar;
        private System.Windows.Forms.Button btn_p1;
        private System.Windows.Forms.Button btn_p2;
    }
}