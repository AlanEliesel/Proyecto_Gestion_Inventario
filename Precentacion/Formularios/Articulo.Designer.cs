namespace Precentacion.Formularios
{
    partial class Articulo
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
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_nuevo = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Nombre = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.txt_Precio = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.txt_Descripcion = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.txt_Stock = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.btn_cancelar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_Guardar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Reporte = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.dgv_Articulo = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new Precentacion.Diseños_Personalizados.Dñ_TextBox();
            this.btn_actualizar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_buscar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.btn_eliminar = new Precentacion.Diseños_Personalizados.Dñ_Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(416, 621);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(192, 36);
            this.lbl_Descripcion.TabIndex = 24;
            this.lbl_Descripcion.Text = "Descripcion:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(421, 133);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(133, 36);
            this.lbl_nombre.TabIndex = 15;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-79, -82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2229, 1510);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(134, 44);
            this.tabControl1.Location = new System.Drawing.Point(158, 277);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2023, 1069);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btn_nuevo);
            this.tabPage1.Controls.Add(this.cmb_Categoria);
            this.tabPage1.Controls.Add(this.lbl_Precio);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.txt_Precio);
            this.tabPage1.Controls.Add(this.txt_Descripcion);
            this.tabPage1.Controls.Add(this.lbl_Stock);
            this.tabPage1.Controls.Add(this.lbl_nombre);
            this.tabPage1.Controls.Add(this.txt_Stock);
            this.tabPage1.Controls.Add(this.btn_cancelar);
            this.tabPage1.Controls.Add(this.btn_Guardar);
            this.tabPage1.Controls.Add(this.lbl_Categoria);
            this.tabPage1.Controls.Add(this.lbl_Descripcion);
            this.tabPage1.Location = new System.Drawing.Point(4, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2015, 1017);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
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
            this.btn_nuevo.Location = new System.Drawing.Point(1171, 780);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(280, 101);
            this.btn_nuevo.TabIndex = 32;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextColor = System.Drawing.Color.Black;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Categoria.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(1099, 464);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(441, 51);
            this.cmb_Categoria.TabIndex = 27;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Precio.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.Color.White;
            this.lbl_Precio.Location = new System.Drawing.Point(1110, 133);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(115, 36);
            this.lbl_Precio.TabIndex = 31;
            this.lbl_Precio.Text = "Precio:";
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
            this.txt_Nombre.Location = new System.Drawing.Point(410, 208);
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
            // 
            // txt_Precio
            // 
            this.txt_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Precio.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Precio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Precio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Precio.BorderRadius = 9;
            this.txt_Precio.BorderSize = 2;
            this.txt_Precio.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.ForeColor = System.Drawing.Color.Black;
            this.txt_Precio.Location = new System.Drawing.Point(1099, 208);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Precio.Multiline = false;
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Precio.PasswordChar = false;
            this.txt_Precio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Precio.PlaceholderText = "";
            this.txt_Precio.Size = new System.Drawing.Size(441, 58);
            this.txt_Precio.TabIndex = 30;
            this.txt_Precio.Texts = "";
            this.txt_Precio.UnderlinedStyle = false;
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
            this.txt_Descripcion.Location = new System.Drawing.Point(410, 696);
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
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.White;
            this.lbl_Stock.Location = new System.Drawing.Point(421, 391);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(102, 36);
            this.lbl_Stock.TabIndex = 29;
            this.lbl_Stock.Text = "Stock:";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Stock.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Stock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.txt_Stock.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Stock.BorderRadius = 9;
            this.txt_Stock.BorderSize = 2;
            this.txt_Stock.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.ForeColor = System.Drawing.Color.Black;
            this.txt_Stock.Location = new System.Drawing.Point(410, 466);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stock.Multiline = false;
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Stock.PasswordChar = false;
            this.txt_Stock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Stock.PlaceholderText = "";
            this.txt_Stock.Size = new System.Drawing.Size(441, 58);
            this.txt_Stock.TabIndex = 28;
            this.txt_Stock.Texts = "";
            this.txt_Stock.UnderlinedStyle = false;
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
            this.btn_cancelar.Location = new System.Drawing.Point(1075, 667);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(219, 87);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.Black;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_Guardar.Location = new System.Drawing.Point(1334, 667);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(219, 87);
            this.btn_Guardar.TabIndex = 21;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextColor = System.Drawing.Color.Black;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(1098, 382);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(160, 36);
            this.lbl_Categoria.TabIndex = 26;
            this.lbl_Categoria.Text = "Categoria:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btn_Reporte);
            this.tabPage2.Controls.Add(this.dgv_Articulo);
            this.tabPage2.Controls.Add(this.txt_Buscar);
            this.tabPage2.Controls.Add(this.btn_actualizar);
            this.tabPage2.Controls.Add(this.btn_buscar);
            this.tabPage2.Controls.Add(this.btn_eliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2015, 1017);
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
            this.btn_Reporte.Location = new System.Drawing.Point(1172, 837);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(280, 101);
            this.btn_Reporte.TabIndex = 32;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.TextColor = System.Drawing.Color.Black;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // dgv_Articulo
            // 
            this.dgv_Articulo.AllowUserToAddRows = false;
            this.dgv_Articulo.AllowUserToDeleteRows = false;
            this.dgv_Articulo.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Articulo.GridColor = System.Drawing.Color.White;
            this.dgv_Articulo.Location = new System.Drawing.Point(6, 180);
            this.dgv_Articulo.Name = "dgv_Articulo";
            this.dgv_Articulo.ReadOnly = true;
            this.dgv_Articulo.RowHeadersWidth = 62;
            this.dgv_Articulo.RowTemplate.Height = 28;
            this.dgv_Articulo.Size = new System.Drawing.Size(1987, 409);
            this.dgv_Articulo.TabIndex = 31;
            this.dgv_Articulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulo_CellClick);
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
            this.txt_Buscar.Location = new System.Drawing.Point(124, 76);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Multiline = false;
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Buscar.PasswordChar = false;
            this.txt_Buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Buscar.PlaceholderText = "";
            this.txt_Buscar.Size = new System.Drawing.Size(568, 58);
            this.txt_Buscar.TabIndex = 29;
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
            this.btn_actualizar.Location = new System.Drawing.Point(565, 837);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(284, 101);
            this.btn_actualizar.TabIndex = 26;
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
            this.btn_buscar.Location = new System.Drawing.Point(720, 69);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(289, 86);
            this.btn_buscar.TabIndex = 28;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.Black;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(872, 837);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(280, 101);
            this.btn_eliminar.TabIndex = 27;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextColor = System.Drawing.Color.Black;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articulo";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Articulo_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Descripcion;
        private Diseños_Personalizados.Dñ_Button btn_Guardar;
        private Diseños_Personalizados.Dñ_Button btn_cancelar;
        private System.Windows.Forms.Label lbl_nombre;
        private Diseños_Personalizados.Dñ_TextBox txt_Descripcion;
        private Diseños_Personalizados.Dñ_TextBox txt_Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label lbl_Stock;
        private Diseños_Personalizados.Dñ_TextBox txt_Stock;
        private System.Windows.Forms.Label lbl_Precio;
        private Diseños_Personalizados.Dñ_TextBox txt_Precio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Diseños_Personalizados.Dñ_TextBox txt_Buscar;
        private Diseños_Personalizados.Dñ_Button btn_actualizar;
        private Diseños_Personalizados.Dñ_Button btn_buscar;
        private Diseños_Personalizados.Dñ_Button btn_eliminar;
        private System.Windows.Forms.DataGridView dgv_Articulo;
        private Diseños_Personalizados.Dñ_Button btn_nuevo;
        private Diseños_Personalizados.Dñ_Button btn_Reporte;
    }
}