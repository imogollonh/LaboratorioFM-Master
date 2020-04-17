using Capa_Logica;
using Laborartorio_FilmMagic.Consultas;
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

namespace Laborartorio_FilmMagic.Mantenimiento
{
    public partial class Frm_MantCliente : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_MantCliente()
        {
            InitializeComponent();
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "yyyy/MM/dd";
            scampo = logic.siguiente("cliente", "pkidcliente");
            Txt_Cod.Text = scampo;
            bloqueartxt();
        }
        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Membresia.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_Telefono.Enabled = false;
        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/

            Txt_Cod.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Direccion.Enabled = true;
            dtp_fecha.Enabled = true;
            txt_Telefono.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Membresia.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_Telefono.Enabled = false;
            Txt_Cod.Text = "";
            txt_Nombre.Text = "";
            txt_Telefono.Text = "";
            txt_Membresia.Text = "";
            txt_Direccion.Text = "";

            scampo = logic.siguiente("cliente", "pkidcliente");
            Txt_Cod.Text = scampo;


        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarCliente(Txt_Cod.Text, txt_Nombre.Text,txt_Direccion.Text,txt_Telefono.Text,txt_Membresia.Text);

            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarCliente(Txt_Cod.Text, txt_Nombre.Text,txt_Direccion.Text,txt_Telefono.Text,txt_Membresia.Text,dtp_fecha.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarCliente(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaCliente cliente = new Frm_consultaCliente();
            cliente.ShowDialog();

            if (cliente.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_Nombre.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_Direccion.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_Telefono.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                dtp_fecha.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[4].Value.ToString();
                txt_Membresia.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[5].Value.ToString();
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            Frm_consultaMembresia cliente = new Frm_consultaMembresia();
            cliente.ShowDialog();

            if (cliente.DialogResult == DialogResult.OK)
            {
                txt_Membresia.Text = cliente.Dgv_consulta.Rows[cliente.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }
    }
}
