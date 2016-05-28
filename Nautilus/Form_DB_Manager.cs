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
        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            //We need to fix the entries to check for acceptable values.
            
            
            //Save Configuration
            ConfigWriter();
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

        //overwrites the App.Config file through the ConfigManager Class
        private void ConfigWriter()
        {
            string value;
            string key;

            //Server Write
            key = "SERVER";
            value = txtServer.Text;
            ConfigManager.writeConfig(key, value);

            //password write
            key = "PASSWORD";
            value = txtPassword.Text;
            ConfigManager.writeConfig(key, value);
            
            //User Write
            key = "UID";
            value = txtUsuario.Text;
            ConfigManager.writeConfig(key, value);

            //Database write
            key = "DATABASE";
            value = txtBase.Text;
            ConfigManager.writeConfig(key, value);

        }

        private void tabConfiguracion_Selected(object sender, TabControlEventArgs e)
        {
            FillTools();

            

        }

        private void FillTools()
        {
            listDBData.Items.Clear();
            listDBData.Items.Add("Servidor= " + ConfigManager.ReadConfigServer());
            listDBData.Items.Add("Base de Datos= " + ConfigManager.ReadConfigDatabase());
            listDBData.Items.Add("UID= " + ConfigManager.ReadConfigUID());

            //Function that retrieves the OK status for all tables
            listDBHealth.DataSource = DBManager.HealthDB();

        }

        private void btnSelectRuta_Click(object sender, EventArgs e)
        {
            SaveDBDialog.ShowDialog();
            txtRutaDB.Text = SaveDBDialog.FileName;
        }

        private void btnGuardarRespaldoBD_Click(object sender, EventArgs e)
        {
            string ruta;
            ruta = txtRutaDB.Text;
            DBManager.backupSQL(ruta);
        }

        private void btnRepararDB_Click(object sender, EventArgs e)
        {
            DBManager.RepairDB("SHOW TABLES IN nautilus");
        }

        private void btnRestaurarRuta_Click(object sender, EventArgs e)
        {
            openRestoreDialog.ShowDialog();
            txtRestoreRuta.Text = openRestoreDialog.FileName.ToString();

        }

        private void btnRestaurarDB_Click(object sender, EventArgs e)
        {

        }
    }
}
