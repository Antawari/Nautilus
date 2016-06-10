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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        /*Buttons functionality
            * 
            * 
            */
            //Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = new bool();
            string _username = txtLoginUsername.Text;
            string _password = txtLoginPassword.Text;
            login = DBManager.LogOk(_username, _password);

            if (login == true)
            {
                MessageBox.Show("Congratulations you are logged in");
                GlobalVariables.Usuario = _username;
                GlobalVariables.Login = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password Incorrect");
                txtLoginPassword.Text = "";
                txtLoginUsername.Text = "";
                txtLoginUsername.Focus();
                GlobalVariables.Login = false;
            }
        }


            //Close the program
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseProgram();
        }


        private void CloseProgram()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
