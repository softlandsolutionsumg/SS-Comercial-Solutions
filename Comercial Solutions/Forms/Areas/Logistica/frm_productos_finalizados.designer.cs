namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_productos_finalizados
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_produccion = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.PictureBox();
            this.Tab_control_producto_finalizado = new System.Windows.Forms.TabControl();
            this.tab_productos_finalizados = new System.Windows.Forms.TabPage();
            this.gpb_ingreso = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_nom_producto = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_orden_p = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpb_consulta = new System.Windows.Forms.GroupBox();
            this.dgv_vista = new System.Windows.Forms.DataGridView();
            this.btn_bloquear = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).BeginInit();
            this.Tab_control_producto_finalizado.SuspendLayout();
            this.tab_productos_finalizados.SuspendLayout();
            this.gpb_ingreso.SuspendLayout();
            this.gpb_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(261, 75);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.refresh;
            this.pictureBox3.Location = new System.Drawing.Point(205, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.pictureBox2.Location = new System.Drawing.Point(149, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(93, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_produccion
            // 
            this.lbl_produccion.AutoSize = true;
            this.lbl_produccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produccion.Location = new System.Drawing.Point(31, 24);
            this.lbl_produccion.Name = "lbl_produccion";
            this.lbl_produccion.Size = new System.Drawing.Size(150, 31);
            this.lbl_produccion.TabIndex = 21;
            this.lbl_produccion.Text = "Producción";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::Comercial_Solutions.Properties.Resources.add;
            this.btn_agregar.Location = new System.Drawing.Point(37, 75);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(50, 50);
            this.btn_agregar.TabIndex = 28;
            this.btn_agregar.TabStop = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Tab_control_producto_finalizado
            // 
            this.Tab_control_producto_finalizado.Controls.Add(this.tab_productos_finalizados);
            this.Tab_control_producto_finalizado.Location = new System.Drawing.Point(37, 149);
            this.Tab_control_producto_finalizado.Name = "Tab_control_producto_finalizado";
            this.Tab_control_producto_finalizado.SelectedIndex = 0;
            this.Tab_control_producto_finalizado.Size = new System.Drawing.Size(726, 329);
            this.Tab_control_producto_finalizado.TabIndex = 29;
            // 
            // tab_productos_finalizados
            // 
            this.tab_productos_finalizados.Controls.Add(this.gpb_ingreso);
            this.tab_productos_finalizados.Controls.Add(this.gpb_consulta);
            this.tab_productos_finalizados.Location = new System.Drawing.Point(4, 22);
            this.tab_productos_finalizados.Name = "tab_productos_finalizados";
            this.tab_productos_finalizados.Padding = new System.Windows.Forms.Padding(3);
            this.tab_productos_finalizados.Size = new System.Drawing.Size(718, 303);
            this.tab_productos_finalizados.TabIndex = 0;
            this.tab_productos_finalizados.Text = "Productos Finalizados";
            this.tab_productos_finalizados.UseVisualStyleBackColor = true;
            // 
            // gpb_ingreso
            // 
            this.gpb_ingreso.Controls.Add(this.label9);
            this.gpb_ingreso.Controls.Add(this.lbl_id_producto);
            this.gpb_ingreso.Controls.Add(this.label18);
            this.gpb_ingreso.Controls.Add(this.lbl_nom_producto);
            this.gpb_ingreso.Controls.Add(this.lbl_numero);
            this.gpb_ingreso.Controls.Add(this.label8);
            this.gpb_ingreso.Controls.Add(this.cmb_orden_p);
            this.gpb_ingreso.Controls.Add(this.label7);
            this.gpb_ingreso.Controls.Add(this.label5);
            this.gpb_ingreso.Location = new System.Drawing.Point(479, 30);
            this.gpb_ingreso.Name = "gpb_ingreso";
            this.gpb_ingreso.Size = new System.Drawing.Size(200, 241);
            this.gpb_ingreso.TabIndex = 3;
            this.gpb_ingreso.TabStop = false;
            this.gpb_ingreso.Text = "Ingresos";
            this.gpb_ingreso.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cargar en producto finalizado los \r\nproductos de una orden de produccion";
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Location = new System.Drawing.Point(90, 135);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_producto.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "ID";
            // 
            // lbl_nom_producto
            // 
            this.lbl_nom_producto.AutoSize = true;
            this.lbl_nom_producto.Location = new System.Drawing.Point(92, 171);
            this.lbl_nom_producto.Name = "lbl_nom_producto";
            this.lbl_nom_producto.Size = new System.Drawing.Size(0, 13);
            this.lbl_nom_producto.TabIndex = 8;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(91, 206);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(0, 13);
            this.lbl_numero.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cantidad";
            // 
            // cmb_orden_p
            // 
            this.cmb_orden_p.FormattingEnabled = true;
            this.cmb_orden_p.Location = new System.Drawing.Point(95, 82);
            this.cmb_orden_p.Name = "cmb_orden_p";
            this.cmb_orden_p.Size = new System.Drawing.Size(60, 21);
            this.cmb_orden_p.TabIndex = 3;
            this.cmb_orden_p.SelectionChangeCommitted += new System.EventHandler(this.cmb_orden_p_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Orden de\r\nProducción";
            // 
            // gpb_consulta
            // 
            this.gpb_consulta.Controls.Add(this.dgv_vista);
            this.gpb_consulta.Location = new System.Drawing.Point(19, 17);
            this.gpb_consulta.Name = "gpb_consulta";
            this.gpb_consulta.Size = new System.Drawing.Size(436, 260);
            this.gpb_consulta.TabIndex = 2;
            this.gpb_consulta.TabStop = false;
            this.gpb_consulta.Text = "Vista";
            // 
            // dgv_vista
            // 
            this.dgv_vista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista.Location = new System.Drawing.Point(9, 19);
            this.dgv_vista.Name = "dgv_vista";
            this.dgv_vista.RowHeadersVisible = false;
            this.dgv_vista.Size = new System.Drawing.Size(408, 235);
            this.dgv_vista.TabIndex = 23;
            // 
            // btn_bloquear
            // 
            this.btn_bloquear.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.btn_bloquear.Location = new System.Drawing.Point(317, 75);
            this.btn_bloquear.Name = "btn_bloquear";
            this.btn_bloquear.Size = new System.Drawing.Size(50, 50);
            this.btn_bloquear.TabIndex = 30;
            this.btn_bloquear.TabStop = false;
            this.btn_bloquear.Click += new System.EventHandler(this.btn_bloquear_Click);
            // 
            // frm_productos_finalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 537);
            this.Controls.Add(this.btn_bloquear);
            this.Controls.Add(this.Tab_control_producto_finalizado);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_produccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_productos_finalizados";
            this.Load += new System.EventHandler(this.frm_produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).EndInit();
            this.Tab_control_producto_finalizado.ResumeLayout(false);
            this.tab_productos_finalizados.ResumeLayout(false);
            this.gpb_ingreso.ResumeLayout(false);
            this.gpb_ingreso.PerformLayout();
            this.gpb_consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_produccion;
        private System.Windows.Forms.PictureBox btn_agregar;
        private System.Windows.Forms.TabControl Tab_control_producto_finalizado;
        private System.Windows.Forms.TabPage tab_productos_finalizados;
        private System.Windows.Forms.GroupBox gpb_consulta;
        private System.Windows.Forms.DataGridView dgv_vista;
        private System.Windows.Forms.GroupBox gpb_ingreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_id_producto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_nom_producto;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_orden_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btn_bloquear;
    }
}