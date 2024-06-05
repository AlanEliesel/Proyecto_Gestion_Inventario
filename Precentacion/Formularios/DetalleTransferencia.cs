using Datos;
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
using Negocio;
using Precentacion.Formularios.Reportes;

namespace Precentacion.Formularios
{
    public partial class DetalleTransferencia : Form
    {
        public DetalleTransferencia()
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

            cmb_Transferencia.Text = "";
            cmb_Articulo.Text = "";
            txt_Cantidad.Texts = "";

        }

        private void Estado_Texto(bool lEstado)
        {
            cmb_Transferencia.Enabled = lEstado;
            cmb_Articulo.Enabled = lEstado;
            txt_Cantidad.Enabled = lEstado;
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

            dgv_Detalle_Transferencia.Columns[0].Visible = false;
            dgv_Detalle_Transferencia.Columns[1].Visible = false;
            dgv_Detalle_Transferencia.Columns[2].Width = 120;
            dgv_Detalle_Transferencia.Columns[2].HeaderText = "Codigo";            
            dgv_Detalle_Transferencia.Columns[3].Width = 140;
            dgv_Detalle_Transferencia.Columns[3].HeaderText = "Areá";
            dgv_Detalle_Transferencia.Columns[4].Width = 180;
            dgv_Detalle_Transferencia.Columns[4].HeaderText = "Responsable";
            dgv_Detalle_Transferencia.Columns[5].Width = 180;
            dgv_Detalle_Transferencia.Columns[5].HeaderText = "Proveedor";
            dgv_Detalle_Transferencia.Columns[6].Width = 290;
            dgv_Detalle_Transferencia.Columns[6].HeaderText = "Almacen Origen";
            dgv_Detalle_Transferencia.Columns[7].Width = 290;
            dgv_Detalle_Transferencia.Columns[7].HeaderText = "Almacen Destino";
            dgv_Detalle_Transferencia.Columns[8].Width = 200;
            dgv_Detalle_Transferencia.Columns[8].HeaderText = "Fecha";
            dgv_Detalle_Transferencia.Columns[9].Width = 230;
            dgv_Detalle_Transferencia.Columns[9].HeaderText = "Usuario";
            dgv_Detalle_Transferencia.Columns[10].Visible = false;
            dgv_Detalle_Transferencia.Columns[11].Width = 230;
            dgv_Detalle_Transferencia.Columns[11].HeaderText = "Articulo";
            dgv_Detalle_Transferencia.Columns[12].Width = 250;
            dgv_Detalle_Transferencia.Columns[12].HeaderText = "Descripción";
            dgv_Detalle_Transferencia.Columns[13].Width = 220;
            dgv_Detalle_Transferencia.Columns[13].HeaderText = "Categoria";
            dgv_Detalle_Transferencia.Columns[14].Width = 170;
            dgv_Detalle_Transferencia.Columns[14].HeaderText = "Stock";
            dgv_Detalle_Transferencia.Columns[15].Width = 190;
            dgv_Detalle_Transferencia.Columns[15].HeaderText = "Precio";
            dgv_Detalle_Transferencia.Columns[16].Width = 190;
            dgv_Detalle_Transferencia.Columns[16].HeaderText = "Cantidad";
            dgv_Detalle_Transferencia.Columns[17].Width = 230;
            dgv_Detalle_Transferencia.Columns[17].HeaderText = "Usuario";
            dgv_Detalle_Transferencia.Columns[18].Width = 200;
            dgv_Detalle_Transferencia.Columns[18].HeaderText = "Fecha";

        }

        private void Listado_Detalle_Transferencia(string cTexto)
        {

            D_Detalle_Transferencia detalle_Transferencia = new D_Detalle_Transferencia();

            dgv_Detalle_Transferencia.DataSource = detalle_Transferencia.Listado_Deta_Tra(cTexto);

            this.Formato_pr();

        }
        private void Cargar_Transferencia()
        {

            D_Transferencia transferencia = new D_Transferencia();

            cmb_Transferencia.DataSource = transferencia.Listado_Tra("%");
            cmb_Transferencia.ValueMember = "Id_Transferencia";
            cmb_Transferencia.DisplayMember = "Codigo_Transferencia";
        }

