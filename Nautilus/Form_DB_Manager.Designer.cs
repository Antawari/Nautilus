namespace Nautilus
{
    partial class Form_DB_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabConfiguracion = new System.Windows.Forms.TabControl();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.btnCancelarConfig = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnTestCon = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TabTools = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listRestaurarData = new System.Windows.Forms.ListBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRestaurarDB = new System.Windows.Forms.Button();
            this.btnOptimizarDB = new System.Windows.Forms.Button();
            this.btnRepararDB = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.listDBData = new System.Windows.Forms.ListBox();
            this.btnGuardarRespaldoBD = new System.Windows.Forms.Button();
            this.btnCancelarRespaldoDB = new System.Windows.Forms.Button();
            this.btnSelectRuta = new System.Windows.Forms.Button();
            this.txtRutaDB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TabConfigMonitor = new System.Windows.Forms.TabPage();
            this.SaveDBDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabConfiguracion.SuspendLayout();
            this.TabConfig.SuspendLayout();
            this.TabTools.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.Controls.Add(this.TabConfig);
            this.tabConfiguracion.Controls.Add(this.TabTools);
            this.tabConfiguracion.Controls.Add(this.TabConfigMonitor);
            this.tabConfiguracion.Location = new System.Drawing.Point(12, 12);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.SelectedIndex = 0;
            this.tabConfiguracion.Size = new System.Drawing.Size(936, 354);
            this.tabConfiguracion.TabIndex = 1;
            this.tabConfiguracion.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabConfiguracion_Selected);
            // 
            // TabConfig
            // 
            this.TabConfig.Controls.Add(this.btnGuardarConfig);
            this.TabConfig.Controls.Add(this.btnCancelarConfig);
            this.TabConfig.Controls.Add(this.btnUnlock);
            this.TabConfig.Controls.Add(this.btnTestCon);
            this.TabConfig.Controls.Add(this.txtBase);
            this.TabConfig.Controls.Add(this.label5);
            this.TabConfig.Controls.Add(this.txtPassword);
            this.TabConfig.Controls.Add(this.label6);
            this.TabConfig.Controls.Add(this.txtUsuario);
            this.TabConfig.Controls.Add(this.label7);
            this.TabConfig.Controls.Add(this.txtServer);
            this.TabConfig.Controls.Add(this.label8);
            this.TabConfig.Location = new System.Drawing.Point(4, 22);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfig.Size = new System.Drawing.Size(928, 328);
            this.TabConfig.TabIndex = 0;
            this.TabConfig.Text = "Configuracion";
            this.TabConfig.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Location = new System.Drawing.Point(389, 184);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConfig.TabIndex = 9;
            this.btnGuardarConfig.Text = "Guardar";
            this.btnGuardarConfig.UseVisualStyleBackColor = true;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // btnCancelarConfig
            // 
            this.btnCancelarConfig.Location = new System.Drawing.Point(308, 184);
            this.btnCancelarConfig.Name = "btnCancelarConfig";
            this.btnCancelarConfig.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarConfig.TabIndex = 8;
            this.btnCancelarConfig.Text = "Cancelar";
            this.btnCancelarConfig.UseVisualStyleBackColor = true;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(89, 185);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.TabIndex = 7;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            // 
            // btnTestCon
            // 
            this.btnTestCon.Location = new System.Drawing.Point(89, 155);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(375, 23);
            this.btnTestCon.TabIndex = 6;
            this.btnTestCon.Text = "Probar Conexion";
            this.btnTestCon.UseVisualStyleBackColor = true;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(89, 119);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(375, 20);
            this.txtBase.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Base de datos";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(375, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(89, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(375, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Usuario";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(89, 20);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(375, 20);
            this.txtServer.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Servidor";
            // 
            // TabTools
            // 
            this.TabTools.Controls.Add(this.panel2);
            this.TabTools.Controls.Add(this.panel1);
            this.TabTools.Location = new System.Drawing.Point(4, 22);
            this.TabTools.Name = "TabTools";
            this.TabTools.Size = new System.Drawing.Size(928, 328);
            this.TabTools.TabIndex = 2;
            this.TabTools.Text = "Herramientas";
            this.TabTools.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listRestaurarData);
            this.panel2.Controls.Add(this.progressBar3);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnRestaurarDB);
            this.panel2.Controls.Add(this.btnOptimizarDB);
            this.panel2.Controls.Add(this.btnRepararDB);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(527, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 282);
            this.panel2.TabIndex = 2;
            // 
            // listRestaurarData
            // 
            this.listRestaurarData.FormattingEnabled = true;
            this.listRestaurarData.Location = new System.Drawing.Point(148, 134);
            this.listRestaurarData.Name = "listRestaurarData";
            this.listRestaurarData.Size = new System.Drawing.Size(238, 134);
            this.listRestaurarData.TabIndex = 11;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(148, 26);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(238, 23);
            this.progressBar3.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(148, 64);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(238, 23);
            this.progressBar2.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(148, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Datos de la Operacion";
            // 
            // btnRestaurarDB
            // 
            this.btnRestaurarDB.Location = new System.Drawing.Point(6, 106);
            this.btnRestaurarDB.Name = "btnRestaurarDB";
            this.btnRestaurarDB.Size = new System.Drawing.Size(135, 23);
            this.btnRestaurarDB.TabIndex = 8;
            this.btnRestaurarDB.Text = "Restaurar Base de Datos";
            this.btnRestaurarDB.UseVisualStyleBackColor = true;
            // 
            // btnOptimizarDB
            // 
            this.btnOptimizarDB.Location = new System.Drawing.Point(6, 65);
            this.btnOptimizarDB.Name = "btnOptimizarDB";
            this.btnOptimizarDB.Size = new System.Drawing.Size(135, 23);
            this.btnOptimizarDB.TabIndex = 7;
            this.btnOptimizarDB.Text = "Optimizar Base de Datos";
            this.btnOptimizarDB.UseVisualStyleBackColor = true;
            // 
            // btnRepararDB
            // 
            this.btnRepararDB.Location = new System.Drawing.Point(6, 27);
            this.btnRepararDB.Name = "btnRepararDB";
            this.btnRepararDB.Size = new System.Drawing.Size(135, 23);
            this.btnRepararDB.TabIndex = 6;
            this.btnRepararDB.Text = "Reparar Base de Datos";
            this.btnRepararDB.UseVisualStyleBackColor = true;
            this.btnRepararDB.Click += new System.EventHandler(this.btnRepararDB_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mantenimiento ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar4);
            this.panel1.Controls.Add(this.listDBData);
            this.panel1.Controls.Add(this.btnGuardarRespaldoBD);
            this.panel1.Controls.Add(this.btnCancelarRespaldoDB);
            this.panel1.Controls.Add(this.btnSelectRuta);
            this.panel1.Controls.Add(this.txtRutaDB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 282);
            this.panel1.TabIndex = 1;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(20, 207);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(498, 23);
            this.progressBar4.TabIndex = 11;
            // 
            // listDBData
            // 
            this.listDBData.FormattingEnabled = true;
            this.listDBData.Location = new System.Drawing.Point(122, 33);
            this.listDBData.Name = "listDBData";
            this.listDBData.Size = new System.Drawing.Size(279, 121);
            this.listDBData.TabIndex = 2;
            // 
            // btnGuardarRespaldoBD
            // 
            this.btnGuardarRespaldoBD.Location = new System.Drawing.Point(443, 246);
            this.btnGuardarRespaldoBD.Name = "btnGuardarRespaldoBD";
            this.btnGuardarRespaldoBD.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRespaldoBD.TabIndex = 5;
            this.btnGuardarRespaldoBD.Text = "Guardar";
            this.btnGuardarRespaldoBD.UseVisualStyleBackColor = true;
            this.btnGuardarRespaldoBD.Click += new System.EventHandler(this.btnGuardarRespaldoBD_Click);
            // 
            // btnCancelarRespaldoDB
            // 
            this.btnCancelarRespaldoDB.Location = new System.Drawing.Point(362, 246);
            this.btnCancelarRespaldoDB.Name = "btnCancelarRespaldoDB";
            this.btnCancelarRespaldoDB.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarRespaldoDB.TabIndex = 4;
            this.btnCancelarRespaldoDB.Text = "Cancelar";
            this.btnCancelarRespaldoDB.UseVisualStyleBackColor = true;
            // 
            // btnSelectRuta
            // 
            this.btnSelectRuta.Location = new System.Drawing.Point(407, 163);
            this.btnSelectRuta.Name = "btnSelectRuta";
            this.btnSelectRuta.Size = new System.Drawing.Size(111, 23);
            this.btnSelectRuta.TabIndex = 3;
            this.btnSelectRuta.Text = "Seleccionar carpeta";
            this.btnSelectRuta.UseVisualStyleBackColor = true;
            this.btnSelectRuta.Click += new System.EventHandler(this.btnSelectRuta_Click);
            // 
            // txtRutaDB
            // 
            this.txtRutaDB.Location = new System.Drawing.Point(122, 163);
            this.txtRutaDB.Name = "txtRutaDB";
            this.txtRutaDB.Size = new System.Drawing.Size(279, 20);
            this.txtRutaDB.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ruta de guardado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Datos de conexion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Respaldar base de datos Principal";
            // 
            // TabConfigMonitor
            // 
            this.TabConfigMonitor.Location = new System.Drawing.Point(4, 22);
            this.TabConfigMonitor.Name = "TabConfigMonitor";
            this.TabConfigMonitor.Size = new System.Drawing.Size(928, 328);
            this.TabConfigMonitor.TabIndex = 3;
            this.TabConfigMonitor.Text = "Monitor";
            this.TabConfigMonitor.UseVisualStyleBackColor = true;
            // 
            // SaveDBDialog
            // 
            this.SaveDBDialog.FileName = "Backup.SQL";
            // 
            // Form_DB_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 384);
            this.Controls.Add(this.tabConfiguracion);
            this.Name = "Form_DB_Manager";
            this.Text = "Database Manager";
            this.Load += new System.EventHandler(this.Form_DB_Manager_Load);
            this.tabConfiguracion.ResumeLayout(false);
            this.TabConfig.ResumeLayout(false);
            this.TabConfig.PerformLayout();
            this.TabTools.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfiguracion;
        private System.Windows.Forms.TabPage TabConfig;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Button btnCancelarConfig;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnTestCon;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage TabTools;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listRestaurarData;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRestaurarDB;
        private System.Windows.Forms.Button btnOptimizarDB;
        private System.Windows.Forms.Button btnRepararDB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ListBox listDBData;
        private System.Windows.Forms.Button btnGuardarRespaldoBD;
        private System.Windows.Forms.Button btnCancelarRespaldoDB;
        private System.Windows.Forms.Button btnSelectRuta;
        private System.Windows.Forms.TextBox txtRutaDB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TabConfigMonitor;
        private System.Windows.Forms.SaveFileDialog SaveDBDialog;
    }
}