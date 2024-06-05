using Datos.Conexion_Usuario;
using Entidades.Entidades_Login;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Precentacion.Formularios
{
    public partial class Login : Form
    {

        //Arrastrar formulario

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }



        private void btn_entrar_Click(object sender, EventArgs e)
        {


            List<E_Usuario> TEST = new D_Usuario().listar();

            E_Usuario e_Usuario = new N_Usuario().listar().Where(u => u.Documento == txt_Usuario.Texts && u.Clave == txt_Contraseña.Texts).FirstOrDefault();


            if (e_Usuario != null)
            {

                Menu_Principal menu_Principal = new Menu_Principal(e_Usuario);


                menu_Principal.Show();
                this.Hide();





            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender, EventArgs e)
        {
            txt_Contraseña.Texts = "";
            txt_Usuario.Texts = "";

            this.Show();
        }

        private void Btn_NoEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
