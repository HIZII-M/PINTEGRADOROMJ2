using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;
using P_proyecto2.BO;
using P_proyecto2.GUI;

namespace P_proyecto2.DAO
{
    internal class conexion_DAO
    {
 //Creamos una variable de conexion 
        SqlConnection Conex;


        //Metodo de conexion a BD
        public  SqlConnection Conectar()
        {                                          //name server en management                 nombre de la bd       tipo de auteniticacion
            string CadenaConexion = "Data Source = DESKTOP-OMHJV6F\\SQLEXPRESS ; Initial Catalog= pintegrador1v; Integrated Security=true  ";
            Conex = new SqlConnection(CadenaConexion);
            return Conex;
        }



        //Metodo para abrir la conexion a la BD
        public void abrirBD()
        {
            Conex.Open();
        }

        //Metodo para cerrar la conexion a la BD
        public void cerrarBD()
        { 
        Conex.Close();
        }



    }

    
}
