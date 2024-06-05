namespace Precentacion.Formularios
{
    partial class Area
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.dgv_Area = new System.Windows.Forms.DataGridView();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reporte = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.txt_Buscar = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.btn_buscar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_Guardar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_cancelar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_eliminar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_actualizar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_nuevo = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.txt_Descripcion = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.txt_Nombre = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(204, 77);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(133, 36);
            this.lbl_nombre.TabIndex = 15;
            this.lbl_nombre.Text = "Nombre:";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // dgv_Area
            // 
            this.dgv_Area.AllowUserToAddRows = false;
            this.dgv_Area.AllowUserToDeleteRows = false;
            this.dgv_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Area.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_Area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Area.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Area.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Area.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Area.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Area.EnableHeadersVisualStyles = false;
            this.dgv_Area.GridColor = System.Drawing.Color.White;
            this.dgv_Area.Location = new System.Drawing.Point(193, 635);
            this.dgv_Area.Name = "dgv_Area";
            this.dgv_Area.RowHeadersWidth = 62;
            this.dgv_Area.RowTemplate.Height = 28;
            this.dgv_Area.Size = new System.Drawing.Size(1353, 443);
            this.dgv_Area.TabIndex = 16;
            this.dgv_Area.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Area_CellClick);
            this.dgv_Area.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Area_CellContentClick);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(760, 77);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(192, 36);
            this.lbl_Descripcion.TabIndex = 24;
            this.lbl_Descripcion.Text = "Descripcion:";
            this.lbl_Descripcion.Click += new System.EventHandler(this.lbl_Descripcion_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_Reporte);
            this.panel1.Controls.Add(this.lbl_Descripcion);
            this.panel1.Controls.Add(this.txt_Buscar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.dgv_Area);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.txt_Descripcion);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Location = new System.Drawing.Point(-68, -43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2082, 1213);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btn_Reporte.Location = new System.Drawing.Point(1701, 966);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(245, 101);
            this.btn_Reporte.TabIndex = 25;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.TextColor = System.Drawing.Color.Black;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
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
            this.txt_Buscar.Location = new System.Drawing.Point(193, 509);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Multiline = false;
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Buscar.PasswordChar = false;
            this.txt_Buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Buscar.PlaceholderText = "";
            this.txt_Buscar.Size = new System.Drawing.Size(533, 58);
            this.txt_Buscar.TabIndex = 23;
            this.txt_Buscar.Texts = "";
            this.txt_Buscar.UnderlinedStyle = false;
            this.txt_Buscar.Load += new System.EventHandler(this.txt_Buscar_Load);
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
            this.btn_buscar.Location = new System.Drawing.Point(753, 500);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(254, 86);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.Black;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_Guardar.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.Location = new System.Drawing.Point(1566, 141);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(219, 87);
            this.btn_Guardar.TabIndex = 21;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextColor = System.Drawing.Color.Black;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
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
            this.btn_cancelar.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Location = new System.Drawing.Point(1285, 141);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(219, 87);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.Black;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(1701, 825);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(245, 101);
            this.btn_eliminar.TabIndex = 19;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextColor = System.Drawing.Color.Black;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_actualizar.Location = new System.Drawing.Point(1697, 680);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(249, 101);
            this.btn_actualizar.TabIndex = 18;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextColor = System.Drawing.Color.Black;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            this.btn_nuevo.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_nuevo.Location = new System.Drawing.Point(1701, 537);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(245, 101);
            this.btn_nuevo.TabIndex = 17;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextColor = System.Drawing.Color.Black;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Descripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Descripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Descripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Descripcion.BorderRadius = 9;
            this.txt_Descripcion.BorderSize = 2;
            this.txt_Descripcion.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.ForeColor = System.Drawing.Color.Black;
            this.txt_Descripcion.Location = new System.Drawing.Point(754, 151);
            this.txt_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Descripcion.Multiline = false;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Descripcion.PasswordChar = false;
            this.txt_Descripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Descripcion.PlaceholderText = "";
            this.txt_Descripcion.Size = new System.Drawing.Size(441, 58);
            this.txt_Descripcion.TabIndex = 14;
            this.txt_Descripcion.Texts = "";
            this.txt_Descripcion.UnderlinedStyle = false;
            this.txt_Descripcion.Load += new System.EventHandler(this.txt_Descripcion_Load);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Nombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Nombre.BorderRadius = 9;
            this.txt_Nombre.BorderSize = 2;
            this.txt_Nombre.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_Nombre.Location = new System.Drawing.Point(193, 151);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Multiline = false;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Nombre.PasswordChar = false;
            this.txt_Nombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Nombre.PlaceholderText = "";
            this.txt_Nombre.Size = new System.Drawing.Size(441, 58);
            this.txt_Nombre.TabIndex = 13;
            this.txt_Nombre.Texts = "";
            this.txt_Nombre.UnderlinedStyle = false;
            this.txt_Nombre.Load += new System.EventHandler(this.txt_Nombre_Load);
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Area";
            this.Text = "Area";
            this.Load += new System.EventHandler(this.Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Diseños_Personalizados.Dñ_TextBox txt_Nombre;
        private Diseños_Personalizados.Dñ_TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridView dgv_Area;
        private Diseños_Personalizados.Dñ_Button btn_nuevo;
        private Diseños_Personalizados.Dñ_Button btn_actualizar;
        private Diseños_Personalizados.Dñ_Button btn_eliminar;
        private Diseños_Personalizados.Dñ_Button btn_cancelar;
        private Diseños_Personalizados.Dñ_Button btn_Guardar;
        private Diseños_Personalizados.Dñ_Button btn_buscar;
        private Diseños_Personalizados.Dñ_TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Panel panel1;
        private Diseños_Personalizados.Dñ_Button btn_Reporte;
    }
}