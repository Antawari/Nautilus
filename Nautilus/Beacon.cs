using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Maps.MapControl.WPF;

namespace Nautilus
{
    public partial class Beacon : Form
    {
        /// <summary>
        /// This Form will control and let you view the beacons of the nautilus
        /// devices. You will be ablet to pinpoint the nautilus device as far as the
        /// last input in the database and compare it to it's first location when configured
        /// </summary>


        //Variables necessary for the beacon to work.
        private string tempHTML;

        public Beacon()
        {
            InitializeComponent();
        }

        private void Beacon_Load(object sender, EventArgs e)
        {
            //webBeacon.Navigate(MapString.MapUrl("20.5698132", "-100.3073437", "14"));
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
