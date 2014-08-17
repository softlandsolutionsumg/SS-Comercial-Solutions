namespace Comercial_Solutions.Forms.Areas.Logistica
{
    partial class frm_capacidad_ruta
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
            this.dt_cpr = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ubicacion = new System.Windows.Forms.ComboBox();
            this.cmb_ruta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cpr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_cpr
            // 
            this.dt_cpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_cpr.Location = new System.Drawing.Point(12, 111);
            this.dt_cpr.Name = "dt_cpr";
            this.dt_cpr.Size = new System.Drawing.Size(278, 150);
            this.dt_cpr.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_ubicacion);
            this.groupBox1.Controls.Add(this.cmb_ruta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion de Ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Colchones";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(215, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
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
            // 
            // cmb_ruta
            // 
            this.cmb_ruta.FormattingEnabled = true;
            this.cmb_ruta.Location = new System.Drawing.Point(87, 59);
            this.cmb_ruta.Name = "cmb_ruta";
            this.cmb_ruta.Size = new System.Drawing.Size(121, 21);
            this.cmb_ruta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ruta:";
            // 
            // frm_capacidad_ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(302, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_cpr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_capacidad_ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacidad Ruta";
            this.Load += new System.EventHandler(this.frm_capacidad_ruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_cpr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_cpr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ubicacion;
        private System.Windows.Forms.ComboBox cmb_ruta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}