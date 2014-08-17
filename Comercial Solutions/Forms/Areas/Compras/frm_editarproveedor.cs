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
    public partial class frm_editarproveedor : Form
    {
        string datos_proveedor;
        i3nRiqJson x = new i3nRiqJson();

        public frm_editarproveedor()
        {
            InitializeComponent();
        }
        public void cargarproveedor()
        {
          
            string query = "select idtbm_proveedor,nombre_proveedor from tbm_acpro";
            cmb_empleado.DataSource = ((x.consulta_DataGridView(query)));
            cmb_empleado.ValueMember = "idtbm_proveedor";
            cmb_empleado.DisplayMember = "nombre_proveedor";

           

          
        }

       
        private void frm_editarproveedor_Load(object sender, EventArgs e)
        {
            cargarproveedor();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            string query4 = "select idtbm_proveedor from tbm_acpro where nombre_proveedor='" + cmb_empleado.Text + "'";
            System.Collections.ArrayList array = x.consultar(query4);



            foreach (Dictionary<string, string> dic in array)
            {
                datos_proveedor = (dic["idtbm_proveedor"] + "\n");
                // Console.WriteLine("VIENEN: "+dic["employee_name"]);

            }

           
            string tabla = "tbm_acpro";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("nombre_proveedor", txtnombre.Text);
            dict.Add("telefono_proveedor", txttelefono.Text);
            //dict2.Add("departamento", comboBox2.Text);
            dict.Add("direccion_proveedor", txtdireccion.Text);
            dict.Add("tipo_acpro", txttipoproveedor.Text);

            string condicion = "idtbm_proveedor= " + datos_proveedor;
            x.actualizar("3", tabla, dict, condicion);



            MessageBox.Show("Datos Actualizados Exitosamente",
        "Editar Proveedores",
        MessageBoxButtons.OK);
            cargarproveedor();


         txtnombre.Text="";
         txttelefono.Text = "";
            
             txtdireccion.Text="";
          txttipoproveedor.Text="";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            string query4 = "select nombre_proveedor,telefono_proveedor,direccion_proveedor,tipo_acpro from tbm_acpro where nombre_proveedor='" + cmb_empleado.Text + "'";
            System.Collections.ArrayList array = x.consultar(query4);



            foreach (Dictionary<string, string> dic in array)
            {
                txtnombre.Text = (dic["nombre_proveedor"]);
                txttelefono.Text = (dic["telefono_proveedor"]);
                txtdireccion.Text = (dic["direccion_proveedor"]);
                txttipoproveedor.Text = (dic["tipo_acpro"]);
               
                // Console.WriteLine("VIENEN: "+dic["employee_name"]);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
