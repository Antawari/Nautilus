using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus
{
    /// <summary>
    /// Class that controls the Kardex
    /// Every single movement to the database will be logged into
    /// this table.
    /// The class acts as a SQL sentence constructor that will eventually
    /// execute an INSERT statement in the DBManager class
    /// </summary>

       class KardexController
    {
        //Variable declaration
        private string SQLInjector;



        //This function will request all the parts necessary to build the SQL Sentence that will be sent
        //To the DBManager class
        public static bool Injector()
        {




            return true;
        }



    }
}
