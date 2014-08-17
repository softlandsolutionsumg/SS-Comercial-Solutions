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
using System.Collections;

namespace Comercial_Solutions.Forms.Areas.Logistica
{
    public partial class frm_inventario : Form
    {
        int X = 0;
        int Y = 0;
        public frm_inventario()
        {
            X = Propp.X;
            Y = Propp.Y;
            
            InitializeComponent();
        }
        i3nRiqJson x = new i3nRiqJson();

        //banderas de indican seleccion de combos
        bool ingresarpedido = false;
        bool ingresoproducto = false;
        bool pestana_productos = false;
        bool pestaña_inventario = false;
        bool seleccioninsercionordencompra = false;
        bool seleccioninsercionalmacen = false;

        bool seleccionalmacen = false;
        bool selecciondelproducto = false; 

        //guardo id del almacen seleccionado
        string idalmacen;
        //guardo id del producto seleccionado
        string idproducto;
        //almaceno la cantidad en el inventario
        string guardacantidad;
        string guardarcantidadproducto;
        //almaceno la cantidad en producto finalizado
        string guardaproducto;

        int cantidadaactualizar = 0;
        int cantidadproductoaactualizar = 0;


        private void Inventario_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);

          
           
           // llenarconsultaproductos();
           llenarconsultainventarios();
            //llenarconsultaalertas();
           XX();
        }

        public void XX()
        {
            string query = "select p.tx_nombre as 'Nombre del Producto', i.cantidad as 'Cantidad', b.nombre_bodega as 'Ubicado en Bodega', i.inventario_minimo as 'Cantidad minima permitida' from tbt_inventario as i, tbm_almacen as b, tbm_producto_finalizado as p where i.tbm_almacen_idtbm_bodega = b.idtbm_bodega and i.tbm_producto_finalizado_idtbm_producto_finalizado = p.idtbm_producto_finalizado";
            System.Collections.ArrayList array = x.consultar(query);

            int intamanoarray = array.Count;


            List<string> Modulos = new List<string>();
            int xx = 0;
            foreach (Dictionary<string, string> dict in array)
            {

                dgv_vista_consulta.Rows[xx].Cells[0].Value = (dict["Nombre del Producto"]);
                dgv_vista_consulta.Rows[xx].Cells[1].Value = (dict["Cantidad"]);
                dgv_vista_consulta.Rows[xx].Cells[2].Value = (dict["Ubicado en Bodega"]);
                dgv_vista_consulta.Rows[xx].Cells[3].Value = (dict["Cantidad minima permitida"]);
                xx++;
            }

        }

        

        public void llenarconsultainventarios()
        {
            string consulta = "select p.tx_nombre as 'Nombre del Producto', i.cantidad as 'Cantidad', b.nombre_bodega as 'Ubicado en Bodega', i.inventario_minimo as 'Cantidad mínima permitida' from tbt_inventario as i, tbm_almacen as b, tbm_producto_finalizado as p where i.tbm_almacen_idtbm_bodega = b.idtbm_bodega and i.tbm_producto_finalizado_idtbm_producto_finalizado = p.idtbm_producto_finalizado";
            dgv_vista_consulta.DataSource = ((x.consulta_ComboBox(consulta)));
            
        }
        public void sumarinventario()
        {
            //selecciono el valor actual en el inventairo
            string suma = "select cantidad from tbt_inventario where id_almacen = " + cmb_almacen.SelectedValue.ToString() + "";
            System.Collections.ArrayList array = x.consultar(suma);
            foreach (Dictionary<string, string> dic in array)
            {
                guardacantidad = (dic["cantidad"]);

            }

            //selecciono el valor actual en el producto finalizado
            string sumapro = "select cantidad_producto_finalizado as Cantidad from tbm_producto_finalizado where p.idtbm_producto_finalizdo = i.tbm_producto_finalizado_idtbm_producto_finalizado  and i.tbm_almacen_idtbm_bodega = " + cmb_almacen.SelectedValue.ToString() + "";
            System.Collections.ArrayList arrayy = x.consultar(suma);
            foreach (Dictionary<string, string> dic in arrayy)
            {
                guardacantidad = (dic["cantidad"]);

            }

            //capturo y convierto mi cantidad de producto del arreglo a entero
            int cantidadasumar = Convert.ToInt32(guardacantidad);

            //convierto a entero la cantidad del pedido
            int sumando = Convert.ToInt32(lbl_cantidad.Text);

            //sumo las dos cantidades para obtener el nuevo valor
            cantidadaactualizar = cantidadasumar + sumando;
        }
        public void restarproductofinalizado()
        {
            //selecciono el valor actual de productos
            string resta = "select cantidad_producto_finalizado from tbm_producto_finalizado where idtbm_producto_finalizado = " + cmb_insertar_nombre_producto.SelectedValue.ToString() + "";
            System.Collections.ArrayList array = x.consultar(resta);
            foreach (Dictionary<string, string> dic in array)
            {
                guardaproducto = (dic["cantidad"]);

            }

            //capturo y convierto mi cantidad de producto del arreglo a entero
            int cantidadarestar = Convert.ToInt32(guardaproducto);
            //convierto a entero la cantidad del pedido
            int restando = Convert.ToInt32(lbl_cantidad.Text);
            //sumo las dos cantidades para obtener el nuevo valor
            cantidadproductoaactualizar = cantidadarestar + restando;
        }
       
        public void insertar()
        {
           

                sumarinventario();
                //actualizo mi inventairo                
                string insercionproductos = "tbt_inventario";
                string condicion = "tbm_almacen_idtbm_bodega = '" + cmb_almacen + "'";
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("cantidad", cantidadproductoaactualizar.ToString());
                //dict.Add("tbm_almacen_idtbm_bodega", cmb_bodega.SelectedValue.ToString());
                dict.Add("tbm_producto_finalizado_idtbm_producto_finalizado", cmb_insertar_nombre_producto.SelectedValue.ToString());
                x.actualizar("3", insercionproductos, dict, condicion);
                
                //resto de mi inventario
                //string restadeproducto = "tbm_producto_finalizado";
                //string condicion1 = "id_tbm_producto_finalizado = '" + lbl_id_producto.ToString() + "'";
                //Dictionary<string, string> dict1 = new Dictionary<string, string>();
                //dict.Add("cantidad_producto_finalizado", cantidadproductoaactualizar.ToString());
                //dict.Add("ultima_vez_modificado", DateTime.Now.ToString("yyyy-MM-dd"));
                //x.actualizar("3", restadeproducto, dict1, condicion1);
            
            
            //if (ingresoproducto == true)
            //{
               

                

               
            //}
            //actualizo mis grids después de insertar
            //llenarconsultaproductos();
            //llenarconsultainventarios();
            //llenarconsultaalertas();
        }
         
        
        private void cmb_bodega_Click(object sender, EventArgs e)
        {
            string query = "Select * from  tbm_almacen ";
            cmb_bodega.DataSource = (x.consulta_ComboBox(query));
            cmb_bodega.DisplayMember = "nombre_bodega";
        }

        private void cmb_ambiente_Click(object sender, EventArgs e)
        {
            string query = "Select * from tbm_producto_finalizado";
            cmb_ambiente.DataSource = (x.consulta_ComboBox(query));
            cmb_ambiente.DisplayMember = "tx_nombre";
        }

       
        public void combobodega()
        
        {
            //string query = "select * from tbm_almacen";
            //cmb_seleccion_bodega.DataSource = ((x.consulta_ComboBox(query)));
            //cmb_seleccion_bodega.DisplayMember = "nombre_bodega";
            //cmb_seleccion_bodega.ValueMember = "idtbm_bodega";

//            idalmacen = cmb_seleccion_bodega.SelectedValue.ToString();
            //bandera de selección del almacén activa
  //          seleccioninsercionalmacen = true;

            //string consulta = "Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where "+idalmacen+" = a.idtbm_bodega and p.idtbm_producto_finalizado = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
            //dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consulta)));

            //if (selecciondelproducto == true)
            //{
               // string consultaprincipal = " Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where " + idalmacen + " = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
              //  dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaprincipal)));
            //}
            //else
            //{
             //   string consultaalmacen = "Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where i.tbm_almacen_idtbm_bodega = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
           //     dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaalmacen)));
         //   } 
        }

        public void comboalmacen()
        {

            string query = "select * from tbm_almacen";
            cmb_almacen.DataSource = ((x.consulta_ComboBox(query)));
            cmb_almacen.DisplayMember = "nombre_bodega";
            cmb_almacen.ValueMember = "idtbm_bodega";

            idalmacen = cmb_almacen.SelectedValue.ToString();
            seleccioninsercionalmacen = true;

        }
        
        

       

        private void cmb_selección_producto_Click(object sender, EventArgs e)
        {
            string query = "select * from tbm_producto_finalizado";
            //cmb_selección_producto.DataSource = ((x.consulta_ComboBox(query)));
            //cmb_selección_producto.DisplayMember = "tx_nombre";
         //   cmb_selección_producto.ValueMember = "idtbm_producto_finalizado";
//
           // idproducto = cmb_selección_producto.SelectedValue.ToString();
            selecciondelproducto = true;
 
            //if (seleccionalmacen == true)
            //{
              //  string consultaprincipal = " Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where " + idalmacen + " = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
                //dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaprincipal)));
            //}
            //else
            //{
                string consultaproducto = "Select p.tx_nombre as 'Nombre', i.cantidad as 'Cantidad',p.medida_producto as 'Dimencional',p.precio_costo as 'Costo del producto', p.ultima_vez_modificado as 'Fecha de ultimo ingreso' from tbm_producto_finalizado as p, tbt_inventario as i, tbm_almacen as a where i.tbm_almacen_idtbm_bodega = a.idtbm_bodega and " + idproducto + " = i.tbm_producto_finalizado_idtbm_producto_finalizado order by p.idtbm_producto_finalizado";
                dgv_vista_consulta.DataSource = ((x.consulta_DataGridView(consultaproducto)));
            //} 
            
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            insertar();
            llenarconsultainventarios();
           // XX();

        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
               
                 
               
                   gpb_inventarios.Visible = true;
        }

        private void cmb_orden_p_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CargarDetalleOrden();
        }

        private void cmb_almacen_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

    
      
        public void cargarcomboxproducto()
        {
            string consulta = "select idtbm_producto_finalizado, tx_nombre from tbm_producto_finalizado ";
            cmb_insertar_nombre_producto.DataSource = ((x.consulta_ComboBox(consulta)));
            cmb_insertar_nombre_producto.DisplayMember = "tx_nombre";
            cmb_insertar_nombre_producto.ValueMember = "idtbm_producto_finalizado";
        }

        public void cargarcomboxalmacen()
        {
            string consulta = "select idtbm_bodega, nombre_bodega from tbm_almacen ";
            cmb_almacen.DataSource = ((x.consulta_ComboBox(consulta)));
            cmb_almacen.DisplayMember = "nombre_bodega";
            cmb_almacen.ValueMember = "idtbm_bodega";
        }
        
        

        private void tab_consulta_Click(object sender, EventArgs e)
        {
            
        }

        private void g_Click(object sender, EventArgs e)
        {
            
            
            //llenarconsultaproductos();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarconsultainventarios();
            //llenarconsultaproductos();
            //llenarconsultaalertas();
            //XX();
        }

        private void llenarconsultaalertas()
        {
            string query = "select (select nombre_bodega from tbm_almacen where  tbm_almacen.idtbm_bodega=tbt_inventario.tbm_almacen_idtbm_bodega)as ALMACEN,(select medida_producto from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado=tbt_inventario.tbm_producto_finalizado_idtbm_producto_finalizado)as medida,(select tx_nombre from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado=tbt_inventario.tbm_producto_finalizado_idtbm_producto_finalizado)as Nombre,(inventario_minimo-cantidad)as 'PRODUCTO FALTANTE' from tbt_inventario where tbt_inventario .cantidad<tbt_inventario.inventario_minimo";
            dgv_alertas.DataSource = ((x.consulta_DataGridView(query))); 
            
            
        }
        public void CargarDetalleProductos()
        {


            string condicional = cmb_insertar_nombre_producto.SelectedValue.ToString();

            string query = "select cantidad_producto_finalizado as CANTIDAD,precio_costo,medida_producto from tbm_producto_finalizado where tbm_producto_finalizado.idtbm_producto_finalizado= '"+cmb_insertar_nombre_producto.SelectedValue.ToString()+"'";

            ArrayList array = x.consultar(query);
            foreach (Dictionary<string, string> v in array)
            {

                lbl_cantidad.Text = v["CANTIDAD"];
                lbl_precio_costo.Text = v["precio_costo"];
                lbl_medida.Text = v["medida_producto"];
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            cargarcomboxproducto();
            cargarcomboxalmacen();
            
            comboalmacen();
            //combobodega();
        }

        private void cmb_orden_p_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            //CargarDetalleOrden();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            llenarconsultaalertas();
            //XX();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dgv_alertas_Click(object sender, EventArgs e)
        {
            llenarconsultaalertas();
        }

        private void cmb_insertar_nombre_producto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDetalleProductos();
        }

        
    }
}

