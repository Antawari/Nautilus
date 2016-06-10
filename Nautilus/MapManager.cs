using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus
{
    /// <summary>
    /// This class will handle all the information necessary
    /// to manage the Beacon map in the frmBeacon
    /// </summary>
    class MapManager
    {

        //This function returns the latitude according to the ID
        public static long Latitude (string ID)
        {
            //variable declaration
            long value = new long();
            string sql = @"SELECT Beacon_Geo_Lat from naut_beacon where Beacon_ID='" + ID + "' ORDER by IdNaut_Beacon DESC LIMIT 1";
            

            value = DBManager.coordinates(sql);

            return value;
        }

        //This function returns the longitude according to the ID
        public static long Longitude(string ID)
        {
            long value = new long();
            string sql = @"SELECT Beacon_Geo_Long from naut_beacon where Beacon_ID='" + ID + "' ORDER by IdNaut_Beacon DESC LIMIT 1";
            
            value = DBManager.coordinates(sql);
            return value;
        }
    }
}
