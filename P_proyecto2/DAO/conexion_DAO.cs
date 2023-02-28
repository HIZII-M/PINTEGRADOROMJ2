using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;

namespace P_proyecto2.DAO
{
    internal class conexion_DAO
    {

        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER = DESKTOP-OMHJV6F\\SQLEXPRESS; DATABASE= pintegrador1v; integrated security=true; ") ;         
            cn.Open();
            return cn ;
        
        }

    }
}
