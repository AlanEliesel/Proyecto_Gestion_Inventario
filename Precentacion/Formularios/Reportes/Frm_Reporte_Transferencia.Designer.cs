namespace Precentacion.Formularios.Reportes
{
    partial class Frm_Reporte_Transferencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Reporte_Transferencia = new Precentacion.Formularios.Reportes.DS_Reporte_Transferencia();
            this.spListarTrasferenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Listar_TrasferenciaTableAdapter = new Precentacion.Formularios.Reportes.DS_Reporte_TransferenciaTableAdapters.Sp_Listar_TrasferenciaTableAdapter();
            this.txt_filtro = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte_Transferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarTrasferenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_Transferencia";
            reportDataSource2.Value = this.spListarTrasferenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Precentacion.Formularios.Reportes.Rpt_Listar_Transferencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1312, 722);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reporte_Transferencia
            // 
            this.dS_Reporte_Transferencia.DataSetName = "DS_Reporte_Transferencia";
            this.dS_Reporte_Transferencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListarTrasferenciaBindingSource
            // 
            this.spListarTrasferenciaBindingSource.DataMember = "Sp_Listar_Trasferencia";
            this.spListarTrasferenciaBindingSource.DataSource = this.dS_Reporte_Transferencia;
            // 
            // sp_Listar_TrasferenciaTableAdapter
            // 
            this.sp_Listar_TrasferenciaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_filtro
            // 
            this.txt_filtro.BackColor = System.Drawing.SystemColors.Window;
            this.txt_filtro.BorderColor = System.Drawing.Color.Gray;
            this.txt_filtro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_filtro.BorderRadius = 10;
            this.txt_filtro.BorderSize = 2;
            this.txt_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro.ForeColor = System.Drawing.Color.DimGray;
            this.txt_filtro.Location = new System.Drawing.Point(52, 88);
            this.txt_filtro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtro.Multiline = false;
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Padding = new System.Windows.Forms.Padding(7);
            this.txt_filtro.PasswordChar = false;
            this.txt_filtro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_filtro.PlaceholderText = "";
            this.txt_filtro.Size = new System.Drawing.Size(250, 39);
            this.txt_filtro.TabIndex = 3;
            this.txt_filtro.Texts = "";
            this.txt_filtro.UnderlinedStyle = false;
            this.txt_filtro.Visible = false;
            // 
            // Frm_Reporte_Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 722);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Transferencia";
            this.Text = "Frm_Reporte_Transferencia";
            this.Load += new System.EventHandler(this.Frm_Reporte_Transferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte_Transferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarTrasferenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListarTrasferenciaBindingSource;
        private DS_Reporte_Transferencia dS_Reporte_Transferencia;
        private DS_Reporte_TransferenciaTableAdapters.Sp_Listar_TrasferenciaTableAdapter sp_Listar_TrasferenciaTableAdapter;
        internal Diseños_Personalizados.Dñ_TextBox txt_filtro;
    }
}