using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nautilus
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DB_Manager DataBaseForm = new Form_DB_Manager();
            DataBaseForm.MdiParent = this;
            DataBaseForm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement userform = new frmUserManagement();
            userform.MdiParent = this;
            userform.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void dispositivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Devices nautilusform = new Form_Devices();
            nautilusform.MdiParent = this;
            nautilusform.Show();
        }

        private void beaconToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBeacon beacon = new frmBeacon();
            beacon.MdiParent = this;
            beacon.Show();
        }
    }
}
