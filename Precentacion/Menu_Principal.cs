using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Precentacion.Formularios;
using Microsoft.Reporting.WinForms;
using Precentacion;
using Negocio;
using Entidades.Entidades_Login;
using System.Data.SqlClient;


namespace Precentacion
{
    public partial class Menu_Principal : Form
    {

        //Fields = Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form Formulario_hijo_actual;


        private static E_Usuario usuarioActual;

        public Menu_Principal( E_Usuario objusuario)
        {
            InitializeComponent();

            usuarioActual = objusuario;

            #region Medidas_Componentes

            this.Width = 1750;
            this.Height = 1050;

            panel_Escritorio.Dock = DockStyle.Fill;
            panel_Escritorio.Width = 324;
            panel_Escritorio.Height = 111;

            panel_Menu.Dock = DockStyle.Left;
            panel_Menu.Width = 324;
            panel_Menu.Height = 976;

            panel_Logo.Dock = DockStyle.Top;
            panel_Logo.Width = 324;
            panel_Logo.Height = 176;

            panel_Title_Bar.Dock = DockStyle.Top;
            panel_Title_Bar.Width = 1426;
            panel_Title_Bar.Height = 100;

            lbl_Titulo_Formulario.Width = 114;
            lbl_Titulo_Formulario.Height = 38;

            iconPictureBox_Maximizar.Width = 49;
            iconPictureBox_Maximizar.Height = 41;

            iconPictureBox_Minimizar.Width = 49;
            iconPictureBox_Minimizar.Height = 41;

            iconPictureBox_Serrar.Width = 49;
            iconPictureBox_Serrar.Height = 41;

            iconPictureBox_Formulario_actual.Width = 55;
            iconPictureBox_Formulario_actual.Height = 56;

            btn_home.Width = 324;
            btn_home.Height = 176;

            btn_Area.Width = 324;
            btn_Area.Height = 86;

            btn_Articulo.Width = 324;
            btn_Articulo.Height = 86;

            btn_Categoria.Width = 324;
            btn_Categoria.Height = 86;

            btn_Transferencia.Width = 324;
            btn_Transferencia.Height = 86;

            btn_Detalle_transferencia.Width = 324;
            btn_Detalle_transferencia.Height = 86;

            btn_Proveedor.Width = 324;
            btn_Proveedor.Height = 86;

            btn_Responsable.Width = 324;
            btn_Responsable.Height = 86;


            #endregion

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 69);
            panel_Menu.Controls.Add(leftBorderBtn);

            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        public Menu_Principal()
        {
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

            //List<E_Permiso> ListaPermisos = new N_Permisos().listar(usuarioActual.IdUsuario);

            //foreach (IconButton ButtonMenu in panel_Menu.Controls)
            //{

            //    bool encontrado = ListaPermisos.Any(m => m.NombreMenu == ButtonMenu.Name);

            //    if(encontrado == false)
            //    {
            //        ButtonMenu.Visible = false;
            //    }

            //}

            lbl_Usuario.Text = usuarioActual.NombreCompleto;
           
        }




        //Methods
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                //Button

                currentBtn = (IconButton)senderBtn;
                
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Formulario hijo actual

