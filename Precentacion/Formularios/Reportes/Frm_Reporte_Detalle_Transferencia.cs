﻿using System;
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
    public partial class Frm_Reporte_Detalle_Transferencia : Form
    {
        public Frm_Reporte_Detalle_Transferencia()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Detalle_Transferencia_Load(object sender, EventArgs e)
        {

            this.sp_Listar_Detalle_TrasferenciaTableAdapter.Fill(this.dS_Reporte_Detalle_Transferencia.Sp_Listar_Detalle_Trasferencia, cTexto: txt_filtro.Texts);


            this.reportViewer1.RefreshReport();
        }
    }
}
