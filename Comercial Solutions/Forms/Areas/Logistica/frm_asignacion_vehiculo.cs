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
    public partial class frm_asignacion_vehiculo : Form
    {
        int X = 0;
        int Y = 0;
        string VEHICULO = "";
            string UBICACION="";
        string RUTA="";
        i3nRiqJson gCon = new i3nRiqJson();
        public frm_asignacion_vehiculo()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();

            actualizardatos();
            cmb_usovehiculo.SelectedIndex++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_asignacion_vehiculo_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
           
        }

        public void actualizardatos() {
            
            Historial_Envios x = new Historial_Envios();

            cmb_vehiculos.DataSource = (x.busquedavehiculos("en ruta", "mantenimiento", "disponible"));
            //dataGridView1.DataSource = (x.busquedavehiculos("en ruta", "mantenimiento"));
            cmb_vehiculos.DisplayMember = "placa_vehiculo";
            cmb_vehiculos.ValueMember = "cod_vehiculo";
            if (cmb_vehiculos.Text.Equals(""))
            {
                groupBox2.Visible = false;


            }

            string Query = "select * from tbm_establecimiento";
            cmb_ubicacion.DataSource = (gCon.consulta_ComboBox(Query));
            cmb_ubicacion.DisplayMember = "tx_establecimiento";
            cmb_ubicacion.ValueMember = "cod_establecimiento";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ubicacion cambia 
            buscarrutas();
        }


        public void datagridbuscar(int x) {


            string clausula = "";
            clausula = cmb_ubicacion.Text;
            string Query = "";
            try
            {
                if (x == 1) {

                    Query = "select (select placa_vehiculo from tbt_vehiculo where tbt_vehiculo.cod_vehiculo=tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo)AS Placa,tx_uso AS Uso ,(tx_disponibilidadvehiculo) AS Estado,(select tx_rutas from tbm_rutas where tbm_rutas.idtbm_rutas=tbt_disponibilidadvehiculo.tbm_rutas_idtbm_rutas)AS Ruta from tbt_disponibilidadvehiculo where tbm_establecimiento_cod_establecimiento=(select cod_establecimiento from tbm_establecimiento where tx_establecimiento ='" + clausula + "')";
                
                }
                if (x == 2) {
                    // subquery
                    Query = "select (select placa_vehiculo from tbt_vehiculo where tbt_vehiculo.cod_vehiculo=tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo)AS Placa,tx_uso AS Uso ,(tx_disponibilidadvehiculo) AS Estado,(select tx_rutas from tbm_rutas where tbm_rutas.idtbm_rutas=tbt_disponibilidadvehiculo.tbm_rutas_idtbm_rutas)AS Ruta from tbt_disponibilidadvehiculo where tbm_establecimiento_cod_establecimiento=(select cod_establecimiento from tbm_establecimiento where tx_establecimiento ='" + clausula + "')  AND tbm_rutas_idtbm_rutas=(" + cmb_ruta.SelectedValue.ToString() + ")";
               
                
                }
              //  MessageBox.Show("CONSULTAMOS REALMENTE: "+Query);

                dt_VxR.DataSource = (gCon.consulta_DataGridView(Query));
                dt_VxR.Visible = true;
                
            }
            catch (Exception c) {

                dt_VxR.Visible = false;
            }
        
        }
        public void buscarrutas() {
            Console.WriteLine("Buscar rutas activado");
            string clausula = "";
            clausula = cmb_ubicacion.Text;
           // Console.WriteLine("DD: "+clausula);
            string Query = "select idtbm_rutas,tx_rutas from tbm_rutas where tbm_establecimiento_cod_establecimiento=(select cod_establecimiento from tbm_establecimiento where tx_establecimiento ='" + clausula + "')";
            
            
            
            
            //
            System.Collections.ArrayList arArray2 = gCon.consultar(Query);
            int inTamano_array2 = arArray2.Count;

            if (inTamano_array2 > 0) {
               // Console.WriteLine("SE EJECUTO: "+Query);
                cmb_ruta.DataSource = (gCon.consulta_ComboBox(Query));

                //cmb_ruta.Visible = true;
              //  label2.Visible = true;
               pnl_rutas.Visible = true;
                //Disponible detalles

            cmb_ruta.DisplayMember = "tx_rutas";
             cmb_ruta.ValueMember = "idtbm_rutas";
             //datagridbuscar();
            // dataGridView1.Visible = true;

            } else {

                dt_VxR.Visible = false;
                pnl_rutas.Visible = false;
               // cmb_ruta.Visible = false;
           // label2.Visible=false;
            }
            
            
        }

        private void barra1_click_buscar_button()
        {

        }

        public void guardarvehiculo() {

            try
            {

                string stQuery = "select cod_vehiculo from tbt_vehiculo where placa_vehiculo='" + this.cmb_vehiculos.Text + "'";
                System.Collections.ArrayList arArray = gCon.consultar(stQuery);
                foreach (Dictionary<string, string> dict1 in arArray)
                { VEHICULO = dict1["cod_vehiculo"]; }

                string stQuery2 = "select cod_establecimiento from tbm_establecimiento where tx_establecimiento='" + this.cmb_ubicacion.Text + "'";
                System.Collections.ArrayList arArray2 = gCon.consultar(stQuery2);
                foreach (Dictionary<string, string> dict12 in arArray2)
                { UBICACION = dict12["cod_establecimiento"]; }


                string stQuery22 = "select idtbm_rutas from tbm_rutas where tx_rutas='" + this.cmb_ruta.Text + "'";
                System.Collections.ArrayList arArray22 = gCon.consultar(stQuery22);
                foreach (Dictionary<string, string> dict122 in arArray22)
                { RUTA = dict122["idtbm_rutas"]; }
                //cmb_usovehiculo.

                string tabla = "tbt_disponibilidadvehiculo";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("tbt_vehiculo_cod_vehiculo",VEHICULO);
                dict.Add("tbm_establecimiento_cod_establecimiento",UBICACION);
                dict.Add("tx_disponibilidadvehiculo", "disponible");
                dict.Add("tbm_rutas_idtbm_rutas",RUTA);


                dict.Add("tx_uso", this.cmb_usovehiculo.Text);
                

                gCon.insertar("1",tabla, dict);
                MessageBox.Show("Vehiculo registrado");
            }
            catch (Exception fe) {
                MessageBox.Show("Datos no se ah podido guardar");

            }

        
        }

        private void barra1_click_guardar_button()
        {
            
        }

        private void barra1_click_actualizar_button()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            datagridbuscar(2);
            buscarrutas(); 
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            actualizardatos();
            pnl_rutas.Visible = false;
            // cmb_ruta.Visible = false;
            //  label2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if ((this.cmb_ubicacion.Text.Equals("")) && (cmb_ruta.Text.Equals("")))
            {
                dt_VxR.Visible = false;
                MessageBox.Show("Seleccione una ubicacion");
            }
            else
            {
                dt_VxR.Visible = true;
                datagridbuscar(1); // mostrando todos
                buscarrutas();
            }
            actualizardatos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guardarvehiculo();
        }
    }
}
