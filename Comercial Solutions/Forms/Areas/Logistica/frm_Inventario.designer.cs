namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_inventario
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
            this.label12 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.PictureBox();
            this.btn_actualizar = new System.Windows.Forms.PictureBox();
            this.btn_bloquear = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_inventarios = new System.Windows.Forms.TabPage();
            this.gpb_inventarios = new System.Windows.Forms.GroupBox();
            this.cmb_insertar_nombre_producto = new System.Windows.Forms.ComboBox();
            this.cmb_almacen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgv_vista_consulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ambiente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_bodega = new System.Windows.Forms.ComboBox();
            this.dgv_consulta = new System.Windows.Forms.DataGridView();
            this.tab_consulta = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cargar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_precio_costo = new System.Windows.Forms.Label();
            this.lbl_medida = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.dgv_alertas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).BeginInit();
            this.tab_inventarios.SuspendLayout();
            this.gpb_inventarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_consulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).BeginInit();
            this.tab_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alertas)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "Inventario";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.btn_insertar.Location = new System.Drawing.Point(128, 66);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(50, 50);
            this.btn_insertar.TabIndex = 17;
            this.btn_insertar.TabStop = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.btn_eliminar.Location = new System.Drawing.Point(240, 66);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 50);
            this.btn_eliminar.TabIndex = 18;
            this.btn_eliminar.TabStop = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Image = global::Comercial_Solutions.Properties.Resources.refresh;
            this.btn_actualizar.Location = new System.Drawing.Point(72, 66);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(50, 50);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.TabStop = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_bloquear
            // 
            this.btn_bloquear.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.btn_bloquear.Location = new System.Drawing.Point(184, 66);
            this.btn_bloquear.Name = "btn_bloquear";
            this.btn_bloquear.Size = new System.Drawing.Size(50, 50);
            this.btn_bloquear.TabIndex = 20;
            this.btn_bloquear.TabStop = false;
            this.btn_bloquear.Click += new System.EventHandler(this.btn_bloquear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alerta de existencia de productos.";
            this.label3.Visible = false;
            // 
            // tab_inventarios
            // 
            this.tab_inventarios.Controls.Add(this.gpb_inventarios);
            this.tab_inventarios.Controls.Add(this.dgv_vista_consulta);
            this.tab_inventarios.Location = new System.Drawing.Point(4, 22);
            this.tab_inventarios.Name = "tab_inventarios";
            this.tab_inventarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inventarios.Size = new System.Drawing.Size(730, 314);
            this.tab_inventarios.TabIndex = 2;
            this.tab_inventarios.Text = "Inventario";
            this.tab_inventarios.UseVisualStyleBackColor = true;
            this.tab_inventarios.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gpb_inventarios
            // 
            this.gpb_inventarios.Controls.Add(this.lbl_cantidad);
            this.gpb_inventarios.Controls.Add(this.lbl_medida);
            this.gpb_inventarios.Controls.Add(this.lbl_precio_costo);
            this.gpb_inventarios.Controls.Add(this.cmb_insertar_nombre_producto);
            this.gpb_inventarios.Controls.Add(this.cmb_almacen);
            this.gpb_inventarios.Controls.Add(this.label6);
            this.gpb_inventarios.Controls.Add(this.label14);
            this.gpb_inventarios.Controls.Add(this.label15);
            this.gpb_inventarios.Controls.Add(this.label16);
            this.gpb_inventarios.Controls.Add(this.label17);
            this.gpb_inventarios.Location = new System.Drawing.Point(490, 48);
            this.gpb_inventarios.Name = "gpb_inventarios";
            this.gpb_inventarios.Size = new System.Drawing.Size(210, 246);
            this.gpb_inventarios.TabIndex = 5;
            this.gpb_inventarios.TabStop = false;
            this.gpb_inventarios.Text = "Ingreso de producto finalizado ";
            this.gpb_inventarios.Visible = false;
            // 
            // cmb_insertar_nombre_producto
            // 
            this.cmb_insertar_nombre_producto.FormattingEnabled = true;
            this.cmb_insertar_nombre_producto.Location = new System.Drawing.Point(88, 85);
            this.cmb_insertar_nombre_producto.Name = "cmb_insertar_nombre_producto";
            this.cmb_insertar_nombre_producto.Size = new System.Drawing.Size(116, 21);
            this.cmb_insertar_nombre_producto.TabIndex = 14;
            this.cmb_insertar_nombre_producto.SelectionChangeCommitted += new System.EventHandler(this.cmb_insertar_nombre_producto_SelectionChangeCommitted);
            // 
            // cmb_almacen
            // 
            this.cmb_almacen.FormattingEnabled = true;
            this.cmb_almacen.Location = new System.Drawing.Point(88, 45);
            this.cmb_almacen.Name = "cmb_almacen";
            this.cmb_almacen.Size = new System.Drawing.Size(116, 21);
            this.cmb_almacen.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Almacén";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 26);
            this.label14.TabIndex = 6;
            this.label14.Text = "Medida de \r\nproducción";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Precio Costo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cantidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nombre";
            // 
            // dgv_vista_consulta
            // 
            this.dgv_vista_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_vista_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_consulta.Location = new System.Drawing.Point(12, 31);
            this.dgv_vista_consulta.Name = "dgv_vista_consulta";
            this.dgv_vista_consulta.Size = new System.Drawing.Size(457, 263);
            this.dgv_vista_consulta.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_ambiente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_bodega);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 259);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacenaje";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Orden de\r\nProducción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Almacen";
            // 
            // cmb_ambiente
            // 
            this.cmb_ambiente.FormattingEnabled = true;
            this.cmb_ambiente.Location = new System.Drawing.Point(84, 57);
            this.cmb_ambiente.Name = "cmb_ambiente";
            this.cmb_ambiente.Size = new System.Drawing.Size(100, 21);
            this.cmb_ambiente.TabIndex = 12;
            this.cmb_ambiente.Click += new System.EventHandler(this.cmb_ambiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producto";
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.FormattingEnabled = true;
            this.cmb_bodega.Location = new System.Drawing.Point(84, 27);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Size = new System.Drawing.Size(100, 21);
            this.cmb_bodega.TabIndex = 11;
            this.cmb_bodega.Click += new System.EventHandler(this.cmb_bodega_Click);
            // 
            // dgv_consulta
            // 
            this.dgv_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_consulta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta.Location = new System.Drawing.Point(247, 24);
            this.dgv_consulta.Name = "dgv_consulta";
            this.dgv_consulta.Size = new System.Drawing.Size(465, 259);
            this.dgv_consulta.TabIndex = 15;
            // 
            // tab_consulta
            // 
            this.tab_consulta.Controls.Add(this.tab_inventarios);
            this.tab_consulta.Location = new System.Drawing.Point(33, 161);
            this.tab_consulta.Name = "tab_consulta";
            this.tab_consulta.SelectedIndex = 0;
            this.tab_consulta.Size = new System.Drawing.Size(738, 340);
            this.tab_consulta.TabIndex = 0;
            this.tab_consulta.Click += new System.EventHandler(this.tab_consulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(296, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Image = global::Comercial_Solutions.Properties.Resources.folder;
            this.btn_cargar.Location = new System.Drawing.Point(16, 66);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(50, 50);
            this.btn_cargar.TabIndex = 24;
            this.btn_cargar.TabStop = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_precio_costo
            // 
            this.lbl_precio_costo.AutoSize = true;
            this.lbl_precio_costo.Location = new System.Drawing.Point(85, 151);
            this.lbl_precio_costo.Name = "lbl_precio_costo";
            this.lbl_precio_costo.Size = new System.Drawing.Size(0, 13);
            this.lbl_precio_costo.TabIndex = 16;
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.Location = new System.Drawing.Point(85, 180);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(10, 13);
            this.lbl_medida.TabIndex = 17;
            this.lbl_medida.Text = " ";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(85, 126);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(10, 13);
            this.lbl_cantidad.TabIndex = 18;
            this.lbl_cantidad.Text = " ";
            // 
            // dgv_alertas
            // 
            this.dgv_alertas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_alertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alertas.Location = new System.Drawing.Point(390, 35);
            this.dgv_alertas.Name = "dgv_alertas";
            this.dgv_alertas.RowHeadersVisible = false;
            this.dgv_alertas.Size = new System.Drawing.Size(370, 120);
            this.dgv_alertas.TabIndex = 21;
            this.dgv_alertas.Visible = false;
            this.dgv_alertas.Click += new System.EventHandler(this.dgv_alertas_Click);
            // 
            // frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 513);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_alertas);
            this.Controls.Add(this.btn_bloquear);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tab_consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inventario";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_insertar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bloquear)).EndInit();
            this.tab_inventarios.ResumeLayout(false);
            this.gpb_inventarios.ResumeLayout(false);
            this.gpb_inventarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_consulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta)).EndInit();
            this.tab_consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btn_insertar;
        private System.Windows.Forms.PictureBox btn_eliminar;
        private System.Windows.Forms.PictureBox btn_actualizar;
        private System.Windows.Forms.PictureBox btn_bloquear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_inventarios;
        private System.Windows.Forms.DataGridView dgv_vista_consulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ambiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_bodega;
        private System.Windows.Forms.DataGridView dgv_consulta;
        private System.Windows.Forms.TabControl tab_consulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpb_inventarios;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox btn_cargar;
        private System.Windows.Forms.ComboBox cmb_almacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_insertar_nombre_producto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_medida;
        private System.Windows.Forms.Label lbl_precio_costo;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.DataGridView dgv_alertas;

    }
}