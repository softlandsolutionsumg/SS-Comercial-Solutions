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
    public partial class frm_compra : Form
    {
        int X = 0;
        int Y = 0;
        String datos_empleado;
        String datos_producto;
        String datos_almacen;
        String datos_proveedor;
        public frm_compra()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
        }

        private void frm_compra_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
            cargar();
        }

        public void cargar()
        {
            i3nRiqJson x = new i3nRiqJson();
            string query2 = "SELECT tbm_compra.fecha_compra as Fecha,tbm_compra.Cantidad_compra as Cantidad,tbm_empleado.nombre_empleado as Empleado,tbt_detalle_proveedor.producto_detalle_proveedorcol as Producto,tbt_detalle_proveedor.precio_compra as Precio, tbm_almacen.nombre_bodega as Almacen from tbm_compra,tbm_empleado,tbt_detalle_proveedor,tbm_almacen where tbm_empleado.idtbm_empleado = tbm_compra.tbm_empleado_idtbm_empleado and tbm_compra.tbm_almacen_idtbm_bodega=tbm_almacen.idtbm_bodega ";
            dataGridView1.DataSource = ((x.consulta_DataGridView(query2)));

            i3nRiqJson x2 = new i3nRiqJson();
            string query = "SELECT idtbm_empleado,nombre_empleado FROM tbm_empleado";
            cbm_empleado.DataSource = ((x2.consulta_DataGridView(query)));
            cbm_empleado.ValueMember = "idtbm_empleado";
            cbm_empleado.DisplayMember = "nombre_empleado";

        

            i3nRiqJson x5 = new i3nRiqJson();
            string query4 = "SELECT idtbm_bodega,nombre_bodega FROM tbm_almacen";
            cbm_almacen.DataSource = ((x5.consulta_DataGridView(query4)));
            cbm_almacen.ValueMember = "idtbm_bodega";
            cbm_almacen.DisplayMember = "nombre_bodega";

            i3nRiqJson x6 = new i3nRiqJson();
            string query5 = "SELECT idtbm_proveedor,nombre_proveedor FROM tbm_acpro";
            cbm_proveedor.DataSource = ((x6.consulta_DataGridView(query5)));
            cbm_proveedor.ValueMember = "idtbm_proveedor";
            String a = "idtbm_proveedor";
            cbm_proveedor.DisplayMember = "nombre_proveedor";


            

            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if ((txtcantidad.Text.Equals("")))
            {

                MessageBox.Show("ALGUNO ESTA VACIO");
            }
            else
            {

                string tabla = "tbm_compra";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("fecha_compra", dtpfecha.Value.Date.ToString("yyy-MM-dd"));
                dict.Add("Cantidad_compra", txtcantidad.Text);
                /***************************************************************
        DESCRIPCION:  inserta en el codigo del empleado que realizo la compra
         
         ***************************************************************/
                i3nRiqJson x4 = new i3nRiqJson();
                string query4 = "select idtbm_empleado from tbm_empleado where nombre_empleado='" + cbm_empleado.Text + "'";
                System.Collections.ArrayList array = x4.consultar(query4);
          
                foreach (Dictionary<string, string> dic in array)
                {
                    datos_empleado = (dic["idtbm_empleado"] + "\n");
                    // Console.WriteLine("VIENEN: "+dic["employee_name"]);

                }
                dict.Add("tbm_empleado_idtbm_empleado", datos_empleado);

                /***************************************************************
        DESCRIPCION:  inserta el codigo del almacen seleccionado
         
         ***************************************************************/

                i3nRiqJson x5 = new i3nRiqJson();
                string query5 = "select idtbm_bodega from tbm_almacen where nombre_bodega='" + cbm_almacen.Text + "'";
                System.Collections.ArrayList array2 = x5.consultar(query5);

                foreach (Dictionary<string, string> dic in array2)
                {
                    datos_almacen = (dic["idtbm_bodega"] + "\n");
                    // Console.WriteLine("VIENEN: "+dic["employee_name"]);

                }
                dict.Add("tbm_almacen_idtbm_bodega", datos_almacen);

                

                /***************************************************************
       DESCRIPCION:  inserta el codigo del producto comprado
         
        ***************************************************************/

                i3nRiqJson x6 = new i3nRiqJson();
                string query6 = "select id_detalle_proveedorcol,producto_detalle_proveedorcol from tbm_detalle_proveedor where producto_detalle_proveedorcol='" + cbm_producto.Text + "'";
                System.Collections.ArrayList array3 = x6.consultar(query6);

                foreach (Dictionary<string, string> dic in array3)
                {
                    datos_producto = (dic["id_detalle_proveedorcol"] + "\n");
                    // Console.WriteLine("VIENEN: "+dic["employee_name"]);

                }
                dict.Add("tbt_detalle_proveedor_id_detalle_proveedorcol", datos_producto);

                i3nRiqJson x = new i3nRiqJson();
                x.insertar("1", tabla, dict);





                MessageBox.Show("Datos Ingresados Exitosamente",
            "Editar Incidentes",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation


          );

            }

            cargar();
            

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            
           /*double a;
            a=double.Parse(txtcantidad.Text) + double.Parse(txtcantidad.Text);

            MessageBox.Show("El total de su compra es de  "+ a  ,
            "Cargar Productos",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            txtcantidad.Text = "0";*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["empleado"].Value);

                if (Valor == this.txtbusqueda.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Green;


                }
                else
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void cbm_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            i3nRiqJson x4 = new i3nRiqJson();
            string query4 = "select precio_compra from tbt_detalle_proveedor where producto_detalle_proveedorcol='" + cbm_producto.Text + "'";
            System.Collections.ArrayList array = x4.consultar(query4);



            foreach (Dictionary<string, string> dic in array)
            {
                txtprecio.Text = (dic["precio_compra"]);
               
              
                // Console.WriteLine("VIENEN: "+dic["employee_name"]);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbm_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbm_proveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            i3nRiqJson x7 = new i3nRiqJson();
            string query7 = "select idtbm_proveedor from tbm_acpro where nombre_proveedor='" + cbm_proveedor.Text + "'";
            System.Collections.ArrayList array7 = x7.consultar(query7);

            foreach (Dictionary<string, string> dic in array7)
            {
                datos_proveedor = (dic["idtbm_proveedor"] + "\n");
                // Console.WriteLine("VIENEN: "+dic["employee_name"]);

            }

            i3nRiqJson x3 = new i3nRiqJson();
            string query3 = "SELECT id_detalle_proveedorcol,producto_detalle_proveedorcol FROM tbt_detalle_proveedor where tbm_proveedor_idtbm_proveedor='" + datos_proveedor + "'";
            cbm_producto.DataSource = ((x3.consulta_DataGridView(query3)));
            cbm_producto.ValueMember = "id_detalle_proveedorcol";
            cbm_producto.DisplayMember = "producto_detalle_proveedorcol";

            MessageBox.Show("Lista de productos del proveedor   " + cbm_proveedor.Text + "  cargada exitosamente",
            "Cargar Productos",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information


          );

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
