namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_Logistica_ruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Logistica_ruta));
            this.bt_confirmar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_TOTAL = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_Vactual = new System.Windows.Forms.DataGridView();
            this.id_disponibilidadvehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_uu = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_Ruta = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Vactual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Ruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.Location = new System.Drawing.Point(465, 130);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(75, 23);
            this.bt_confirmar.TabIndex = 12;
            this.bt_confirmar.Text = "Confirmar";
            this.bt_confirmar.UseVisualStyleBackColor = true;
            this.bt_confirmar.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 408);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rutas Pendientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lbl_TOTAL);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dt_Vactual);
            this.tabPage2.Controls.Add(this.bt_confirmar);
            this.tabPage2.Controls.Add(this.lbl_uu);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.lbl_ruta);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dt_Ruta);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle envio";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(42, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "TOTAL:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(297, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 13);
            this.textBox1.TabIndex = 16;
            // 
            // lbl_TOTAL
            // 
            this.lbl_TOTAL.Location = new System.Drawing.Point(424, 133);
            this.lbl_TOTAL.Name = "lbl_TOTAL";
            this.lbl_TOTAL.Size = new System.Drawing.Size(18, 22);
            this.lbl_TOTAL.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Disponibilidad vehiculos de la ruta";
            // 
            // dt_Vactual
            // 
            this.dt_Vactual.AllowUserToAddRows = false;
            this.dt_Vactual.AllowUserToDeleteRows = false;
            this.dt_Vactual.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dt_Vactual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_Vactual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Vactual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_disponibilidadvehiculo,
            this.Disponible});
            this.dt_Vactual.Location = new System.Drawing.Point(297, 226);
            this.dt_Vactual.Name = "dt_Vactual";
            this.dt_Vactual.RowHeadersVisible = false;
            this.dt_Vactual.Size = new System.Drawing.Size(243, 150);
            this.dt_Vactual.TabIndex = 17;
            // 
            // id_disponibilidadvehiculo
            // 
            this.id_disponibilidadvehiculo.HeaderText = "Vehiculo";
            this.id_disponibilidadvehiculo.Name = "id_disponibilidadvehiculo";
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Capacidad disponible";
            this.Disponible.Name = "Disponible";
            // 
            // lbl_uu
            // 
            this.lbl_uu.Location = new System.Drawing.Point(266, 86);
            this.lbl_uu.Name = "lbl_uu";
            this.lbl_uu.Size = new System.Drawing.Size(57, 16);
            this.lbl_uu.TabIndex = 15;
            this.lbl_uu.Text = "0";
            this.lbl_uu.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruta.ForeColor = System.Drawing.Color.Red;
            this.lbl_ruta.Location = new System.Drawing.Point(502, 193);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(38, 21);
            this.lbl_ruta.TabIndex = 12;
            this.lbl_ruta.Text = "0";
            this.lbl_ruta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Detalle de factura:";
            // 
            // dt_Ruta
            // 
            this.dt_Ruta.AllowUserToAddRows = false;
            this.dt_Ruta.AllowUserToDeleteRows = false;
            this.dt_Ruta.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dt_Ruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Ruta.Location = new System.Drawing.Point(6, 130);
            this.dt_Ruta.Name = "dt_Ruta";
            this.dt_Ruta.RowHeadersVisible = false;
            this.dt_Ruta.Size = new System.Drawing.Size(223, 90);
            this.dt_Ruta.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(495, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(47, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Codigo postal:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(266, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(143, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(109, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Municipio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamento:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(452, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(452, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destinatario:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 189);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(230, 162);
            this.dataGridView3.TabIndex = 16;
            this.dataGridView3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "No. Factura";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(31, 21);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(218, 20);
            this.txt_buscar.TabIndex = 8;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Detalle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbl_busqueda);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Location = new System.Drawing.Point(660, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 533);
            this.panel2.TabIndex = 17;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.Location = new System.Drawing.Point(28, 44);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(221, 21);
            this.lbl_busqueda.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(4, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Comercial_Solutions.Properties.Resources.add;
            this.pictureBox5.Location = new System.Drawing.Point(12, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(181, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Carga - Ruta";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.pictureBox3.Location = new System.Drawing.Point(121, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.pictureBox6.Location = new System.Drawing.Point(67, 66);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 50);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Comercial_Solutions.Properties.Resources.folder;
            this.pictureBox7.Location = new System.Drawing.Point(457, 96);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // frm_Logistica_ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 573);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Logistica_ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de rutas";
            this.Load += new System.EventHandler(this.frm_Logistica_ruta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Vactual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Ruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_confirmar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dt_Ruta;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_uu;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dt_Vactual;
        private System.Windows.Forms.Label lbl_TOTAL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_disponibilidadvehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}