using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_proyecto2.DAO;
using P_proyecto2.GUI;
using System.Data.SqlClient;

namespace P_proyecto2.GUI
{
    public partial class login_GUI : Form
    {
        public login_GUI()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            conexion_DAO.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT (*) FROM EMPLEADOS WHERE MATRICULA='" + txt_user.Text + "'AND PASSWORDS='" + txt_contra.Text + "' ", conexion_DAO.Conectar());
            
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows [0] [0].ToString()=="1")
            {
                this.Hide();
                new menu_GUI().Show();
            }
            else 
            {
                MessageBox.Show("who are you?");
            }
        }

        private void btn_p1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_p2_Click(object sender, EventArgs e)
        {
            //comentario para ver si surgen cambios
        }

        private void login_GUI_Load(object sender, EventArgs e)
        {
            conexion_DAO.Conectar();
            MessageBox.Show("La conexion fue un exito");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
