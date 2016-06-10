using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus
{
    /// <summary>
    /// Class that handles all the Global variables necessary for the program
    /// </summary>
    public static class GlobalVariables
    {
        /// <summary>
        /// Variable Usuario
        /// </summary>
        static string _usuario;
        /// <summary>
        /// Variable Login
        /// </summary>
        static bool _login;


        //Usuario Handle
        public static string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

            //Login Handle
            public static bool Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        
        }
    }
}
