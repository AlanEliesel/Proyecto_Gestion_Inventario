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
    public partial class Frm_Reporte_Responsable : Form
    {
        public Frm_Reporte_Responsable()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Responsable_Load(object sender, EventArgs e)
        {

            this.sp_Listar_ResponsableTableAdapter.Fill(this.dS_Reporte_Responsable.Sp_Listar_Responsable, cTexto: txt_filtro.Texts);


            this.reportViewer1.RefreshReport();
        }
    }
}
