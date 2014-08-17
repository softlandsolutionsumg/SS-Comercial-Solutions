using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ODBCConnect;
using i3nRiqJSON;
using System.Data.Odbc;
//Ejemplo de implementacion de formas jerarquicamente
using Comercial_Solutions.Forms;
using Comercial_Solutions.Forms.Areas;
using Comercial_Solutions.Forms.Areas.Logistica;


namespace Comercial_Solutions.Clases
{
    class Historial_Envios
    {

        i3nRiqJson gCon = new i3nRiqJson();

        public void historial(int inCaso, string stFactura)
        {
            int inEstado = 0;
            int inUbicacion = 0;
            DateTime dtActual = DateTime.Now;
            string stFormat_datetime = "yyyy-MM-dd HH:mm:ss";
            switch (inCaso)
            {
                case 0://ingreso de nueva factura, area comercial
                    inUbicacion = 1;
                    inEstado = 1;
                    break;

                case 1: //validacion de producto, area logistica
                   // Console.WriteLine("SE CAMBIO A - - -  estado 2"+inUbicacion+"   - "+inEstado);
                    inUbicacion = 1;
                    inEstado = 2;
                    break;

                case 2: //producto seleccionado y apartado, listo para ser cargado al camion, planificado su envio en viaje especifico, area logistica
                    inUbicacion = 2;
                    inEstado = 2;
                    break;

                case 3: //producto cargado al camion, viaje en ruta, producto en camino, "shipping", area logistica
                    inUbicacion = 3;
                    inEstado = 2;
                    break;

                case 4: //confirmacion de entrega de producto a destinatario, area logistica
                    inUbicacion = 4;
                    inEstado = 2;
                    break;

                case 5: //confirmacion de anulacion o declinacion a pedido por parte de destinatario, area logistica
                        //confirmacion de anulacion de pedido, area comercial o financiera
                    inUbicacion = 4;
                    inEstado = 3;
                    break;
            }
            string stTabla1 = "tbt_historialenvios";
            Dictionary<string, string> diDict2x2_1 = new Dictionary<string, string>();
            diDict2x2_1.Add("tx_fecha", dtActual.ToString(stFormat_datetime));
            diDict2x2_1.Add("tbm_factura_id_factura", stFactura);
            diDict2x2_1.Add("tbm_ubicacionpedido_id_ubicacionpedido", inUbicacion.ToString());
            diDict2x2_1.Add("tbm_estadopedido_id_estadopedido", inEstado.ToString());
            gCon.insertar("1",stTabla1, diDict2x2_1);
            Console.WriteLine(" >> "+diDict2x2_1);
            //Console.WriteLine("Fecha y hora: " + DateTime.Now.ToShortTimeString());
            if (inEstado == 2)
            {
                if (inUbicacion != 4)
                {
                    inUbicacion++;
                    inEstado = 1;
                    string stTabla2 = "tbt_historialenvios";
                    Dictionary<string, string> diDict2x2_2 = new Dictionary<string, string>();
                    diDict2x2_2.Add("tx_fecha", dtActual.ToString(stFormat_datetime));
                    diDict2x2_2.Add("tbm_factura_id_factura", stFactura);
                    diDict2x2_2.Add("tbm_ubicacionpedido_id_ubicacionpedido", inUbicacion.ToString());
                    diDict2x2_2.Add("tbm_estadopedido_id_estadopedido", inEstado.ToString());
                    gCon.insertar("1", stTabla2, diDict2x2_2);
                }
            }
        }


        public BindingSource busquedaporarea(int ubicacion, string filtro)
        {

            //string querybeta="(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion";
            string query = "select tbm_factura_id_factura,(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion, id_historialenvios from tbt_historialenvios WHERE tbm_ubicacionpedido_id_ubicacionpedido =  " + ubicacion + " and tbm_factura_id_factura=" + filtro + "";
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            DataTable dt = new DataTable();
            dt.Columns.Add("Factura");
            //
            dt.Columns.Add("Ubicacion");
            dt.Columns.Add("Estado");

            foreach (Dictionary<string, string> dict in array)
            {


                dt.Rows.Add(dict["tbm_factura_id_factura"].ToString(), dict["ubicacion"].ToString(), "pendiente");
                //    dt.Rows.Add(new object[] { dict["tbm_factura_id_factura"].ToString() }, new object[] { "hoa" }, new object[] { "hoa" });//+stubicacion);//,"pendiente");



            }

            var source = new BindingSource();
            source.DataSource = dt;
            return source;


        }


        public BindingSource busquedadeviaje(string filtro)
        {
            string query = "SELECT idtbm_viajes_logistica AS Viaje, tbm_rutas_idtbm_rutas AS Ruta FROM  `tbm_viajes_logistica` WHERE idtbm_viajes_logistica = " + filtro;
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            DataTable dt = new DataTable();
            dt.Columns.Add("Viaje");
            dt.Columns.Add("Ruta");

            foreach (Dictionary<string, string> dict in array)
            {
                //string date = dict["Fecha"];
                //DateTime dts = Convert.ToDateTime(date);
                //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
                //DateTime fecha2 = dts.Day + "/" + dts.Month + "/" + dts.Year;
                //string stFormat_datetime = "dd/MM/yyyy";
                //DateTime fecha2 = DateTime.Parse(dict["Fecha"]);
                //fecha2.ToString(stFormat_datetime);
                //dt.Rows.Add(dict["Viaje"].ToString(), dict["Ruta"].ToString(), fecha2);
                dt.Rows.Add(dict["Viaje"].ToString(), dict["Ruta"].ToString());
                //    dt.Rows.Add(new object[] { dict["tbm_factura_id_factura"].ToString() }, new object[] { "hoa" }, new object[] { "hoa" });//+stubicacion);//,"pendiente");
            }

            var source = new BindingSource();
            source.DataSource = dt;
            return source;


        }


