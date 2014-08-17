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
    public partial class frm_Logistica_autorizacion_salida : Form
    {
        public frm_Logistica_autorizacion_salida()
        {
            InitializeComponent();
            button3.Hide();
            dataGridView3.Hide();
            // string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //string stQuery = "select tbm_factura_id_factura as 'Factura', tbm_estadopedido_id_estadopedido as 'Bodega' from tbt_historialenvios where tbm_ubicacionpedido_id_ubicacionpedido=1 and tbm_estadopedido_id_estadopedido=1";
            // ContruirDatagridview(1, stQuery, "");
            tabControl1.TabPages.Remove(tabPage2);
            llenarviajes();
        }

        public void llenarviajes()
        {
            //Historial_Envios x = new Historial_Envios();
            //// 1
            //dataGridView1.DataSource = (x.historialarea(1));
            string stQuery = "SELECT idtbm_viajes_logistica as Viaje, tbm_rutas_idtbm_rutas as Ruta FROM  `tbm_viajes_logistica` WHERE tbm_estadopedido_id_estadopedido = 1 and tx_fecha >= ADDDATE( NOW( ) , -1 ) AND tx_fecha < ADDDATE( NOW( ) , 1 ) ";
            ContruirDatagridview(1, stQuery, "");
        }
        
        string stId_viaje = "";

        i3nRiqJson gCon = new i3nRiqJson();

        public void Obtener_cod_viaje()
        {
            stId_viaje = "";
            stId_viaje = txt_buscar.Text;
        }

        public void AnalizarDATA()
        {
            try
            {
                int inX = 0;
                foreach (DataGridViewRow dgRow in dataGridView2.Rows)
                {
                    DataGridViewCheckBoxCell dgChk = (DataGridViewCheckBoxCell)dgRow.Cells[0];
                    if (dgChk.Value == dgChk.FalseValue || dgChk.Value == null)
                    {
                        dgRow.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        Console.WriteLine("..1");
                        dgChk.Value = dgChk.TrueValue;
                        inX++;
                    }
                    else
                    {
                        dgRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        Console.WriteLine("..2");
                        dgChk.Selected = true;
                        dgChk.Value = dgChk.FalseValue;
                    }
                }
                if (inX == 0)
                {
                    Console.WriteLine("Todo limpio");
                    //agregar reparando
                    foreach (DataGridViewRow Fila in dataGridView3.Rows)// recorrer fila por fila
                    {
                        Historial_Envios x = new Historial_Envios();
                        //// Console.WriteLine("SE CAMBIO A - - -  estado 2");                        
                        Console.Write("---------------->Factura: " + Convert.ToString(Fila.Cells[0].Value));
                        x.historial(3, Convert.ToString(Fila.Cells[0].Value));
                    }
                    salir();
                }
                else
                {
                    MessageBox.Show("Producto faltante");
                }
            }
            catch (Exception fe)
            {
                creardetalle();
            }
        }

        public void ContruirDatagridview(int inX, string stQuery, string stQueryerror)
        {
            if (inX == 1)
            {
                try
                {
                    dataGridView1.Columns.Clear();
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
                dataGridView2.Columns.Clear();
                dataGridView2.DataSource = gCon.consulta_DataGridView(stQuery);
                DataGridViewCheckBoxColumn dgCheckboxColumn = new DataGridViewCheckBoxColumn();
                //CheckBox chk = new CheckBox();    
                dgCheckboxColumn.Width = 20;
                dataGridView2.Columns.Add(dgCheckboxColumn);
            }
            if (inX == 3)
            {
                dataGridView3.Columns.Clear();
                dataGridView3.DataSource = gCon.consulta_DataGridView(stQuery);
            }
        }
        
        private void button1_Click(object obSender, EventArgs evE)
        {
            creardetalle();
            creardetalle();
        }

        private void dataGridView1_Click(object obSender, EventArgs evE)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void button2_Click(object obSender, EventArgs evE)
        {
            tabControl1.TabPages.Remove(tabPage2);
            button1.Hide();
            button3.Hide();
            Obtener_cod_viaje();
            //crear a que factura hacerle BUSQUEDA
            buscarpendientesunicamente();
            //  string stQuery = "select tbm_factura_id_factura as 'Factura', tx_ubicacionpedido as 'Ubicacion', tx_estadopedido as 'Estado' from tbm_estadopedido, tbm_ubicacionpedido, tbt_historialenvios where tbm_factura_id_factura=" + stId_factura + " and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=1 and tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido=tbm_ubicacionpedido.id_ubicacionpedido and tbt_historialenvios.tbm_estadopedido_id_estadopedido=1 and tbt_historialenvios.tbm_estadopedido_id_estadopedido=tbm_estadopedido.id_estadopedido";
            //  ContruirDatagridview(1, stQuery, "select idAplicaciones AS Codigo, txAplicacion AS Descripcion, frAplicacion AS Cantidad from aplicaciones");
        }

        public void buscarpendientesunicamente()
        {
            int xx = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)// recorrer fila por fila
            {
                string stsubquery = "";
                stsubquery = stsubquery + (Convert.ToString(Fila.Cells[0].Value));
                // Console.WriteLine("ENVIOS: "+stsubquery);
                if (stsubquery.Equals(stId_viaje))
                {
                    Historial_Envios x = new Historial_Envios();
                    dataGridView1.DataSource = (x.busquedadeviaje(stId_viaje));
                    MessageBox.Show("Regitro de viaje encontrado");
                    xx++;
                }
            }
            if (xx == 0)
            {
                MessageBox.Show("No se encontro registro del viaje");
                button3.Hide();
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
            //agrupando();
            ContruirDatagridview(3, "SELECT DISTINCT tbm_factura_id_factura AS Factura FROM tbt_detalle_viajes where tbm_factura_id_factura=" + stId_viaje, "");
            AnalizarDATA();
        }

        public void salir()
        {
            llenarviajes(); 
            tabControl1.TabPages.Remove(tabPage2);
            button1.Hide();
            button3.Hide();
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
            //string stActualizar_estado = "UPDATE `tbm_viajes_logistica` SET `tbm_estadopedido_id_estadopedido`=[value-4] WHERE idtbm_viajes_logistica = " + stId_viaje;
            string stCondicion="idtbm_viajes_logistica = " + stId_viaje;
            string stTabla1 = "tbm_viajes_logistica";
            Dictionary<string, string> diDict2 = new Dictionary<string, string>();
            diDict2.Add("tbm_estadopedido_id_estadopedido", Convert.ToString(2));
            gCon.actualizar("3",stTabla1, diDict2, stCondicion);            
        }

        public void confirmar()
        {
            llenarviajes();
            this.tabControl1.SelectedIndex = 0;
            tabControl1.TabPages.Remove(tabPage2);
            button1.Visible = false;
            button3.Hide();
        }
        
        public void creardetalle()
        {
            this.tabControl1.SelectedIndex = 1;
            try
            {
                string stQuery1 = "SELECT idtbm_viajes_logistica AS Viaje, tbm_rutas_idtbm_rutas AS Ruta, tx_fecha AS Fecha FROM  `tbm_viajes_logistica` WHERE idtbm_viajes_logistica = " + stId_viaje;
                //string stQuery = "SELECT tbm_factura_id_factura AS Factura, id_disponibilidadvehiculo AS Vehiculo FROM  `tbt_detalle_viajes` WHERE idtbm_viajes_logistica =" + stId_viaje + " order by id_disponibilidadvehiculo";
                string stQuery = "SELECT dv.tbm_factura_id_factura AS Factura,  c.tbt_vehiculo_cod_vehiculo AS Vehiculo FROM  tbt_detalle_viajes as dv, tbt_disponibilidadvehiculo as c WHERE idtbm_viajes_logistica =" + stId_viaje + " and dv.id_disponibilidadvehiculo=c.id_disponibilidadvehiculo ORDER BY c.tbt_vehiculo_cod_vehiculo";
                System.Collections.ArrayList arArray = gCon.consultar(stQuery1);
                foreach (Dictionary<string, string> dict in arArray)
                {
                    textBox2.Text = dict["Viaje"];
                    textBox3.Text = dict["Ruta"];
                    string stFormat_datetime = "dd/MM/yyyy";
                    DateTime fecha2 = DateTime.Parse(dict["Fecha"]);
                    //fecha2.ToString(stFormat_datetime);
                    //DateTime dt = Convert.ToDateTime(date);            
                    //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
                    textBox4.Text = fecha2.ToString(stFormat_datetime);
                }
                ContruirDatagridview(2, stQuery, "");
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Insert(1, tabPage2);

                tabControl1.SelectTab("tabPage2");
                button3.Show();
            }
            catch (Exception fe)
            {
                Console.WriteLine("Error ala hora de consultar detalle de factura");
            }
        }

        private void frm_Logistica_autorizacion_salida_Load(object sender, EventArgs e)
        {

        }
    }
}