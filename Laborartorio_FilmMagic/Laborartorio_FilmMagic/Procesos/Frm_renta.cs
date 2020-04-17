using Laborartorio_FilmMagic.Consulta;
using Laborartorio_FilmMagic.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborartorio_FilmMagic.Procesos
{
    public partial class Frm_renta : Form
    {
        public Frm_renta()
        {
            InitializeComponent();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            Frm_consultaMembresia memb = new Frm_consultaMembresia();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_consultasucursal concep = new Frm_consultasucursal();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                textBox1.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_consultaproducto concep = new Frm_consultaproducto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
