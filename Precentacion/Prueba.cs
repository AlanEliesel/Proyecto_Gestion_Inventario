using Precentacion.Formularios.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Area oFrm_Rpt = new Frm_Reporte_Area();

            oFrm_Rpt.Width = 1128;
            oFrm_Rpt.Height = 806;



            oFrm_Rpt.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Area oFrm_Rpt = new Frm_Reporte_Area();

            oFrm_Rpt.Width = 1128;
            oFrm_Rpt.Height = 806;



            oFrm_Rpt.Show();


        }
    }
}
