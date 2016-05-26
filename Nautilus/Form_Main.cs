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
    }
}
