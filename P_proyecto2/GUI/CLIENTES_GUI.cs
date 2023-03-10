using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using P_proyecto2.DAO;
using P_proyecto2.BO;
using System.Xml.Linq;

namespace P_proyecto2.GUI
{
    public partial class CLIENTES_GUI : Form
    {


        clientes_BO objDatos2 = new clientes_BO();
        clientes_DAO objSQL2 = new clientes_DAO();

        public void MostrarTablaCLI()
        {
            dgv_clie.DataSource = objSQL2.Tablaclientes();

        }

        public CLIENTES_GUI()
        {
            InitializeComponent();
        }

        private void dgv_emple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CLIENTES_GUI_Load(object sender, EventArgs e)
        {
            dgv_clie.DataSource = objSQL2.Tablaclientes();
        }

        private void btn_addclie_Click(object sender, EventArgs e)
        {
            //1enviar los datos a la capa de negocio
            objDatos2.Nombre_c = txtnameclie.Text;
            objDatos2.Apellido_c = txtapeclie.Text;
            objDatos2.Celular_c = int.Parse(txttelclie.Text);

            //2ejecutamos el metodo guardar de DAO
            if (objSQL2.GuardarCLI(objDatos2) == true)
            {
                MessageBox.Show("Datos Guardados :) ");

            }
            else
            {
                MessageBox.Show("Error al guardar :( ");
            }
            MostrarTablaCLI();
        }

        private void btn_updateclie_Click(object sender, EventArgs e)
        {
            objDatos2.Id_clie = int.Parse(txtidclie.Text);
            objDatos2.Nombre_c = txtnameclie.Text;
            objDatos2.Apellido_c = txtapeclie.Text;
            objDatos2.Celular_c = int.Parse(txttelclie.Text);

            if (objSQL2.ActualizarCLI(objDatos2) == true)
            {
                MostrarTablaCLI();
                MessageBox.Show("Datos Actualizados");
            }


            else
            {
                MessageBox.Show("Error al Actualizar");
            }

        }

        private void btn_deletclie_Click(object sender, EventArgs e)
        {
            objDatos2.Id_clie = int.Parse(txtidclie.Text);
            if (objSQL2.EliminarCLI(objDatos2) == true)
            {
                MostrarTablaCLI();
                MessageBox.Show("Datos Eliminados");
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
        }

        private void dgv_clie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int FilaSeleccionada = e.RowIndex;
            txtidclie.Text = dgv_clie.Rows[FilaSeleccionada].Cells[0].Value.ToString();        
            txtnameclie.Text = dgv_clie.Rows[FilaSeleccionada].Cells[1].Value.ToString();
            txtapeclie.Text = dgv_clie.Rows[FilaSeleccionada].Cells[2].Value.ToString();
            txttelclie.Text = dgv_clie.Rows[FilaSeleccionada].Cells[3].Value.ToString();
        }
    }
}
