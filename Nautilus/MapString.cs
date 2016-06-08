using System;
using System.IO;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus
{
    class MapString
    {
        /*SUMMARY
         * Class that will generate the required URL to show
         * the google map necessary to pinpoint the location
         * of a specific device.
         */

        //Variable declaration
        private static string Url;
     
        private static  string Latitude;
        private static string Longitude;
        private static  string Zoom;
        private static string API_Key = "AIzaSyAYhnt-J0kr_58YrKq5pD_oYT4dFINrOas";

        //Part of the class that receives the parameters and returns the url
        public static  string MapUrl(string lat, string lon, string zo)
        {
            Latitude = lat;
            Longitude = lon;
            Zoom = zo;

            //ejecutar el constructor que devolvera el URL
            constructor();
           return Url;
        }

        private static void constructor()
        {
            string BaseUrl = @"https://www.google.com/maps/embed/v1/place?key=" + API_Key;

            //it adds the coordinates
            BaseUrl = BaseUrl +"&center="+ Latitude + "," + Longitude;
            //adds the zoom parameter if needed
            if (Zoom != "" || Zoom != null)
            {
                Zoom = ",&zoom=" + Zoom;
                BaseUrl = BaseUrl + Zoom;
            }


            Url = BaseUrl;
        }

        //Function that will create the temporary HTML required to show the map on the browser control
        public string MapHTML(string url)
        {
            string htmlComplete = null;



            return htmlComplete;
        }
    }
}
