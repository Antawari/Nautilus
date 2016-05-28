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
        public static MySqlConnection _conn;


        public void Conector()
        {



            Iniciador();


        }

        private static void Iniciador()
        {

            //Se asigna el inicio de conexion
            //los datos de cadena de conexion son extraidos de el archivo de configuraccion del sistema
            string cadenaConeccion = ConfigManager.ConnString();

            _conn = new MySqlConnection(cadenaConeccion);

        }

        private static bool Conectarse()
        {
            try
            {
                _conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                /* Cuando se abre una coneccion y no es existoas
                 * mysql puede manejar los errores.
                 * los dos errores mas comunes son:
                 * 0: No se puede conectar al servidor.
                 * 1045: Usuario o contraseña invalidos. */
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se puede conectar al servidor. Contactar al administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Usuario/Contraseña invalidos, Corrija los datos de la conexion");
                        break;
                }
                return false;
            }
        }


        private static bool Desconectarse()
        {
            //Rutina de desconexion

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

        public static void Insertar(string Query)
        {
            //Se inician las variables requeridas
            Iniciador();

            if (Conectarse() == true)
            {
                //Ejecucion del INSERT INTO
                MySqlCommand sqlInsert = new MySqlCommand(Query, _conn);
                sqlInsert.ExecuteNonQuery();
                Desconectarse();
                MessageBox.Show("Insertado con exito");
            }

        }






        //rutina de select con DataTable para los datagrids
        // Funciona para todos os datagrids del programa
        //Acepta todas las sentencias Select.
        public static DataTable SelectForGrid(string query)
        {
            //Iniciar las variables
            Iniciador();
            // Declaracion de variables de retorno
            //DataSet dataSet;
            MySqlDataAdapter mySqlDataAdapter;
            DataTable dataSet = new DataTable();
            //Iniciar conexion y rutina
            if (Conectarse() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter(query, _conn);
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter.Dispose();
                Desconectarse();
                return dataSet;
            }
            return dataSet;
            //fin de la rutina SelectForGrid           
        }

        //rutina de select con DataTable para los datagrids
        // Funciona para todos os datagrids del programa
        //Acepta todas las sentencias Select.

        public static DataSet SelectForText(string query)
        {
            //Iniciar las variables
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





        // rutina de select para el grid de modificar usuario
        public static List<string>[] Select(string query)
        {
            //Iniciar Variables Necesarias
            Iniciador();


            //Crear una lista para almacenar el resultado
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Abrir conexion y ejecutar sentencia
            if (Conectarse() == true)
            {
                //Crear el comando
                MySqlCommand cmd = new MySqlCommand(query, _conn);

                //Crear un lector de datos y ejecutar el comando
                MySqlDataReader lectorDatos = cmd.ExecuteReader();

                //Leer el lectorDatos y llenar la lista
                while (lectorDatos.Read())
                {
                    list[0].Add(lectorDatos["Nombre"] + "");
                    list[1].Add(lectorDatos["Apellido Paterno"] + "");
                    list[2].Add(lectorDatos["Apellido Materno"] + "");

                }

                //Cerrar lector de datos
                lectorDatos.Close();

                //Cerrar conexion
                Desconectarse();

                //Retornar la lista al componente que la solicita.
                return list;

            }
            else
            {
                return list;
            }




        }




        //Funcion publica para sentencia UPDATE

        public static void Actualizar(string query)
        {
            //inicializar variables
            Iniciador();

            //Conector y rutina
            if (Conectarse() == true)
            {
                //Ejecucion del Update
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



        public static void deleteSQL(string query)
        {
            //inicializar variables
            Iniciador();

            //Conector y rutina
            if (Conectarse() == true)
            {
                //Ejecucion del Update
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


        public static bool testConn(string connectionString)
        {
            bool valor = false;

            //Iniciar conexion y revisar si es posible con los atributos obetenidos del formulario.
            Iniciador();


            return valor;
        }

        //to backup the database

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

        public static  void RepairTable(string query)
        {
            //Method executed in the RepairDB loop
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter();
            cmd = _conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

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
            MySqlDataReader lectorDatos = null ;
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
         * 
         * 
         * 
         */
             

         

             
                

        


    }
}
