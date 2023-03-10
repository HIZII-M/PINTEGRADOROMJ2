using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_proyecto2.BO
{
    internal class clientes_BO
    {
        private int id_clie;
        private string nombre_c;
        private string apellido_c;
        private int celular_c;

        public int Id_clie { get => id_clie; set => id_clie = value; }
        public string Nombre_c { get => nombre_c; set => nombre_c = value; }
        public string Apellido_c { get => apellido_c; set => apellido_c = value; }
        public int Celular_c { get => celular_c; set => celular_c = value; }
    }
}
