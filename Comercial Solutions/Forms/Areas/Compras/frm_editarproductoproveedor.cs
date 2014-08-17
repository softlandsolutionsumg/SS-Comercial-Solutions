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
using System.Configuration;

namespace Comercial_Solutions.Forms.Areas.Compras
{
    public partial class frm_editarproductoproveedor : Form
    {
        i3nRiqJson x = new i3nRiqJson();
        String datos_moneda;
        String datos_proveedor;
        String datos_producto;
        public frm_editarproductoproveedor()
        {

            InitializeComponent();
        }
        public void cargarproducto()
        {

            string query = "select id_detalle_proveedorcol,producto_detalle_proveedorcol from tbt_detalle_proveedor";
            cmb_producto.DataSource = ((x.consulta_DataGridView(query)));
            cmb_producto.ValueMember = "id_detalle_proveedorcol";
            cmb_producto.DisplayMember = "producto_detalle_proveedorcol";




        }

        private void frm_editarproductoproveedor_Load(object sender, EventArgs e)
        {
            cargarproducto();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

                i3nRiqJson x6 = new i3nRiqJson();
                string query6 = "select id_detalle_proveedorcol from tbt_detalle_proveedor where producto_detalle_proveedorcol='" + cmb_producto.Text + "'";
                System.Collections.ArrayList array6 = x6.consultar(query6);
                foreach (Dictionary<string, string> dic2 in array6)
                {
                    datos_producto = (dic2["id_detalle_proveedorcol"] + "\n");
                    // Console.WriteLine("VIENEN: "+dic["employee_name"]);
                }
                dict.Add("tbm_moneda_idtbm_moneda", datos_moneda);

                string condicion = "id_detalle_proveedorcol= " + datos_producto;
                x.actualizar("3", tabla, dict, condicion);


                







                MessageBox.Show("Datos Ingresados Exitosamente",
            "Editar Producto Proveedor",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation


          );

            }
            cargarproducto();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            string query4 = "select producto_detalle_proveedorcol,precio_compra from  tbt_detalle_proveedor where producto_detalle_proveedorcol='" + cmb_producto.Text + "'";
            System.Collections.ArrayList array = x.consultar(query4);
                        foreach (Dictionary<string, string> dic in array)
            {
                txtnombre.Text = (dic["producto_detalle_proveedorcol"]);
                txtpcompra.Text = (dic["precio_compra"]);
                           }
                        i3nRiqJson x2 = new i3nRiqJson();
                        string query5 = "SELECT idtbm_proveedor,nombre_proveedor FROM tbm_acpro";
                        cbm_proveedor.DataSource = ((x2.consulta_DataGridView(query5)));
                        cbm_proveedor.ValueMember = "idtbm_proveedor";
                        cbm_proveedor.DisplayMember = "nombre_proveedor";

                        i3nRiqJson x3 = new i3nRiqJson();
                        string query3 = "SELECT idtbm_moneda, tipo_moneda FROM tbm_moneda";
                        cbm_moneda.DataSource = ((x3.consulta_DataGridView(query3)));
                        cbm_moneda.ValueMember = "idtbm_moneda";
                        cbm_moneda.DisplayMember = "tipo_moneda";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
