using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using P_proyecto2.BO;
using P_proyecto2.DAO;

namespace P_proyecto2.GUI
{
    public partial class faltaemp_GUI : Form
    {

        empleados_BO objDatos = new empleados_BO();
        empleados_DAO objSQL = new empleados_DAO();



        public faltaemp_GUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void faltaemp_GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1enviar los datos a la capa de negocio
            objDatos.Matricula = int.Parse(txtmatricula.Text);
            objDatos.Passwords = txtpassword.Text; 
            objDatos.Nombre = txtname.Text;
            objDatos.Apellido = txtapellid.Text;
            objDatos.Email = txtemail.Text;
            objDatos.Celular = txttel.Text;

            //2ejecutamos el metodo guardar de DAO
            if (objSQL.GuardarEMP(objDatos) == true)
            {
                MessageBox.Show("Datos Guardados :) ");
                
            }
            else
            {
                MessageBox.Show("Error al guardar :( ");
            }

        }

        private void btn_regemp_Click(object sender, EventArgs e)
        {
            Usuario B1 = new Usuario();
            B1.MostrarTablaEMP();

        }
    }
}
