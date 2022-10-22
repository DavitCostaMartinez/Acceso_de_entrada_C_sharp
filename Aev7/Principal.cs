using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aev7
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("T");
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            FrmMantenimiento mante = new FrmMantenimiento();
            mante.ShowDialog();
        }
    }
}
