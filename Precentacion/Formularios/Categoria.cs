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
    public partial class Categoria : Form
    {
        public Categoria()
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

            dgv_Categoria.Columns[0].Width = 110;
            dgv_Categoria.Columns[0].HeaderText = " Id Categoria";
            dgv_Categoria.Columns[1].Width = 250;
            dgv_Categoria.Columns[1].HeaderText = "Nombre de la Categoria";
            dgv_Categoria.Columns[2].Width = 440;
            dgv_Categoria.Columns[2].HeaderText = "Descripción de la Categoria";

        }

        private void Listado_Categoria(string cTexto)
        {

            D_Categoria categoria = new D_Categoria();

            dgv_Categoria.DataSource = categoria.Listado_Ca(cTexto);

            this.Formato_pr();

        }

        private void Selecciona_Item_Categoria()
        {



            if (string.IsNullOrEmpty(Convert.ToString(dgv_Categoria.CurrentRow.Cells["Id_Categoria"].Value)))
            {

                MessageBox.Show("No se tiene informacion para Visualizar",
                                 "Aviso de sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
            else
            {

                this.vCodigo = Convert.ToInt32(dgv_Categoria.CurrentRow.Cells["Id_Categoria"].Value);
                txt_Nombre.Texts = Convert.ToString(dgv_Categoria.CurrentRow.Cells["Nombre_Ca"].Value);
                txt_Descripcion.Texts = Convert.ToString(dgv_Categoria.CurrentRow.Cells["Descripción_Ca"].Value);


            }

        }
        #endregion


        private void Categoria_Load(object sender, EventArgs e)
        {
            this.Listado_Categoria("%");

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

                E_Categoria oCategoria = new E_Categoria();

                oCategoria.Id_Categoria = this.vCodigo;
                oCategoria.Nombre_Ca = txt_Nombre.Texts;
                oCategoria.Descripción_Ca = txt_Descripcion.Texts;


                D_Categoria d_Categoria = new D_Categoria();

                Rpsta = d_Categoria.Guardar_Ca(this.nEstado_Guardado, oCategoria);

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

                this.Listado_Categoria("%");



            }
        }


        #region No Necesario
        private void dgv_Categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void dgv_Categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Categoria();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {


            this.nEstado_Guardado = 2; // Actualizar Registro
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            txt_Nombre.Select();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_Categoria(txt_Buscar.Texts);
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
                D_Categoria d_Categoria = new D_Categoria();
                respuesta = d_Categoria.Activo_Ca(vCodigo, false);


                if (respuesta.Equals("OK"))
                {

                    this.Listado_Categoria("%");
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            this.nEstado_Guardado = 1;// Nuevo Registro
            this.vCodigo = 0;
            this.Limpiar_Texto();
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            txt_Nombre.Select();
        }

        #region No necesario
        private void txt_Buscar_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Categoria oFrm_Rpt = new Frm_Reporte_Categoria();

            oFrm_Rpt.Width = 1350;
            oFrm_Rpt.Height = 806;

            oFrm_Rpt.Show();

            oFrm_Rpt.txt_filtro.Texts = txt_Buscar.Texts;
        }
    }
}
