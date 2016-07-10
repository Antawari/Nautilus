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
        private static string Status;
        private static string StatusMU;
        private static string UserID;
        private string EliminarID;

        //Variables for the Kardex Operations
        private static string User;
        private static string ID;

        /// <summary>
        /// End of Sector 1
        /// </summary>

        /*************************************************************************************************************************/

        /// <summary>
        /// Sector 2
        /// Controls and events
        /// </summary>

        //initialize component
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
            string _usuario = GlobalVariables.Usuario;
            string _description = @"El Usuario " + _usuario + " modifico al usuario con el identificador " + ID +
                " y con el siguiente nombre " + User + ". A la FECHA/HORA" + DateTime.Now;
            KardexInsert(_description); //HERE I GO, I THINK I SHOULD 

            FillMUUserGrid();
        }
        // this function fills the the fields of the delete user
        private void tabEliminarUsuario_Enter(object sender, EventArgs e)
        {
            LlenadoEU();
        }
        // when the txt field of the new user part of the forms changes
        private void txtNUMail_TextChanged(object sender, EventArgs e)
        {
            mailOK();
        }
        // When you click on the modify user tab
        private void tabModificarUsuario_Enter(object sender, EventArgs e)
        {
            FillMUUserGrid();
        }
        //click on the modify user grid
        private void lstMUSeleccionU_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LlenadoMU();
        }
        //lick on the cancel button on the new user
        private void btnNUCancelar_Click(object sender, EventArgs e)
        {
            CleanGroup(gpNU);
            txtNUUsuario.Focus();
        }
        private void btnMUCancelar_Click(object sender, EventArgs e)
        {
            CleanGroup(gpMU);
            txtMUBuscar.Focus();
        }
        //New User button click
        private void btnNUGuardar_Click_1(object sender, EventArgs e)
        {
            NewUser();
            string _usuario = GlobalVariables.Usuario;
            string _description = @"El Usuario " + _usuario + " inserto a un nuevo usuario con el identificador " + ID +
                " y con el siguiente nombre " + User + ". A la FECHA/HORA" + DateTime.Now;
            KardexInsert(_description);
        }
        //Delete user button click
        private void btnEUEliminar_Click(object sender, EventArgs e)
        {
            DeleteUser();
            string _usuario = GlobalVariables.Usuario;
            string _description = @"El Usuario " + _usuario + " Elimino a un usuario con el identificador " + ID +
                " y con el siguiente nombre " + User + ". A la FECHA/HORA" + DateTime.Now;
            KardexInsert(_description);
        }
        //when you click on the Delete user click
        private void lstEUlista_Click(object sender, EventArgs e)
        {
            seleccionEU();
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
            if (rbNUActivo.Checked == true)
            {
                Status = "Activo";
            }
            else
            {
                Status = "Inactivo";
            }

            if (rbMUActivo.Checked == true)
            {
                StatusMU = "Activo";
            }
            else
            {
                StatusMU = "Inactivo";
            }
        }
        // function that checks the mail format
        private void mailOK()
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
        // Function that fills up the text fields in the modify user part of the form
        private void LlenadoMU()
        {
            //Para llenar los campos a modificar, hacemos una busqueda con select.
            string id = lstMUSeleccionU.CurrentRow.Cells[0].Value.ToString();
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
                rbMUActivo.Checked = true;
                rbMUInactivo.Checked = false;
            }
            else
            {
                rbMUInactivo.Checked = true;
                rbMUActivo.Checked = false;
            }

            cmbMURol.Text = ds.Tables[0].Rows[0]["rol"].ToString();

            //liberar la memoria del dataset
            ds.Dispose();
        }
        //Function that fills the grid on the delete user part of the form
        private void LlenadoEU()
        {
            // Construir el select inicial para llenar el grid
            string query = @"SELECT idusuarios as 'ID',Nombre,ApellidoP as 'Apellido Paterno', ApellidoM as 'Apellido Materno' from usuarios order by Nombre; ";

            /////Revisar el codigo Lista
            lstEUlista.DataSource = null;
            lstEUlista.DataSource = DBManager.SelectForGrid(query);
            lstEUlista.Columns[0].Visible = false;
        }
        //Function that assigns the variables to the delete user
        //its called whn the grid on the form is clicked
        private void seleccionEU()
        {
            EliminarID = lstEUlista.CurrentRow.Cells[0].Value.ToString();
            string nombre = lstEUlista.CurrentRow.Cells[1].Value.ToString();
            string apellidoP = lstEUlista.CurrentRow.Cells[2].Value.ToString();
            string apellidoM = lstEUlista.CurrentRow.Cells[3].Value.ToString();
            lblEUSelected.Text = nombre + " " + apellidoP + " " + apellidoM;
            //kardex variables
            ID = EliminarID;
            string _nombre = nombre;
            string _apellidoP = apellidoP;
            string _apellidoM = apellidoM;
            User = _nombre + " " + _apellidoP + " " + _apellidoM;



        }
        //Update user method
        private void UpdateUser()
        {
            //status selector
            StatusSelector();
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
                "Status='" + StatusMU + "'," +
                "Rol='" + cmbMURol.Text + "' ";




            //llenamos la variable para extraer el id
            string id = lstMUSeleccionU.CurrentRow.Cells[0].Value.ToString();
            string _where = "WHERE idusuarios='" + id + "'";
            //Sacamos la sentencia del SQL de la funcion UpdateSQl
            string updateQuery = SQLBuilder.updateSQL(_table, _values, _where);

            //Variable fill for the kardex
            string Nombre = txtMUNombre.Text;
            string ApellidoP = txtMUApellidoP.Text;
            string ApellidoM = txtMUApellidoM.Text;
            User = Nombre + " " + ApellidoP + " " + ApellidoM;
            ID = id;



            if (DBManager.Actualizar(updateQuery) == true)
            {
                MessageBox.Show("Usuario actualizado con exito");
                CleanGroup(gpMU);
            }
            else
            {
                MessageBox.Show("Actualizacion de usuario fallida");
            }

            _values = null;

            //Fin de la rutina de actualizaciones
        }
        //habilitates the new user part of the form
        private void habilitarNU()
        {
            gpNU.Enabled = true;
            txtNUNombre.Focus();
        }
        //function that fills the user grid for the modify user part of the form.
        private void FillMUUserGrid()
        {
            // Construir el select inicial para llenar el grid
            string query = @"SELECT idusuarios as 'ID',Nombre,ApellidoP as 'Apellido Paterno', ApellidoM as 'Apellido Materno' from usuarios order by Nombre; ";

            // assignation of data
            lstMUSeleccionU.DataSource = null;
            lstMUSeleccionU.DataSource = DBManager.SelectForGrid(query);
            lstMUSeleccionU.Columns[0].Visible = false;
        }
        //function that cleans all the controls in the assigned group
        private void CleanGroup(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).Text = "";
                }
            }
        }
        //Function that inserts new user
        private void NewUser()
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

            ID = userID;  //To pass to the kardex
            User = Nombre + " " + ApellidoP + " " + ApellidoM;  //to pass to the kardex
            //Asigancion del la variable status
            StatusSelector();
            rol = cmbMURol.Text;

            //construccion enorme del string
            query = @"INSERT INTO usuarios (UserID,Pass,Nombre,ApellidoP,ApellidoM,Direccion1,Direccion2," +
