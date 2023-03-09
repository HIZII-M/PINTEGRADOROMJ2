using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_proyecto2.BO
{
    internal class empleados_BO
    {
        private int matricula;
        private string passwords;
        private string nombre;
        private string apellido;
        private string celular;
        private string email;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
    }
}