                iconPictureBox_Formulario_actual.IconChar = currentBtn.IconChar;
                iconPictureBox_Formulario_actual.IconColor = color;
            }
            

        }


        //Abrir formulario hijo

        public void Abrir_Formulario_Hijo(Form form_Hijo)
        {

            //open only form
            if (Formulario_hijo_actual != null)
            {
                Formulario_hijo_actual.Close();
            }
            Formulario_hijo_actual = form_Hijo;
            //End
            form_Hijo.TopLevel = false;
            form_Hijo.FormBorderStyle = FormBorderStyle.None;
            form_Hijo.Dock = DockStyle.Fill;
            panel_Escritorio.Controls.Add(form_Hijo);
            panel_Escritorio.Tag = form_Hijo;
            form_Hijo.BringToFront();
            form_Hijo.Show();
            lbl_Titulo_Formulario.Text = form_Hijo.Text;


        }

    

        private void btn_Area_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new Area());

            #region Desabilitar_Diseño

            
            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;


            
            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Transferencia.ForeColor = System.Drawing.Color.White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion

        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new Categoria());

            #region Desabilitar_Diseño

            
            btn_Area.ForeColor = System.Drawing.Color.White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;


            
            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Transferencia.ForeColor = System.Drawing.Color.White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion
        }

        private void btn_Articulo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new Articulo());


            #region Desabilitar_Diseño

           
            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;


           
            btn_Area.ForeColor = System.Drawing.Color.  White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Transferencia.ForeColor = System.Drawing.Color. White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;

            
            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;

           
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion           
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new Proveedor());

            #region Desabilitar_Diseño

   
            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;



            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;


            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;


            btn_Transferencia.ForeColor = System.Drawing.Color.White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;


            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;


      
            btn_Area.ForeColor = System.Drawing.Color.White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion 
        }

        private void btn_Responsable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new Responsable());

            #region Desabilitar_Diseño


            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;


  
            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;

     
            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;

   
            btn_Transferencia.ForeColor = System.Drawing.Color.White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;

      
            btn_Area.ForeColor = System.Drawing.Color.White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;

     
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion

        }

        private void btn_Transferencia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new Transferencia());

            #region Desabilitar_Diseño

          
            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;


       
            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;

        
            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;

        
            btn_Area.ForeColor = System.Drawing.Color.White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;

       
            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;

         
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion

        }

        private void btn_Detalle_transferencia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, System.Drawing.Color.FromArgb(250, 250, 250));

            Abrir_Formulario_Hijo(new DetalleTransferencia());

            #region Desabilitar_Diseño

          
            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;


          
            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;

          
            btn_Area.ForeColor = System.Drawing.Color.White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;

         
            btn_Transferencia.ForeColor = System.Drawing.Color.White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;

           
            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;

          
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion

        }

        private void btn_home_Click(object sender, EventArgs e)
        {         
            Formulario_hijo_actual.Close();

            Reset();
        }

        private void Reset()
        {
            
            leftBorderBtn.Visible = false;
            iconPictureBox_Formulario_actual.IconChar = IconChar.Home;
            iconPictureBox_Formulario_actual.IconColor = System.Drawing.Color.White;

            #region Desabilitar_Diseño

           
            btn_Categoria.ForeColor = System.Drawing.Color.White;
            btn_Categoria.TextAlign = ContentAlignment.MiddleCenter;
            btn_Categoria.IconColor = System.Drawing.Color.White;
            btn_Categoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Categoria.ImageAlign = ContentAlignment.MiddleLeft;


            
            btn_Articulo.ForeColor = System.Drawing.Color.White;
            btn_Articulo.TextAlign = ContentAlignment.MiddleCenter;
            btn_Articulo.IconColor = System.Drawing.Color.White;
            btn_Articulo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Articulo.ImageAlign = ContentAlignment.MiddleLeft;

         
            btn_Area.ForeColor = System.Drawing.Color.White;
            btn_Area.TextAlign = ContentAlignment.MiddleCenter;
            btn_Area.IconColor = System.Drawing.Color.White;
            btn_Area.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Area.ImageAlign = ContentAlignment.MiddleLeft;

        
            btn_Transferencia.ForeColor = System.Drawing.Color.White;
            btn_Transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Transferencia.IconColor = System.Drawing.Color.White;
            btn_Transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Transferencia.ImageAlign = ContentAlignment.MiddleLeft;

        
            btn_Detalle_transferencia.ForeColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextAlign = ContentAlignment.MiddleCenter;
            btn_Detalle_transferencia.IconColor = System.Drawing.Color.White;
            btn_Detalle_transferencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Detalle_transferencia.ImageAlign = ContentAlignment.MiddleLeft;

          
            btn_Responsable.ForeColor = System.Drawing.Color.White;
            btn_Responsable.TextAlign = ContentAlignment.MiddleCenter;
            btn_Responsable.IconColor = System.Drawing.Color.White;
            btn_Responsable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Responsable.ImageAlign = ContentAlignment.MiddleLeft;

    
            btn_Proveedor.ForeColor = System.Drawing.Color.White;
            btn_Proveedor.TextAlign = ContentAlignment.MiddleCenter;
            btn_Proveedor.IconColor = System.Drawing.Color.White;
            btn_Proveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Proveedor.ImageAlign = ContentAlignment.MiddleLeft;
            #endregion

            lbl_Titulo_Formulario.Text = "HOME";

        }

        //Arrastrar formulario

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel_Title_Bar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void iconPictureBox_Serrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox_Maximizar_Click(object sender, EventArgs e)
        {

            if(WindowState  == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else { WindowState = FormWindowState.Normal; }
        }

        private void iconPictureBox_Minimizar_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        private void timer_Hora_Fecha_Tick(object sender, EventArgs e)
        {

            lbl_Hora.Text = DateTime.Now.ToLongTimeString();

            lbl_fecha.Text = DateTime.Now.ToLongDateString();



        }

        #region No necesario
        private void panel_Sombra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Title_Bar_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-8I8DIUV;Database=Gestíón_Inventario;User Id=sa;Password=2308;";
            string backupDirectory = @"C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup\"; // Cambia esto al directorio donde deseas guardar la copia de seguridad
            string backupFileName = $"Backup_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.bak";
            string backupPath = System.IO.Path.Combine(backupDirectory, backupFileName);

            string backupQuery = $"BACKUP DATABASE [Gestíón_Inventario] TO DISK = '{backupPath}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Copia de seguridad realizada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la copia de seguridad: {ex.Message}");
                }
            }
        }
    }
}
