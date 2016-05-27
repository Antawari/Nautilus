using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Nautilus
{
    public static class ConfigManager

    {
        //Config Information retriever
        public static string ConnString()
        {
            string connString; //The string that'll hold the end value
            string server; //this will hold the server
            string database; //Tjis will hold the database
            string uid; //this will hold the user id
            string password; //this will hold the password

            server = ConfigurationManager.AppSettings["SERVER"];
            database = ConfigurationManager.AppSettings["DATABASE"];
            uid = ConfigurationManager.AppSettings["UID"];
            password = ConfigurationManager.AppSettings["PASSWORD"];
            //Concat
            connString = @"SERVER=" + server + ";DATABASE=" + database + 
                ";UID=" + uid + ";PASSWORD=" + password + ";";

            //Return Value
            return connString;
        }


        /* BLOCK THAT READS 
        **************************************************************
        **************************************************************
        * *************************************************************
        */

        //function that returns the server stored in the config file
        public static string ReadConfigServer()
        {
            string value;
            value = ConfigurationManager.AppSettings["SERVER"];

            return value;
        }

        //function that returns the Database stored in the config file
        public static string ReadConfigDatabase()
        {
            string value;
            value = ConfigurationManager.AppSettings["DATABASE"];

            return value;
        }

        //function that returns the user stored in the config file
        public static string ReadConfigUID()
        {
            string value;
            value = ConfigurationManager.AppSettings["UID"];

            return value;
        }

        //function that returns the password stored in the config file
        public static string ReadConfigPassword()
        {
            string value;
            value = ConfigurationManager.AppSettings["PASSWORD"];

            return value;
        }

        /* END BLOCK THAT READS 
       **************************************************************
       **************************************************************
       * *************************************************************
       */



        /* BLOCK THAT WRITES 
       **************************************************************
       **************************************************************
       * *************************************************************
       */
       public static void writeConfig(string key, string value)
        {
            System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);

            //Read the value
            MessageBox.Show(config.AppSettings.Settings[key].Value);

            //Write a new value
            config.AppSettings.Settings.Remove(key );
            config.AppSettings.Settings.Add(key, value);

            //Save the configuration file.
            config.Save(System.Configuration.ConfigurationSaveMode.Modified);
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }


        /* END BLOCK THAT WRITES 
       **************************************************************
       **************************************************************
       * *************************************************************
       */
    }
}
