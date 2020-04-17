namespace Laborartorio_FilmMagic.Procesos
{
    partial class Frm_renta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_renta));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtp_FechaC = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Lbl_cod = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_pedido = new System.Windows.Forms.DataGridView();
            this.codP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.gpb_datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lblTitutlo);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(2, 1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1028, 51);
            this.Pnl_nombreForm.TabIndex = 89;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(951, 8);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(916, 8);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutlo.ForeColor = System.Drawing.Color.White;
            this.lblTitutlo.Location = new System.Drawing.Point(20, 12);
            this.lblTitutlo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(68, 20);
            this.lblTitutlo.TabIndex = 0;
            this.lblTitutlo.Text = "RENTA";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(989, 8);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.label2);
            this.gpb_datos.Controls.Add(this.textBox2);
            this.gpb_datos.Controls.Add(this.button1);
            this.gpb_datos.Controls.Add(this.label1);
            this.gpb_datos.Controls.Add(this.textBox1);
            this.gpb_datos.Controls.Add(this.dtp_FechaC);
            this.gpb_datos.Controls.Add(this.dtp_fecha);
            this.gpb_datos.Controls.Add(this.lbl_Valor);
            this.gpb_datos.Controls.Add(this.lbl_Descripcion);
            this.gpb_datos.Controls.Add(this.Btn_seleccionar);
            this.gpb_datos.Controls.Add(this.Lbl_cod);
            this.gpb_datos.Controls.Add(this.Txt_Cod);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(48, 90);
            this.gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Size = new System.Drawing.Size(971, 176);
            this.gpb_datos.TabIndex = 95;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Encabezado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Total:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(603, 78);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 23);
            this.textBox2.TabIndex = 114;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(855, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 113;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "COD Sucursal:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(603, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 23);
            this.textBox1.TabIndex = 111;
            // 
            // dtp_FechaC
            // 
            this.dtp_FechaC.Location = new System.Drawing.Point(163, 121);
            this.dtp_FechaC.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_FechaC.Name = "dtp_FechaC";
            this.dtp_FechaC.Size = new System.Drawing.Size(232, 23);
            this.dtp_FechaC.TabIndex = 110;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(163, 75);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(232, 23);
            this.dtp_fecha.TabIndex = 109;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(20, 127);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(105, 17);
            this.lbl_Valor.TabIndex = 108;
            this.lbl_Valor.Text = "Fecha Entrega:";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(20, 81);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(102, 17);
            this.lbl_Descripcion.TabIndex = 107;
            this.lbl_Descripcion.Text = "Fecha Alquiler:";
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_seleccionar.FlatAppearance.BorderSize = 3;
            this.Btn_seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(399, 29);
            this.Btn_seleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(41, 33);
            this.Btn_seleccionar.TabIndex = 106;
            this.Btn_seleccionar.Text = "B";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Lbl_cod
            // 
            this.Lbl_cod.AutoSize = true;
            this.Lbl_cod.Location = new System.Drawing.Point(20, 34);
            this.Lbl_cod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cod.Name = "Lbl_cod";
            this.Lbl_cod.Size = new System.Drawing.Size(115, 17);
            this.Lbl_cod.TabIndex = 1;
            this.Lbl_cod.Text = "COD Membresia:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Enabled = false;
            this.Txt_Cod.Location = new System.Drawing.Point(163, 34);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(232, 23);
            this.Txt_Cod.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Dgv_pedido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 282);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(971, 352);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // Dgv_pedido
            // 
            this.Dgv_pedido.AllowUserToAddRows = false;
            this.Dgv_pedido.AllowUserToDeleteRows = false;
            this.Dgv_pedido.AllowUserToResizeColumns = false;
            this.Dgv_pedido.AllowUserToResizeRows = false;
            this.Dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codP,
            this.nombre,
            this.subtotal});
            this.Dgv_pedido.Location = new System.Drawing.Point(11, 36);
            this.Dgv_pedido.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_pedido.MultiSelect = false;
            this.Dgv_pedido.Name = "Dgv_pedido";
            this.Dgv_pedido.ReadOnly = true;
            this.Dgv_pedido.RowHeadersVisible = false;
            this.Dgv_pedido.RowHeadersWidth = 51;
            this.Dgv_pedido.RowTemplate.Height = 24;
            this.Dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_pedido.Size = new System.Drawing.Size(885, 286);
            this.Dgv_pedido.TabIndex = 81;
            // 
            // codP
            // 
            this.codP.HeaderText = "COD Producto";
            this.codP.Name = "codP";
            this.codP.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(848, 638);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 33);
            this.button2.TabIndex = 116;
            this.button2.Text = "RENTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(905, 137);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 70);
            this.button3.TabIndex = 116;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_renta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_renta";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lblTitutlo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.Label Lbl_cod;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtp_FechaC;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView Dgv_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}