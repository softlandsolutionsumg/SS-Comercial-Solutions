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
    public partial class frm_productos_finalizados : Form
    {
        
        int X = 0;
        int Y = 0;
        public frm_productos_finalizados()
        {
            
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
        }
        i3nRiqJson x = new i3nRiqJson();

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
        private void frm_produccion_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
            cargar();
     


        }
        public void cargarcomboboxproduccion()
        {
            string consulta = "select idtbm_ordendeproduccion from tbm_ordendeproduccion where estado = 1";
            cmb_orden_p.DataSource = ((x.consulta_ComboBox(consulta)));
            cmb_orden_p.DisplayMember = "idtbm_ordendeproduccion";
            cmb_orden_p.ValueMember = "idtbm_ordendeproduccion";

        }
        public void CargarDetalleOrden()
        {


            //seleccioninsercionordencompra = true;

            string condicional = cmb_orden_p.SelectedValue.ToString();

            string query = "select tbm_producto_finalizado_idtbm_producto_finalizado as 'ID Producto', (select f.tx_nombre from tbm_producto_finalizado as f, tbm_ordendeproduccion as pr where f.idtbm_producto_finalizado = pr.tbm_producto_finalizado_idtbm_producto_finalizado and pr.idtbm_ordendeproduccion = " + condicional + ") as 'nombre',producto_requerido as 'cantidad' from tbm_ordendeproduccion where idtbm_ordendeproduccion = " + condicional + " ";

            ArrayList array = x.consultar(query);
            foreach (Dictionary<string, string> v in array)
            {

                lbl_nom_producto.Text = v["nombre"];
                lbl_numero.Text = v["cantidad"];
                lbl_id_producto.Text = v["ID Producto"];
            }
        }

        public void sumarproductos()
        {
            //selecciono el valor actual en el inventairo
            string suma = "select cantidad_producto_finalizado from tbm_producto_finalizado where idtbm_producto_finalizado = " + lbl_id_producto.Text + "";
            System.Collections.ArrayList array = x.consultar(suma);
            foreach (Dictionary<string, string> dic in array)
            {
                guardarcantidadproducto = (dic["cantidad_producto_finalizado"]);

            }

            //capturo y convierto mi cantidad de producto del arreglo a entero
            int cantidadasumar = Convert.ToInt32(guardarcantidadproducto);

            //convierto a entero la cantidad del pedido
            int sumando = Convert.ToInt32(lbl_numero.Text);

            //sumo las dos cantidades para obtener el nuevo valor
            cantidadaactualizar = cantidadasumar + sumando;
        }

        public void llenarconsultaproductos()
        {


            string query2 = "Select tx_nombre as 'Nombre', cantidad_producto_finalizado as 'Cantidad',medida_producto as 'Dimencional',precio_costo as 'Costo del producto', ultima_vez_modificado as 'Fecha de último ingreso' from tbm_producto_finalizado order by idtbm_producto_finalizado ";
            dgv_vista.DataSource = ((x.consulta_DataGridView(query2)));

        }

        public void cargar()
        {
            cargarcomboboxproduccion();
            CargarDetalleOrden();
            llenarconsultaproductos();
        }
        public void inserta()
        {

            sumarproductos();
            string tabla1 = "tbm_producto_finalizado";
            string condicion2 = "idtbm_producto_finalizado = '" + lbl_id_producto.Text + "'";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("cantidad_producto_finalizado", cantidadaactualizar.ToString());
            dict.Add("ultima_vez_modificado", DateTime.Now.ToString("yyyy-MM-dd"));

            x.actualizar("3", tabla1, dict, condicion2);
            //quito la orden de mi combo cambiando el estado
            string estado = "tbm_ordendeproduccion";
            string condicionestado = "idtbm_ordendeproduccion ='" + cmb_orden_p.SelectedValue.ToString() + "'";
            Dictionary<string, string> dicct = new Dictionary<string, string>();
            int nuevoestado = 3;
            dicct.Add("estado", nuevoestado.ToString());

            x.actualizar("3", estado, dicct, condicionestado);
            //MessageBox.Show("Trae " + i3nRiqJson.RespuestaConexion.ToString());
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inserta();
            cargar();

        }
       

 
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            gpb_ingreso.Visible = true;
        }

        private void cmb_orden_p_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            CargarDetalleOrden();
        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            gpb_consulta.Visible = true;
        }
    }
}
