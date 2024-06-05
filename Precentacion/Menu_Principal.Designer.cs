namespace Precentacion
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.panel_Title_Bar = new System.Windows.Forms.Panel();
            this.iconPictureBox_Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_Maximizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_Serrar = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Titulo_Formulario = new System.Windows.Forms.Label();
            this.iconPictureBox_Formulario_actual = new FontAwesome.Sharp.IconPictureBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.panel_Escritorio = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.pictureBox_inicio = new System.Windows.Forms.PictureBox();
            this.timer_Hora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.btn_Area = new FontAwesome.Sharp.IconButton();
            this.btn_Categoria = new FontAwesome.Sharp.IconButton();
            this.btn_Articulo = new FontAwesome.Sharp.IconButton();
            this.btn_Proveedor = new FontAwesome.Sharp.IconButton();
            this.btn_Responsable = new FontAwesome.Sharp.IconButton();
            this.btn_Transferencia = new FontAwesome.Sharp.IconButton();
            this.btn_Detalle_transferencia = new FontAwesome.Sharp.IconButton();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Backup = new FontAwesome.Sharp.IconButton();
            this.panel_Title_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Serrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Formulario_actual)).BeginInit();
            this.panel_Escritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inicio)).BeginInit();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title_Bar
            // 
            this.panel_Title_Bar.BackColor = System.Drawing.Color.Black;
            this.panel_Title_Bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Title_Bar.Controls.Add(this.iconPictureBox_Minimizar);
            this.panel_Title_Bar.Controls.Add(this.iconPictureBox_Maximizar);
            this.panel_Title_Bar.Controls.Add(this.iconPictureBox_Serrar);
            this.panel_Title_Bar.Controls.Add(this.lbl_Titulo_Formulario);
            this.panel_Title_Bar.Controls.Add(this.iconPictureBox_Formulario_actual);
            this.panel_Title_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title_Bar.Location = new System.Drawing.Point(324, 0);
            this.panel_Title_Bar.Name = "panel_Title_Bar";
            this.panel_Title_Bar.Size = new System.Drawing.Size(1622, 100);
            this.panel_Title_Bar.TabIndex = 1;
            this.panel_Title_Bar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Title_Bar_Paint);
            this.panel_Title_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_Bar_MouseDown);
            // 
            // iconPictureBox_Minimizar
            // 
            this.iconPictureBox_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox_Minimizar.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Minimizar.IconSize = 41;
            this.iconPictureBox_Minimizar.Location = new System.Drawing.Point(1347, 32);
            this.iconPictureBox_Minimizar.Name = "iconPictureBox_Minimizar";
            this.iconPictureBox_Minimizar.Size = new System.Drawing.Size(49, 41);
            this.iconPictureBox_Minimizar.TabIndex = 4;
            this.iconPictureBox_Minimizar.TabStop = false;
            this.iconPictureBox_Minimizar.Click += new System.EventHandler(this.iconPictureBox_Minimizar_Click);
            // 
            // iconPictureBox_Maximizar
            // 
            this.iconPictureBox_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox_Maximizar.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_Maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox_Maximizar.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Maximizar.IconSize = 41;
            this.iconPictureBox_Maximizar.Location = new System.Drawing.Point(1443, 32);
            this.iconPictureBox_Maximizar.Name = "iconPictureBox_Maximizar";
            this.iconPictureBox_Maximizar.Size = new System.Drawing.Size(49, 41);
            this.iconPictureBox_Maximizar.TabIndex = 3;
            this.iconPictureBox_Maximizar.TabStop = false;
            this.iconPictureBox_Maximizar.Click += new System.EventHandler(this.iconPictureBox_Maximizar_Click);
            // 
            // iconPictureBox_Serrar
            // 
            this.iconPictureBox_Serrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox_Serrar.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_Serrar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.iconPictureBox_Serrar.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Serrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Serrar.IconSize = 41;
            this.iconPictureBox_Serrar.Location = new System.Drawing.Point(1533, 32);
            this.iconPictureBox_Serrar.Name = "iconPictureBox_Serrar";
            this.iconPictureBox_Serrar.Size = new System.Drawing.Size(49, 41);
            this.iconPictureBox_Serrar.TabIndex = 2;
            this.iconPictureBox_Serrar.TabStop = false;
            this.iconPictureBox_Serrar.Click += new System.EventHandler(this.iconPictureBox_Serrar_Click);
            // 
            // lbl_Titulo_Formulario
            // 
            this.lbl_Titulo_Formulario.AutoSize = true;
            this.lbl_Titulo_Formulario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo_Formulario.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Formulario.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo_Formulario.Location = new System.Drawing.Point(106, 32);
            this.lbl_Titulo_Formulario.Name = "lbl_Titulo_Formulario";
            this.lbl_Titulo_Formulario.Size = new System.Drawing.Size(98, 36);
            this.lbl_Titulo_Formulario.TabIndex = 1;
            this.lbl_Titulo_Formulario.Text = "HOME";
            // 
            // iconPictureBox_Formulario_actual
            // 
            this.iconPictureBox_Formulario_actual.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_Formulario_actual.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconPictureBox_Formulario_actual.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Formulario_actual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox_Formulario_actual.IconSize = 55;
            this.iconPictureBox_Formulario_actual.Location = new System.Drawing.Point(38, 24);
            this.iconPictureBox_Formulario_actual.Name = "iconPictureBox_Formulario_actual";
            this.iconPictureBox_Formulario_actual.Size = new System.Drawing.Size(55, 56);
            this.iconPictureBox_Formulario_actual.TabIndex = 0;
            this.iconPictureBox_Formulario_actual.TabStop = false;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(32, 999);
            this.Usuario.Margin = new System.Windows.Forms.Padding(3, 0, 40, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(133, 36);
            this.Usuario.TabIndex = 8;
            this.Usuario.Text = "Usuario:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(32, 1052);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(3, 0, 40, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(251, 36);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "Nombre usuario:";
            // 
            // panel_Escritorio
            // 
            this.panel_Escritorio.BackColor = System.Drawing.Color.Black;
            this.panel_Escritorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Escritorio.Controls.Add(this.lbl_fecha);
            this.panel_Escritorio.Controls.Add(this.lbl_Hora);
            this.panel_Escritorio.Controls.Add(this.pictureBox_inicio);
            this.panel_Escritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Escritorio.Location = new System.Drawing.Point(324, 100);
            this.panel_Escritorio.Name = "panel_Escritorio";
            this.panel_Escritorio.Size = new System.Drawing.Size(1622, 1006);
            this.panel_Escritorio.TabIndex = 3;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(359, 792);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(220, 80);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hora.Font = new System.Drawing.Font("Britannic Bold", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.White;
            this.lbl_Hora.Location = new System.Drawing.Point(426, 639);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(273, 115);
            this.lbl_Hora.TabIndex = 1;
            this.lbl_Hora.Text = "Hora";
            // 
            // pictureBox_inicio
            // 
            this.pictureBox_inicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_inicio.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_inicio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_inicio.Image")));
            this.pictureBox_inicio.Location = new System.Drawing.Point(447, 80);
            this.pictureBox_inicio.Name = "pictureBox_inicio";
            this.pictureBox_inicio.Size = new System.Drawing.Size(894, 584);
            this.pictureBox_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_inicio.TabIndex = 0;
            this.pictureBox_inicio.TabStop = false;
            // 
            // timer_Hora_Fecha
            // 
            this.timer_Hora_Fecha.Enabled = true;
            this.timer_Hora_Fecha.Tick += new System.EventHandler(this.timer_Hora_Fecha_Tick);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Logo.Controls.Add(this.btn_home);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.ForeColor = System.Drawing.Color.White;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(322, 176);
            this.panel_Logo.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(320, 174);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_Area
            // 
            this.btn_Area.BackColor = System.Drawing.Color.Transparent;
            this.btn_Area.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Area.FlatAppearance.BorderSize = 0;
            this.btn_Area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Area.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Area.ForeColor = System.Drawing.Color.White;
            this.btn_Area.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btn_Area.IconColor = System.Drawing.Color.White;
            this.btn_Area.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Area.IconSize = 32;
            this.btn_Area.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Area.Location = new System.Drawing.Point(0, 176);
            this.btn_Area.Name = "btn_Area";
            this.btn_Area.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Area.Size = new System.Drawing.Size(322, 73);
            this.btn_Area.TabIndex = 1;
            this.btn_Area.Text = "Área";
            this.btn_Area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Area.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Area.UseVisualStyleBackColor = false;
            this.btn_Area.Click += new System.EventHandler(this.btn_Area_Click);
            // 
            // btn_Categoria
            // 
            this.btn_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_Categoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Categoria.FlatAppearance.BorderSize = 0;
            this.btn_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categoria.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Categoria.ForeColor = System.Drawing.Color.White;
            this.btn_Categoria.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.btn_Categoria.IconColor = System.Drawing.Color.White;
            this.btn_Categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Categoria.IconSize = 32;
            this.btn_Categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Categoria.Location = new System.Drawing.Point(0, 249);
            this.btn_Categoria.Name = "btn_Categoria";
            this.btn_Categoria.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Categoria.Size = new System.Drawing.Size(322, 73);
            this.btn_Categoria.TabIndex = 2;
            this.btn_Categoria.Text = "Categoria";
            this.btn_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Categoria.UseVisualStyleBackColor = false;
            this.btn_Categoria.Click += new System.EventHandler(this.btn_Categoria_Click);
            // 
            // btn_Articulo
            // 
            this.btn_Articulo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Articulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Articulo.FlatAppearance.BorderSize = 0;
            this.btn_Articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Articulo.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Articulo.ForeColor = System.Drawing.Color.White;
            this.btn_Articulo.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.btn_Articulo.IconColor = System.Drawing.Color.White;
            this.btn_Articulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Articulo.IconSize = 32;
            this.btn_Articulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Articulo.Location = new System.Drawing.Point(0, 322);
            this.btn_Articulo.Name = "btn_Articulo";
            this.btn_Articulo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Articulo.Size = new System.Drawing.Size(322, 73);
            this.btn_Articulo.TabIndex = 3;
            this.btn_Articulo.Text = "Articulo";
            this.btn_Articulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Articulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Articulo.UseVisualStyleBackColor = false;
            this.btn_Articulo.Click += new System.EventHandler(this.btn_Articulo_Click);
            // 
            // btn_Proveedor
            // 
            this.btn_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_Proveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Proveedor.FlatAppearance.BorderSize = 0;
            this.btn_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedor.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedor.ForeColor = System.Drawing.Color.White;
            this.btn_Proveedor.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingLuggage;
            this.btn_Proveedor.IconColor = System.Drawing.Color.White;
            this.btn_Proveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Proveedor.IconSize = 32;
            this.btn_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedor.Location = new System.Drawing.Point(0, 395);
            this.btn_Proveedor.Name = "btn_Proveedor";
            this.btn_Proveedor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Proveedor.Size = new System.Drawing.Size(322, 73);
            this.btn_Proveedor.TabIndex = 4;
            this.btn_Proveedor.Text = "Proveedor";
            this.btn_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Proveedor.UseVisualStyleBackColor = false;
            this.btn_Proveedor.Click += new System.EventHandler(this.btn_Proveedor_Click);
            // 
            // btn_Responsable
            // 
            this.btn_Responsable.BackColor = System.Drawing.Color.Transparent;
            this.btn_Responsable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Responsable.FlatAppearance.BorderSize = 0;
            this.btn_Responsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Responsable.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Responsable.ForeColor = System.Drawing.Color.White;
            this.btn_Responsable.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.btn_Responsable.IconColor = System.Drawing.Color.White;
            this.btn_Responsable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Responsable.IconSize = 32;
            this.btn_Responsable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Responsable.Location = new System.Drawing.Point(0, 468);
            this.btn_Responsable.Name = "btn_Responsable";
            this.btn_Responsable.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Responsable.Size = new System.Drawing.Size(322, 73);
            this.btn_Responsable.TabIndex = 5;
            this.btn_Responsable.Text = "Responsable";
            this.btn_Responsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Responsable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Responsable.UseVisualStyleBackColor = false;
            this.btn_Responsable.Click += new System.EventHandler(this.btn_Responsable_Click);
            // 
            // btn_Transferencia
            // 
            this.btn_Transferencia.BackColor = System.Drawing.Color.Transparent;
            this.btn_Transferencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Transferencia.FlatAppearance.BorderSize = 0;
            this.btn_Transferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transferencia.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transferencia.ForeColor = System.Drawing.Color.White;
            this.btn_Transferencia.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btn_Transferencia.IconColor = System.Drawing.Color.White;
            this.btn_Transferencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Transferencia.IconSize = 32;
            this.btn_Transferencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transferencia.Location = new System.Drawing.Point(0, 541);
            this.btn_Transferencia.Name = "btn_Transferencia";
            this.btn_Transferencia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Transferencia.Size = new System.Drawing.Size(322, 73);
            this.btn_Transferencia.TabIndex = 6;
            this.btn_Transferencia.Text = "Transferencia";
            this.btn_Transferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Transferencia.UseVisualStyleBackColor = false;
            this.btn_Transferencia.Click += new System.EventHandler(this.btn_Transferencia_Click);
            // 
            // btn_Detalle_transferencia
            // 
            this.btn_Detalle_transferencia.BackColor = System.Drawing.Color.Transparent;
            this.btn_Detalle_transferencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Detalle_transferencia.FlatAppearance.BorderSize = 0;
            this.btn_Detalle_transferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detalle_transferencia.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            this.btn_Detalle_transferencia.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            this.btn_Detalle_transferencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Detalle_transferencia.IconSize = 32;
            this.btn_Detalle_transferencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Detalle_transferencia.Location = new System.Drawing.Point(0, 614);
            this.btn_Detalle_transferencia.Name = "btn_Detalle_transferencia";
            this.btn_Detalle_transferencia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Detalle_transferencia.Size = new System.Drawing.Size(322, 86);
            this.btn_Detalle_transferencia.TabIndex = 7;
            this.btn_Detalle_transferencia.Text = "Detalle Transferencia";
            this.btn_Detalle_transferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Detalle_transferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Detalle_transferencia.UseVisualStyleBackColor = false;
            this.btn_Detalle_transferencia.Click += new System.EventHandler(this.btn_Detalle_transferencia_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Black;
            this.panel_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.btn_Backup);
            this.panel_Menu.Controls.Add(this.Usuario);
            this.panel_Menu.Controls.Add(this.lbl_Usuario);
            this.panel_Menu.Controls.Add(this.btn_Detalle_transferencia);
            this.panel_Menu.Controls.Add(this.btn_Transferencia);
            this.panel_Menu.Controls.Add(this.btn_Responsable);
            this.panel_Menu.Controls.Add(this.btn_Proveedor);
            this.panel_Menu.Controls.Add(this.btn_Articulo);
            this.panel_Menu.Controls.Add(this.btn_Categoria);
            this.panel_Menu.Controls.Add(this.btn_Area);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(324, 1106);
            this.panel_Menu.TabIndex = 0;
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Backup.FlatAppearance.BorderSize = 0;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.ForeColor = System.Drawing.Color.White;
            this.btn_Backup.IconChar = FontAwesome.Sharp.IconChar.FileZipper;
            this.btn_Backup.IconColor = System.Drawing.Color.White;
            this.btn_Backup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Backup.IconSize = 32;
            this.btn_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Backup.Location = new System.Drawing.Point(0, 700);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Backup.Size = new System.Drawing.Size(322, 86);
            this.btn_Backup.TabIndex = 9;
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel_Escritorio);
            this.Controls.Add(this.panel_Title_Bar);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.panel_Title_Bar.ResumeLayout(false);
            this.panel_Title_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Serrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Formulario_actual)).EndInit();
            this.panel_Escritorio.ResumeLayout(false);
            this.panel_Escritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inicio)).EndInit();
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Title_Bar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Formulario_actual;
        private System.Windows.Forms.Label lbl_Titulo_Formulario;
        private System.Windows.Forms.Panel panel_Escritorio;
        private System.Windows.Forms.PictureBox pictureBox_inicio;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Serrar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Minimizar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Maximizar;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer timer_Hora_Fecha;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.PictureBox btn_home;
        private FontAwesome.Sharp.IconButton btn_Area;
        private FontAwesome.Sharp.IconButton btn_Categoria;
        private FontAwesome.Sharp.IconButton btn_Articulo;
        private FontAwesome.Sharp.IconButton btn_Proveedor;
        private FontAwesome.Sharp.IconButton btn_Responsable;
        private FontAwesome.Sharp.IconButton btn_Transferencia;
        private FontAwesome.Sharp.IconButton btn_Detalle_transferencia;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private FontAwesome.Sharp.IconButton btn_Backup;
    }
}