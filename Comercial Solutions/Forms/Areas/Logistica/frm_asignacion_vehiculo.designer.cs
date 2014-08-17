namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_asignacion_vehiculo
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
            this.cmb_vehiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ubicacion = new System.Windows.Forms.ComboBox();
            this.cmb_ruta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_VxR = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_rutas = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_usovehiculo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_VxR)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnl_rutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_vehiculos
            // 
            this.cmb_vehiculos.FormattingEnabled = true;
            this.cmb_vehiculos.Location = new System.Drawing.Point(87, 18);
            this.cmb_vehiculos.Name = "cmb_vehiculos";
            this.cmb_vehiculos.Size = new System.Drawing.Size(121, 21);
            this.cmb_vehiculos.TabIndex = 0;
            this.cmb_vehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnl_rutas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_ubicacion);
            this.groupBox1.Location = new System.Drawing.Point(20, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 110);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion de Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ubicacion:";
            // 
            // cmb_ubicacion
            // 
            this.cmb_ubicacion.FormattingEnabled = true;
            this.cmb_ubicacion.Location = new System.Drawing.Point(87, 29);
            this.cmb_ubicacion.Name = "cmb_ubicacion";
            this.cmb_ubicacion.Size = new System.Drawing.Size(121, 21);
            this.cmb_ubicacion.TabIndex = 10;
            this.cmb_ubicacion.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmb_ruta
            // 
            this.cmb_ruta.FormattingEnabled = true;
            this.cmb_ruta.Location = new System.Drawing.Point(81, 10);
            this.cmb_ruta.Name = "cmb_ruta";
            this.cmb_ruta.Size = new System.Drawing.Size(121, 21);
            this.cmb_ruta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ruta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dt_VxR
            // 
            this.dt_VxR.AllowUserToAddRows = false;
            this.dt_VxR.AllowUserToDeleteRows = false;
            this.dt_VxR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dt_VxR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_VxR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_VxR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_VxR.Enabled = false;
            this.dt_VxR.Location = new System.Drawing.Point(20, 322);
            this.dt_VxR.Name = "dt_VxR";
            this.dt_VxR.RowHeadersVisible = false;
            this.dt_VxR.Size = new System.Drawing.Size(539, 126);
            this.dt_VxR.TabIndex = 9;
            this.dt_VxR.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_usovehiculo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_vehiculos);
            this.groupBox2.Location = new System.Drawing.Point(20, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 51);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehiculos";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Comercial_Solutions.Properties.Resources.next;
            this.pictureBox6.Location = new System.Drawing.Point(215, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vehiculos";
            // 
            // pnl_rutas
            // 
            this.pnl_rutas.Controls.Add(this.label2);
            this.pnl_rutas.Controls.Add(this.label5);
            this.pnl_rutas.Controls.Add(this.cmb_ruta);
            this.pnl_rutas.Controls.Add(this.pictureBox6);
            this.pnl_rutas.Location = new System.Drawing.Point(6, 65);
            this.pnl_rutas.Name = "pnl_rutas";
            this.pnl_rutas.Size = new System.Drawing.Size(316, 36);
            this.pnl_rutas.TabIndex = 15;
            this.pnl_rutas.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Comercial_Solutions.Properties.Resources.add;
            this.pictureBox5.Location = new System.Drawing.Point(12, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(180, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gestion de flota";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.pictureBox3.Location = new System.Drawing.Point(121, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(67, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(236, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Comercial_Solutions.Properties.Resources.refresh;
            this.pictureBox7.Location = new System.Drawing.Point(292, 66);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Uso:";
            // 
            // cmb_usovehiculo
            // 
            this.cmb_usovehiculo.FormattingEnabled = true;
            this.cmb_usovehiculo.Items.AddRange(new object[] {
            "Ruta",
            "Apoyo",
            "Emergencia"});
            this.cmb_usovehiculo.Location = new System.Drawing.Point(272, 18);
            this.cmb_usovehiculo.Name = "cmb_usovehiculo";
            this.cmb_usovehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmb_usovehiculo.TabIndex = 14;
            // 
            // frm_asignacion_vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 460);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dt_VxR);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_asignacion_vehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de vehiculos";
            this.Load += new System.EventHandler(this.frm_asignacion_vehiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_VxR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnl_rutas.ResumeLayout(false);
            this.pnl_rutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_vehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ubicacion;
        private System.Windows.Forms.ComboBox cmb_ruta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dt_VxR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel pnl_rutas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_usovehiculo;
    }
}