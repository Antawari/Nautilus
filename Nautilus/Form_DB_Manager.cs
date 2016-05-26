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
    public partial class Form_DB_Manager : Form
    {
        public Form_DB_Manager()
        {
            InitializeComponent();
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {

        }

        private void Form_DB_Manager_Load(object sender, EventArgs e)
        {
            formLoader();

        }

        //gets the values for the form loading stage
        private void formLoader()
        {
            txtServer.Text = ConfigManager.ReadConfigServer();
            txtPassword.Text = ConfigManager.ReadConfigPassword();
            txtUsuario.Text = ConfigManager.ReadConfigUID();
            txtBase.Text = ConfigManager.ReadConfigDatabase();
        }
    }
}
