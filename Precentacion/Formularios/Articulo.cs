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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
        }

        #region Mis_Variable

        int nEstado_Guardado = 0;
        int vCodigo = 0;
        private int vCodigo_pr;

        #endregion


        #region "MIS METODOS"

        private void Limpiar_Texto()
        {

            txt_Nombre.Texts = "";
            txt_Descripcion.Texts = "";
            cmb_Categoria.Text = "";
            txt_Stock.Texts = "";
            txt_Precio.Texts = "";

        }

        private void Estado_Texto(bool lEstado)
        {
            txt_Stock.Enabled = lEstado;
            txt_Precio.Enabled = lEstado;
            txt_Nombre.Enabled = lEstado;
            txt_Descripcion.Enabled = lEstado;
            cmb_Categoria.Enabled = lEstado;
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

            dgv_Articulo.Columns[0].Visible = false;
            dgv_Articulo.Columns[1].Width = 180;
            dgv_Articulo.Columns[1].HeaderText = "Articulo";
            dgv_Articulo.Columns[2].Width = 200;
            dgv_Articulo.Columns[2].HeaderText = "Descripción";
            dgv_Articulo.Columns[3].Width = 220;
            dgv_Articulo.Columns[3].HeaderText = "Categoria";
            dgv_Articulo.Columns[4].Width = 130;
            dgv_Articulo.Columns[4].HeaderText = "Stock";
            dgv_Articulo.Columns[5].Width = 130;
            dgv_Articulo.Columns[5].HeaderText = "Precio";
            dgv_Articulo.Columns[6].Width = 220;
            dgv_Articulo.Columns[6].HeaderText = "Usuario";
            dgv_Articulo.Columns[7].Width = 200;
            dgv_Articulo.Columns[7].HeaderText = "Fecha";

            

        }

        private void Listado_Articulo(string cTexto)
        {

            D_Articulo articulo = new D_Articulo();

            dgv_Articulo.DataSource = articulo.Listado_A(cTexto);

            this.Formato_pr();

        }

        private void Cargar_Categorias()
        {

            D_Categoria Categorias = new D_Categoria();

            cmb_Categoria.DataSource = Categorias.Listado_Ca("%");
            cmb_Categoria.ValueMember = "Id_Categoria";
            cmb_Categoria.DisplayMember = "Nombre_Ca";
        }

        private void Selecciona_Item_Articulo()
        {



            if (string.IsNullOrEmpty(Convert.ToString(dgv_Articulo.CurrentRow.Cells["Id_Articulos"].Value)))
            {

                MessageBox.Show("No se tiene informacion para Visualizar",
                                 "Aviso de sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
            else
            {

                this.vCodigo = Convert.ToInt32(dgv_Articulo.CurrentRow.Cells["Id_Articulos"].Value);
                txt_Nombre.Texts = Convert.ToString(dgv_Articulo.CurrentRow.Cells["Nombre_Ar"].Value);
                txt_Descripcion.Texts = Convert.ToString(dgv_Articulo.CurrentRow.Cells["Descripción_Ar"].Value);
                cmb_Categoria.Text = Convert.ToString(dgv_Articulo.CurrentRow.Cells["Nombre_Ca"].Value);
                txt_Stock.Texts = Convert.ToString(dgv_Articulo.CurrentRow.Cells["Stock"].Value);
                txt_Precio.Texts = Convert.ToString(dgv_Articulo.CurrentRow.Cells["Precio"].Value);

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
            
            btn_nuevo.Visible = false;

        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            this.Cargar_Categorias();

            this.Listado_Articulo("%");

            this.Estado_Botones(true);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            if (txt_Nombre.Texts == string.Empty ||
                cmb_Categoria.Text == string.Empty ||
                txt_Stock.Texts == string.Empty ||
                txt_Precio.Texts == string.Empty)//validar que todos los datos estan correctos
            {

                MessageBox.Show("Falta ingresar datos requeridos (*)",
                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else// guardar los datos
            {

                string Rpsta = "";

                E_Articulo e_Articulo = new E_Articulo();

                e_Articulo.Id_Articulo = this.vCodigo_pr;
                e_Articulo.Nombre_Ar = txt_Nombre.Texts;
                e_Articulo.Descripción_Ar = txt_Descripcion.Texts;
                e_Articulo.Id_Categoria = Convert.ToInt32(cmb_Categoria.SelectedValue);
                e_Articulo.Stock = Convert.ToInt32(txt_Stock.Texts);
                e_Articulo.Precio = Convert.ToInt32(txt_Precio.Texts);


                D_Articulo Datos = new D_Articulo();

                Rpsta = Datos.Guardar_A(this.nEstado_Guardado, e_Articulo);

                if (Rpsta == "OK")
                {

                    MessageBox.Show("Los datos han sido guardados correctamente",
                                     "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*Le indicamos que imediatamente se realize la accion de actualizar que regrese
                      el codigo producto a un estado de 0 ( vCodigo_pr = 0 ) */

                    this.vCodigo_pr = 0;

                    this.Limpiar_Texto();
                    this.Estado_Texto(false);
                    this.Estado_Botones(true);
                    btn_nuevo.Visible = true;
                }

                this.Listado_Articulo("%");

            }
        }

        private void dgv_Articulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Articulo();
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

            this.Listado_Articulo(txt_Buscar.Texts);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Estado_Botones(true);
            this.Limpiar_Texto();

            btn_nuevo.Visible = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {


            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea eliminar el registro?", "Aviso del sistema",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {

                string respuesta = "";
                D_Articulo d_Articulo = new D_Articulo();
                respuesta = d_Articulo.Activo_A(vCodigo, false);


                if (respuesta.Equals("OK"))
                {

                    this.Listado_Articulo("%");
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

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Articulo oFrm_Rpt = new Frm_Reporte_Articulo();

            oFrm_Rpt.Width = 1350;
            oFrm_Rpt.Height = 806;

            oFrm_Rpt.Show();

            oFrm_Rpt.txt_filtro.Texts = txt_Buscar.Texts;
        }
    }
}
