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
    public partial class Form_Nautilus : Form
    {
        public Form_Nautilus()
        {
            InitializeComponent();
        }

        private void btnNautAltaAgregar_Click(object sender, EventArgs e)
        {
            AltaNautilus();
            LimpiarAlta();
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
//Mini function that returns the behavior result of the radio buttons
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
    }
}
