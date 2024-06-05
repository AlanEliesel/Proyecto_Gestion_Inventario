namespace Precentacion.Formularios.Reportes
{
    partial class Frm_Reporte_Proveedor
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
            this.dS_Reporte_Proveedor = new Precentacion.Formularios.Reportes.DS_Reporte_Proveedor();
            this.spListarProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Listar_ProveedorTableAdapter = new Precentacion.Formularios.Reportes.DS_Reporte_ProveedorTableAdapters.Sp_Listar_ProveedorTableAdapter();
            this.txt_filtro = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_Proveedor";
            reportDataSource2.Value = this.spListarProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Precentacion.Formularios.Reportes.Rpt_Listar_Proveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1312, 722);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Reporte_Proveedor
            // 
            this.dS_Reporte_Proveedor.DataSetName = "DS_Reporte_Proveedor";
            this.dS_Reporte_Proveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListarProveedorBindingSource
            // 
            this.spListarProveedorBindingSource.DataMember = "Sp_Listar_Proveedor";
            this.spListarProveedorBindingSource.DataSource = this.dS_Reporte_Proveedor;
            // 
            // sp_Listar_ProveedorTableAdapter
            // 
            this.sp_Listar_ProveedorTableAdapter.ClearBeforeFill = true;
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
            this.txt_filtro.Location = new System.Drawing.Point(52, 92);
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
            // Frm_Reporte_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 722);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Proveedor";
            this.Text = "Frm_Reporte_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Reporte_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListarProveedorBindingSource;
        private DS_Reporte_Proveedor dS_Reporte_Proveedor;
        private DS_Reporte_ProveedorTableAdapters.Sp_Listar_ProveedorTableAdapter sp_Listar_ProveedorTableAdapter;
        internal Diseños_Personalizados.Dñ_TextBox txt_filtro;
    }
}