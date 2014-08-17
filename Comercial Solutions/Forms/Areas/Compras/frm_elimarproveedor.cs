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
  
    public partial class frm_elimarproveedor : Form
    {
        string datos_proveedor; 
        public frm_elimarproveedor()
        {
            InitializeComponent();
        }

        private void frm_elimarproveedor_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargargrid()
        {
            i3nRiqJson x = new i3nRiqJson();
            string query2 = "SELECT `nombre_proveedor`,`telefono_proveedor`,`direccion_proveedor`,`tipo_acpro` FROM `tbm_acpro` where nombre_proveedor='" + cbm_empleado.Text + "'";
            dataGridView1.DataSource = ((x.consulta_DataGridView(query2)));
        }
        public void cargar()
        {
            i3nRiqJson x2 = new i3nRiqJson();
            string query = "SELECT 	idtbm_proveedor,nombre_proveedor FROM tbm_acpro";
            cbm_empleado.DataSource = ((x2.consulta_DataGridView(query)));
            cbm_empleado.ValueMember = "idtbm_proveedor";
            cbm_empleado.DisplayMember = "nombre_proveedor";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cargargrid();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            i3nRiqJson x = new i3nRiqJson();


            i3nRiqJson x4 = new i3nRiqJson();
            string query4 = "select Idtbm_proveedor from tbm_acpro  where nombre_proveedor='" + cbm_empleado.Text + "'";
            System.Collections.ArrayList array = x4.consultar(query4);



            foreach (Dictionary<string, string> dic in array)
            {
                datos_proveedor = (dic["Idtbm_proveedor"] + "\n");
                // Console.WriteLine("VIENEN: "+dic["employee_name"]);


            }
            string tabla = "tbm_acpro";
            string condicion = "Idtbm_proveedor=" + datos_proveedor;

            x.eliminar("4", tabla, condicion);
            MessageBox.Show("datos eliminados correctamente");
            cargar();
            cargargrid();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }   
    }
}
