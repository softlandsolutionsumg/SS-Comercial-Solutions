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
//Ejemplo de implementacion de formas jerarquicamente
using Comercial_Solutions.Forms;
using Comercial_Solutions.Forms.Areas;
using Comercial_Solutions.Forms.Areas.Logistica;
using Comercial_Solutions.Clases;
using Generador_de_fechas;
using i3nRiqJSON;


namespace Comercial_Solutions.Clases
{
    class Vehiculos_rutas
    {

        i3nRiqJson gCon = new i3nRiqJson();
        public string EXISTENCIADEVIAJE(string ruta) {
            string viaje = "";
            Fechalaborales x = new Fechalaborales();

            string query = "select * from tbm_viajes_logistica where tbm_rutas_idtbm_rutas=" + ruta + " and tx_fecha='" + x.fechasiguiente() + " 07:00:00" + "'";
           // Console.WriteLine("QUERY: "+query);
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            foreach (Dictionary<string, string> dict in array)
            {
                Console.WriteLine("-->>>>||");
                viaje = (dict["idtbm_viajes_logistica"]);
            }


            return viaje;
        
        }
        public string utilizadoporfechayruta(string ruta, string fechafutura)
        {
            string cantidad = "";


            string query = "select id_disponibilidadvehiculo,unidades_carga from tbt_detalle_viajes where idtbm_viajes_logistica=(select idtbm_viajes_logistica from tbm_viajes_logistica where tx_fecha='" + fechafutura + " 07:00:00' and tbm_rutas_idtbm_rutas='" + ruta + "')";

            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            int capacidad = 0;
            //Console.WriteLine("SQL/ "+query);
            foreach (Dictionary<string, string> dict in array)
            {
                capacidad = capacidad + (Convert.ToInt32(dict["unidades_carga"]));
            //    Console.WriteLine("\t"+dict["id_disponibilidadvehiculo"] + " -unidades de carga: " + dict["unidades_carga"]);
                //string query2 = "select capacidad from tbt_vehiculo where cod_vehiculo=" + dict["tbt_vehiculo_cod_vehiculo"] + "";

                //System.Collections.ArrayList array2 = gCon.consultar(query2);
                //int intamanoarray2 = array2.Count;
                //foreach (Dictionary<string, string> dict2 in array2)
                //{
                  //  capacidad = capacidad + (Convert.ToInt32(dict2["capacidad"]));
                    //Console.WriteLine("capacidad: " + dict2["capacidad"]+" total"+capacidad);
                //}

               
            }
            
            cantidad = "";
            cantidad = cantidad + capacidad;
         //   Console.WriteLine("Ingresados x Ruta: " + capacidad);
            return cantidad;
        }

        public string vehiculosdisponibles(string ruta) {
            string cantidad = "";

            string query = "select tbt_vehiculo_cod_vehiculo,(select capacidad from tbt_vehiculo where tbt_vehiculo.cod_vehiculo=tbt_disponibilidadvehiculo.tbt_vehiculo_cod_vehiculo) as capacidad from tbt_disponibilidadvehiculo where tbm_rutas_idtbm_rutas=" + ruta + "";
            
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            int capacidad = 0;
            try
            {
                foreach (Dictionary<string, string> dict in array)
                {
                    capacidad = capacidad + (Convert.ToInt32(dict["capacidad"]));

                  
                }
              
            }
            catch (Exception e) { }
           
            cantidad = cantidad + capacidad;
        
            return cantidad;
        }

        public string RUTAXDEPARTAMENTO(string departamento) {
            string ruta = "";

            string query = "select tbm_rutas_idtbm_rutas,parada_detallerutascol from tbt_detallerutas where tbm_departamentos_idtbm_departamentos=(select idtbm_departamentos from tbm_departamentos where nombre='" + departamento + "')";
            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            foreach (Dictionary<string, string> dict in array)
            {

                ruta=(dict["tbm_rutas_idtbm_rutas"]);
            }

            return ruta;
        }



        public BindingSource ESPACIOPORVEHICULO(string ruta, string fechafutura)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_disponibilidadvehiculo");
            //
            dt.Columns.Add("Disponible");

            //Console.WriteLine("ESPACIO POR VEHICULO: \n \n");
            string cantidad = "";

            string query = "select tbt_vehiculo_cod_vehiculo,id_disponibilidadvehiculo from tbt_disponibilidadvehiculo where tbm_rutas_idtbm_rutas=" + ruta + "";

            System.Collections.ArrayList array = gCon.consultar(query);
            int intamanoarray = array.Count;
            int capacidad = 0;

            foreach (Dictionary<string, string> dict in array)
            {

                //Console.WriteLine(dict["tbt_vehiculo_cod_vehiculo"]);
                string query2 = "select capacidad from tbt_vehiculo where cod_vehiculo=" + dict["tbt_vehiculo_cod_vehiculo"] + "";
                
                System.Collections.ArrayList array2 = gCon.consultar(query2);
                int intamanoarray2 = array2.Count;
                foreach (Dictionary<string, string> dict2 in array2)
                {
                    //Console.WriteLine((dict2["capacidad"])+"Capacidades de query: "+query);
                    string queryx = "select unidades_carga from tbt_detalle_viajes where idtbm_viajes_logistica=(select idtbm_viajes_logistica from tbm_viajes_logistica where tx_fecha='" + fechafutura + " 07:00:00' and tbm_rutas_idtbm_rutas='" + ruta + "') and id_disponibilidadvehiculo="+dict["id_disponibilidadvehiculo"]+"";


                    System.Collections.ArrayList arrayx = gCon.consultar(queryx);
                    int intamanoarrayx = arrayx.Count;
                    
                    foreach (Dictionary<string, string> dictx in arrayx)
                    {

                        string capacidadv = (dict2["capacidad"]);
                        string carga = (dictx["unidades_carga"]);
                       // Console.WriteLine("Capacidad del vehiculo: "+capacidadv+" Unidades cargadas:"+carga);
                        int CV = (Convert.ToInt32(capacidadv));
                        int CC = (Convert.ToInt32(carga));
                        int TO = CV - CC;
                        if (TO == 0) { 
                            
                            Console.WriteLine(dict["id_disponibilidadvehiculo"]+" Vehiculo lleno");
                        }
                        if (TO > 0) { 
                            
                           Console.WriteLine(dict["id_disponibilidadvehiculo"]+" Tiene una capacidad de: "+TO);
                        string xx=(Convert.ToString(TO));
                        dt.Rows.Add(dict["id_disponibilidadvehiculo"],xx);
                        
                        }

                     }




                    capacidad = capacidad + (Convert.ToInt32(dict2["capacidad"]));
                   // Console.WriteLine("\t capacidad: " + dict2["capacidad"] + " total" + capacidad);
                }
                cantidad = "";
              //  Console.WriteLine("Capacidad x Ruta: " + capacidad);
                cantidad = cantidad + capacidad;
            }

            var source = new BindingSource();
            source.DataSource = dt;
            return source;

}



    }
}
