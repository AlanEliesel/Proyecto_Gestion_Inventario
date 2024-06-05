﻿using System;
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
    public partial class Responsable : Form
    {
        public Responsable()
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

            dgv_Responsable.Columns[0].Width = 130;
            dgv_Responsable.Columns[0].HeaderText = " Id Responsable";
            dgv_Responsable.Columns[1].Width = 310;
            dgv_Responsable.Columns[1].HeaderText = "Nombre del Responsable";
            dgv_Responsable.Columns[2].Width = 440;
            dgv_Responsable.Columns[2].HeaderText = "Descripción del Responsable";

        }

        private void Listado_Responsable(string cTexto)
        {

            D_Responsable responsable = new D_Responsable();

            dgv_Responsable.DataSource = responsable.Listado_Re(cTexto);

            this.Formato_pr();

        }

        private void Selecciona_Item_Responsable()
        {



            if (string.IsNullOrEmpty(Convert.ToString(dgv_Responsable.CurrentRow.Cells["Id_Responsable"].Value)))
            {

                MessageBox.Show("No se tiene informacion para Visualizar",
                                 "Aviso de sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);

            }
            else
            {

                this.vCodigo = Convert.ToInt32(dgv_Responsable.CurrentRow.Cells["Id_Responsable"].Value);
                txt_Nombre.Texts = Convert.ToString(dgv_Responsable.CurrentRow.Cells["Nombre_Re"].Value);
                txt_Descripcion.Texts = Convert.ToString(dgv_Responsable.CurrentRow.Cells["Descripción_Re"].Value);


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

        private void Responsable_Load(object sender, EventArgs e)
        {
            this.Listado_Responsable("%");

            this.Estado_Botones(true);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {



            if (txt_Nombre.Texts == string.Empty)//validar que todos los datos estan correctos
            {

                MessageBox.Show("Falta ingresar datos requeridos",
                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else// guardar los datos
            {

                string Rpsta = "";

                E_Responsable e_Responsable = new E_Responsable();

                e_Responsable.Id_Responsable = this.vCodigo;
                e_Responsable.Nombre_Re = txt_Nombre.Texts;
                e_Responsable.Descripción_Re = txt_Descripcion.Texts;


                D_Responsable d_Responsable = new D_Responsable();

                Rpsta = d_Responsable.Guardar_Re(this.nEstado_Guardado, e_Responsable);

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

                this.Listado_Responsable("%");


            }

        }

        private void dgv_Responsable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_Responsable();
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

            this.Listado_Responsable(txt_Buscar.Texts);

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
                D_Responsable d_responsable = new D_Responsable();
                respuesta = d_responsable.Activo_Re(vCodigo, false);


                if (respuesta.Equals("OK"))
                {

                    this.Listado_Responsable("%");
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
            Frm_Reporte_Responsable oFrm_Rpt = new Frm_Reporte_Responsable();

            oFrm_Rpt.Width = 1350;
            oFrm_Rpt.Height = 806;

            oFrm_Rpt.Show();

            oFrm_Rpt.txt_filtro.Texts = txt_Buscar.Texts;
        }
    }
}
