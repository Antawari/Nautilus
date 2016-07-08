using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nautilus
{
    /// <summary>
    /// Class that controls the Kardex
    /// Every single movement to the database will be logged into
    /// this table.
    /// The class acts as a SQL sentence constructor that will eventually
    /// execute an INSERT statement in the DBManager class
    /// It'll also handle log files
    /// </summary>

    class KardexController
    {
        
        //********************************************************************************************************************************//
        /// <summary>
        /// This function will request all the parts necessary to build the SQL Sentence that will be sent To the DBManager class
        /// </summary>
        /// <returns></returns>
        public static  bool Injector(string query, string text)
        {
            // Condition that will insert both    
            if(LogFileManager(text) == true &&  DBManager.Insertar(query) == true ) //condition that checks the kardex operation and returns OK
            {
                return true;
            }
            else
            {
                //Add a error management class
                MessageBox.Show("Hay un error en el manejo del Kardex");
                return false;
            }
        }
        // End of the injector
        //********************************************************************************************************************************//

        //********************************************************************************************************************************//
        /// <summary>
        ///This function handles the log files. It'll create them or add lines 
        ///if necessary
        /// </summary>
        private static bool LogFileManager(string text)
        {
            //Variables necessary for th routine
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string dirPath = @"D:\Nautilus\Log\";
            string fileName = "log"+ date + ".txt";
            string path = System.IO.Path.Combine(dirPath, fileName);
            
            //Error handling and try
            try
            {
                if (Directory.Exists(dirPath) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                    //if the file exists open it and write from the last entry.
                    if (File.Exists(path))
                    {
                        //Write a line to the file
                        using (StreamWriter file = new StreamWriter(path,true))
                        {
                            file.WriteLine(text);
                            return true;
                        }
                    }
                    else
                    {
                        // Create the file.
                        using (FileStream fs = File.Create(path))
                        {
                            Byte[] info = new UTF8Encoding(true).GetBytes(text);
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                            return true;
                        }
                    }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el archivo log: "+ ex.ToString());
                return false;
            }
        }
        //End of file management function
        //********************************************************************************************************************************//

    }
}
