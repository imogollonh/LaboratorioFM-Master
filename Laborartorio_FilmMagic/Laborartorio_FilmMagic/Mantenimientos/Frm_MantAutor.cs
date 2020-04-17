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

namespace Laborartorio_FilmMagic.Mantenimientos
{
    public partial class Frm_MantAutor : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_MantAutor()
        {
            InitializeComponent();
            scampo = logic.siguiente("autor", "pkidautor");
            bloqueartxt();
            Txt_Cod.Text = scampo;
            Txt_nombre.Enabled = false;
        }

        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
        }

        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";

            scampo = logic.siguiente("autor", "pkidautor");
            Txt_Cod.Text = scampo;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader ejectuar = logic.modificarAutor(Txt_Cod.Text, Txt_nombre.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.insertarAutor(Txt_Cod.Text, Txt_nombre.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarAutor(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaAutor concep = new Frm_consultaAutor();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
            }
        }
    }
}
