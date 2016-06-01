using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Nautilus
{
    class DBManager
    {
        //VARIABLE DECLARATION
        private static MySqlConnection _conn;
        /**********************************************************************************************************************************************/
        private void Conector()
        {
            Iniciador();
        }

        private static void Iniciador()
        {
            //Assign the connection string
            //The connection string information is extracted from the
            //ConfigManager class
            string cadenaConeccion = ConfigManager.ConnString();
            _conn = new MySqlConnection(cadenaConeccion);
        }
        /**********************************************************************************************************************************************/
        //Connection Function
        private static bool Conectarse()
        {
            try
            {
                _conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                /* If the connection misses
                 * we handle the error with a catcher
                 * The most common errors are:
                 * 0: Can't connect to the server (Ip or no internet connection available)
                 * 1045: Invalid User or Password. */
                switch (ex.Number)
                {
                    //Server unreachable case
                    case 0:
                        MessageBox.Show("No se puede conectar al servidor. Contactar al administrador");
                        break;
                    //Bas username/password case
                    case 1045:
                        MessageBox.Show("Usuario/Contraseña invalidos, Corrija los datos de la conexion");
                        break;
                }
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Disconnection Function
        private static bool Desconectarse()
        {
            try
            {
                _conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Insert Sentence Function
        //we make it boolean to check if the insertion was effective
        public static bool Insertar(string Query)
        {
            //We initiate the variables
            Iniciador();

            if (Conectarse() == true)
            {
                //Sql sentence execution
                MySqlCommand sqlInsert = new MySqlCommand(Query, _conn);
                sqlInsert.ExecuteNonQuery();
                Desconectarse();
                return true;
                //MessageBox.Show("Insertado con exito");
            }
            else
            {
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Select Routine with DataTable for datagrids
        // Works for any datagrid inside the program
        //Takes any SELECT sentence.
        public static DataTable SelectForGrid(string query)
        {
            //Initiate variables
            Iniciador();
            // Return variable declaration
            //DataSet dataSet;
            MySqlDataAdapter mySqlDataAdapter;
            DataTable dataSet = new DataTable();
            //Initiate connection
            if (Conectarse() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter(query, _conn);
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter.Dispose();
                Desconectarse();
                return dataSet;
            }
            return dataSet;
            //End of succesful routine          
        }
        /**********************************************************************************************************************************************/
        //This is a special Select Routine that handles 
        // Text fields
        //Takes a special SELECT sentence
        public static DataSet SelectForText(string query)
        {
            //Initiate Variables
            Iniciador();
            DataSet ds;
            if (Conectarse() == true)
            {
                ds = new DataSet();
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter(query, _conn);
                mySqlDataAdapter.Fill(ds);
                mySqlDataAdapter.Dispose();
                Desconectarse();
                return ds;
            }
            ds = null;
            return ds;
        }
        /**********************************************************************************************************************************************/
        // SELECT function for the modify user Grid
        public static List<string>[] Select(string query)
        {
            //Initiate variables
            Iniciador();
            //Create a List to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open Connection and Execute sentence
            if (Conectarse() == true)
            {
                //Create the command
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                //Create a DataReader and execute the command
                MySqlDataReader lectorDatos = cmd.ExecuteReader();
                //Read the DataReader and populate the List
                while (lectorDatos.Read())
                {
                    list[0].Add(lectorDatos["Nombre"] + "");
                    list[1].Add(lectorDatos["Apellido Paterno"] + "");
                    list[2].Add(lectorDatos["Apellido Materno"] + "");
                }

                //Close the DataReader
                lectorDatos.Close();
                //Close Connection
                Desconectarse();
                //Return the result
                return list;
            }
            else
            {
                return list; //Return empty list
            }
        }
        /**********************************************************************************************************************************************/
        //Public Function for UPDATE sentence
        public static void Actualizar(string query)
        {
            //Initialize variables
            Iniciador();

            //Connector and method
            if (Conectarse() == true)
            {
                //UPDATE execution
                MySqlCommand sqlUpdate = new MySqlCommand(query, _conn);
                sqlUpdate.ExecuteNonQuery();
                Desconectarse();
                MessageBox.Show("Actualizado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un problema con la actualizacion");
            }
        }
        /**********************************************************************************************************************************************/
        //Public method for DELETE sentence
        public static void deleteSQL(string query)
        {
            //Start Variables
            Iniciador();

            //Connect and method
            if (Conectarse() == true)
            {
                //UPDATE execution
                MySqlCommand sqlUpdate = new MySqlCommand(query, _conn);
                sqlUpdate.ExecuteNonQuery();
                Desconectarse();
                MessageBox.Show("eliminado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un problema con la eliminacion");
            }
            Desconectarse();
        }
        /**********************************************************************************************************************************************/
        //Public Method to test the connection
        public static bool testConn(string connectionString)
        {
            /* INCOMPLETE */
            bool valor = false;
            //Start Variables
            Iniciador();
            return valor;
        }
        /**********************************************************************************************************************************************/
        //Backup the DATABASE
        public static void backupSQL(string ruta)
        {
            //Start Variables
            Iniciador();
            //Connector and routine
            if (Conectarse() == true)
            {
                //Backup Execution
                using (MySqlCommand command = new MySqlCommand())
                {
                    using (MySqlBackup backup = new MySqlBackup(command))
                    {
                        command.Connection = _conn;
                        backup.ExportToFile(ruta);
                        Desconectarse();
                        MessageBox.Show("Actualizado con exito");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hubo un problema con la Conexion");
            }
        }
        /**********************************************************************************************************************************************/
        //Repair DB function
        public static void RepairDB(string query)
        {
            //Initiate Variables and conection
            Iniciador();
            Conectarse();

            //Components necessary for the function
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlDataAdapter ad = new MySqlDataAdapter(query, _conn);
            ad.Fill(dt);
            //Loop that executes repair table by table
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                RepairTable("repair table " + dt.Rows[i][0].ToString() + "");
            }
            Desconectarse();
        }
        /**********************************************************************************************************************************************/
        //Function that once we have the list executes the repair table by table
        private static void RepairTable(string query)
        {
            //Method executed in the RepairDB loop
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            cmd = _conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        /**********************************************************************************************************************************************/
        /* Important Function.
         * Review for upcoming updates
         */
        //List that returns the overall health state of the tables in the current Database
        public static List<string> HealthDB()
        {
            //Object declaration and allocation
            string tabla = null;
            string query2 = null;
            MySqlCommand cmd = new MySqlCommand();
            List<string> statusList = new List<string>();
            MySqlDataReader lectorDatos = null;
            Iniciador();
            //Abrir conexion y ejecutar sentencia
            if (Conectarse() == true)
            {
                //Components necessary for the function
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                MySqlDataAdapter ad = new MySqlDataAdapter("SHOW TABLES IN nautilus", _conn);
                ad.Fill(dt);
                //Loop that executes repair table by table

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tabla = dt.Rows[i][0].ToString();
                    query2 = "CHECK TABLE " + tabla + "";
                    //create the command
                    cmd = _conn.CreateCommand();
                    cmd.CommandText = query2;
                    //create a reader and execute the command
                    lectorDatos = cmd.ExecuteReader();
                    lectorDatos.Read();
                    //add items to the list
                    statusList.Add("TABLA:" + tabla + " = " + lectorDatos["Msg_text"]);
                    //Close the data reader for a new query
                    lectorDatos.Close();
                }
                //disconnect and return the list
                Desconectarse();
                return statusList;
            }
            //disconnect, nullify the list and return the null parameter
            Desconectarse();
            statusList = null;
            return statusList;
        }

        /* End of health function
       */

        /**********************************************************************************************************************************************/
        /* LOGIN FUNCTION*/
        public static bool LogOk(string _username, string _password)
        {
            //Variable that stores the result
            bool value = new bool();
            string sql = null;
            int count = new int();

            Iniciador();

            //routine that checks both fields and compares them in the db
            //checkPassword
            if (Conectarse() == true)
            {
                sql = @"SELECT COUNT(*) FROM usuarios where UserID='" +
 _username + "' AND Pass='" + _password + "';";
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    count = Convert.ToInt32(result);
                }
            }
            //Algorithm that validates if the row exists
            //and assigns the true to the value variable
            if (count > 0)
            {
                value = true;
                return value;
            }
            else
            {
                value = false;
                return value;
            }
        }

    }
}