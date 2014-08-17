using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using i3nRiqJSON;

namespace Comercial_Solutions.Forms.Areas.Compras
{
    public partial class frm_eliminarproductoproveedor : Form
    {
        String datos_proveedor;
        public frm_eliminarproductoproveedor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            i3nRiqJson x = new i3nRiqJson();
            string query2 = "SELECT tbt_detalle_proveedor.producto_detalle_proveedorcol AS Detalle_De_Producto, tbt_detalle_proveedor.precio_compra AS Precio_Unitario_De_Compra, tbm_acpro.nombre_proveedor FROM tbt_detalle_proveedor, tbm_acpro WHERE tbm_acpro.idtbm_proveedor = tbt_detalle_proveedor.tbm_proveedor_idtbm_proveedor and tbt_detalle_proveedor.producto_detalle_proveedorcol='" + cbm_incidente.Text + "'";
            dataGridView1.DataSource = ((x.consulta_DataGridView(query2)));
        }

        public void cargar()
        {

            i3nRiqJson x2 = new i3nRiqJson();
            string query = "SELECT id_detalle_proveedorcol,producto_detalle_proveedorcol FROM tbt_detalle_proveedor";
            cbm_incidente.DataSource = ((x2.consulta_DataGridView(query)));
            cbm_incidente.ValueMember = "id_detalle_proveedorcol";
            cbm_incidente.DisplayMember = "producto_detalle_proveedorcol";

          

        }

        private void frm_eliminarproductoproveedor_Load(object sender, EventArgs e)
        {
            cargar();

           

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            i3nRiqJson x = new i3nRiqJson();


            i3nRiqJson x4 = new i3nRiqJson();
            string query4 = "select id_detalle_proveedorcol from tbt_detalle_proveedor where producto_detalle_proveedorcol='" + cbm_incidente.Text + "'";
            System.Collections.ArrayList array = x4.consultar(query4);



            foreach (Dictionary<string, string> dic in array)
            {
                datos_proveedor = (dic["id_detalle_proveedorcol"] + "\n");
                // Console.WriteLine("VIENEN: "+dic["employee_name"]);


            }
            string tabla = "tbt_detalle_proveedor";
            string condicion = "id_detalle_proveedorcol=" + datos_proveedor;

            x.eliminar("4", tabla, condicion);
            MessageBox.Show("datos eliminados correctamente");

           


            cargar();

            i3nRiqJson x6 = new i3nRiqJson();
            string query2 = "SELECT tbt_detalle_proveedor.producto_detalle_proveedorcol AS Detalle_De_Producto, tbt_detalle_proveedor.precio_compra AS Precio_Unitario_De_Compra, tbm_acpro.nombre_proveedor FROM tbt_detalle_proveedor, tbm_acpro WHERE tbm_acpro.idtbm_proveedor = tbt_detalle_proveedor.tbm_proveedor_idtbm_proveedor and tbt_detalle_proveedor.producto_detalle_proveedorcol='" + cbm_incidente.Text + "'";
            dataGridView1.DataSource = ((x6.consulta_DataGridView(query2)));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
