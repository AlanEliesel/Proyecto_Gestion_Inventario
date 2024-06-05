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
    public partial class Frm_Reporte_Proveedor : Form
    {
        public Frm_Reporte_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Proveedor_Load(object sender, EventArgs e)
        {

            this.sp_Listar_ProveedorTableAdapter.Fill(this.dS_Reporte_Proveedor.Sp_Listar_Proveedor, cTexto: txt_filtro.Texts);


            this.reportViewer1.RefreshReport();
        }
    }
}
