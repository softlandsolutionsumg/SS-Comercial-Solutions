using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using i3nRiqJSON;
using Comercial_Solutions.Clases;
using Comercial_Solutions.Forms.Principal;


namespace Comercial_Solutions.Forms.Areas.Logistica
{
    public partial class frm_logistica_almacen : Form
    {
        int inteditmode = 0;
        string ESTABLECIMIENTO = "";
        string IDESTABLECIMIENTO = "";
        i3nRiqJson db = new i3nRiqJson();
        int X = 0;
        int Y = 0;

        string EditCod = "";
        string EditNom = "";
        string EditAlto = "";
        string EditAncho = "";
        string EditFondo = "";
        string EditAmb = "";
        string EditMed = "";


        public frm_logistica_almacen()
        {
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
            cmb_busqueda.SelectedIndex = 0;
            
            transferencia();
            cargaralmacenes("1");
            cargarambiente();
            cargarestados();
            ToolTIPmenu();
            frm_mdi.alzheimer();
        }

        private void frm_logistica_almacen_Load(object sender, EventArgs e)
        {
            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
           
        }

        public void transferencia() {
            ESTABLECIMIENTO = frm_logistica_establecimiento.ESTABLECIMIENTO.ToString();
         IDESTABLECIMIENTO = frm_logistica_establecimiento.IDESTABLECIMIENTO.ToString();

         
            label3.Text=label3.Text+" - "+ESTABLECIMIENTO;
             if (IDESTABLECIMIENTO.Equals(""))
                {
         
                    MessageBox.Show("Debe de seleccionar un establecimiento primero");
        
                }
            }


        

        public void cargaralmacenes(string tipo)
        {

            

            string query = "";
            try
            {
                if (tipo.Equals("1")) {
                    // tipo activos
                    query = "select nombre_bodega as Nombre,	(select tipo_ambiente from tbm_ambiente where tbm_ambiente.	idtbm_ambiente=tbm_almacen.tbm_ambiente_idtbm_ambiente) as Ambiente,(select tx_medidas from tbm_medidas where  tbm_medidas.	idtbm_medidas= tbm_almacen.tbm_medidas_idtbm_medidas) as Medida,alto as Alto,ancho as Ancho,fondo as Fondo from tbm_almacen where tbm_establecimiento_cod_establecimiento='" + IDESTABLECIMIENTO + "' AND tbm_estadoestablecimiento_idtbm_estadoestablecimiento='1'";
               
                }
                if (tipo.Equals("2"))
                {
                    // tipo inactivos
                    query = "select nombre_bodega as Nombre,(select tipo_ambiente from tbm_ambiente where tbm_ambiente.	idtbm_ambiente=tbm_almacen.tbm_ambiente_idtbm_ambiente) as Ambiente,(select tx_medidas from tbm_medidas where  tbm_medidas.	idtbm_medidas= tbm_almacen.tbm_medidas_idtbm_medidas) as Medida,alto as Alto,ancho as Ancho,fondo as Fondo from tbm_almacen where tbm_establecimiento_cod_establecimiento='" + IDESTABLECIMIENTO + "' AND tbm_estadoestablecimiento_idtbm_estadoestablecimiento='2'";

                }
                dataGridView1.DataSource = (db.consulta_DataGridView(query));
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 42;
                dataGridView1.Columns[3].Width = 42;
                dataGridView1.Columns[4].Width = 42;
                dataGridView1.Columns[5].Width = 42;
            }
            catch (Exception e) { 
            
            
            }
        }
        public void cargarestados() {
            string query = "select idtbm_estadoestablecimiento,tx_estadoestablecimientocol from tbm_estadoestablecimiento";
        cmb_estados.DataSource=(db.consulta_ComboBox(query));

        cmb_estados.DisplayMember = "tx_estadoestablecimientocol";
        cmb_estados.ValueMember = "idtbm_estadoestablecimiento";

        }
        public void cargarambiente() {
            string query = "select idtbm_ambiente,tipo_ambiente from tbm_ambiente";
            cmb_ambiente.DataSource = (db.consulta_ComboBox(query));

            cmb_ambiente.DisplayMember = "tipo_ambiente";
            cmb_ambiente.ValueMember = "idtbm_ambiente";


            string query2 = "select idtbm_medidas,tx_medidas from tbm_medidas";
            cmb_medida.DataSource = (db.consulta_ComboBox(query2));

            cmb_medida.DisplayMember = "tx_medidas";
            cmb_medida.ValueMember = "idtbm_medidas";
        }

        public int verificarprev()
        {
            string query = "select nombre_bodega from tbm_almacen where nombre_bodega='" + txtnombre.Text + "'";
            System.Collections.ArrayList array = db.consultar(query);
            int intamanoarray = array.Count;

            return intamanoarray;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_municipio_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (inteditmode == 0)
            {
                if (verificarprev() == 0) {
                     guardaralmacen(); 
                }
                else
                {
                    MessageBox.Show("Ya existe un almacen con ese nombre");
                    txtnombre.Text = "";
                }

            }
            else
            {
                try
                {
                   // guardaredicion();
                   // editarOFF();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Los cambios no se guardaron");

                }
            }
            
        }

