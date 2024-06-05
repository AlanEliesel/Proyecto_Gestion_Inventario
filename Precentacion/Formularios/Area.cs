using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;
using Negocio;
using Precentacion.Formularios.Reportes;

namespace Precentacion.Formularios
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        #region Mis_Variable

        int nEstado_Guardado = 0;
        int vCodigo = 0;

        #endregion


        #region "MIS METODOS"

        private void Limpiar_Texto()
        {

            txt_Nombre.Texts = "";
            txt_Descripcion.Texts = "";

        }

        private void Estado_Texto(bool lEstado)
        {
            txt_Nombre.Enabled = lEstado;
            txt_Descripcion.Enabled = lEstado;
        }

        private void Estado_Botones(bool lEstado)
        {

            btn_cancelar.Visible = !lEstado;
            btn_Guardar.Visible = !lEstado;


            btn_nuevo.Enabled = lEstado;
            btn_actualizar.Enabled = lEstado;
            btn_eliminar.Enabled = lEstado;



            btn_buscar.Enabled = lEstado;
        }



        private void Formato_pr()
        {

            dgv_Area.Columns[0].Width = 210;
            dgv_Area.Columns[0].HeaderText = " Id Areá";
            dgv_Area.Columns[1].Width = 290;
            dgv_Area.Columns[1].HeaderText = "Nombre del Areá";
            dgv_Area.Columns[2].Width = 320;
            dgv_Area.Columns[2].HeaderText = "Descripción del Areá";

        }

        private void Listado_Area(string cTexto)
        {

            D_Area area = new D_Area();

            dgv_Area.DataSource = area.Listado_Ar(cTexto);

            this.Formato_pr();

        }

        private void Selecciona_Item_Area()
        {

            

            if (string.IsNullOrEmpty(Convert.ToString(dgv_Area.CurrentRow.Cells["Id_Area"].Value)))
            {

                MessageBox.Show("No se tiene informacion para Visualizar",
                                 "Aviso de sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
            else
            {

                this.vCodigo = Convert.ToInt32(dgv_Area.CurrentRow.Cells["Id_Area"].Value);
                txt_Nombre.Texts =  Convert.ToString(dgv_Area.CurrentRow.Cells["Nombre_Are"].Value);
                txt_Descripcion.Texts = Convert.ToString(dgv_Area.CurrentRow.Cells["Descripción_Are"].Value);


            }

        }
        #endregion








        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            this.nEstado_Guardado = 1;// Nuevo Registro
            this.vCodigo = 0;
            this.Limpiar_Texto();
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            txt_Nombre.Select();

        }

        private void Area_Load(object sender, EventArgs e)
        {
            this.Listado_Area("%");

            this.Estado_Botones(true);
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            if (txt_Nombre.Texts == string.Empty )//validar que todos los datos estan correctos
            {

                MessageBox.Show("Falta ingresar datos requeridos",
                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else// guardar los datos
            {

                string Rpsta = "";

                E_Area oArea = new E_Area();

                oArea.Id_Area = this.vCodigo;
                oArea.Nombre_Are = txt_Nombre.Texts;
                oArea.Descripción_Are = txt_Descripcion.Texts;


                D_Area d_Area = new D_Area();

                Rpsta = d_Area.Guardar_Ar(this.nEstado_Guardado, oArea);

                if (Rpsta == "OK")
                {

                    MessageBox.Show("Los datos han sido guardados correctamente",
                                     "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*Le indicamos que imediatamente se realize la accion de actualizar que regrese
                      el codigo producto a un estado de 0 ( vCodigo_pr = 0 ) */

                    this.vCodigo = 0;

                    this.Limpiar_Texto();
                    this.Estado_Texto(false);
                    this.Estado_Botones(true);
                }

                this.Listado_Area("%");


            }
        }



        private void dgv_Area_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Area();
        }






        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            this.nEstado_Guardado = 2; // Actualizar Registro
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            txt_Nombre.Select();

        }


            #region NoNecesario
        private void dñ_TextBox2_Load(object sender, EventArgs e)
        {

        }

        private void dñ_TextBox1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            this.Listado_Area(txt_Buscar.Texts);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Estado_Botones(true);
            this.Limpiar_Texto();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {


            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea eliminar el registro?", "Aviso del sistema",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {

                string respuesta = "";
                D_Area d_Area = new D_Area();
                respuesta = d_Area.Activo_Ar(vCodigo, false);


                if (respuesta.Equals("OK"))
                {

                    this.Listado_Area("%");
                    this.Limpiar_Texto();
                    vCodigo = 0;

                    MessageBox.Show("Registro eliminado", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                }

            }


        }

        #region Innecesario
        private void txt_Descripcion_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Area_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Buscar_Load(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Descripcion_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btn_Reporte_Click(object sender, EventArgs e)
        {

            Frm_Reporte_Area oFrm_Rpt = new Frm_Reporte_Area();

            oFrm_Rpt.Width = 1128;
            oFrm_Rpt.Height = 806;

            

            oFrm_Rpt.Show();

            oFrm_Rpt.txt_filtro.Texts = txt_Buscar.Texts;

        }
    }
}
