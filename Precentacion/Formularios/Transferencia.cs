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
    public partial class Transferencia : Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }


        #region Mis_Variable

        int nEstado_Guardado = 1;
        int vCodigo = 0;
        private int vCodigo_pr;

        #endregion


        #region "MIS METODOS"

        private void Limpiar_Texto()
        {
            txt_Codigo.Text = "";
            txt_Almacen_Origen.Texts = "";
            cmb_Almacen_Destino_Area.Text = "";
            cmb_Responsable.Text = "";
            cmb_Proveedor.Text = "";

        }

        private void Estado_Texto(bool lEstado)
        {
            txt_Codigo.Enabled = lEstado;
            txt_Almacen_Origen.Enabled = lEstado;
            cmb_Almacen_Destino_Area.Enabled = lEstado;
            cmb_Responsable.Enabled = lEstado;
            cmb_Proveedor.Enabled = lEstado;
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
            dgv_Transferencia.Columns[0].Visible = false;
            dgv_Transferencia.Columns[1].Width = 120;
            dgv_Transferencia.Columns[1].HeaderText = " Codigo";
            dgv_Transferencia.Columns[2].Width = 280;
            dgv_Transferencia.Columns[2].HeaderText = "Areá";
            dgv_Transferencia.Columns[3].Width = 280;
            dgv_Transferencia.Columns[3].HeaderText = "Responsable";
            dgv_Transferencia.Columns[4].Width = 280;
            dgv_Transferencia.Columns[4].HeaderText = "Proveedor";
            dgv_Transferencia.Columns[5].Width = 280;
            dgv_Transferencia.Columns[5].HeaderText = "Almacen Origen";
            dgv_Transferencia.Columns[6].Width = 280;
            dgv_Transferencia.Columns[6].HeaderText = "Almacen Destino";            
            dgv_Transferencia.Columns[7].Width = 240;
            dgv_Transferencia.Columns[7].HeaderText = "Fecha";
            dgv_Transferencia.Columns[8].Width = 230;
            dgv_Transferencia.Columns[8].HeaderText = "Usuario";
            dgv_Transferencia.Columns[9].Visible = false;
            dgv_Transferencia.Columns[10].Visible = false;
            dgv_Transferencia.Columns[11].Visible = false;


        }

        private void Listado_Transferencia(string cTexto)
        {

            D_Transferencia transferencia = new D_Transferencia();

            dgv_Transferencia.DataSource = transferencia.Listado_Tra(cTexto);

            this.Formato_pr();

        }
        private void Cargar_Proveedor()
        {

            D_Proveedor proveedor = new D_Proveedor();

            cmb_Proveedor.DataSource = proveedor.Listado_Pr("%");
            cmb_Proveedor.ValueMember = "Id_Proveedor";
            cmb_Proveedor.DisplayMember = "Nombre_Pr";
        }

        private void Cargar_Responsable()
        {

            D_Responsable responsable = new D_Responsable();

            cmb_Responsable.DataSource = responsable.Listado_Re("%");
            cmb_Responsable.ValueMember = "Id_Responsable";
            cmb_Responsable.DisplayMember = "Nombre_Re";
        }

        private void Cargar_Area()
        {

            D_Area area = new D_Area();

            cmb_Almacen_Destino_Area.DataSource = area.Listado_Ar("%");
            cmb_Almacen_Destino_Area.ValueMember = "Id_Area";
            cmb_Almacen_Destino_Area.DisplayMember = "Nombre_Are";
        }

        private void Selecciona_Item_Transferencia()
        {



            if (string.IsNullOrEmpty(Convert.ToString(dgv_Transferencia.CurrentRow.Cells["Id_Transferencia"].Value)))
            {

                MessageBox.Show("No se tiene informacion para Visualizar",
                                 "Aviso de sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
            else
            {

                this.vCodigo = Convert.ToInt32(dgv_Transferencia.CurrentRow.Cells["Id_Transferencia"].Value);
                txt_Codigo.Text = Convert.ToString(dgv_Transferencia.CurrentRow.Cells["Codigo_Transferencia"].Value);               
                cmb_Responsable.Text = Convert.ToString(dgv_Transferencia.CurrentRow.Cells["Nombre_Re"].Value);
                cmb_Proveedor.Text = Convert.ToString(dgv_Transferencia.CurrentRow.Cells["Nombre_Pr"].Value);
                txt_Almacen_Origen.Text = Convert.ToString(dgv_Transferencia.CurrentRow.Cells["Almacen_Origen"].Value);
                cmb_Almacen_Destino_Area.Text = Convert.ToString(dgv_Transferencia.CurrentRow.Cells["Almacen_Destino"].Value);

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
            txt_Codigo.Select();

            btn_nuevo.Visible = false;
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {
            this.Cargar_Area();

            this.Cargar_Responsable();

            this.Cargar_Proveedor();

            this.Listado_Transferencia("%");

            this.Estado_Botones(true);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            if (txt_Codigo.Texts == string.Empty || 
                txt_Almacen_Origen.Texts == string.Empty  ||
                cmb_Almacen_Destino_Area.Text == string.Empty ||
                cmb_Proveedor.Text == string.Empty ||
                cmb_Responsable.Text == string.Empty)//validar que todos los datos estan correctos
            {

                MessageBox.Show("Falta ingresar datos requeridos",
                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                string Rpsta = "";

                E_Transferencia transferencia = new E_Transferencia();

                transferencia.Id_Trasnferencia = this.vCodigo_pr;
                transferencia.Codigo_Transferencia = Convert.ToInt32(txt_Codigo.Texts);
                transferencia.Id_Area = Convert.ToInt32(cmb_Almacen_Destino_Area.SelectedValue);
                transferencia.Id_Responsable = Convert.ToInt32(cmb_Responsable.SelectedValue);
                transferencia.Id_Proveedor = Convert.ToInt32(cmb_Proveedor.SelectedValue);
                transferencia.Almacen_Origen = txt_Almacen_Origen.Texts;
                transferencia.Almacen_Destino = cmb_Almacen_Destino_Area.Text;


                D_Transferencia d_Transferencia = new D_Transferencia();

                Rpsta = d_Transferencia.Guardar_Transferencia(this.nEstado_Guardado, transferencia);

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

                this.Listado_Transferencia("%");

            }

        }

        private void dgv_Transferencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Transferencia();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.nEstado_Guardado = 2; // Actualizar Registro
            this.Estado_Texto(true);
            this.Estado_Botones(false);
            cmb_Almacen_Destino_Area.Select();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_Transferencia(txt_Buscar.Texts);
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
                D_Transferencia d_Transferencia = new D_Transferencia();
                respuesta = d_Transferencia.Activo_Tra(vCodigo, false);


                if (respuesta.Equals("OK"))
                {

                    this.Listado_Transferencia("%");
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

        #region No necesario

        private void dñ_TextBox1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Transferencia oFrm_Rpt = new Frm_Reporte_Transferencia();

            oFrm_Rpt.Width = 1350;
            oFrm_Rpt.Height = 806;

            oFrm_Rpt.Show();

            oFrm_Rpt.txt_filtro.Texts = txt_Buscar.Texts;
        }


        
    }
}