        public void bloquearform()
        {
            txtnombre.Enabled = false;
            txtalto.Enabled = false;
            txtancho.Enabled = false;
            txtprofundidad.Enabled = false;
            cmb_ambiente.Enabled = false;
            cmb_medida.Enabled = false;
            pictureBox1.Enabled = false;

        }
        public void desbloquearform()
        {

            txtnombre.Enabled = true;
            txtalto.Enabled = true;
            txtancho.Enabled = true;
            txtprofundidad.Enabled = true;
            cmb_ambiente.Enabled = true;
            cmb_medida.Enabled = true;
            pictureBox1.Enabled = true;
        }

        public void Resetear()
        {
            txtnombre.Text = "";
            txtprofundidad.Text = "";
            txtalto.Text = "";
            txtancho.Text = "";
            
             
            txtnombre.Focus();
            cargaralmacenes("1");
            cargarambiente();
            cargarestados();

            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
        }


        public void editarON()
        {
            desbloquearform();

            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.parent;
            inteditmode = 1;
        }
        public void editarOFF()
        {
            bloquearform();

            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.edit;
            inteditmode = 0;
        }

        public void guardaralmacen()
        {

            if ((txtnombre.Text.Equals("")) || (txtalto.Text.Equals("")) || (txtancho.Text.Equals("")) || (txtprofundidad.Text.Equals("")))
            {

                MessageBox.Show("Ingrese todos los datos requeridos");

            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea realizar el registro", "Registro de almacen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string tabla = "tbm_almacen";
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("nombre_bodega", txtnombre.Text);
                    dict.Add("tbm_establecimiento_cod_establecimiento",IDESTABLECIMIENTO);
                    dict.Add("tbm_ambiente_idtbm_ambiente",cmb_ambiente.SelectedValue.ToString());
                    dict.Add("tbm_medidas_idtbm_medidas", cmb_medida.SelectedValue.ToString());
                    dict.Add("alto",txtalto.Text);
                    dict.Add("ancho",txtancho.Text);
                    dict.Add("fondo",txtprofundidad.Text);
                    dict.Add("tbm_estadoestablecimiento_idtbm_estadoestablecimiento", "1");
                    

                    db.insertar("1", tabla, dict);
                    if (i3nRiqJson.RespuestaConexion.ToString().Equals("0"))
                    {
                        MessageBox.Show("Registro Realizado exitosamente");
                      //  Resetear();
                    }
                    else
                    {

                        MessageBox.Show("Registro no se ah realizado consulte con su administrador");

                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = "tbm_estadoestablecimiento_idtbm_estadoestablecimiento='1'";//Esta activo
            string query = "";
            string condicion = txtbusqueda.Text;
            if (e.KeyCode == Keys.Enter)
            {

                if ((cmb_busqueda.SelectedItem.ToString()).Equals("Ambiente"))
                {
                    if ((txtbusqueda.Text).Equals(""))
                    {
                        query = "select DISTINCT(select tipo_ambiente from tbm_ambiente where  tbm_ambiente.idtbm_ambiente=tbm_almacen.tbm_ambiente_idtbm_ambiente) as ambiente from tbm_almacen where tbm_establecimiento_cod_establecimiento='" + IDESTABLECIMIENTO + "' AND " + filtro;
                        lst_busqueda.Enabled = false;
                    }
                    else
                    {
                        query = "select nombre_bodega as ambiente from tbm_almacen where tbm_almacen.tbm_ambiente_idtbm_ambiente=(select idtbm_ambiente from tbm_ambiente where tipo_ambiente='"+condicion+"') AND " + filtro;
                       lst_busqueda.Enabled = true;
                    }
                }
                if ((cmb_busqueda.SelectedItem.ToString()).Equals("Nombre"))
                {
                    if ((txtbusqueda.Text).Equals(""))
                    {
                        query = "select nombre_bodega as ambiente from tbm_almacen where tbm_establecimiento_cod_establecimiento='"+IDESTABLECIMIENTO+"'  AND " + filtro;
                        lst_busqueda.Enabled = true;
                    }
                    else
                    {
                        query = "select nombre_bodega as ambiente from tbm_almacen where nombre_bodega='"+txtbusqueda.Text+"' AND " + filtro;
                        lst_busqueda.Enabled = true;
                    }
                }
             
               CargarBusqueda(query);
            }
        }

        public void CargarBusqueda(string query)
        {
            Console.WriteLine("QUERY prueba: " + query);
            int i = 0;
            lst_busqueda.Items.Clear();
            try
            {


                System.Collections.ArrayList array = db.consultar(query);

                int intamanoarray = array.Count;


                List<string> Modulos = new List<string>();

                foreach (Dictionary<string, string> dict in array)
                {

                    i++;

                    lst_busqueda.Items.Add(dict["ambiente"]);


                }

                lst_busqueda.Visible = true;

            }
            catch (Exception fe)
            {

            }
            try
            {

                lst_busqueda.SelectedIndex = 0;
                lst_busqueda.Height = i * 16;

            }
            catch (Exception fe)
            {
                lst_busqueda.Visible = false;
                lbl_busqueda.Text = "La busqueda no obtuvo resultados";

            }
        }

        private void txtbusqueda_DoubleClick(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            lst_busqueda.Text = "";
            lst_busqueda.Enabled = true;
            editarOFF();
           // Resetear();
            desbloquearform();
        }

        private void txtbusqueda_Click(object sender, EventArgs e)
        {
            lst_busqueda.Items.Clear();
            lst_busqueda.Visible = false;
            lst_busqueda.Enabled = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_busqueda.Text = "";
        }
        public void ToolTIPmenu()
        {
            toolTip.SetToolTip(this.txtnombre, "Ingrese un nombre");
            
            toolTip.SetToolTip(this.cmb_busqueda, "Metodo de busqueda");
            toolTip.SetToolTip(this.pictureBox5, "Nuevo");
            toolTip.SetToolTip(this.pictureBox1, "Guardar");
            toolTip.SetToolTip(this.pictureBox3, "Editar");
            toolTip.SetToolTip(this.pictureBox4, "Eliminar");
            toolTip.SetToolTip(this.pictureBox6, "Atras");
            toolTip.SetToolTip(this.txtbusqueda, "Ingrese el valor de su busqueda");
        }

        private void cmb_estados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { 
            if (cmb_estados.SelectedValue.ToString().Equals("1"))
            {
             
                cargaralmacenes("1");
            }
            if (cmb_estados.SelectedValue.ToString().Equals("2"))
            {
                
                cargaralmacenes("2");
            }
            }
            catch (Exception f) { }
            cargarestados();
        }

        private void cmb_estados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_busqueda_DoubleClick(object sender, EventArgs e)
        {
           desplegar((lst_busqueda.SelectedItem.ToString()));
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
        }



        public void desplegar(string stseleccion)
        {

            string query = "select idtbm_bodega,nombre_bodega as Nombre,tbm_ambiente_idtbm_ambiente,tbm_medidas_idtbm_medidas,	(select tipo_ambiente from tbm_ambiente where tbm_ambiente.	idtbm_ambiente=tbm_almacen.tbm_ambiente_idtbm_ambiente) as Ambiente,(select tx_medidas from tbm_medidas where  tbm_medidas.	idtbm_medidas= tbm_almacen.tbm_medidas_idtbm_medidas) as Medida,alto as Alto,ancho as Ancho,fondo as Fondo from tbm_almacen where nombre_bodega='" + stseleccion + "'";
            System.Collections.ArrayList array = db.consultar(query);
            string municipio = "";
            foreach (Dictionary<string, string> dict in array)
            {

                EditCod = (dict["idtbm_bodega"]);

               EditNom = (dict["Nombre"]);
               EditAlto = (dict["Alto"]);
               EditAncho = (dict["Ancho"]);
               EditFondo = (dict["Fondo"]);
               EditAmb = (dict["tbm_ambiente_idtbm_ambiente"]);
               EditMed = (dict["tbm_medidas_idtbm_medidas"]);
               // EditNom = (dict["tx_establecimiento"]);
               // EditDir = (dict["direccion_establecimiento"]);
               // EditDep = (dict["tbm_departamentos_idtbm_departamentos"]);
               //// EditMun = (dict["tbm_municipio_idtbm_municipio"]);
                //IDESTABLECIMIENTO = (dict["cod_establecimiento"]);
                //ESTABLECIMIENTO = (dict["tx_establecimiento"]);
                txtnombre.Text = (dict["Nombre"]);
        
                cmb_medida.SelectedIndex = cmb_medida.FindStringExact(dict["Medida"]);
                txtalto.Text = (dict["Alto"]);
                    txtancho.Text = (dict["Ancho"]);
                    txtprofundidad.Text = (dict["Fondo"]);
                cmb_ambiente.SelectedIndex = cmb_ambiente.FindStringExact(dict["Ambiente"]);
              


            }
          
            bloquearform();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Resetear();
            desbloquearform();
        }


        public void eliminar()
        {
            DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro?", "Eliminacion de almacen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string tabla = "tbm_almacen";
                string condicion = "idtbm_bodega= " + EditCod;

                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("tbm_estadoestablecimiento_idtbm_estadoestablecimiento", "2");
                db.actualizar("3", tabla, dict, condicion);



                if (i3nRiqJson.RespuestaConexion.ToString().Equals("0"))
                {

                    MessageBox.Show("Registro eliminado exitosamente");
                    Resetear();
                    desbloquearform();
                }
                else
                {

                    MessageBox.Show("Registro no se ah eliminado consulte con su administrador");

                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            eliminar(); 
        }


    }
}
