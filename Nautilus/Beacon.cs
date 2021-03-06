﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Design;
using System.Globalization;

namespace Nautilus
{
    public partial class frmBeacon : Form
    {
        /// <summary>
        /// This Form will control and let you view the beacons of the nautilus
        /// devices. You will be ablet to pinpoint the nautilus device as far as the
        /// last input in the database and compare it to it's first location when configured
        /// </summary>


        //Variables necessary for the beacon to work.
       

        LocationConverter locConverter = new LocationConverter();
        public frmBeacon()
        {
            InitializeComponent();
           
        }

        private void Beacon_Load(object sender, EventArgs e)
        {
            //webBeacon.Navigate(MapString.MapUrl("20.5698132", "-100.3073437", "14"));
            IniciarMapa();
            llenarGrid();

            //Test of GlobalVariable Usuario
            //MessageBox.Show(GlobalVariables.Usuario);
        }

        private void IniciarMapa()
        {
           map1.NautMap.Center = new Location(20.612137, -100.4069873);
           map1.NautMap.ZoomLevel = 12;

        }


        private void llenarGrid()
        {

            string sql = @"SELECT Naut_ID as Identificador, Naut_Name as Dispositivo, Naut_Status as Status FROM naut_devices ORDER BY Naut_ID";

            dgBeacon.DataSource = null;
            dgBeacon.DataSource = DBManager.SelectForGrid(sql);
        }

      
    }
}
