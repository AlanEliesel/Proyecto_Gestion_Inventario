namespace Precentacion.Formularios
{
    partial class DetalleTransferencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Cantidad = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.cmb_Articulo = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cmb_Transferencia = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_nuevo = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.lbl_Codigo_Categoria = new System.Windows.Forms.Label();
            this.btn_Guardar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Reporte = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.dgv_Detalle_Transferencia = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.txt_Buscar = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.btn_actualizar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_buscar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle_Transferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-68, -54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2229, 1510);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(156, 263);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1964, 1083);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.txt_Cantidad);
            this.tabPage1.Controls.Add(this.cmb_Articulo);
            this.tabPage1.Controls.Add(this.lbl_nombre);
            this.tabPage1.Controls.Add(this.cmb_Transferencia);
            this.tabPage1.Controls.Add(this.btn_cancelar);
            this.tabPage1.Controls.Add(this.btn_nuevo);
            this.tabPage1.Controls.Add(this.lbl_Codigo_Categoria);
            this.tabPage1.Controls.Add(this.btn_Guardar);
            this.tabPage1.Controls.Add(this.lbl_Descripcion);
            this.tabPage1.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1956, 1032);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Cantidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Cantidad.BorderRadius = 9;
            this.txt_Cantidad.BorderSize = 2;
            this.txt_Cantidad.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.ForeColor = System.Drawing.Color.Black;
            this.txt_Cantidad.Location = new System.Drawing.Point(422, 506);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cantidad.Multiline = false;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Cantidad.PasswordChar = false;
            this.txt_Cantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Cantidad.PlaceholderText = "";
            this.txt_Cantidad.Size = new System.Drawing.Size(441, 58);
            this.txt_Cantidad.TabIndex = 13;
            this.txt_Cantidad.Texts = "";
            this.txt_Cantidad.UnderlinedStyle = false;
            // 
            // cmb_Articulo
            // 
            this.cmb_Articulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Articulo.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Articulo.FormattingEnabled = true;
            this.cmb_Articulo.Location = new System.Drawing.Point(994, 261);
            this.cmb_Articulo.Name = "cmb_Articulo";
            this.cmb_Articulo.Size = new System.Drawing.Size(441, 51);
            this.cmb_Articulo.TabIndex = 28;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(434, 434);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(155, 37);
            this.lbl_nombre.TabIndex = 15;
            this.lbl_nombre.Text = "Cantidad:";
            // 
            // cmb_Transferencia
            // 
            this.cmb_Transferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Transferencia.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Transferencia.FormattingEnabled = true;
            this.cmb_Transferencia.Location = new System.Drawing.Point(442, 257);
            this.cmb_Transferencia.Name = "cmb_Transferencia";
            this.cmb_Transferencia.Size = new System.Drawing.Size(441, 51);
            this.cmb_Transferencia.TabIndex = 27;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.White;
            this.btn_cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cancelar.BorderRadius = 20;
            this.btn_cancelar.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(1003, 417);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(219, 87);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.Black;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nuevo.BackColor = System.Drawing.Color.White;
            this.btn_nuevo.BackgroundColor = System.Drawing.Color.White;
            this.btn_nuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_nuevo.BorderRadius = 20;
            this.btn_nuevo.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_nuevo.Location = new System.Drawing.Point(1128, 533);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(245, 101);
            this.btn_nuevo.TabIndex = 17;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextColor = System.Drawing.Color.Black;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lbl_Codigo_Categoria
            // 
            this.lbl_Codigo_Categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Codigo_Categoria.AutoSize = true;
            this.lbl_Codigo_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Codigo_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Codigo_Categoria.Location = new System.Drawing.Point(434, 178);
            this.lbl_Codigo_Categoria.Name = "lbl_Codigo_Categoria";
            this.lbl_Codigo_Categoria.Size = new System.Drawing.Size(333, 37);
            this.lbl_Codigo_Categoria.TabIndex = 26;
            this.lbl_Codigo_Categoria.Text = "Codigo Transferencia:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.BackColor = System.Drawing.Color.White;
            this.btn_Guardar.BackgroundColor = System.Drawing.Color.White;
            this.btn_Guardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Guardar.BorderRadius = 20;
            this.btn_Guardar.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.Location = new System.Drawing.Point(1262, 417);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(219, 87);
            this.btn_Guardar.TabIndex = 21;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextColor = System.Drawing.Color.Black;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(1005, 178);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(134, 37);
            this.lbl_Descripcion.TabIndex = 24;
            this.lbl_Descripcion.Text = "Articulo:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btn_Reporte);
            this.tabPage2.Controls.Add(this.dgv_Detalle_Transferencia);
            this.tabPage2.Controls.Add(this.btn_eliminar);
            this.tabPage2.Controls.Add(this.txt_Buscar);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1956, 1034);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reporte.BackColor = System.Drawing.Color.White;
            this.btn_Reporte.BackgroundColor = System.Drawing.Color.White;
            this.btn_Reporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Reporte.BorderRadius = 20;
            this.btn_Reporte.BorderSize = 0;
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte.ForeColor = System.Drawing.Color.Black;
            this.btn_Reporte.Location = new System.Drawing.Point(1226, 842);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(287, 101);
            this.btn_Reporte.TabIndex = 29;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.TextColor = System.Drawing.Color.Black;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // dgv_Detalle_Transferencia
            // 
            this.dgv_Detalle_Transferencia.AllowUserToAddRows = false;
            this.dgv_Detalle_Transferencia.AllowUserToDeleteRows = false;
            this.dgv_Detalle_Transferencia.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Detalle_Transferencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Detalle_Transferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Detalle_Transferencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Detalle_Transferencia.EnableHeadersVisualStyles = false;
            this.dgv_Detalle_Transferencia.GridColor = System.Drawing.Color.White;
            this.dgv_Detalle_Transferencia.Location = new System.Drawing.Point(23, 313);
            this.dgv_Detalle_Transferencia.Name = "dgv_Detalle_Transferencia";
            this.dgv_Detalle_Transferencia.ReadOnly = true;
            this.dgv_Detalle_Transferencia.RowHeadersWidth = 62;
            this.dgv_Detalle_Transferencia.RowTemplate.Height = 28;
            this.dgv_Detalle_Transferencia.Size = new System.Drawing.Size(1973, 467);
            this.dgv_Detalle_Transferencia.TabIndex = 28;
            this.dgv_Detalle_Transferencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detalle_Transferencia_CellClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminar.BackColor = System.Drawing.Color.White;
            this.btn_eliminar.BackgroundColor = System.Drawing.Color.White;
            this.btn_eliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_eliminar.BorderRadius = 20;
            this.btn_eliminar.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(892, 842);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(287, 101);
            this.btn_eliminar.TabIndex = 25;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextColor = System.Drawing.Color.Black;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Buscar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Buscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Buscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Buscar.BorderRadius = 9;
            this.txt_Buscar.BorderSize = 2;
            this.txt_Buscar.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_Buscar.Location = new System.Drawing.Point(75, 183);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Multiline = false;
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Buscar.PasswordChar = false;
            this.txt_Buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Buscar.PlaceholderText = "";
            this.txt_Buscar.Size = new System.Drawing.Size(533, 58);
            this.txt_Buscar.TabIndex = 27;
            this.txt_Buscar.Texts = "";
            this.txt_Buscar.UnderlinedStyle = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actualizar.BackColor = System.Drawing.Color.White;
            this.btn_actualizar.BackgroundColor = System.Drawing.Color.White;
            this.btn_actualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_actualizar.BorderRadius = 20;
            this.btn_actualizar.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualizar.Location = new System.Drawing.Point(556, 842);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(287, 101);
            this.btn_actualizar.TabIndex = 24;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextColor = System.Drawing.Color.Black;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.BackgroundColor = System.Drawing.Color.White;
            this.btn_buscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_buscar.BorderRadius = 20;
            this.btn_buscar.BorderSize = 0;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_buscar.Location = new System.Drawing.Point(680, 169);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(254, 86);
            this.btn_buscar.TabIndex = 26;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.Black;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // DetalleTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleTransferencia";
            this.Text = "Detalle_Transferencia";
            this.Load += new System.EventHandler(this.form_Detalle_Transferencia_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle_Transferencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Transferencia;
        private System.Windows.Forms.Label lbl_Codigo_Categoria;
        private System.Windows.Forms.Label lbl_Descripcion;
        private Diseños_Personalizados.Dñ_Button btn_Guardar;
        private Diseños_Personalizados.Dñ_Button btn_cancelar;
        private Diseños_Personalizados.Dñ_Button btn_nuevo;
        private System.Windows.Forms.Label lbl_nombre;
        private Diseños_Personalizados.Dñ_TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox cmb_Articulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Detalle_Transferencia;
        private Diseños_Personalizados.Dñ_Button btn_eliminar;
        private Diseños_Personalizados.Dñ_TextBox txt_Buscar;
        private Diseños_Personalizados.Dñ_Button btn_actualizar;
        private Diseños_Personalizados.Dñ_Button btn_buscar;
        private Diseños_Personalizados.Dñ_Button btn_Reporte;
    }
}