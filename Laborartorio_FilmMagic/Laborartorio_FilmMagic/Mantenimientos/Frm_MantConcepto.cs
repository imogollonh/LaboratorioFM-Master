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
using Capa_Logica;
using Laborartorio_FilmMagic.Consultas;


namespace Laborartorio_FilmMagic
{
    public partial class Mnt_Concepto : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Mnt_Concepto()
        {
            InitializeComponent();

            scampo = logic.siguiente("conceptos", "pkidconcepto");
            bloqueartxt();
            Txt_Cod.Text = scampo;
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
            txt_Descripcion.Enabled = false;
            txt_Valor.Enabled = false;
            txt_TipoOp.Enabled = false;
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
            txt_Descripcion.Enabled = true;
            txt_Valor.Enabled = true;
            txt_TipoOp.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Descripcion.Enabled = false;
            txt_Valor.Enabled = false;
            txt_TipoOp.Enabled = false;
            Txt_Cod.Text = "";
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            txt_Valor.Text = "";
            txt_TipoOp.Text = "";

            scampo = logic.siguiente("conceptos", "pkidconcepto");
            Txt_Cod.Text = scampo;

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarConcepto(Txt_Cod.Text, txt_Nombre.Text, txt_Descripcion.Text, txt_Valor.Text,txt_TipoOp.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarConcepto(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConcepto concep = new Frm_consultaConcepto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_Nombre.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_Descripcion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_Valor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                txt_TipoOp.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[4].Value.ToString();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarConcepto(Txt_Cod.Text, txt_Nombre.Text, txt_Descripcion.Text, txt_Valor.Text,txt_TipoOp.Text);
            
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Mnt_Concepto_Load(object sender, EventArgs e)
        {

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
    }
}
