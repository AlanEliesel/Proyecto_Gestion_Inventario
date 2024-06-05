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
    public partial class Frm_Reporte_Categoria : Form
    {
        public Frm_Reporte_Categoria()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Categoria_Load(object sender, EventArgs e)
        {




            this.sp_Listar_CategoriaTableAdapter.Fill(this.dS_Reporte_Categoria.Sp_Listar_Categoria, cTexto: txt_filtro.Texts);

            this.reportViewer1.RefreshReport();
        }
    }
}