"Telefono1,Telefono2,Mail,Status,rol) " +
"VALUES " +
"('" + userID + "','" + password + "','" + Nombre + "','" + ApellidoP + "','" + ApellidoM + "','" + Direccion1 + "','"
+ Direccion2 + "','" + Telefono1 + "','" + Telefono2 + "','" + mail + "','" + Status + "','" + rol + "');";

            if (DBManager.Insertar(query) == true)
            {
                MessageBox.Show("El usuario " + Nombre + " fue insertado con Exito");
            }
            else
            {
                MessageBox.Show("Hubo un error en la insercion del usuario");
            }
        }
        //function that deletes user
        private void DeleteUser()
        {
            string condicional = "idusuarios=" + EliminarID;
            string query = QueryBuilder.DeleteSQL("usuarios", condicional);
            DBManager.deleteSQL(query);

          

        }
        //Kardex handler
        private void KardexInsert(string description)
        {
            //MessageBox.Show("Congratulations you are logged in");
            string _username = GlobalVariables.Usuario;

            //Add to the Kardex Routine
            //build the SQL query
            string query = @"INSERT INTO naut_kardex (Kardex_Modulo,Kardex_Fecha,Kardex_Hora,Kardex_Usuario,Kardex_Descripcion) 
VALUES 
('User-Module',curdate(), curtime(),'" + _username + "','" + description + "')";

            if (KardexController.Injector(query, description) != true)
            {
                MessageBox.Show("Error en el kardex.");
            }

        }
        //***********************************************************************************************************************************
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
