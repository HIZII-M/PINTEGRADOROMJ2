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
    internal class empleados_DAO
    {


        conexion_DAO objBD = new conexion_DAO();       //creamos una variable que ejecute el comando sqlserver
        SqlCommand cmd = new SqlCommand();
        string ABC;                                //variable para la estructura para insertar, eliminar o actualizar



        public bool GuardarEMP(empleados_BO objDiv)        //CReamos un metodo de tipo bool para guardar
        {
            empleados_BO datos = (empleados_BO)objDiv;
            cmd.Connection = objBD.Conectar();
            objBD.abrirBD();
            ABC = "Insert into EMPLEADOS (PASSWORDS, NOMBRE, APELLIDO, CELULAR, EMAIL) values('" + datos.Passwords + "' , '" + datos.Nombre+"' , '"+datos.Apellido+"' , '"+datos.Celular+"' , '"+datos.Email+"' ) ";
            cmd.CommandText = ABC;
            int Acuse = cmd.ExecuteNonQuery();
            objBD.cerrarBD();
            if (Acuse <= 0)
            {
                return false;
            }
            return true;


        }

        public DataTable Tablaempleados()         //metodo para mostrar la tabla al datagridview
        {
            string ConSQL = "select * from EMPLEADOS";
            SqlDataAdapter adp = new SqlDataAdapter(ConSQL, objBD.Conectar());
            DataTable TablaVirtual = new DataTable();
            adp.Fill(TablaVirtual);
            return TablaVirtual;
        }

        public bool ActualizarEMP(empleados_BO objDiv)         //CReamos un metodo de tipo bool para actualizar
        {
            empleados_BO datos = (empleados_BO)objDiv;
            cmd.Connection = objBD.Conectar();
            objBD.abrirBD();
            ABC = "UPDATE EMPLEADOS set PASSWORDS= '" + datos.Passwords + "', NOMBRE = '"+datos.Nombre+"', APELLIDO= '"+datos.Apellido+"', CELULAR= '"+datos.Celular+"', EMAIL='"+datos.Email+"' ,  WHERE MATRICULA = '" + datos.Matricula + "'";
            cmd.CommandText = ABC;
            int Acuse = cmd.ExecuteNonQuery();
            objBD.cerrarBD();
            if (Acuse <= 0)
            {
                return false;
            }
            return true;

        }

        public bool EliminarEMP(empleados_BO objDiv)         //CReamos un metodo de tipo bool para eliminar
        {
            empleados_BO datos = (empleados_BO)objDiv;
            cmd.Connection = objBD.Conectar();
            objBD.abrirBD();
            ABC = "DELETE FROM EMPLEADOS Where MATRICULA='" + datos.Matricula + "'"; 
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
