using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using P_proyecto2.DAO;
using P_proyecto2.BO;
using System.Data.SqlClient;
using System.Xml;

namespace P_proyecto2.GUI
{
    public partial class Usuario : Form
    {

        empleados_BO objDatos = new empleados_BO();
        empleados_DAO objSQL = new empleados_DAO();


        public void MostrarTablaEMP()
        {
            dgv_emple.DataSource = objSQL.Tablaempleados();

        }
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            dgv_emple.DataSource = objSQL.Tablaempleados();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_emple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
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
            MostrarTablaEMP();
        }

        private void dgv_emple_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaSeleccionada = e.RowIndex;
            txtmatricula.Text = dgv_emple.Rows[FilaSeleccionada].Cells[0].Value.ToString();
            txtpassword.Text = dgv_emple.Rows[FilaSeleccionada].Cells[1].Value.ToString();
            txtname.Text = dgv_emple.Rows[FilaSeleccionada].Cells[2].Value.ToString();
            txtapellid.Text = dgv_emple.Rows[FilaSeleccionada].Cells[2].Value.ToString();
            txttel.Text = dgv_emple.Rows[FilaSeleccionada].Cells[3].Value.ToString();
            txtemail.Text = dgv_emple.Rows[FilaSeleccionada].Cells[4].Value.ToString();



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            objDatos.Matricula = int.Parse(txtmatricula.Text);
            objDatos.Passwords = txtpassword.Text;
            objDatos.Nombre = txtname.Text;
            objDatos.Apellido = txtapellid.Text;
            objDatos.Email = txtemail.Text;
            objDatos.Celular = txttel.Text;

            if (objSQL.ActualizarEMP(objDatos) == true)
            {
                MostrarTablaEMP();
                MessageBox.Show("Datos Actualizados");
            }


            else
            {
                MessageBox.Show("Error al Actualizar");
            }



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            objDatos.Matricula = int.Parse(txtmatricula.Text);
            if (objSQL.EliminarEMP(objDatos) == true)
            {
                MostrarTablaEMP();
                MessageBox.Show("Datos Eliminado");
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
        }
    }
}
