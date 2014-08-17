using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Comercial_Solutions.Forms;
using Comercial_Solutions.Forms.Areas;
using Comercial_Solutions.Clases;
using i3nRiqJSON;
using Generador_de_fechas;
using Comercial_Solutions.Forms.Principal;



namespace Comercial_Solutions.Forms.Areas.Logistica
{
    public partial class frm_logistica_historial_factura : Form
    {
        int X = 0;
        int Y = 0;
        public frm_logistica_historial_factura()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();

            //busqueda();
        }
        i3nRiqJson gCon = new i3nRiqJson();





public void buscarfactura(string nofactura) {

    if (nofactura.Equals(""))
    {
        MessageBox.Show("Ingrese un numero de factura");
       

    }
    else
    {
        dataGridView1.Columns.Clear();

        string stQuery = "select tx_fecha AS Fecha, (select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido) AS Ubicacion, (select tx_estadopedido from tbm_estadopedido  where tbm_estadopedido.id_estadopedido=tbt_historialenvios.tbm_estadopedido_id_estadopedido) AS Estado from tbt_historialenvios where tbm_factura_id_factura=" + nofactura + "";

        dataGridView1.DataSource = gCon.consulta_DataGridView(stQuery);
    }
}



        private void frm_logistica_historial_factura_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barra1_click_buscar_button()
        {
      
        }

        public void ultimoestado() {

            string stQuery1 = "select MAX() from ";
            
            System.Collections.ArrayList arArray = gCon.consultar(stQuery1);
            foreach (Dictionary<string, string> dict in arArray)
            {
               // textBox2.Text = dict["cliente"];
               // textBox3.Text = dict["direccion"];
              //  textBox4.Text = dict["departamento"];
            //    textBox5.Text = dict["municipio"];
            } 
        
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                buscarfactura(txt_buscar.Text);

            }
        }
    }
}
