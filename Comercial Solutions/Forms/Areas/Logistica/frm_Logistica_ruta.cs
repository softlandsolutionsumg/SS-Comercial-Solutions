using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ODBCConnect;
using System.Data.Odbc;
// Ejemplo de implementacion de formas jerarquicamente
using Comercial_Solutions.Forms;
using Comercial_Solutions.Forms.Areas;
using Comercial_Solutions.Clases;
using i3nRiqJSON;
using Generador_de_fechas;
using Comercial_Solutions.Forms.Principal;

namespace Comercial_Solutions.Forms.Areas.Logistica
{
    public partial class frm_Logistica_ruta : Form
    {
        int X = 0;
        int Y = 0;
        public frm_Logistica_ruta()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
            bt_confirmar.Hide();
            // string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //string stQuery = "select tbm_factura_id_factura as 'Factura', tbm_estadopedido_id_estadopedido as 'Bodega' from tbt_historialenvios where tbm_ubicacionpedido_id_ubicacionpedido=1 and tbm_estadopedido_id_estadopedido=1";
            // ContruirDatagridview(1, stQuery, "");
            tabControl1.TabPages.Remove(tabPage2);

            llenarbodega();
        }

        public void llenarbodega()
        {
            dataGridView1.Columns.Clear();
            Historial_Envios x = new Historial_Envios();
            // 1
            //MessageBox.Show("Intentanto consultar historial de bodega");
            dataGridView1.DataSource = (x.historialarea(2));

        }



        string stId_factura = "";
        string stViaje = "";
        i3nRiqJson gCon = new i3nRiqJson();



        public void Obtener_factura()
        {
            stId_factura = "";
            stId_factura = txt_buscar.Text;
        }

        public void AnalizarDATA()
        {
            try
            {
                int inX = 0;
                foreach (DataGridViewRow dgRow in dt_Ruta.Rows)
                {
                    DataGridViewCheckBoxCell dgChk = (DataGridViewCheckBoxCell)dgRow.Cells[0];
                    if (dgChk.Value == dgChk.FalseValue || dgChk.Value == null)
                    {
                        dgRow.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        Console.WriteLine("1");
                        dgChk.Value = dgChk.TrueValue;
                        inX++;
                    }
                    else
                    {
                        dgRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        Console.WriteLine("2");
                        dgChk.Selected = true;
                        dgChk.Value = dgChk.FalseValue;
                    }
                }
                if (inX == 0)
                {
                    Console.WriteLine("Todo limpio");
                    
                    CONFIRMARSI();
                    
            
                    agregar_historial(2);
                  salir();
                }
                else
                {
                    MessageBox.Show("Pedido pendiente");
                }
            }
            catch (Exception fe)
            {
                creardetalle();
            }
        }

        public void agregar_historial(int inX)
        {
            Historial_Envios x = new Historial_Envios();
            // Console.WriteLine("SE CAMBIO A - - -  estado 2");
            x.historial(inX, stId_factura);
        }

