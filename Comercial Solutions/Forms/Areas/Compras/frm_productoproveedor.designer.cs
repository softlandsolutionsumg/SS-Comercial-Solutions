namespace Comercial_Solutions.Forms.Areas.Compras
{
    partial class frm_productoproveedor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpcompra = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbm_proveedor = new System.Windows.Forms.ComboBox();
            this.cbm_moneda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Precio unitario de compra";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "Producto";
            // 
            // txtpcompra
            // 
            this.txtpcompra.Enabled = false;
            this.txtpcompra.Location = new System.Drawing.Point(337, 164);
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Size = new System.Drawing.Size(279, 22);
            this.txtpcompra.TabIndex = 97;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(11, 164);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(318, 22);
            this.txtnombre.TabIndex = 96;
            // 
            // cbm_proveedor
            // 
            this.cbm_proveedor.Enabled = false;
            this.cbm_proveedor.FormattingEnabled = true;
            this.cbm_proveedor.Location = new System.Drawing.Point(11, 220);
            this.cbm_proveedor.Name = "cbm_proveedor";
            this.cbm_proveedor.Size = new System.Drawing.Size(318, 24);
            this.cbm_proveedor.TabIndex = 100;
            // 
            // cbm_moneda
            // 
            this.cbm_moneda.Enabled = false;
            this.cbm_moneda.FormattingEnabled = true;
            this.cbm_moneda.Location = new System.Drawing.Point(338, 220);
            this.cbm_moneda.Name = "cbm_moneda";
            this.cbm_moneda.Size = new System.Drawing.Size(278, 24);
            this.cbm_moneda.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 102;
            this.label3.Text = "Elija moneda ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Elija un Proveedor";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Comercial_Solutions.Properties.Resources.add;
            this.pictureBox5.Location = new System.Drawing.Point(11, 61);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 62);
            this.pictureBox5.TabIndex = 105;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "2";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Comercial_Solutions.Properties.Resources.save;
            this.pictureBox1.Location = new System.Drawing.Point(86, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "3";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.edit;
            this.pictureBox3.Location = new System.Drawing.Point(159, 61);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 62);
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "4";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Comercial_Solutions.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(238, 61);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 62);
            this.pictureBox4.TabIndex = 104;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "5";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Comercial_Solutions.Properties.Resources.back;
            this.pictureBox6.Location = new System.Drawing.Point(11, 13);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 109;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "1";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(46, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 39);
            this.label5.TabIndex = 108;
            this.label5.Text = "Productos Proveedores";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 152);
            this.dataGridView1.TabIndex = 110;
            // 
            // frm_productoproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbm_moneda);
            this.Controls.Add(this.cbm_proveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpcompra);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_productoproveedor";
            this.Text = "frm_productoproveedor";
            this.Load += new System.EventHandler(this.frm_productoproveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpcompra;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbm_proveedor;
        private System.Windows.Forms.ComboBox cbm_moneda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}