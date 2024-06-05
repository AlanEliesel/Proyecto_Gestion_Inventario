namespace Precentacion.Formularios.Reportes
{
    partial class Frm_Reporte_Area
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spListarAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reporte_Area = new Precentacion.Formularios.Reportes.DS_Reporte_Area();
            this.sp_Listar_AreaTableAdapter = new Precentacion.Formularios.Reportes.DS_Reporte_AreaTableAdapters.Sp_Listar_AreaTableAdapter();
            this.panel_Fondo = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_filtro = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spListarAreaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte_Area)).BeginInit();
            this.panel_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // spListarAreaBindingSource
            // 
            this.spListarAreaBindingSource.DataMember = "Sp_Listar_Area";
            this.spListarAreaBindingSource.DataSource = this.dS_Reporte_Area;
            // 
            // dS_Reporte_Area
            // 
            this.dS_Reporte_Area.DataSetName = "DS_Reporte_Area";
            this.dS_Reporte_Area.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Listar_AreaTableAdapter
            // 
            this.sp_Listar_AreaTableAdapter.ClearBeforeFill = true;
            // 
            // panel_Fondo
            // 
            this.panel_Fondo.Controls.Add(this.txt_filtro);
            this.panel_Fondo.Controls.Add(this.reportViewer1);
            this.panel_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_Fondo.Name = "panel_Fondo";
            this.panel_Fondo.Size = new System.Drawing.Size(1918, 750);
            this.panel_Fondo.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Area";
            reportDataSource1.Value = this.spListarAreaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Precentacion.Formularios.Reportes.Rpt_Listar_Area.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1918, 750);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            this.txt_filtro.Location = new System.Drawing.Point(13, 113);
            this.txt_filtro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtro.Multiline = false;
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Padding = new System.Windows.Forms.Padding(7);
            this.txt_filtro.PasswordChar = false;
            this.txt_filtro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_filtro.PlaceholderText = "";
            this.txt_filtro.Size = new System.Drawing.Size(250, 39);
            this.txt_filtro.TabIndex = 2;
            this.txt_filtro.Texts = "";
            this.txt_filtro.UnderlinedStyle = false;
            this.txt_filtro.Visible = false;
            // 
            // Frm_Reporte_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 750);
            this.Controls.Add(this.panel_Fondo);
            this.Name = "Frm_Reporte_Area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reporte_Area";
            this.Load += new System.EventHandler(this.Frm_Reporte_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spListarAreaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reporte_Area)).EndInit();
            this.panel_Fondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spListarAreaBindingSource;
        private DS_Reporte_Area dS_Reporte_Area;
        private DS_Reporte_AreaTableAdapters.Sp_Listar_AreaTableAdapter sp_Listar_AreaTableAdapter;
        private System.Windows.Forms.Panel panel_Fondo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        internal Diseños_Personalizados.Dñ_TextBox txt_filtro;
    }
}