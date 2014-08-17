using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercial_Solutions.Clases;
using i3nRiqJSON;

namespace Comercial_Solutions.Forms.Areas.Compras
{
    public partial class frm_productoproveedor : Form
    {
        String datos_proveedor;
        String datos_moneda;
        int X = 0;
        int Y = 0;
        public frm_productoproveedor()
        {
           
            InitializeComponent();
            X = Propp.X;
            Y = Propp.Y;
        }
        public void cargar()
        {
            i3nRiqJson x = new i3nRiqJson();
            i3nRiqJson x2 = new i3nRiqJson();
            i3nRiqJson x3 = new i3nRiqJson();

            string query = "SELECT idtbm_proveedor,nombre_proveedor FROM tbm_acpro";
            cbm_proveedor.DataSource = ((x2.consulta_DataGridView(query)));
            cbm_proveedor.ValueMember = "idtbm_proveedor";
            cbm_proveedor.DisplayMember = "nombre_proveedor";


            string query3 = "SELECT idtbm_moneda, tipo_moneda FROM tbm_moneda";
            cbm_moneda.DataSource = ((x3.consulta_DataGridView(query3)));
            cbm_moneda.ValueMember = "idtbm_moneda";
            cbm_moneda.DisplayMember = "tipo_moneda";



            string query2 = "SELECT tbt_detalle_proveedor.producto_detalle_proveedorcol AS Detalle_De_Producto, tbt_detalle_proveedor.precio_compra AS Precio_Unitario_De_Compra, tbm_acpro.nombre_proveedor FROM tbt_detalle_proveedor, tbm_acpro WHERE tbm_acpro.idtbm_proveedor = tbt_detalle_proveedor.tbm_proveedor_idtbm_proveedor";
            dataGridView1.DataSource = ((x.consulta_DataGridView(query2)));
        }

        private void frm_productoproveedor_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
            cargar();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((txtnombre.Text.Equals("")) || (txtpcompra.Text.Equals("")))
            {

                MessageBox.Show("ALGUNO ESTA VACIO");
            }
            else
            {
                i3nRiqJson x = new i3nRiqJson();
                string tabla = "tbt_detalle_proveedor";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("producto_detalle_proveedorcol", txtnombre.Text);
                dict.Add("precio_compra", txtpcompra.Text);
                //dict.Add("tbm_moneda_idtbm_moneda", "1");
                //dict.Add("tbm_proveedor_idtbm_proveedor", "1"); 
                

                i3nRiqJson x4 = new i3nRiqJson();
                string query4 = "select idtbm_proveedor from tbm_acpro where nombre_proveedor='" + cbm_proveedor.Text + "'";
                System.Collections.ArrayList array = x4.consultar(query4);
                foreach (Dictionary<string, string> dic in array)
                {
                    datos_proveedor = (dic["idtbm_proveedor"] + "\n");
                    // Console.WriteLine("VIENEN: "+dic["employee_name"]);
                }
                dict.Add("tbm_proveedor_idtbm_proveedor", datos_proveedor);




                





                i3nRiqJson x5 = new i3nRiqJson();
                string query5 = "select idtbm_moneda from tbm_moneda where tipo_moneda='" + cbm_moneda.Text + "'";
                System.Collections.ArrayList array5 = x5.consultar(query5);
                foreach (Dictionary<string, string> dic2 in array5)
                {
                    datos_moneda = (dic2["idtbm_moneda"] + "\n");
                    // Console.WriteLine("VIENEN: "+dic["employee_name"]);
                }
                dict.Add("tbm_moneda_idtbm_moneda", datos_moneda);

                


                x.insertar("1", tabla, dict);







                MessageBox.Show("Datos Ingresados Exitosamente",
            "Editar Incidentes",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation


          );

            }
            cargar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtpcompra.Enabled = true;
            cbm_moneda.Enabled = true;
            cbm_proveedor.Enabled = true;
            dataGridView1.Enabled = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_editarproductoproveedor x = new frm_editarproductoproveedor();
            x.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
