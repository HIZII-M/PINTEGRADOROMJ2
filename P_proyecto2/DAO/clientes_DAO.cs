using P_proyecto2.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_proyecto2.DAO
{
    internal class clientes_DAO
    {

        conexion_DAO objBD = new conexion_DAO();       //creamos una variable que ejecute el comando sqlserver
        SqlCommand cmd = new SqlCommand();
        string ABC;




        public bool GuardarCLI(clientes_BO objDiv)        //CReamos un metodo de tipo bool para guardar
        {
            clientes_BO datos = (clientes_BO)objDiv;
            cmd.Connection = objBD.Conectar();
            objBD.abrirBD();
            ABC = "Insert into CLIENTES ( NOMBRE_C, APELLIDO_C, CELULAR_C) values('" + datos.Nombre_c + "' , '" + datos.Apellido_c + "' , '" + datos.Celular_c + "') ";
            cmd.CommandText = ABC;
            int Acuse = cmd.ExecuteNonQuery();
            objBD.cerrarBD();
            if (Acuse <= 0)
            {
                return false;
            }
            return true;


        }

        public DataTable Tablaclientes()         //metodo para mostrar la tabla al datagridview
        {
            string ConSQL = "select * from CLIENTES";
            SqlDataAdapter adp = new SqlDataAdapter(ConSQL, objBD.Conectar());
            DataTable TablaVirtual = new DataTable();
            adp.Fill(TablaVirtual);
            return TablaVirtual;
        }

        public bool ActualizarCLI(clientes_BO objDiv)         //CReamos un metodo de tipo bool para actualizar
        {
            clientes_BO datos = (clientes_BO)objDiv;
            cmd.Connection = objBD.Conectar();
            objBD.abrirBD();
            ABC = "update CLIENTES set NOMBRE_C = '" + datos.Nombre_c + "', APELLIDO_C= '" + datos.Apellido_c + "', CELULAR_C= '" + datos.Celular_c + "'  where ID_CLIE = '" + datos.Id_clie + "'";
            cmd.CommandText = ABC;
            int Acuse = cmd.ExecuteNonQuery();
            objBD.cerrarBD();
            if (Acuse <= 0)
            {
                return false;
            }
            return true;

        }

        public bool EliminarCLI(clientes_BO objDiv)         //CReamos un metodo de tipo bool para eliminar
        {
            clientes_BO datos = (clientes_BO )objDiv;
            cmd.Connection = objBD.Conectar();
            objBD.abrirBD();
            ABC = "DELETE FROM CLIENTES Where ID_CLIE='" + datos.Id_clie + "'";
            cmd.CommandText = ABC;
            int Acuse = cmd.ExecuteNonQuery();
            objBD.cerrarBD();
            if (Acuse <= 0)
            {
                return false;
            }
            return true;

        }





    }
}
