using Capa_Logica;
using Laborartorio_FilmMagic.Consulta;
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
    public partial class Frm_productos : Form
    {
        Logica logic = new Logica();
        public Frm_productos()
        {
            InitializeComponent();
            bloqueartxt();
            Txt_Cod.Text = logic.siguiente("productos", "pkidproducto");
        }
        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            Txt_precio.Text = "";
            Txt_telefono.Text = "";
            Txt_tipoproducto.Text = "";
            Txt_idproveedor.Text = "";
            Txt_categoria.Text = "";
            Txt_idautor.Text = "";
            Cbo_estado.Text = "";
            Txt_Cod.Text = logic.siguiente("productos", "pkidproducto");
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
            Txt_precio.Enabled = false;
            Txt_telefono.Enabled = false;
            Txt_tipoproducto.Enabled = false;
            Txt_idproveedor.Enabled = false;
            Txt_categoria.Enabled = false;
            Txt_idautor.Enabled = false;
            Cbo_estado.Enabled = false;
        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_precio.Enabled = true;
            Txt_tipoproducto.Enabled = true;
            Cbo_estado.Enabled = true;
        }
    
        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarproductos(Txt_Cod.Text, Txt_nombre.Text, Txt_precio.Text, Txt_categoria.Text, Cbo_estado.Text, Txt_telefono.Text,Txt_idautor.Text,Txt_idproveedor.Text);
            MessageBox.Show("Datos modificados.");
            limpiar();
            bloqueartxt();
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
            OdbcDataReader cita = logic.insertarproducto(Txt_Cod.Text, Txt_nombre.Text, Txt_precio.Text, Txt_categoria.Text, Cbo_estado.Text, Txt_telefono.Text, Txt_idautor.Text, Txt_idproveedor.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
            Txt_Cod.Text = logic.siguiente("productos", "pkidproducto");
            bloqueartxt();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarproducto(Txt_Cod.Text);
            MessageBox.Show("Datos eliminados.");
            limpiar();
            bloqueartxt();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaproducto concep = new Frm_consultaproducto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Cod.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_precio.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_categoria.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                     Cells[4].Value.ToString();
                Txt_telefono.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                   Cells[5].Value.ToString();
                Txt_idautor.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[6].Value.ToString();
                Txt_idproveedor.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[7].Value.ToString();

            }
        }

        private void Btn_categoria_Click(object sender, EventArgs e)
        {

            Frm_consultaCategoria concep = new Frm_consultaCategoria();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_categoria.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void Btn_idtipo_Click(object sender, EventArgs e)
        {
            Frm_consultaTipoProducto concep = new Frm_consultaTipoProducto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_telefono.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void Btn_idautor_Click(object sender, EventArgs e)
        {
            Frm_consultaAutor concep = new Frm_consultaAutor();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_idautor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void Btn_idproveedor_Click(object sender, EventArgs e)
        {
            Frm_consultaproveedor concep = new Frm_consultaproveedor();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_idproveedor.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }
    }
}
