﻿using MySql.Data.MySqlClient;
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
            string cadenaConeccion = ConfigurationManager.AppSettings["ConnectionString"];

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
        }


        public static bool testConn(string connectionString)
        {
            bool valor = false;

            //Iniciar conexion y revisar si es posible con los atributos obetenidos del formulario.
            Iniciador();


            return valor;
        }



    }
}