        private void Cargar_Articulo()
        {

            D_Articulo articulo = new D_Articulo();

            cmb_Articulo.DataSource = articulo.Listado_A("%");
            cmb_Articulo.ValueMember = "Id_Articulos";
            cmb_Articulo.DisplayMember = "Nombre_Ar";
        }

        private void Selecciona_Item_Detalle_Transferencia()
        {



            if (string.IsNullOrEmpty(Convert.ToString(dgv_Detalle_Transferencia.CurrentRow.Cells["Id_Detalle_Transferencia"].Value)))
            {

                MessageBox.Show("No se tiene informacion para Visualizar",
                                 "Aviso de sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
            else
            {

                this.vCodigo = Convert.ToInt32(dgv_Detalle_Transferencia.CurrentRow.Cells["Id_Detalle_Transferencia"].Value);
                cmb_Transferencia.Text = Convert.ToString(dgv_Detalle_Transferencia.CurrentRow.Cells["Codigo_Transferencia"].Value);
                cmb_Articulo.Text = Convert.ToString(dgv_Detalle_Transferencia.CurrentRow.Cells["Nombre_Ar"].Value);
                txt_Cantidad.Text = Convert.ToString(dgv_Detalle_Transferencia.CurrentRow.Cells["Cantidad_trans"].Value);

            }

        }




        #endregion

        private void form_Detalle_Transferencia_Load(object sender, EventArgs e)
        {

            this.Cargar_Transferencia();

            this.Cargar_Articulo();

            this.Listado_Detalle_Transferencia("%");

            this.Estado_Botones(true);

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            if (cmb_Transferencia.Text == string.Empty ||
                cmb_Articulo.Text == string.Empty ||
                txt_Cantidad.Texts == string.Empty)//validar que todos los datos estan correctos
            {

                MessageBox.Show("Falta ingresar datos requeridos (*)",
                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else// guardar los datos
            {

                string Rpsta = "";

                E_Detalle_Transferencia detalle_Transferencia = new E_Detalle_Transferencia();

                detalle_Transferencia.Id_Detalle_Transferencia = this.vCodigo_pr;
                detalle_Transferencia.Id_Trasnferencia = Convert.ToInt32(cmb_Transferencia.SelectedValue);
                detalle_Transferencia.Id_Articulos = Convert.ToInt32(cmb_Articulo.SelectedValue);
                detalle_Transferencia.Cantidad_trans = Convert.ToInt32(txt_Cantidad.Texts);


                D_Detalle_Transferencia d_detalle_Transferencia = new D_Detalle_Transferencia();

                Rpsta = d_detalle_Transferencia.Guardar_Deta_Tra(this.nEstado_Guardado, detalle_Transferencia);

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

                this.Listado_Detalle_Transferencia("%");

            }
        }

        private void dgv_Detalle_Transferencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Detalle_Transferencia();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.nEstado_Guardado = 2; // Actualizar Registro
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            cmb_Transferencia.Select();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_Detalle_Transferencia(txt_Buscar.Texts);
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

                E_Detalle_Transferencia e_Detalle_Transferencia = new E_Detalle_Transferencia();
                e_Detalle_Transferencia.Id_Trasnferencia = Convert.ToInt32(cmb_Transferencia.SelectedValue);
                e_Detalle_Transferencia.Id_Articulos = Convert.ToInt32(cmb_Articulo.SelectedValue);
                e_Detalle_Transferencia.Cantidad_trans = Convert.ToDecimal(txt_Cantidad.Texts);

                string respuesta = "";
                D_Detalle_Transferencia detalle_Transferencia = new D_Detalle_Transferencia();
                respuesta = detalle_Transferencia.Activo_Deta_Tra(vCodigo, false,e_Detalle_Transferencia.Id_Articulos,e_Detalle_Transferencia.Cantidad_trans);


                if (respuesta.Equals("OK"))
                {

                    this.Listado_Detalle_Transferencia("%");
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.nEstado_Guardado = 1;// Nuevo Registro
            this.vCodigo = 0;
            this.Limpiar_Texto();
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            cmb_Transferencia.Select();

            btn_nuevo.Visible = false;
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Detalle_Transferencia oFrm_Rpt = new Frm_Reporte_Detalle_Transferencia();

            oFrm_Rpt.Width = 1350;
            oFrm_Rpt.Height = 806;

            oFrm_Rpt.Show();

            oFrm_Rpt.txt_filtro.Texts = txt_Buscar.Texts;
        }
    }
}
