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
using Comercial_Solutions.Forms.Principal;


namespace Comercial_Solutions.Forms.Areas.Logistica
{
    public partial class frm_logistica_establecimiento : Form
    {
        int inteditmode = 0;
        public static string ESTABLECIMIENTO = "";
        public static string IDESTABLECIMIENTO = "";
        i3nRiqJson db = new i3nRiqJson();
        int X = 0;
        int Y = 0;
        string EditCod = "";
        string EditNom = "";
        string EditDir = "";
        string EditDep = "";
        string EditMun = "";
       

        public frm_logistica_establecimiento()
        {
          
            X = Propp.X;
            Y = Propp.Y;
            InitializeComponent();
            ESTABLECIMIENTO = "";
            IDESTABLECIMIENTO = "";
            cmb_busqueda.SelectedIndex = 0;
            cmb_municipio.SelectedIndex = 0;
            ToolTIPmenu();
        }

        private void frm_logistica_almacen_Load(object sender, EventArgs e)
        {

            this.Size = new Size(X, Y);
            this.Location = new Point(250, 56);
            cargarudepartamento();
        }

        public void cargarudepartamento() {

         
            string query = "SELECT idtbm_departamentos,nombre FROM tbm_departamentos";
            cmb_departamento.DataSource = ((db.consulta_ComboBox(query)));
            cmb_departamento.DisplayMember = "nombre";
            cmb_departamento.ValueMember = "idtbm_departamentos";
        
        }

        public void cargarmunicipio() {

            Console.WriteLine("Se selecciono");
            string query = "SELECT idtbm_municipio,nombre,idtbm_departamentos,cod_postal FROM tbm_municipio where idtbm_departamentos='" + cmb_departamento.SelectedValue.ToString() + "'";
            cmb_municipio.DataSource = ((db.consulta_ComboBox(query)));
            cmb_municipio.DisplayMember = "nombre";
            cmb_municipio.ValueMember = "idtbm_municipio";
        }

        public void cargarmunicipiosub()
        {


            string query = "SELECT idtbm_municipio,nombre,idtbm_departamentos,cod_postal FROM tbm_municipio where idtbm_departamentos=(select idtbm_departamentos from tbm_departamentos where tbm_departamentos.nombre='" + cmb_departamento.Text.ToString() + "')";
           
            cmb_municipio.DataSource = ((db.consulta_ComboBox(query)));
           cmb_municipio.DisplayMember = "nombre";
            cmb_municipio.ValueMember = "idtbm_municipio";
        }


        public void CargarBusqueda(string query)
        {
            Console.WriteLine("QUERY prueba: "+query);
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
            
                    lst_busqueda.Items.Add(dict["tx_establecimiento"]);

                   
                }

