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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_olvid = new System.Windows.Forms.Label();
            this.recordar = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_user, "txt_user");
            this.txt_user.Name = "txt_user";
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // lbl_usuario
            // 
            resources.ApplyResources(this.lbl_usuario, "lbl_usuario");
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usuario.Name = "lbl_usuario";
            // 
            // lbl_contraseña
            // 
            resources.ApplyResources(this.lbl_contraseña, "lbl_contraseña");
            this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contraseña.Name = "lbl_contraseña";
            // 
            // txt_contra
            // 
            this.txt_contra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_contra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_contra, "txt_contra");
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.TextChanged += new System.EventHandler(this.txt_contra_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(116)))), ((int)(((byte)(30)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_olvid
            // 
            resources.ApplyResources(this.lbl_olvid, "lbl_olvid");
            this.lbl_olvid.BackColor = System.Drawing.Color.Transparent;
            this.lbl_olvid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_olvid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_olvid.Name = "lbl_olvid";
            // 
            // recordar
            // 
            resources.ApplyResources(this.recordar, "recordar");
            this.recordar.BackColor = System.Drawing.Color.Transparent;
            this.recordar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recordar.Name = "recordar";
            this.recordar.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Image = global::P_proyecto2.Properties.Resources.exit2;
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::P_proyecto2.Properties.Resources.c;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::P_proyecto2.Properties.Resources.l;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::P_proyecto2.Properties.Resources.lllllllllllllllll_remov;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::P_proyecto2.Properties.Resources.FONDO_LOGIMA;
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_exit);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // login_GUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.BackgroundImage = global::P_proyecto2.Properties.Resources.fondo_login;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.recordar);
            this.Controls.Add(this.lbl_olvid);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_user);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_GUI";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.login_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_olvid;
        private System.Windows.Forms.CheckBox recordar;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}