        public void ContruirDatagridview(int inX, string stQuery, string stQueryerror)
        {
            if (inX == 1)
            {
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = gCon.consulta_DataGridView(stQuery);
                }
                catch (Exception exE)
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = gCon.consulta_DataGridView(stQueryerror);
                }
            }
            if (inX == 2)
            {
                dt_Ruta.Columns.Clear();
                dt_Ruta.DataSource = gCon.consulta_DataGridView(stQuery);
                DataGridViewCheckBoxColumn dgCheckboxColumn = new DataGridViewCheckBoxColumn();
                //CheckBox chk = new CheckBox();    
                dgCheckboxColumn.Width = 20;
                dt_Ruta.Columns.Add(dgCheckboxColumn);
            }
        }

        public string TOTAL() {
            string total = "";

   int stsubquery=0;

             foreach (DataGridViewRow Fila in dt_Ruta.Rows)// recorrer fila por fila
            {

             
         
            stsubquery = stsubquery + (Convert.ToInt32(Fila.Cells[1].Value));
            Console.WriteLine("CANTIDAD: "+stsubquery);

       
            }
             total = (Convert.ToString(stsubquery));
            return total;
        
        }
    //
        int REFERENCIA = 0;
        int TOTALFAC = 0;
        string total = "";
        private void button1_Click(object obSender, EventArgs evE)
        {
            creardetalle();
            creardetalle();

            
            Vehiculos_rutas x = new Vehiculos_rutas();
            Fechalaborales c= new Fechalaborales();
            // Console.WriteLine("--" + x.RUTAXDEPARTAMENTO(textBox4.Text));
            
            
            
             lbl_ruta.Text = (x.RUTAXDEPARTAMENTO(textBox4.Text));
            
            string viaje=(x.EXISTENCIADEVIAJE(lbl_ruta.Text));
            stViaje = "";
            stViaje = stViaje + viaje;
            Console.WriteLine("======VIAJE=====>:::::"+viaje+"::");

           
            string cantidadxruta=(x.vehiculosdisponibles(lbl_ruta.Text));
            Console.WriteLine("TOTAL POR RUTA "+cantidadxruta);
             int cantidadxfactura = (Convert.ToInt32(TOTAL()));
             Console.WriteLine("TOTAL PARA LA FACTURA: " + cantidadxfactura);
             total = "";
             total = total + cantidadxfactura;
             textBox1.Text = total;
           string cantidadasignado=(x.utilizadoporfechayruta(lbl_ruta.Text, c.fechasiguiente()));//..
              Console.WriteLine("Capacidad: " + cantidadxruta+" Ingresados: "+cantidadasignado+" Nuevo ingreso: "+cantidadxfactura);

              int X = (Convert.ToInt32(cantidadxruta));
              int Y = (Convert.ToInt32(cantidadasignado));
              int Z = (Convert.ToInt32(cantidadxfactura));
              TOTALFAC = X;
              REFERENCIA = (Y + Z);
              //int YZ = (Y + Z);
            /**
           **/

            //DUDA
             // dataGridView3.DataSource = (x.ESPACIOPORVEHICULO(lbl_ruta.Text, c.fechasiguiente() + " 07:00:00"));
              //-- prbar 
            //  timer1.Start();
              dt_Vactual.DataSource = null;
              VEHICULOSNUEVOS();
        }

        private void dataGridView1_Click(object obSender, EventArgs evE)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void button2_Click(object obSender, EventArgs evE)
        {
        
        }

        public void buscarpendientesunicamente()
        {

            int xx = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)// recorrer fila por fila
            {


                string stsubquery = "";
                stsubquery = stsubquery + (Convert.ToString(Fila.Cells[0].Value));
                // Console.WriteLine("ENVIOS: "+stsubquery);
                if (stsubquery.Equals(stId_factura))
                {
                   
                    Historial_Envios x = new Historial_Envios();
                    dataGridView1.DataSource = (x.busquedaporarea(2, stId_factura));

                    MessageBox.Show("Factura encontrada");

                    xx++;
                }

            }

            if (xx == 0)
            {
                MessageBox.Show("No se encontro la factura");
                bt_confirmar.Hide();
                button1.Visible = false;
            }
            else
            {


                // Factura encontrada en el area de bodega pendiente
                button1.Visible = true;
            }
        }

        private void tabControl1_Click(object obSender, EventArgs evE)
        {
            confirmar();

        }

        private void button3_Click(object obSender, EventArgs evE)
        {
            
            AnalizarDATA();

           
        }

        private void dataGridView2_CellContentClick(object obSender, DataGridViewCellEventArgs dgE)
        {
        }


        public void salir()
        {

            DialogResult result = MessageBox.Show("Desea confirmar otro envio?", "Envios", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                confirmar();
                txt_buscar.Text = ("");
            }
            else if (result == DialogResult.No)
            {

                this.Hide();

            }


        }

        public void confirmar()
        {

            Historial_Envios x = new Historial_Envios();
            dataGridView1.DataSource = (x.historialarea(2));
            this.tabControl1.SelectedIndex = 0;
            tabControl1.TabPages.Remove(tabPage2);
            button1.Visible = false;
            bt_confirmar.Hide();
        }


        public void creardetalle()
        {


            Obtener_factura();
            this.tabControl1.SelectedIndex = 1;

            try
            {
                string stQuery1 = "select (select nombre from tbm_departamentos where tbm_departamentos.idtbm_departamentos=(select idtbm_departamentos from tbm_municipio where tbm_municipio.idtbm_municipio=(select idtbm_municipio from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente)))AS departamento,(select nombre from tbm_municipio where tbm_municipio.idtbm_municipio=(select idtbm_municipio from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente))AS municipio,(select direccion_cliente from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente)AS direccion,(select nombre_cliente from tbm_cliente where tbm_cliente.idtbm_cliente=tbm_factura.idtbm_cliente) AS cliente from tbm_factura where no_factura=" + stId_factura + "";
              //  string stQuery = "select cantidad AS Cantidad,idtbm_bodega AS Descripcion from tbt_detalle_factura where no_factura=" + stId_factura + "";


                string stQuery = "select cantidad AS Cantidad,(select tx_nombre from tbm_producto_finalizado where tbm_producto_finalizado.	idtbm_producto_finalizado=tbt_detalle_factura.tbm_producto_finalizado_idtbm_producto_finalizado) AS Descripcion from tbt_detalle_factura where no_factura=" + stId_factura + "";
                System.Collections.ArrayList arArray = gCon.consultar(stQuery1);
                foreach (Dictionary<string, string> dict in arArray)
                {
                    textBox2.Text = dict["cliente"];
                    textBox3.Text = dict["direccion"];
                    textBox4.Text = dict["departamento"];
                    textBox5.Text = dict["municipio"];
                }

                ContruirDatagridview(2, stQuery, "");

                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Insert(1, tabPage2);

                tabControl1.SelectTab("tabPage2");
                bt_confirmar.Show();

            }
            catch (Exception fe)
            {
                Console.WriteLine("Error ala hora de consultar detalle de factura");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           // string sSelectedClient = (string)comboBox1.SelectedValue;
            //lbl_uu.Text = (sSelectedClient);
        }



        public void CAMIONESSINASIGNAR(string viaje) {
            string cantidad = "";

            //string query2 = "select id_disponibilidadvehiculo from tbt_disponibilidadvehiculo where tbm_rutas_idtbm_rutas=" + lbl_ruta.Text + "";

            string query2 = "select id_disponibilidadvehiculo,(select capacidad from tbt_vehiculo where tbt_vehiculo.cod_vehiculo=tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo)AS capacidad from tbt_disponibilidadvehiculo where tbm_rutas_idtbm_rutas=" + lbl_ruta.Text + "";
            System.Collections.ArrayList array2 = gCon.consultar(query2);
            int intamanoarray2 = array2.Count;
           


            foreach (Dictionary<string, string> dict2 in array2)
            {
                    Console.WriteLine(">>>>>--GG-----");
                    string query = "select id_disponibilidadvehiculo from tbt_detalle_viajes where idtbm_viajes_logistica=" + viaje+ "";
                  // sss
                    System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            int xx = 0;
            
                    foreach (Dictionary<string, string> dict in array)
                        {

            //this.dt_Embarc.Rows.Add("", tx_Nombre.Text, cb_Tipo.Text + "(" + tx_Tamano.Text + ")");




                            if (dict2["id_disponibilidadvehiculo"].Equals(dict["id_disponibilidadvehiculo"]))
                {
                    Console.WriteLine("Encontro el vehiculo: " + dict2["id_disponibilidadvehiculo"] + " con el ID:" + dict["id_disponibilidadvehiculo"]);
                    xx++;
                }
                else {

                    Console.WriteLine("Falta el vehiculo: " + dict2["id_disponibilidadvehiculo"] + " con el ID:" + dict["id_disponibilidadvehiculo"]);

                }
                }
                    if (xx == 0) { 
                        //Console.WriteLine("Nunca se encontro el vehiculo: " + dict2["id_disponibilidadvehiculo"]+" con capacidad de"+dict2["capacidad"]);
                  dt_Vactual.Rows.Add(dict2["id_disponibilidadvehiculo"],dict2["capacidad"]);
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        

        }
        public void traspasar() {

            foreach (DataGridViewRow Fila in dataGridView3.Rows)// recorrer fila por fila
            {
                string stsubquery = "";
                stsubquery = stsubquery + (Convert.ToString(Fila.Cells[0].Value)); 
                string stsubquery2 = "";
                stsubquery2 = stsubquery2 + (Convert.ToString(Fila.Cells[1].Value));
                this.dt_Vactual.Rows.Add(stsubquery, stsubquery2);

            }
        }
        public void ASIGNAR(int cant) {

           
            int ERROR = 0;
            foreach (DataGridViewRow Fila in dt_Vactual.Rows)// recorrer fila por fila
            {
                if (ERROR == 0)
                {
                    int dips = ((Convert.ToInt32(Fila.Cells[1].Value)));
                    
                    int tope = 0;
                    if ((dips > cant)&&(tope==0))
                    {
                        dips = dips - cant;
                        
                        Fila.Cells[1].Value = dips;
                        ERROR = 1;
                        insertarING((Convert.ToString(Fila.Cells[0].Value)), (Convert.ToString(cant)), (txt_buscar.Text),stViaje);
                        Console.WriteLine("INSERCION|>| ID VEHICULO:" + (Convert.ToString(Fila.Cells[0].Value)) + " CANTIDAD: " + cant + " FACTURA: " + txt_buscar.Text + " VIAJE: " + stViaje);
                        cant = 0;
                        tope = 1;
                    }
                    if ((dips < cant) && (tope == 0))
                    {
                        cant = cant - dips;
                     
                        insertarING((Convert.ToString(Fila.Cells[0].Value)), (Convert.ToString(dips)), (txt_buscar.Text),stViaje);
                        Console.WriteLine("INSERCION|<| ID VEHICULO:" + (Convert.ToString(Fila.Cells[0].Value)) + " CANTIDAD: " + dips + " FACTURA: " + txt_buscar.Text + " VIAJE: " + stViaje);
                           dips = 0;
                        Fila.Cells[1].Value = dips;
                        tope = 1;
                    }
                    if ((dips == cant) && (tope == 0)) {
                        dips = 0;
                        
                        Fila.Cells[1].Value = dips;
                        insertarING((Convert.ToString(Fila.Cells[0].Value)), (Convert.ToString(cant)), (txt_buscar.Text),stViaje);
                        Console.WriteLine("INSERCION|=| ID VEHICULO:" + (Convert.ToString(Fila.Cells[0].Value)) + " CANTIDAD: " + cant + " FACTURA: " + txt_buscar.Text + " VIAJE: " + stViaje);
                        cant = 0;
                        tope = 1;
                        ERROR = 1;
                    }

                }
            }
        
        }

        public void insertarING(string idvehiculo,string cantidad,string factura,string viaje) {

               string tabla = "tbt_detalle_viajes";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("id_disponibilidadvehiculo",idvehiculo );
            dict.Add("unidades_carga",cantidad);
            dict.Add("idtbm_viajes_logistica", viaje);
            dict.Add("tbm_factura_id_factura",factura );
            gCon.insertar("1",tabla, dict);
           //;;;;
          //stViaje
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }


        public void VEHICULOSNUEVOS() {

            string query = "select id_disponibilidadvehiculo,(select capacidad from tbt_vehiculo where tbt_vehiculo.cod_vehiculo=tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo)AS capacidad from tbt_disponibilidadvehiculo where tbm_rutas_idtbm_rutas=" + lbl_ruta.Text + "";
           System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
          

            foreach (Dictionary<string, string> dict in array)
            {
               dt_Vactual.Rows.Add(dict["id_disponibilidadvehiculo"], dict["capacidad"]);
            }
        }


        public void INSERTARNUEVOVIAJE() {
            Fechalaborales c = new Fechalaborales();
            string tabla = "tbm_viajes_logistica";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("tbm_rutas_idtbm_rutas", lbl_ruta.Text);
            dict.Add("tx_fecha", c.fechasiguiente()+ " 07:00:00");
            dict.Add("tbm_estadopedido_id_estadopedido", "1");
            gCon.insertar("1",tabla, dict);
        
      
            string query2 = "select MAX(idtbm_viajes_logistica)AS idviajes from tbm_viajes_logistica";
            // string query = "select id_disponibilidadvehiculo,(select capacidad from tbt_vehiculo where tbt_vehiculo.cod_vehiculo=tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo)AS capacidad from tbt_disponibilidadvehiculo where tbm_rutas_idtbm_rutas=" + lbl_ruta.Text + "";
            System.Collections.ArrayList array2 = gCon.consultar(query2);
            int intamanoarray2 = array2.Count;


            foreach (Dictionary<string, string> dict2 in array2)
            {
                stViaje = "";
                stViaje=(dict2["idviajes"]);
               // this.dataGridView4.Rows.Add(dict["id_disponibilidadvehiculo"]);
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void CONFIRMARSI() {

            Vehiculos_rutas x = new Vehiculos_rutas();
            Fechalaborales c = new Fechalaborales();
            if (REFERENCIA > TOTALFAC)
            {
                Console.WriteLine("SE EXCEDE LA CAPACIDAD ADMITIDA POR RUTA");
                bt_confirmar.Enabled = false;
            }
            else
            {
                bt_confirmar.Enabled = true;
                if (stViaje.Equals(""))
                {
                    Console.WriteLine("Se creara un nuevo viaje");
                    VEHICULOSNUEVOS();
                    INSERTARNUEVOVIAJE();
                    ASIGNAR((Convert.ToInt32(textBox1.Text)));
                }
                else
                {

                    Console.WriteLine("Ya existe un camion para esta ruta: " + lbl_ruta.Text);
                    // string[] vector = cadena.Split(' ');
                    comboBox1.DataSource = (x.ESPACIOPORVEHICULO(lbl_ruta.Text, c.fechasiguiente() + " 07:00:00"));
                    comboBox1.DisplayMember = "id_disponibilidadvehiculo";
                    comboBox1.ValueMember = "Disponible";
                    // Console.WriteLine(""+comboBox1.DataBindings..DisplayMember+""+comboBox1.ValueMember)

                    dataGridView3.DataSource = (x.ESPACIOPORVEHICULO(lbl_ruta.Text, c.fechasiguiente() + " 07:00:00"));
                    //-- prbar 
                    timer1.Start();
                }
            }
            
        
        }

        public void STOP() {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //stViaje;
            Console.WriteLine("TRASPASAR AL DATAGGGGGGGGGG");
            traspasar();
            CAMIONESSINASIGNAR(stViaje);
               ASIGNAR((Convert.ToInt32(textBox1.Text)));
               STOP();
        
        }

        private void frm_Logistica_ruta_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Obtener_factura();
                //crear a que factura hacerle BUSQUEDA

                buscarpendientesunicamente();
                //  string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbm_factura_id_factura=" + stId_factura + " and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
                //  ContruirDatagridview(1, stQuery, "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones");
           

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        }
    }
