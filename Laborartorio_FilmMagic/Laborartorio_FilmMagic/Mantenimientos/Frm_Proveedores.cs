using Capa_Logica;
using Laborartorio_FilmMagic.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborartorio_FilmMagic.Mantenimientos
{
 
    public partial class Frm_Proveedores : Form
    {
        Logica logic = new Logica();
        public Frm_Proveedores()
        {
            InitializeComponent();
            bloqueartxt();
            Txt_Cod.Text = logic.siguiente("proveedor", "pkidproveedor");
        }

        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            Txt_direccion.Text = "";
            Txt_telefono.Text = "";
            Cbo_estado.Text = "";
            Txt_Cod.Text = logic.siguiente("proveedor", "pkidproveedor");
        }
        public void bloqueartxt()
        {

            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_direccion.Enabled = false;
            Cbo_estado.Enabled = false;
            Txt_telefono.Enabled = false;
        }
        public void desbloqueartxt()
        {
            Txt_telefono.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_direccion.Enabled = true;
            Cbo_estado.Enabled = true;
        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.insertarproveedor(Txt_Cod.Text, Txt_nombre.Text, Txt_direccion.Text,Txt_telefono.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
            Txt_Cod.Text = logic.siguiente("proveedor", "pkidproveedor");
            bloqueartxt();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarproveedor(Txt_Cod.Text, Txt_nombre.Text, Txt_direccion.Text, Txt_telefono.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados.");
            limpiar();
            bloqueartxt();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarproveedor(Txt_Cod.Text);
            MessageBox.Show("Datos eliminados.");
            limpiar();
            bloqueartxt();

        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaproveedor concep = new Frm_consultaproveedor();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Cod.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_direccion.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_telefono.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                     Cells[4].Value.ToString();

            }
        }
    }
}
