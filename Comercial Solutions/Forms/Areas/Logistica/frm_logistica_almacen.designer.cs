namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_logistica_almacen
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.lst_busqueda = new System.Windows.Forms.ListBox();
            this.cmb_busqueda = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_estados = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprofundidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtalto = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_municipio = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.cmb_medida = new System.Windows.Forms.ComboBox();
            this.cmb_ambiente = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Comercial_Solutions.Properties.Resources.back;
            this.pictureBox6.Location = new System.Drawing.Point(12, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_busqueda);
            this.panel2.Controls.Add(this.lst_busqueda);
            this.panel2.Controls.Add(this.cmb_busqueda);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txtbusqueda);
            this.panel2.Location = new System.Drawing.Point(485, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 434);
            this.panel2.TabIndex = 17;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.Location = new System.Drawing.Point(27, 38);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(221, 21);
            this.lbl_busqueda.TabIndex = 6;
            // 
            // lst_busqueda
            // 
            this.lst_busqueda.BackColor = System.Drawing.SystemColors.Control;
            this.lst_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_busqueda.FormattingEnabled = true;
            this.lst_busqueda.Location = new System.Drawing.Point(29, 65);
            this.lst_busqueda.Name = "lst_busqueda";
            this.lst_busqueda.Size = new System.Drawing.Size(219, 65);
            this.lst_busqueda.TabIndex = 5;
            this.lst_busqueda.Visible = false;
            this.lst_busqueda.DoubleClick += new System.EventHandler(this.lst_busqueda_DoubleClick);
            // 
            // cmb_busqueda
            // 
            this.cmb_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_busqueda.FormattingEnabled = true;
            this.cmb_busqueda.Items.AddRange(new object[] {
            "Ambiente",
            "Nombre"});
            this.cmb_busqueda.Location = new System.Drawing.Point(29, 14);
            this.cmb_busqueda.Name = "cmb_busqueda";
            this.cmb_busqueda.Size = new System.Drawing.Size(89, 21);
            this.cmb_busqueda.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(3, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbusqueda.Location = new System.Drawing.Point(130, 15);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(118, 20);
            this.txtbusqueda.TabIndex = 3;
            this.txtbusqueda.Click += new System.EventHandler(this.txtbusqueda_Click);
            this.txtbusqueda.DoubleClick += new System.EventHandler(this.txtbusqueda_DoubleClick);
            this.txtbusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Comercial_Solutions.Properties.Resources.add;
            this.pictureBox5.Location = new System.Drawing.Point(12, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(181, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Almacenes";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.pictureBox3.Location = new System.Drawing.Point(121, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(67, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmb_estados);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtprofundidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtancho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtalto);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_municipio);
            this.panel1.Controls.Add(this.lbl_departamento);
            this.panel1.Controls.Add(this.cmb_medida);
            this.panel1.Controls.Add(this.cmb_ambiente);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 307);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado de los almacenes";
            // 
            // cmb_estados
            // 
            this.cmb_estados.FormattingEnabled = true;
            this.cmb_estados.Location = new System.Drawing.Point(155, 122);
            this.cmb_estados.Name = "cmb_estados";
            this.cmb_estados.Size = new System.Drawing.Size(64, 21);
            this.cmb_estados.Sorted = true;
            this.cmb_estados.TabIndex = 15;
            this.cmb_estados.SelectedIndexChanged += new System.EventHandler(this.cmb_estados_SelectedIndexChanged);
            this.cmb_estados.SelectionChangeCommitted += new System.EventHandler(this.cmb_estados_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(449, 140);
            this.dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fondo";
            // 
            // txtprofundidad
            // 
            this.txtprofundidad.Location = new System.Drawing.Point(92, 67);
            this.txtprofundidad.Name = "txtprofundidad";
            this.txtprofundidad.Size = new System.Drawing.Size(64, 20);
            this.txtprofundidad.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtancho
            // 
            this.txtancho.Location = new System.Drawing.Point(340, 41);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(55, 20);
            this.txtancho.TabIndex = 10;
            this.txtancho.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ancho";
            // 
            // txtalto
            // 
            this.txtalto.Location = new System.Drawing.Point(193, 40);
            this.txtalto.Name = "txtalto";
            this.txtalto.Size = new System.Drawing.Size(55, 20);
            this.txtalto.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(92, 14);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(156, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // lbl_municipio
            // 
            this.lbl_municipio.AutoSize = true;
            this.lbl_municipio.Location = new System.Drawing.Point(15, 44);
            this.lbl_municipio.Name = "lbl_municipio";
            this.lbl_municipio.Size = new System.Drawing.Size(42, 13);
            this.lbl_municipio.TabIndex = 3;
            this.lbl_municipio.Text = "Medida";
            this.lbl_municipio.Click += new System.EventHandler(this.lbl_municipio_Click);
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(254, 17);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(67, 13);
            this.lbl_departamento.TabIndex = 2;
            this.lbl_departamento.Text = "Temperatura";
            // 
            // cmb_medida
            // 
            this.cmb_medida.FormattingEnabled = true;
            this.cmb_medida.Items.AddRange(new object[] {
            "Seleccione un municipio"});
            this.cmb_medida.Location = new System.Drawing.Point(92, 40);
            this.cmb_medida.Name = "cmb_medida";
            this.cmb_medida.Size = new System.Drawing.Size(64, 21);
            this.cmb_medida.TabIndex = 1;
            // 
            // cmb_ambiente
            // 
            this.cmb_ambiente.FormattingEnabled = true;
            this.cmb_ambiente.Location = new System.Drawing.Point(340, 14);
            this.cmb_ambiente.Name = "cmb_ambiente";
            this.cmb_ambiente.Size = new System.Drawing.Size(127, 21);
            this.cmb_ambiente.TabIndex = 0;
            // 
            // frm_logistica_almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 458);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_logistica_almacen";
            this.Text = "frm_logistica_almacen";
            this.Load += new System.EventHandler(this.frm_logistica_almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.ListBox lst_busqueda;
        private System.Windows.Forms.ComboBox cmb_busqueda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.ComboBox cmb_ambiente;
        private System.Windows.Forms.Label lbl_municipio;
        private System.Windows.Forms.ComboBox cmb_medida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprofundidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtalto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_estados;
        private System.Windows.Forms.ToolTip toolTip;

    }
}