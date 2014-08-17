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
    public partial class frm_Proveedores : Form
    {
        int X = 0;
        int Y = 0;
        public frm_Proveedores()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if ((txtnombre.Text.Equals("")) || (txttelefono.Text.Equals("")))
            {

                MessageBox.Show("ALGUNO ESTA VACIO");
            }
            else
            {

                string tabla = "tbm_acpro";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("nombre_proveedor", txtnombre.Text);
                dict.Add("telefono_proveedor", txttelefono.Text);
                dict.Add("direccion_proveedor", txtdireccion.Text);
                dict.Add("tipo_acpro", txttipoproveedor.Text);
                




                i3nRiqJson x = new i3nRiqJson();
                x.insertar("1", tabla, dict);






                MessageBox.Show("Datos Ingresados Exitosamente",
            "Editar Incidentes",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation


          );

            }

            cargar();
            desactivartextbox();


        }
        public void desactivartextbox()
        {
             txtnombre.Enabled=false;
            txttelefono.Enabled=false;
           txtdireccion.Enabled=false;
           txttipoproveedor.Enabled = false;
         }
        public void cargar()
        {
            i3nRiqJson x = new i3nRiqJson();
            string query2 = "SELECT `nombre_proveedor` as Nombre,`telefono_proveedor` as Telefono,`direccion_proveedor` as Direccion,`tipo_acpro`as Tipo FROM `tbm_acpro` ";
            dataGridView1.DataSource = ((x.consulta_DataGridView(query2)));
        }
        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            desactivartextbox();

            cargar();
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm_elimarproveedor x = new frm_elimarproveedor();
            x.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txttelefono.Enabled = true;
            txtdireccion.Enabled = true;
            txttipoproveedor.Enabled = true;

     txtnombre.Text="";
           txttelefono.Text="";
           txtdireccion.Text="";
           txttipoproveedor.Text = "";
                

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_editarproveedor x = new frm_editarproveedor();
            x.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
