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
    public partial class frmUserManagement : Form
    {
        /// <summary>
        /// Sector 1
        /// Variable and Constant declarations
        /// </summary>
        public string Status;
        public string UserID;
        private string EliminarID;
        /// <summary>
        /// End of Sector 1
        /// </summary>

        /*************************************************************************************************************************/

        /// <summary>
        /// Sector 2
        /// Controls and events
        /// </summary>
        public frmUserManagement()
        {
            InitializeComponent();
        }

        //when the form loads
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            habilitarNU();
        }

        //Click on the new user tab
        private void tabNuevoUsuario_Click(object sender, EventArgs e)
        {
            habilitarNU();
        }

        // click on the modify user button
        private void btnMUUsuario_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
        /// <summary>
        /// End of Sector 2
        /// </summary>
        /***************************************************************************************************************************/


        /// <summary>
        /// Sector 3
        /// Functions
        /// </summary>
        /// 

        //Enables the modify user part of the form
        private void habilitarMU()
        {
            gpMU.Enabled = true;
            cargarListMU();
            lstMUSeleccionU.Focus();
        }
        // function that loads the information from the database
        // into the modify user datagrid
        private void cargarListMU()
        {
            // query construction
            string query = @"SELECT idusuarios as 'ID',Nombre,ApellidoP as 'Apellido Paterno', ApellidoM as 'Apellido Materno' from usuarios order by Nombre; ";

            // assignation of data to the grid
            // call from the DBManager          
            lstMUSeleccionU.DataSource = null;
            lstMUSeleccionU.DataSource = DBManager.SelectForGrid(query);
            lstMUSeleccionU.Columns[0].Visible = false;
        }
        // function that assigns the variable status from the radio buttons 
        // NOTE change from checkboxes to radio buttons
        private void StatusSelector()
        {
            //llenado de variable de status
            if (chkNUActivo.Checked == true)
            {
                Status = "Activo";
            }
            else
            {
                Status = "Inactivo";
            }
        }

        // function that checks the mail format
        private void txtNUMail_TextChanged(object sender, EventArgs e)
        {
            string mailCheck = txtNUMail.Text;
            bool _valido = MailValidator.EmailEsValido(mailCheck);

            if (_valido == true)
            {
                lblMailCheck.Text = "Mail Correcto";
            }
            else
            {
                lblMailCheck.Text = "Mail Incorrecto";
            }

        }



        private void tabModificarUsuario_Enter(object sender, EventArgs e)
        {
            // Construir el select inicial para llenar el grid
            string query = @"SELECT idusuarios as 'ID',Nombre,ApellidoP as 'Apellido Paterno', ApellidoM as 'Apellido Materno' from usuarios order by Nombre; ";

            // assignation of data
            lstMUSeleccionU.DataSource = null;
            lstMUSeleccionU.DataSource = DBManager.SelectForGrid(query);
            lstMUSeleccionU.Columns[0].Visible = false;
        }

        // AQUI VOY /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Funcion que llena todos los campos de el formulario que pertenecen a Modifica Usuario
        private void LlenadoMU()
        {
            //Para llenar los campos a modificar, hacemos una busqueda con select.
            string id = lstMUSeleccionU.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(id);
            string query = @"SELECT UserID,Pass,Nombre,ApellidoP,ApellidoM,Direccion1,Direccion2," +
"Telefono1,Telefono2,Mail,Status,rol from usuarios WHERE idusuarios='"
+ id + "' order by Nombre; ";

            //Asignamos un dataset y extraemos de la funcion select for text
            DataSet ds = DBManager.SelectForText(query);

            txtMUUsuario.Text = ds.Tables[0].Rows[0]["UserID"].ToString();
            txtMUPassword.Text = ds.Tables[0].Rows[0]["Pass"].ToString();
            txtMUNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtMUApellidoP.Text = ds.Tables[0].Rows[0]["ApellidoP"].ToString();
            txtMUApellidoM.Text = ds.Tables[0].Rows[0]["ApellidoM"].ToString();
            txtMUDireccion.Text = ds.Tables[0].Rows[0]["Direccion1"].ToString();
            txtMUDireccion2.Text = ds.Tables[0].Rows[0]["Direccion2"].ToString();
            txtMUTel1.Text = ds.Tables[0].Rows[0]["Telefono1"].ToString();
            txtMUTel2.Text = ds.Tables[0].Rows[0]["Telefono2"].ToString();
            txtMUMail.Text = ds.Tables[0].Rows[0]["Mail"].ToString();
            //rutina para llenar el campo activo/inactivo
            string status = ds.Tables[0].Rows[0]["Status"].ToString();

            if (status == "Activo")
            {
                chkMUActivo.Checked = true;
                chkMUInactivo.Checked = false;
            }
            else
            {
                chkMUInactivo.Checked = true;
                chkMUActivo.Checked = false;
            }

            cmbMURol.Text = ds.Tables[0].Rows[0]["rol"].ToString();

            //liberar la memoria del dataset
            ds.Dispose();
        }

        private void lstMUSeleccionU_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenadoMU();
        }

        private void btnNUCancelar_Click(object sender, EventArgs e)
        {

        }

        //funcion que limpia todos los textos de modificar usuario.
        private void LimpiarMU()
        {
            txtMUBuscar.Text = "";
            txtMUUsuario.Text = "";
            txtMUPassword.Text = "";
            txtMUNombre.Text = "";
            txtMUApellidoP.Text = "";
            txtMUApellidoM.Text = "";
            txtMUDireccion.Text = "";
            txtMUDireccion2.Text = "";
            txtMUTel1.Text = "";
            txtMUTel2.Text = "";
            txtMUMail.Text = "";
            chkMUActivo.Checked = false;
            chkMUInactivo.Checked = false;
            cmbMURol.Text = "";
        }

        private void btnMUCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMU();
            txtMUBuscar.Focus();
        }




        private void btnEUEliminar_Click(object sender, EventArgs e)
        {
            string condicional = "idusuarios=" + EliminarID;
            string query = QueryBuilder.DeleteSQL("usuarios", condicional);
            DBManager.deleteSQL(query);
        }



        private void LlenadoEU()
        {
            // Construir el select inicial para llenar el grid
            string query = @"SELECT idusuarios as 'ID',Nombre,ApellidoP as 'Apellido Paterno', ApellidoM as 'Apellido Materno' from usuarios order by Nombre; ";

            /////Revisar el codigo Lista

            lstEUlista.DataSource = null;
            lstEUlista.DataSource = DBManager.SelectForGrid(query);
            lstEUlista.Columns[0].Visible = false;

        }

        private void seleccionEU()
        {
            EliminarID = lstEUlista.CurrentRow.Cells[0].Value.ToString();

            string nombre = lstEUlista.CurrentRow.Cells[1].Value.ToString();
            string apellidoP = lstEUlista.CurrentRow.Cells[2].Value.ToString();
            string apellidoM = lstEUlista.CurrentRow.Cells[3].Value.ToString();

            lblEUSelected.Text = nombre + " " + apellidoP + " " + apellidoM;
        }

        private void lstEUlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionEU();
        }

        private void lstEUlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionEU();
        }

        private void btnNUGuardar_Click_1(object sender, EventArgs e)
        {
            //Variables para la construccion de la sentencia
            //UserID,Password,Nombre,ApellidoP,ApellidoM,Direccion1,Direccion2,Telefono1,Telefono2,Mail,Status,Rol
            string userID;
            string password;
            string Nombre;
            string ApellidoP;
            string ApellidoM;
            string Direccion1;
            string Direccion2;
            string Telefono1;
            string Telefono2;
            string mail;

            string rol;

            string query;

            //Constructor de sentencia
            //llenado de variables
            userID = txtNUUsuario.Text;
            password = txtNUPassword.Text;
            Nombre = txtNUNombre.Text;
            ApellidoP = txtNUApellidoP.Text;
            ApellidoM = txtNUApellidoM.Text;
            Direccion1 = txtNUDireccion1.Text;
            Direccion2 = txtNUDireccion2.Text;
            Telefono1 = txtNUTelefono1.Text;
            Telefono2 = txtNUTelefono2.Text;
            mail = txtNUMail.Text;

            //Asigancion del la variable status
            StatusSelector();

            rol = cmbMURol.Text;

            //construccion enorme del string
            query = @"INSERT INTO usuarios (UserID,Pass,Nombre,ApellidoP,ApellidoM,Direccion1,Direccion2," +
"Telefono1,Telefono2,Mail,Status,rol) " +
"VALUES " +
"('" + userID + "','" + password + "','" + Nombre + "','" + ApellidoP + "','" + ApellidoM + "','" + Direccion1 + "','"
+ Direccion2 + "','" + Telefono1 + "','" + Telefono2 + "','" + mail + "','" + Status + "','" + rol + "');";


            //MessageBox.Show(query);
            if (DBManager.Insertar(query) == true)
            {
                //Kardex injection
                //Extract the variables
                string _username = GlobalVariables.Usuario;
                string description = "Se efectuo una insercion de usuario en el modulo de usuarios. El usuario insertado fue: " + userID;
                //build the SQL query
                string kardexQuery = @"INSERT INTO naut_kardex (Kardex_Modulo,Kardex_Fecha,Kardex_Hora,Kardex_Usuario,Kardex_Descripcion) 
VALUES 
('User_Module',curdate(), curtime(),'" + _username + "','" + description + "')";
                // String to write in the LOG file
                string LogText = @"El usuario: " + _username + " Inserto al usuario: " + userID + "  a la fecha/hora: " + DateTime.Now;

                if (KardexController.Injector(kardexQuery, LogText) == true)
                {
                    MessageBox.Show("Usuario insertado con exito");
                    //Falta generar la rutina para limpiar el formulario
                    //LimpiarAU();

                }
                else
                {
                    MessageBox.Show("Error en el kardex.");
                }
            }
            else
            {
                MessageBox.Show("Hubo un error en la insercion del usuario");
            }
        }


        //Update user method
        private void UpdateUser()
        {
            //declaracion y llenado de variables
            string _table = "usuarios"; //Esta tabla es estatica para la rutina


            //Values Variable fill
            string _values = "UserID='" + txtMUUsuario.Text.Trim() + "'," +
                "Pass='" + txtMUPassword.Text + "'," +
                "Nombre='" + txtMUNombre.Text + "'," +
                "ApellidoP='" + txtMUApellidoP.Text + "'," +
                "ApellidoM='" + txtMUApellidoM.Text + "'," +
                 "Direccion1='" + txtMUDireccion.Text + "'," +
                  "Direccion2='" + txtMUDireccion2.Text + "'," +
                "Telefono1='" + txtMUTel1.Text + "'," +
                "Telefono2='" + txtMUTel2.Text + "'," +
                "Mail='" + txtMUMail.Text + "'," +
                "Status='" + Status + "'," +
                "Rol='" + cmbMURol.Text + "' ";

            //llenamos la variable para extraer el id
            string id = lstMUSeleccionU.CurrentRow.Cells[0].Value.ToString();
            string _where = "WHERE idusuarios='" + id + "'";

            //Sacamos la sentencia del SQL de la funcion UpdateSQl
            string updateQuery = SQLBuilder.updateSQL(_table, _values, _where);

            if (DBManager.Actualizar(updateQuery) == true)
            {
                MessageBox.Show("Usuario actualizado con exito");
            }
            else
            {
                MessageBox.Show("Actualizacion de usuario fallida");
            }

            _values = null;

            //Fin de la rutina de actualizaciones
        }



        private void tabEliminarUsuario_Enter(object sender, EventArgs e)
        {
            LlenadoEU();
        }



        //habilitates the new user part of the form
        private void habilitarNU()
        {
            gpNU.Enabled = true;
            txtNUNombre.Focus();
        }


    }
}

// REPOSITORY AND DISCONTINUED CODE

/*
        * Discontinued Code
       //Llenado de la variable _values
       string[,,] _values =
      {
           { { "UserID", txtMUUsuario.Text, "string" } },
           { { "Pass", txtMUPassword.Text,"string" } },
           { {"Nombre",txtMUNombre.Text ,"string"} },
           { {"ApellidoP",txtMUApellidoP.Text ,"string" } },
           { {"ApellidoM",txtMUApellidoM.Text ,"string" } },
           { {"Direccion1",txtMUDireccion.Text,"string" } },
           { {"Direccion2",txtMUDireccion2.Text,"string" } },
           { {"Telefono1",txtMUTel1.Text ,"string"} },
           { {"Telefono2",txtMUTel2.Text ,"string" } },
           { {"Mail",txtMUMail.Text ,"string" } },
           { {"Status",Status ,"string" } },
           { {"rol",cmbMURol.Text ,"string" } }
       };
           discontinued CODE used in query builder a discontinued class
        */
