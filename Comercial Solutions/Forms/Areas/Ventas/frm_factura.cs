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
using Comercial_Solutions.Forms.Principal;
using i3nRiqJSON;
using System.Collections;

namespace Comercial_Solutions.Forms.Areas.Ventas
{
    public partial class frm_factura : Form
    {
        int X = 0;
        int Y = 0;
        i3nRiqJson db = new i3nRiqJson();
        bool crearcliente=false;
        float inDescuento = 0;
        int c = 0;
        int inCLiente = 0;
        int inMunicipio = 0;
        string idCLIENTE = "";
        public frm_factura()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
           
        }

        private void frm_factura_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
            cargarudepartamento();
            Console.WriteLine(Propp.nombre + " " + Propp.apellido);
            
            CargarInformacion();
        }

        public void cargarudepartamento()
        {


            string query = "SELECT idtbm_departamentos,nombre FROM tbm_departamentos";
            cmb_departamento.DataSource = ((db.consulta_ComboBox(query)));
            cmb_departamento.DisplayMember = "nombre";
            cmb_departamento.ValueMember = "idtbm_departamentos";

        }

        public void cargarmunicipio()
        {

            Console.WriteLine("Se selecciono");
            string query = "SELECT idtbm_municipio,nombre,idtbm_departamentos,cod_postal FROM tbm_municipio where idtbm_departamentos='" + cmb_departamento.SelectedValue.ToString() + "'";
            cmb_municipio.DataSource = ((db.consulta_ComboBox(query)));
            cmb_municipio.DisplayMember = "nombre";
            cmb_municipio.ValueMember = "idtbm_municipio";
        }


        public void CargarInformacion() {
            txtPRUEBA.Text = Propp.IdV + " - " + Propp.nombre + " " + Propp.apellido;
            string queryest = "select tx_establecimiento,cod_establecimiento from tbm_establecimiento";
          cmb_establecimiento.DataSource=(db.consulta_ComboBox(queryest));
          cmb_establecimiento.DisplayMember = "tx_establecimiento";
          cmb_establecimiento.ValueMember = "cod_establecimiento";
          cmb_establecimiento.SelectedIndex = 0;

            string queryfact="select (MAX(no_factura))as no_fact from tbm_factura";
             System.Collections.ArrayList array = db.consultar(queryfact);

          
                foreach (Dictionary<string, string> dic in array){

                    c = (int.Parse(dic["no_fact"]));
                    c++;
                }

                lblcorrelativo.Text = ("Factura No:  F - 0"+c);


                CargarProductoPorEstablecimiento();
            //
              
            //}
            //catch (Exception d) { }
            //    
        }

        public void ARMAR(string XX) {
            System.Collections.ArrayList array6 = db.consultar("select tx_nombre from tbm_producto_finalizado where idtbm_producto_finalizado=" + XX+ ";");

            foreach (Dictionary<string, string> dic2 in array6)
            {
                Console.WriteLine(dic2["tx_nombre"]);
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab)||(e.KeyCode == Keys.Enter))
            {
              
                if ((textBox2.Text.Equals("CF")) || (textBox2.Text.Equals("cf")) || (textBox2.Text.Equals("")))
                {
                textBox2.Text=("CF");
                crearcliente = true;
                idCLIENTE = "";
                }
                else { 
               CargarNITCliente();

                }
            }

        }

        public void CargarNITCliente() {

            string queryfact = "select idtbm_cliente,nombre_cliente,direccion_cliente,(select nombre from tbm_municipio where tbm_municipio.idtbm_municipio=tbm_cliente.idtbm_municipio)as Municipio,(select nombre from tbm_departamentos where tbm_departamentos.idtbm_departamentos=(select idtbm_departamentos from tbm_municipio where tbm_municipio.idtbm_municipio=tbm_cliente.idtbm_municipio))as depto, idtbm_municipio,(select cantidad from tbm_descuento where tbm_descuento.idtbm_descuento=tbm_descuento_idtbm_descuento)as descuento,(select descuento from tbm_descuento where tbm_descuento.idtbm_descuento=tbm_descuento_idtbm_descuento)as porcentaje from tbm_cliente where nit_cliente='" + textBox2.Text + "'";
            System.Collections.ArrayList array = db.consultar(queryfact);
            int c = array.Count;

            if (c > 0) {
                lbl_Descuento.Visible = true;
                lbl_PORCENTAJE.Visible = true;
                crearcliente = false;
                foreach (Dictionary<string, string> dic in array)
                {
                    idCLIENTE = "";
                    idCLIENTE = (dic["idtbm_cliente"]);
                    txt_nombre.Text = (dic["nombre_cliente"]);
                    txt_direccion.Text = (dic["direccion_cliente"]);
                    cmb_municipio.Text = dic["Municipio"];
                    cmb_departamento.Text = dic["depto"];
                    lbl_PORCENTAJE.Text = dic["porcentaje"];
                    inDescuento = (float.Parse(dic["descuento"]));
                    Console.WriteLine("SUPER DESCUENTO SOBRE: "+inDescuento);
                    inMunicipio = (int.Parse(dic["idtbm_municipio"]));
                }
            } else {
                crearcliente = true;
                lbl_Descuento.Visible = false;
                lbl_PORCENTAJE.Visible = false;
                MessageBox.Show("No existe este cliente");
                


            }
          

        }


        public void CargarProductoPorEstablecimiento() {
            string queryEst = "select DISTINCT(tbm_producto_finalizado_idtbm_producto_finalizado),tx_nombre from tbm_almacen,tbt_inventario,tbm_producto_finalizado where tbm_almacen.tbm_establecimiento_cod_establecimiento='" + cmb_establecimiento.SelectedValue.ToString() + "' AND tbt_inventario.tbm_almacen_idtbm_bodega=tbm_almacen.idtbm_bodega AND  tbm_producto_finalizado.idtbm_producto_finalizado	=tbm_producto_finalizado_idtbm_producto_finalizado";


            cmb_producto.DataSource = (db.consulta_ComboBox(queryEst));
            cmb_producto.DisplayMember = "tx_nombre";
            cmb_producto.ValueMember = "tbm_producto_finalizado_idtbm_producto_finalizado";

            if (cmb_producto.Text.Equals(""))
            {

                
                NOfacturar();
                MessageBox.Show("No tiene permitido facturar");
            }
            else {

                SIfacturar();
            }

        }

        private void cmb_establecimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarProductoPorEstablecimiento();
        }

        public void Resetear() {

            txt_cantidad.Text = "";
            txt_direccion.Text = "";
            txt_nombre.Text = "";
           
            cmb_municipio.Text = "";
            cmb_departamento.SelectedIndex = 0;
            lbl_Descuento.Visible = false;
            lbl_PORCENTAJE.Visible = false;
            textBox2.Text = "";

            while (dtg_detalle.RowCount > 0)
            {

                dtg_detalle.Rows.Remove(dtg_detalle.CurrentRow);

            }
            txt_TOTAL.Text = "0";

        }

        public void SIfacturar() {


            grp_detalle.Visible = true;
            pnl_producto.Visible = true;
        
        }

        public void NOfacturar() {
            grp_detalle.Visible = false;
            pnl_producto.Visible = false;
        
        
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if ((txt_precio.Text.Equals("")) || (txt_cantidad.Text.Equals("")))
            {

            }
            else { 
            AgregaralDetalle();
            }
        }


       

        private void cmb_departamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarmunicipio();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Resetear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            Resetear();
            textBox2.Text = "";
        }
        public void Registrarcliente() {
            string queryfact = "select (MAX(idtbm_cliente))as idtbm_cliente from tbm_cliente";
            System.Collections.ArrayList array = db.consultar(queryfact);


            foreach (Dictionary<string, string> dic in array)
            {

                inCLiente = (int.Parse(dic["idtbm_cliente"]));
                inCLiente++;
            }
            idCLIENTE=Convert.ToString(inCLiente);
            string tabla = "tbm_cliente";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("idtbm_cliente", idCLIENTE);
            dict.Add("nombre_cliente", txt_nombre.Text);
            dict.Add("nit_cliente", textBox2.Text);
            dict.Add("direccion_cliente", txt_direccion.Text);

           
                dict.Add("idtbm_municipio", cmb_municipio.SelectedValue.ToString());
           
            
            dict.Add("tbm_descuento_idtbm_descuento", "4");

            db.insertar("1", tabla, dict);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea facturar?", "Factura", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (crearcliente == true)
                {
                    Registrarcliente();
                }
                else { }
             
                verificarTOTAL();
                //do somethingasd
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

           
        }

        public void GUARDARFACTURA() {

            string tabla = "tbm_factura";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("no_factura",(Convert.ToString(c)));
            dict.Add("fecha_factura", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            dict.Add("idtbm_vendedor", Propp.IdV);
            dict.Add("idtbm_cliente", idCLIENTE);
            dict.Add("total", txt_TOTAL.Text);
            dict.Add("referencia_cheque", "A1");
            dict.Add("referencia_tarjeta", "VV");
            dict.Add("tbm_almacen_idtbm_bodega", cmb_establecimiento.SelectedValue.ToString());
            dict.Add("tbm_estado_factura_idtbm_estado_factura", "1");
            //referencia_cheque	referencia_tarjeta	tbm_almacen_idtbm_bodega	tbm_estado_factura_idtbm_estado_factura
            db.insertar("1", tabla, dict);



        // no de facturac
        //Propp.IdV
        }

        public void guardardetallefactura(string cantidad, string producto) {

            string tabla = "tbt_detalle_factura";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("no_factura",(Convert.ToString(c)));
            dict.Add("cantidad", cantidad);
            dict.Add("tbm_producto_finalizado_idtbm_producto_finalizado", producto);
             dict.Add("idtbm_bodega",cmb_establecimiento.SelectedValue.ToString());

            db.insertar("1", tabla, dict);
      
        
        }

        public void verificarTOTAL()
        {
            int ESTADOFACTURA = 0;
            Cls_Inventario d = new Cls_Inventario();

            // GUARDAR FACTURA
            GUARDARFACTURA();

            foreach (DataGridViewRow row in dtg_detalle.Rows)
            {
                Console.WriteLine("RECORRIENDO EL DATAGRIDVIEW " + row.Cells[0].Value);
                string query = "select G.tbm_almacen_idtbm_bodega as almacen,G.cantidad as CantidadINV ,G.tbm_producto_finalizado_idtbm_producto_finalizado as IDProdu from (select DISTINCT(tbm_producto_finalizado_idtbm_producto_finalizado),tx_nombre,cantidad,tbm_almacen_idtbm_bodega from tbm_almacen,tbt_inventario,tbm_producto_finalizado where tbm_almacen.tbm_establecimiento_cod_establecimiento='" + cmb_establecimiento.SelectedValue.ToString() + "' AND tbt_inventario.tbm_almacen_idtbm_bodega=tbm_almacen.idtbm_bodega AND  tbm_producto_finalizado.idtbm_producto_finalizado	=tbm_producto_finalizado_idtbm_producto_finalizado)as G where 	G.tx_nombre='" + row.Cells[1].Value.ToString() + "'";
                //  v1 += Convert.ToInt32(row.Cells[0].Value);
                ArrayList f = (db.consultar(query));
                int CantidadINVENTARIO = 0;
                int CantidadSOLICITADA = Convert.ToInt32(row.Cells[0].Value);
                string IDProducto = "";
                string IDAlmacen = "";
                foreach (Dictionary<string, string> dic in f)
                {
                    CantidadINVENTARIO = Convert.ToInt32(dic["CantidadINV"]);
                    IDProducto = dic["IDProdu"];
                    IDAlmacen = dic["almacen"];
                  //  Console.WriteLine("Esta enviandose " + dic["almacen"]);
                }
                if (CantidadINVENTARIO > CantidadSOLICITADA)
                {
                    Restar(IDProducto,IDAlmacen,CantidadSOLICITADA);
                    // restar y crear orden
                   // MessageBox.Show("restar y crear orden del producto "+IDProducto);
                   // Restar(IDProducto,
                    Crearorden(IDProducto, CantidadSOLICITADA);
                    guardardetallefactura(Convert.ToString(CantidadSOLICITADA), IDProducto);
                }
                else {
                    ESTADOFACTURA++;
                    //MessageBox.Show("solo crear orden del producto " + IDProducto);
                // solo crear orden
                    Crearorden(IDProducto,CantidadSOLICITADA);
                    guardardetallefactura(Convert.ToString(CantidadSOLICITADA), IDProducto);
                }

            }


            



        }

        public void AgregaralDetalle()
        {
            

             double DD = ((Convert.ToDouble(txt_precio.Text))*(Convert.ToDouble(txt_cantidad.Text)));
        
            this.dtg_detalle.Rows.Add(txt_cantidad.Text, cmb_producto.Text.ToString(), txt_precio.Text,DD);

            double TOTAL=((Convert.ToDouble(txt_TOTAL.Text))+(DD));
            txt_TOTAL.Text=(Convert.ToString(TOTAL));
        }


        public void Crearorden(string producto, int cantidad)
        {
            string condicion = "fecha_solicitado LIKE '" + DateTime.Now.ToString("yyyy-MM-dd") + "%' AND tbm_producto_finalizado_idtbm_producto_finalizado='"+producto+"'";
            string query = "SELECT producto_requerido FROM tbm_ordendeproduccion WHERE "+condicion;
        // verificar si existe una de ese dia
            ArrayList f = (db.consultar(query));
            int intArra = f.Count;
           
            if (intArra > 0) {
                int CANT = 0;// cantidad requerida
            foreach (Dictionary<string, string> dic in f)
            {

                CANT = Convert.ToInt32(dic["producto_requerido"]);
            }
            //si existe
                // seleccionar el dato q tenga de cantidad solicitada
                    // sumarle el nuevo valor

            string tabla = "tbm_ordendeproduccion";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int C = CANT + cantidad;
            dict.Add("producto_requerido", Convert.ToString(C));
            db.actualizar("3", tabla, dict, condicion);

            }
            else { 
            
            
            }
            // sino existe
                //crear el registro



        }

        public void Restar(string producto,string almacen,int cantidad) {
            string condicion = "tbm_producto_finalizado_idtbm_producto_finalizado='" + producto + "' AND tbm_almacen_idtbm_bodega='" + almacen + "'";

            string query = "select cantidad from tbt_inventario where " + condicion;
            ArrayList f = (db.consultar(query));
            int CANT= 0;
            foreach (Dictionary<string, string> dic in f)
            {
              
                CANT = Convert.ToInt32(dic["cantidad"]);
            }
            string tabla = "tbt_inventario";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int C=CANT-cantidad;
            dict.Add("cantidad",Convert.ToString(C));
            db.actualizar("3", tabla, dict, condicion);
        }

        private void cmb_producto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            palcularprecio();
        }

        public void palcularprecio() {
            
            string query = "select precio_costo from tbm_producto_finalizado where idtbm_producto_finalizado='" + cmb_producto.SelectedValue.ToString() + "'";
            ArrayList f = (db.consultar(query));
            int CANT = 0;
            foreach (Dictionary<string, string> dic in f)
            {

                CANT = Convert.ToInt32(dic["precio_costo"]);
            }
            float DD = (float)1.20;
            float SUBTOTAL = ((CANT * DD) - (CANT * inDescuento));
            
            txt_precio.Text = (Convert.ToString(SUBTOTAL));
         
        }

        private void cmb_producto_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void cmb_producto_MouseMove(object sender, MouseEventArgs e)
        {
            cmb_producto.Enabled = true;
        }

        private void pnl_producto_MouseMove(object sender, MouseEventArgs e)
        {
            cmb_producto.Enabled = true;
        }

        private void dtg_detalle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
        }

        public void eliminardetalle() {

            DialogResult dialogResult = MessageBox.Show("Desea eliminar este producto de su factura?", "Eliminar detalle", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int x = Convert.ToInt32(dtg_detalle.CurrentRow.Index.ToString());
                

                double DD = (Convert.ToDouble(Convert.ToString(dtg_detalle.Rows[x].Cells[3].Value)));
                double TOTAL = ((Convert.ToDouble(txt_TOTAL.Text)) -(DD));
                txt_TOTAL.Text = (Convert.ToString(TOTAL));
                dtg_detalle.Rows.RemoveAt(x);
                    //Convert.ToString(DataGridView1.CurrentRow.Cells(3).Value)
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            //MessageBox.Show(dtg_detalle.CurrentRow.Index.ToString());
        }

        private void dtg_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminardetalle();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //
        }

    }

