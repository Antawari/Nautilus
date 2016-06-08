using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nautilus
{
    public partial class Form_Devices : Form
    {
        //Necessary Variables needed for the form
        private string conditional;

        public Form_Devices()
        {
            InitializeComponent();
        }

        /**********************************************************************************************************************************************/
        /*Control Behavior start here.*/
        /**********************************************************************************************************************************************/
        /**********************************************************************************************************************************************/
        //Adds a new registry to the Database
        private void btnNautAltaAgregar_Click(object sender, EventArgs e)
        {
            AltaNautilus();
            LimpiarAlta();
        }
        //Closes the form.
        private void btnNautAltaCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Cleans the  add new device Tab
        private void btnNautAltaClean_Click(object sender, EventArgs e)
        {
            LimpiarAlta();
        }
        //When the TabMod control is activated
        private void TabNautMod_Enter(object sender, EventArgs e)
        {
            string sql = @"SELECT Naut_ID as Identificador, Naut_Name as Dispositivo, Naut_Status as Status FROM naut_devices ORDER BY Naut_ID";
            dgNautMod.DataSource = null;
            dgNautMod.DataSource = DBManager.SelectForGrid(sql);
        }
        //When you click on the DataGrid for modification
        private void dgNautMod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillGridMod();
        }
        //populates the datarid with the search terms
        private void btnNautModSearch_Click(object sender, EventArgs e)
        {
            BuscarModificacion();
        }
        /**********************************************************************************************************************************************/
        /*Modification part of the form*/
        //Cleans the modification part of the form
        private void btnNautModClean_Click(object sender, EventArgs e)
        {
            LimpiarModificacion();
        }
        //Close the form
        private void btnNautModCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Modifies the selected Registry
        private void btnNautModModify_Click(object sender, EventArgs e)
        {
            ModificarNautilus();
        }
        /**********************************************************************************************************************************************/
        /*Operational Functions start here.*/
        /**********************************************************************************************************************************************/
        /**********************************************************************************************************************************************/
        //Function that inserts into the database a new Nautilus device
        private void AltaNautilus()
        {
            //declare variables
            string Naut_ID = txtNautAltaID.Text;
            string Naut_Type = cmbNautAltaTipo.Text;
            string Naut_Name = txtNautAltaNombre.Text;
            string Naut_Status = AltaStatus();
            string Naut_Activation = dateNautAltaActivacion.Text;
            string Naut_Description = txtNautAltaDescripcion.Text;
            //String that builds the Sql that will be sent to the DBManager Class
                string sql = @"INSERT INTO nautilus.naut_devices (Naut_ID,Naut_Type,Naut_Name,Naut_Status,Naut_Activation,Naut_Description) "+
                "VALUES ('"+
                Naut_ID+ "','" +
                Naut_Type + "','"+
                Naut_Name + "','" +
                Naut_Status + "','" +
                Naut_Activation + "','"+
                Naut_Description + "');";
            if(DBManager.Insertar(sql)==true)
            {
                MessageBox.Show("Insertado con Exito");
                LimpiarAlta();
            }
            else
            {
                MessageBox.Show("Fallo la Insercion");
            }
        }
//Mini function that returns the behavior result of the radio buttons for Alta
        private string AltaStatus()
        {
            string status;
            if (rbNautAltaActivo.Checked==true)
            {
                status = "Activo";
            } else
            {
                status = "Inactivo";
            }
            return status;
        }
        //Mini function that returns the behavior result of the radio buttons for Mod
        private string ModStatus()
        {
            string status;
            if (rbNautModActivo.Checked == true)
            {
                status = "Activo";
            }
            else
            {
                status = "Inactivo";
            }
            return status;
        }
        //function that cleans the form and prepares it for a new registry
        private void LimpiarAlta()
        {
            txtNautAltaID.Text = "";
            txtNautAltaDescripcion.Text = "";
            txtNautAltaNombre.Text = "";
            dateNautAltaActivacion.Value = DateTime.Today;
            cmbNautAltaTipo.Text = "";
            rbNautAltaActivo.Checked = true;
            txtNautAltaID.Focus();
        }
        //Function that Cleans Modification part of the form
       private void LimpiarModificacion()
        {
            txtNautModID.Text = "";
            txtNautModDescription.Text = "";
            txtNautModNombre.Text = "";
            dateNautMod.Value = DateTime.Today;
            cmbNautModTipo.Text = "";
            rbNautModActivo.Checked = true;
            txtNautModID.Focus();
        }
        //Function that modifies the nautilus that is selected on the grid
        private void ModificarNautilus()
        {
            //declare variables
            string Naut_ID = txtNautModID.Text;
            string Naut_Type = cmbNautModTipo.Text;
            string Naut_Name = txtNautModNombre.Text;
            string Naut_Status = ModStatus();
            string Naut_Activation = dateNautMod.Text;
            string Naut_Description = txtNautModDescription.Text;
            string sql = @"UPDATE naut_devices SET

            Naut_ID = '" + Naut_ID + "'," +
            "Naut_Type = '" + Naut_Type + "'," +
            "Naut_Name = '" + Naut_Name + "'," +
            "Naut_Status = '" + Naut_Status + "'," +
            "Naut_Activation = '" + Naut_Activation+ "'," +
            "Naut_Description = '" + Naut_Description + "'" +
            "WHERE Naut_ID = '" + conditional + "'";


            if(DBManager.Actualizar(sql)==true)
            {
                MessageBox.Show("Actualizado con Exito");
                LimpiarModificacion();
                FillGridMod();
            }
            else
            {
                MessageBox.Show("Fallo en la actualizacion");
            }
        }
        //Function that fills the modification Grid
        private void FillGridMod()
        {
            //Variables necessary to fill th emodification part of the form
            conditional = dgNautMod.CurrentRow.Cells[0].Value.ToString();
            string sql = @"SELECT * FROM naut_devices WHERE Naut_ID='" + conditional + "'";
            //retrieve data for text fields
            DataSet ds = DBManager.SelectForText(sql);
            txtNautModID.Text = ds.Tables[0].Rows[0]["Naut_ID"].ToString();
            txtNautModNombre.Text = ds.Tables[0].Rows[0]["Naut_Name"].ToString();
            txtNautModDescription.Text = ds.Tables[0].Rows[0]["Naut_Description"].ToString();
            cmbNautModTipo.Text = ds.Tables[0].Rows[0]["Naut_Type"].ToString();
            if (ds.Tables[0].Rows[0]["Naut_Status"].ToString() == "Activo")
            {
                rbNautModActivo.Checked = true;
            }
            else
            {
                rbNautModInactivo.Checked = true;
            }
            dateNautMod.Text = ds.Tables[0].Rows[0]["Naut_Activation"].ToString();
        }
        //Function that populates the dgNautMod with the parameters on the searchbox
        private void BuscarModificacion()
        {
            string condicion = txtNautModSearch.Text.Trim();
            string sql = @"SELECT Naut_ID as Identificador, Naut_Name as Dispositivo, Naut_Status as Status FROM naut_devices WHERE " +
                "Naut_ID LIKE '%" + condicion + "%' OR Naut_Name LIKE '%" + condicion + "%' OR Naut_Status LIKE '%" + condicion + "%'" ;

            dgNautMod.DataSource = null;
            dgNautMod.DataSource = DBManager.SelectForGrid(sql);
        }
        
    }
}
