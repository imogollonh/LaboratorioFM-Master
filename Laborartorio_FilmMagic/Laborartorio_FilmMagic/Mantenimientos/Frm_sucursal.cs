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
    public partial class Frm_sucursal : Form
    {
        Logica logic = new Logica();
        public Frm_sucursal()
        {
            InitializeComponent();
            bloqueartxt();
            Txt_Cod.Text = logic.siguiente("sucursal", "pkidsucursal");
        }

        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            Txt_precio.Text = "";
            Txt_telefono.Text = "";
            Cbo_estado.Text = "";
        }
        public void bloqueartxt()
        {

            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_precio.Enabled = false;
            Cbo_estado.Enabled = false;
            Cbo_estado.Enabled = false;
        }
        public void desbloqueartxt()
        {
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_precio.Enabled = true;
            Cbo_estado.Enabled = true;
            Cbo_estado.Enabled = true;
        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarsucursal(Txt_Cod.Text, Txt_nombre.Text, Txt_precio.Text, Txt_telefono.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados.");
            limpiar();
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
            OdbcDataReader cita = logic.insertarsucursal(Txt_Cod.Text, Txt_nombre.Text, Txt_precio.Text, Txt_telefono.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarsucursal(Txt_Cod.Text);
            MessageBox.Show("Datos eliminados.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultasucursal concep = new Frm_consultasucursal();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Cod.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_precio.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_telefono.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                     Cells[4].Value.ToString();

            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