        public BindingSource busquedavehiculos(string disp1,string disp2,string disp3)// vehiculos disponibles
        {

            //string querybeta="(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion";
            string query = "select cod_vehiculo, placa_vehiculo, capacidad,tx_marca from tbt_vehiculo";
            
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            DataTable dt = new DataTable();

            dt.Columns.Add("cod_vehiculo");
            dt.Columns.Add("placa_vehiculo");             
            dt.Columns.Add("capacidad");
            dt.Columns.Add("tx_marca");
           
            //

            try
            {
                foreach (Dictionary<string, string> dict in array)
                {
                    try
                    {
                        string cod = (dict["cod_vehiculo"]);
                        string placa = (dict["placa_vehiculo"]);
                        string capacidad = (dict["capacidad"]);
                        string marca = (dict["tx_marca"]);


                        string stQuery2 = "select tbt_vehiculo_cod_vehiculo from tbt_disponibilidadvehiculo where tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo = '" + cod + "' AND (tx_disponibilidadvehiculo = '" + disp1 + "' or tx_disponibilidadvehiculo = '" + disp2 + "' or tx_disponibilidadvehiculo = '" + disp3 + "');";
                        //              string stQuery2 = "select tbt_vehiculo_cod_vehiculo from tbt_disponibilidadvehiculo where tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo = " + dict["cod_vehiculo"].ToString() + " AND (tx_disponibilidadvehiculo = '" + disp1 + "' or tx_disponibilidadvehiculo = '" + disp2 + "')";


                        System.Collections.ArrayList arArray2 = gCon.consultar(stQuery2);
                        int inTamano_array2 = arArray2.Count;

                        //  Console.WriteLine("ENVIADO: " + inTamano_array2);


                        if (inTamano_array2 > 0)
                        {

                            // MessageBox.Show("XX - - - " + stQuery2);  
                        }
                        else
                        {

                            dt.Rows.Add(cod, placa, capacidad, marca);
                        }
                        // MessageBox.Show("2XX - - - " + stQuery2);
                        // dt.Rows.Add("", Convert.ToString(intamanoarray));
                        //  dt.Rows.Add("1","2","555","FFF");
                    }
                    catch (Exception ff)
                    {
                        // string k = "--";
                        //  string B = "--";
                        //  string C = "--";
                        //   string D = "--";
                    }

                    // Console.WriteLine("CODIGO: " + dict["cod_vehiculo"] + " " + dict["placa_vehiculo"] + " " + dict["capacidad"]);
                    //



                }
            }
            catch (Exception s) {
                Console.WriteLine("Ërror encontrado: " + s);
            }
           
            var source = new BindingSource();
            source.DataSource = dt;
            return source;


        }



        public BindingSource historialarea(int ubicacion)
        {
            // 
            //string querybeta="(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion";
            string stQuery = "select tbm_factura_id_factura,(select tx_ubicacionpedido from tbm_ubicacionpedido where tbm_ubicacionpedido.id_ubicacionpedido=tbt_historialenvios.tbm_ubicacionpedido_id_ubicacionpedido)AS ubicacion, id_historialenvios from tbt_historialenvios WHERE tbm_ubicacionpedido_id_ubicacionpedido =  " + ubicacion + "";
            System.Collections.ArrayList arArray = gCon.consultar(stQuery);
            int inTamano_array = arArray.Count;
            //MessageBox.Show("No de registros en array 1: "+inTamano_array);
            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("Factura");
            //
            dtTable.Columns.Add("Ubicacion");
            dtTable.Columns.Add("Estado");
            try
            {
            foreach (Dictionary<string, string> dict in arArray)
            {

              //  MessageBox.Show(dict["tbm_factura_id_factura"]);
                

                string stQuery2 = "select id_historialenvios from tbt_historialenvios WHERE tbm_factura_id_factura=" + dict["tbm_factura_id_factura"] + " and (tbm_estadopedido_id_estadopedido =  '3' or tbm_estadopedido_id_estadopedido =  '2') and tbm_ubicacionpedido_id_ubicacionpedido="+ubicacion+"";


              
                    System.Collections.ArrayList arArray2 = gCon.consultar(stQuery2);
                    int inTamano_array2 = arArray2.Count;
                  //  MessageBox.Show("No de registros en array 2: " + inTamano_array2);
                
               
                
                
                 if (inTamano_array2 > 0)
                 {
                  //   MessageBox.Show("XX - - - " + stQuery2);  
                 }
                 else
                 {
                   //  MessageBox.Show("2XX - - - "+stQuery2);  
                   dtTable.Rows.Add(dict["tbm_factura_id_factura"].ToString(), dict["ubicacion"].ToString(), "pendiente");
                     //dt.Rows.Add(new object[] { dict["tbm_factura_id_factura"].ToString() }, new object[] { "hoa" }, new object[] { "hoa" });//+stubicacion);//,"pendiente");
                 }/*  **/
            }
             }catch (Exception e) { }
          
            var vaSource = new BindingSource();
            vaSource.DataSource = dtTable;
            return vaSource;
        }
    }
}