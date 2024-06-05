using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precentacion.Formularios.Reportes
{
    public partial class Frm_Reporte_Area : Form
    {
        public Frm_Reporte_Area()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Area_Load(object sender, EventArgs e)
        {

            this.sp_Listar_AreaTableAdapter.Fill(this.dS_Reporte_Area.Sp_Listar_Area,cTexto:txt_filtro.Texts);
            
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
