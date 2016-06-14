using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus
{
    /// <summary>
    /// This class builds all sql sentences necessary to do the injections
    /// </summary>

    public static class SQLBuilder
    {

        /// <summary>
        /// function that constructs
        /// </summary>
       /// <returns>
       /// SQL query for update
       /// </returns>
        public static string updateSQL(string _table, string _values, string _condition)
        {
            string query = null;
            query = "UPDATE " + _table + " SET " + _values + " " + _condition + ";";

            return query;
        }
    }
}
