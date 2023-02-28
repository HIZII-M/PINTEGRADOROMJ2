using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_proyecto2.GUI;

namespace P_proyecto2
{




    public partial class menu_GUI : Form
    {
        public menu_GUI()
        {
            InitializeComponent();
        }

        private void recargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                OpenFormRecharge(new recarga_GUI());
            }

        }

        private void OpenFormRecharge(object formrecarga)
        {
            if (this.PNL_Panel_Contenedor.Controls.Count > 0)

                this.PNL_Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formrecarga as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PNL_Panel_Contenedor.Controls.Add(fh);
            this.PNL_Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu_GUI_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


 
    }
}