                lst_busqueda.Visible = true;

            }
            catch (Exception fe)
            {

            }
            try
            {
        
                lst_busqueda.SelectedIndex = 0;
                lst_busqueda.Height = i*14;
                
            }
            catch (Exception fe)
            {
                lst_busqueda.Visible = false;
                lbl_busqueda.Text = "La busqueda no obtuvo resultados";

            }
        }

        private void cmb_departamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarmunicipio();
        }
        public int verificarprev() {
            string query = "select tx_establecimiento from tbm_establecimiento where tx_establecimiento='"+txtnombre.Text+"'";
            System.Collections.ArrayList array = db.consultar(query);
            int intamanoarray = array.Count;

            return intamanoarray;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (inteditmode == 0)
            {
                if (verificarprev() == 0) { guardarestablecimiento(); } else {
                    MessageBox.Show("Ya existe un establecimiento con ese nombre");
                    txtnombre.Text = "";
                }
               
            }
            else
            {
                try
                {
                    guardaredicion();
                    editarOFF();
                }
                catch (Exception f)
                {
                    MessageBox.Show("Los cambios no se guardaron");
                    
                }
            }
            
        }

        public void guardarestablecimiento(){
          
            if ((txtnombre.Text.Equals("")) || (txtdireccion.Text.Equals("")) || (cmb_municipio.SelectedItem.Equals("Seleccione un municipio")))
           {

              MessageBox.Show("Ingrese todos los datos requeridos");

           }
            
             else
             {
                DialogResult dialogResult = MessageBox.Show("Desea realizar el registro", "Registro de establecimiento", MessageBoxButtons.YesNo);
if(dialogResult == DialogResult.Yes)
{
      string tabla = "tbm_establecimiento";
                 Dictionary<string, string> dict = new Dictionary<string, string>();
                 dict.Add("tx_establecimiento", txtnombre.Text);
                 dict.Add("direccion_establecimiento", txtdireccion.Text);
                 dict.Add("tbm_departamentos_idtbm_departamentos",cmb_departamento.SelectedValue.ToString());
                 dict.Add("tbm_municipio_idtbm_municipio",cmb_municipio.SelectedValue.ToString());
                 dict.Add("tbm_estadoestablecimiento_idtbm_estadoestablecimiento", "1");            
 
                 db.insertar("1", tabla, dict);
                 if (i3nRiqJson.RespuestaConexion.ToString().Equals("0"))
                 {
                     MessageBox.Show("Registro Realizado exitosamente");
                     Resetear();
                 }
                 else {

                     MessageBox.Show("Registro no se ah realizado consulte con su administrador");
                 
                 }
}
else if (dialogResult == DialogResult.No)
{
    
}
              
             }

        }

       

        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = "tbm_estadoestablecimiento_idtbm_estadoestablecimiento='1'";//Esta activo
            string query = "";
            string condicion = txtbusqueda.Text;
            if (e.KeyCode == Keys.Enter)
            {
              
               if ((cmb_busqueda.SelectedItem.ToString()).Equals("Direccion"))
                {
                   
                    query = "select tx_establecimiento from tbm_establecimiento where direccion_establecimiento='" + condicion + "' AND "+filtro;
                    
                }

               if ((cmb_busqueda.SelectedItem.ToString()).Equals("Departamento"))
               {
                   if ((txtbusqueda.Text).Equals(""))
                   {
                       query = "select DISTINCT(select nombre from tbm_departamentos where tbm_departamentos.idtbm_departamentos=tbm_establecimiento.tbm_departamentos_idtbm_departamentos)as tx_establecimiento from tbm_establecimiento where "+filtro;
                       lst_busqueda.Enabled = false;
                   }
                   else
                   {
                       query = "select tx_establecimiento from tbm_establecimiento where tbm_departamentos_idtbm_departamentos=(select idtbm_departamentos	from tbm_departamentos where nombre='" + condicion + "') AND "+filtro;
                       lst_busqueda.Enabled = true;
                   }
               }
               if ((cmb_busqueda.SelectedItem.ToString()).Equals("Municipio"))
               {
                   if ((txtbusqueda.Text).Equals(""))
                   {
                       query = "select DISTINCT(select nombre from tbm_municipio where tbm_municipio.idtbm_municipio=tbm_establecimiento.tbm_municipio_idtbm_municipio)as tx_establecimiento from tbm_establecimiento where "+filtro;
                       lst_busqueda.Enabled = false;
                   }
                   else
                   {
                       query = "select tx_establecimiento from tbm_establecimiento where tbm_municipio_idtbm_municipio=(select idtbm_municipio	from tbm_municipio where nombre='" + condicion + "') AND "+filtro;
                       lst_busqueda.Enabled = true;
                   }
               }
               if ((cmb_busqueda.SelectedItem.ToString()).Equals("Nombre"))
               {
                   if ((txtbusqueda.Text).Equals(""))
                   {
                       query = "select tx_establecimiento from tbm_establecimiento where "+filtro;
                       
                   }
                   else
                   {
                       query = "select tx_establecimiento from tbm_establecimiento where tx_establecimiento='" + condicion + "' AND "+filtro;
                   }
               }
               CargarBusqueda(query);
            }
        }

        public void desplegar(string stseleccion) {

            string query = "select cod_establecimiento,tx_establecimiento,direccion_establecimiento,(SELECT nombre FROM tbm_departamentos where tbm_departamentos.idtbm_departamentos=tbm_establecimiento.tbm_departamentos_idtbm_departamentos)as depto,tbm_departamentos_idtbm_departamentos,(SELECT nombre FROM tbm_municipio where tbm_municipio.idtbm_municipio=tbm_establecimiento.tbm_municipio_idtbm_municipio)as muni,tbm_municipio_idtbm_municipio from tbm_establecimiento where tx_establecimiento='" + stseleccion + "'";
               System.Collections.ArrayList array = db.consultar(query);
               string municipio = "";
               foreach (Dictionary<string, string> dict in array)
                {

                    EditCod = (dict["cod_establecimiento"]);
                    EditNom = (dict["tx_establecimiento"]);
                    EditDir = (dict["direccion_establecimiento"]);
                    EditDep = (dict["tbm_departamentos_idtbm_departamentos"]);
                    EditMun = (dict["tbm_municipio_idtbm_municipio"]);
                    IDESTABLECIMIENTO = (dict["cod_establecimiento"]);
                    ESTABLECIMIENTO = (dict["tx_establecimiento"]);
                    txtnombre.Text = (dict["tx_establecimiento"]);
                    txtdireccion.Text = (dict["direccion_establecimiento"]);
                    cmb_departamento.SelectedIndex = cmb_departamento.FindStringExact(dict["depto"]);
                    municipio = (dict["muni"]);
                    cmb_municipio.Text = municipio;
                    
                    
                }
               cargarmunicipiosub();
               cmb_municipio.SelectedIndex = cmb_municipio.FindStringExact(municipio);
               bloquearform();  
        }
        public void guardaredicion() {
            string tabla = "tbm_establecimiento";
            string condicion = "cod_establecimiento= " + EditCod;

            try
            {
                if (txtnombre.Text.Equals(EditNom))
                { }
                else
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("tx_establecimiento", txtnombre.Text);
                    db.actualizar("3", tabla, dict, condicion);
                }
                if (txtdireccion.Text.Equals(EditDir))
                { }
                else
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("direccion_establecimiento", txtdireccion.Text);
                    db.actualizar("3", tabla, dict, condicion);
                }
                if (cmb_departamento.SelectedValue.ToString().Equals(EditDep))
                { }
                else
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("tbm_departamentos_idtbm_departamentos", cmb_departamento.SelectedValue.ToString());
                    db.actualizar("3", tabla, dict, condicion);
                }
                if (cmb_municipio.SelectedValue.ToString().Equals(EditDep))
                { }
                else
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("tbm_municipio_idtbm_municipio", cmb_municipio.SelectedValue.ToString());
                    db.actualizar("3", tabla, dict, condicion);
                }
            }
            catch (Exception e) {
                MessageBox.Show("Algo no esta bien en la edicion");
            }



        }
        public void eliminar() {
            DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro?", "Eliminacion de establecimiento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // UPDATE FASE BETA
                string tabla = "tbm_establecimiento";
                string condicion = "cod_establecimiento= " + EditCod;

                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("tbm_estadoestablecimiento_idtbm_estadoestablecimiento", "2");
                db.actualizar("3", tabla, dict, condicion);
          
                

                //db.eliminar("4", tabla, condicion);

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
        public void bloquearform() {
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            cmb_departamento.Enabled = false;
            cmb_municipio.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox6.Visible = true;
            lbl_alamacen.Visible = true;
        
        }
        public void desbloquearform() {

            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            cmb_departamento.Enabled = true;
            cmb_municipio.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox6.Visible = false;
            lbl_alamacen.Visible = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_busqueda.Text = "";
        }

        private void txtbusqueda_Click(object sender, EventArgs e)
        {
            lst_busqueda.Items.Clear();
            lst_busqueda.Visible = false;
            lst_busqueda.Enabled = true;
        }

        private void txtbusqueda_DoubleClick(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            lst_busqueda.Text = "";
            lst_busqueda.Enabled = true;
            editarOFF();
            Resetear();
            desbloquearform();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            
            Resetear();
            desbloquearform();
           
        }

        private void lst_busqueda_DoubleClick(object sender, EventArgs e)
        {
            desplegar((lst_busqueda.SelectedItem.ToString()));
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (inteditmode == 0) {
                editarON();
            } else {
                editarOFF();
            }
           
        }

        public void editarON() {
            desbloquearform();
            
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.parent;
            inteditmode = 1;
        }
        public void editarOFF() {
            bloquearform();
            
            this.pictureBox3.Image = global::Comercial_Solutions.Properties.Resources.edit;
            inteditmode = 0;
        }

        public void Resetear() {
            txtdireccion.Text = "";
            txtnombre.Text = "";
            txtnombre.Focus();
            cargarudepartamento();
            cmb_municipio.DataSource = null;
         
            this.cmb_municipio.Items.AddRange(new object[] {"Seleccione un municipio"});
            cmb_municipio.Text = "Seleccione un municipio";
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
        }

        public void ToolTIPmenu()
        {
            toolTip.SetToolTip(this.txtnombre, "Ingrese un nombre");
            toolTip.SetToolTip(this.txtdireccion, "Ingrese una direccion");
            toolTip.SetToolTip(this.cmb_departamento, "Seleccione un departamento");
            toolTip.SetToolTip(this.cmb_municipio, "Seleccione un municipio");
            toolTip.SetToolTip(this.cmb_busqueda, "Metodo de busqueda");
            toolTip.SetToolTip(this.pictureBox5, "Nuevo");
            toolTip.SetToolTip(this.pictureBox1, "Guardar");
            toolTip.SetToolTip(this.pictureBox3, "Editar");
            toolTip.SetToolTip(this.pictureBox4, "Eliminar");
            toolTip.SetToolTip(this.pictureBox6, "Almacenes");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            frm_logistica_almacen x = new frm_logistica_almacen();
            x.MdiParent = this.MdiParent;
            
            try
            {
                
                x.Show();
               // this.Dispose();
            }
            catch (Exception f) { }
        }
    }
}
