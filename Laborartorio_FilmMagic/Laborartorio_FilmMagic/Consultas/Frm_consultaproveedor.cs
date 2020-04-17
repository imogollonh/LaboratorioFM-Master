using Capa_Logica;
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

namespace Laborartorio_FilmMagic.Consulta
{
    public partial class Frm_consultaproveedor : Form
    {
        Logica logic = new Logica();
        public Frm_consultaproveedor()
        {
            InitializeComponent();
            Dgv_consultaproveedor.Rows.Clear();
            MostrarConsulta();
        }
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultarproveedor();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaproveedor.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
            private void Btn_actualizar_Click(object sender, EventArgs e)
            {
            Dgv_consultaproveedor.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaproveedor.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Dgv_consultaproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pnl_nombreForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

