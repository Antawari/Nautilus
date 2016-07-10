namespace Nautilus
{
    partial class frmUserManagement
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
            this.tabUserManagement = new System.Windows.Forms.TabControl();
            this.tabNuevoUsuario = new System.Windows.Forms.TabPage();
            this.gpNU = new System.Windows.Forms.GroupBox();
            this.rbNUInactivo = new System.Windows.Forms.RadioButton();
            this.rbNUActivo = new System.Windows.Forms.RadioButton();
            this.lblMailCheck = new System.Windows.Forms.Label();
            this.btnNUCancelar = new System.Windows.Forms.Button();
            this.btnNUGuardar = new System.Windows.Forms.Button();
            this.cmbNURol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNUMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNUTelefono2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNUTelefono1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNUDireccion2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNUDireccion1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNUApellidoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNUPassword = new System.Windows.Forms.TextBox();
            this.txtNUApellidoP = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNUUsuario = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNUNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModificarUsuario = new System.Windows.Forms.TabPage();
            this.gpMU = new System.Windows.Forms.GroupBox();
            this.rbMUInactivo = new System.Windows.Forms.RadioButton();
            this.rbMUActivo = new System.Windows.Forms.RadioButton();
            this.btnMUUsuario = new System.Windows.Forms.Button();
            this.txtMUPassword = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMUUsuario = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lstMUSeleccionU = new System.Windows.Forms.DataGridView();
            this.cmbMURol = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnMUBuscar = new System.Windows.Forms.Button();
            this.txtMUBuscar = new System.Windows.Forms.TextBox();
            this.btnMUCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMUMail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMUTel2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMUTel1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMUDireccion2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMUDireccion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMUApellidoM = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMUApellidoP = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMUNombre = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabEliminarUsuario = new System.Windows.Forms.TabPage();
            this.lblEUSelected = new System.Windows.Forms.Label();
            this.lstEUlista = new System.Windows.Forms.DataGridView();
            this.btnEUCancelar = new System.Windows.Forms.Button();
            this.btnEUEliminar = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.btnEUBuscar = new System.Windows.Forms.Button();
            this.txtEUBuscarU = new System.Windows.Forms.TextBox();
            this.tabUserManagement.SuspendLayout();
            this.tabNuevoUsuario.SuspendLayout();
            this.gpNU.SuspendLayout();
            this.tabModificarUsuario.SuspendLayout();
            this.gpMU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMUSeleccionU)).BeginInit();
            this.tabEliminarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEUlista)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Controls.Add(this.tabNuevoUsuario);
            this.tabUserManagement.Controls.Add(this.tabModificarUsuario);
            this.tabUserManagement.Controls.Add(this.tabEliminarUsuario);
            this.tabUserManagement.Location = new System.Drawing.Point(12, 12);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.SelectedIndex = 0;
            this.tabUserManagement.Size = new System.Drawing.Size(478, 614);
            this.tabUserManagement.TabIndex = 2;
            // 
            // tabNuevoUsuario
            // 
            this.tabNuevoUsuario.Controls.Add(this.gpNU);
            this.tabNuevoUsuario.Controls.Add(this.label1);
            this.tabNuevoUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabNuevoUsuario.Name = "tabNuevoUsuario";
            this.tabNuevoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevoUsuario.Size = new System.Drawing.Size(470, 588);
            this.tabNuevoUsuario.TabIndex = 0;
            this.tabNuevoUsuario.Text = "Nuevo Usuario";
            this.tabNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // gpNU
            // 
            this.gpNU.Controls.Add(this.rbNUInactivo);
            this.gpNU.Controls.Add(this.rbNUActivo);
            this.gpNU.Controls.Add(this.lblMailCheck);
            this.gpNU.Controls.Add(this.btnNUCancelar);
            this.gpNU.Controls.Add(this.btnNUGuardar);
            this.gpNU.Controls.Add(this.cmbNURol);
            this.gpNU.Controls.Add(this.label7);
            this.gpNU.Controls.Add(this.label8);
            this.gpNU.Controls.Add(this.txtNUMail);
            this.gpNU.Controls.Add(this.label9);
            this.gpNU.Controls.Add(this.txtNUTelefono2);
            this.gpNU.Controls.Add(this.label10);
            this.gpNU.Controls.Add(this.txtNUTelefono1);
            this.gpNU.Controls.Add(this.label11);
            this.gpNU.Controls.Add(this.txtNUDireccion2);
            this.gpNU.Controls.Add(this.label6);
            this.gpNU.Controls.Add(this.txtNUDireccion1);
            this.gpNU.Controls.Add(this.label5);
            this.gpNU.Controls.Add(this.txtNUApellidoM);
            this.gpNU.Controls.Add(this.label4);
            this.gpNU.Controls.Add(this.txtNUPassword);
            this.gpNU.Controls.Add(this.txtNUApellidoP);
            this.gpNU.Controls.Add(this.label27);
            this.gpNU.Controls.Add(this.label3);
            this.gpNU.Controls.Add(this.txtNUUsuario);
            this.gpNU.Controls.Add(this.label26);
            this.gpNU.Controls.Add(this.txtNUNombre);
            this.gpNU.Controls.Add(this.label2);
            this.gpNU.Enabled = false;
            this.gpNU.Location = new System.Drawing.Point(9, 31);
            this.gpNU.Name = "gpNU";
            this.gpNU.Size = new System.Drawing.Size(447, 487);
            this.gpNU.TabIndex = 20;
            this.gpNU.TabStop = false;
            // 
            // rbNUInactivo
            // 
            this.rbNUInactivo.AutoSize = true;
            this.rbNUInactivo.Location = new System.Drawing.Point(158, 311);
            this.rbNUInactivo.Name = "rbNUInactivo";
            this.rbNUInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbNUInactivo.TabIndex = 45;
            this.rbNUInactivo.TabStop = true;
            this.rbNUInactivo.Text = "Inactivo";
            this.rbNUInactivo.UseVisualStyleBackColor = true;
            // 
            // rbNUActivo
            // 
            this.rbNUActivo.AutoSize = true;
            this.rbNUActivo.Location = new System.Drawing.Point(97, 311);
            this.rbNUActivo.Name = "rbNUActivo";
            this.rbNUActivo.Size = new System.Drawing.Size(55, 17);
            this.rbNUActivo.TabIndex = 44;
            this.rbNUActivo.TabStop = true;
            this.rbNUActivo.Text = "Activo";
            this.rbNUActivo.UseVisualStyleBackColor = true;
            // 
            // lblMailCheck
            // 
            this.lblMailCheck.AutoSize = true;
            this.lblMailCheck.Location = new System.Drawing.Point(315, 282);
            this.lblMailCheck.Name = "lblMailCheck";
            this.lblMailCheck.Size = new System.Drawing.Size(0, 13);
            this.lblMailCheck.TabIndex = 43;
            // 
            // btnNUCancelar
            // 
            this.btnNUCancelar.Location = new System.Drawing.Point(290, 379);
            this.btnNUCancelar.Name = "btnNUCancelar";
            this.btnNUCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnNUCancelar.TabIndex = 15;
            this.btnNUCancelar.Text = "Cancelar";
            this.btnNUCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNUGuardar
            // 
            this.btnNUGuardar.Location = new System.Drawing.Point(371, 379);
            this.btnNUGuardar.Name = "btnNUGuardar";
            this.btnNUGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnNUGuardar.TabIndex = 16;
            this.btnNUGuardar.Text = "Guardar";
            this.btnNUGuardar.UseVisualStyleBackColor = true;
            this.btnNUGuardar.Click += new System.EventHandler(this.btnNUGuardar_Click_1);
            // 
            // cmbNURol
            // 
            this.cmbNURol.FormattingEnabled = true;
            this.cmbNURol.Items.AddRange(new object[] {
            "1 - Usuario",
            "2 - Editor",
            "3 - Administrador",
            "4 - Root"});
            this.cmbNURol.Location = new System.Drawing.Point(96, 342);
            this.cmbNURol.Name = "cmbNURol";
            this.cmbNURol.Size = new System.Drawing.Size(350, 21);
            this.cmbNURol.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Rol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Status";
            // 
            // txtNUMail
            // 
            this.txtNUMail.Location = new System.Drawing.Point(97, 279);
            this.txtNUMail.Name = "txtNUMail";
            this.txtNUMail.Size = new System.Drawing.Size(350, 20);
            this.txtNUMail.TabIndex = 11;
            this.txtNUMail.TextChanged += new System.EventHandler(this.txtNUMail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Correo electronico";
            // 
            // txtNUTelefono2
            // 
            this.txtNUTelefono2.Location = new System.Drawing.Point(96, 250);
            this.txtNUTelefono2.Name = "txtNUTelefono2";
            this.txtNUTelefono2.Size = new System.Drawing.Size(350, 20);
            this.txtNUTelefono2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Telefono 2";
            // 
            // txtNUTelefono1
            // 
            this.txtNUTelefono1.Location = new System.Drawing.Point(96, 220);
            this.txtNUTelefono1.Name = "txtNUTelefono1";
            this.txtNUTelefono1.Size = new System.Drawing.Size(350, 20);
            this.txtNUTelefono1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Telefono 1";
            // 
            // txtNUDireccion2
            // 
            this.txtNUDireccion2.Location = new System.Drawing.Point(96, 190);
            this.txtNUDireccion2.Name = "txtNUDireccion2";
            this.txtNUDireccion2.Size = new System.Drawing.Size(350, 20);
            this.txtNUDireccion2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Direccion 2";
            // 
            // txtNUDireccion1
            // 
            this.txtNUDireccion1.Location = new System.Drawing.Point(96, 159);
            this.txtNUDireccion1.Name = "txtNUDireccion1";
            this.txtNUDireccion1.Size = new System.Drawing.Size(350, 20);
            this.txtNUDireccion1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Direccion";
            // 
            // txtNUApellidoM
            // 
            this.txtNUApellidoM.Location = new System.Drawing.Point(96, 130);
            this.txtNUApellidoM.Name = "txtNUApellidoM";
            this.txtNUApellidoM.Size = new System.Drawing.Size(350, 20);
            this.txtNUApellidoM.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apellido Materno";
            // 
            // txtNUPassword
            // 
            this.txtNUPassword.Location = new System.Drawing.Point(96, 44);
            this.txtNUPassword.Name = "txtNUPassword";
            this.txtNUPassword.Size = new System.Drawing.Size(350, 20);
            this.txtNUPassword.TabIndex = 3;
            // 
            // txtNUApellidoP
            // 
            this.txtNUApellidoP.Location = new System.Drawing.Point(96, 101);
            this.txtNUApellidoP.Name = "txtNUApellidoP";
            this.txtNUApellidoP.Size = new System.Drawing.Size(350, 20);
            this.txtNUApellidoP.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 47);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 23;
            this.label27.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtNUUsuario
            // 
            this.txtNUUsuario.Location = new System.Drawing.Point(96, 14);
            this.txtNUUsuario.Name = "txtNUUsuario";
            this.txtNUUsuario.Size = new System.Drawing.Size(350, 20);
            this.txtNUUsuario.TabIndex = 2;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 20;
            this.label26.Text = "Usuario";
            // 
            // txtNUNombre
            // 
            this.txtNUNombre.Location = new System.Drawing.Point(96, 71);
            this.txtNUNombre.Name = "txtNUNombre";
            this.txtNUNombre.Size = new System.Drawing.Size(350, 20);
            this.txtNUNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dar de alta Usuarios para el Nautilus";
            // 
            // tabModificarUsuario
            // 
            this.tabModificarUsuario.Controls.Add(this.gpMU);
            this.tabModificarUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabModificarUsuario.Name = "tabModificarUsuario";
            this.tabModificarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarUsuario.Size = new System.Drawing.Size(470, 588);
            this.tabModificarUsuario.TabIndex = 1;
            this.tabModificarUsuario.Text = "ModificarUsuario";
            this.tabModificarUsuario.UseVisualStyleBackColor = true;
            this.tabModificarUsuario.Click += new System.EventHandler(this.tabModificarUsuario_Enter);
            this.tabModificarUsuario.Enter += new System.EventHandler(this.tabModificarUsuario_Enter);
            // 
            // gpMU
            // 
            this.gpMU.Controls.Add(this.rbMUInactivo);
            this.gpMU.Controls.Add(this.rbMUActivo);
            this.gpMU.Controls.Add(this.btnMUUsuario);
            this.gpMU.Controls.Add(this.txtMUPassword);
            this.gpMU.Controls.Add(this.label28);
            this.gpMU.Controls.Add(this.txtMUUsuario);
            this.gpMU.Controls.Add(this.label29);
            this.gpMU.Controls.Add(this.lstMUSeleccionU);
            this.gpMU.Controls.Add(this.cmbMURol);
            this.gpMU.Controls.Add(this.label23);
            this.gpMU.Controls.Add(this.btnMUBuscar);
            this.gpMU.Controls.Add(this.txtMUBuscar);
            this.gpMU.Controls.Add(this.btnMUCancelar);
            this.gpMU.Controls.Add(this.label12);
            this.gpMU.Controls.Add(this.label13);
            this.gpMU.Controls.Add(this.txtMUMail);
            this.gpMU.Controls.Add(this.label14);
            this.gpMU.Controls.Add(this.txtMUTel2);
            this.gpMU.Controls.Add(this.label15);
            this.gpMU.Controls.Add(this.txtMUTel1);
            this.gpMU.Controls.Add(this.label16);
            this.gpMU.Controls.Add(this.txtMUDireccion2);
            this.gpMU.Controls.Add(this.label17);
            this.gpMU.Controls.Add(this.txtMUDireccion);
            this.gpMU.Controls.Add(this.label18);
            this.gpMU.Controls.Add(this.txtMUApellidoM);
            this.gpMU.Controls.Add(this.label19);
            this.gpMU.Controls.Add(this.txtMUApellidoP);
            this.gpMU.Controls.Add(this.label20);
            this.gpMU.Controls.Add(this.txtMUNombre);
            this.gpMU.Controls.Add(this.label21);
            this.gpMU.Controls.Add(this.label22);
            this.gpMU.Location = new System.Drawing.Point(7, 7);
            this.gpMU.Name = "gpMU";
            this.gpMU.Size = new System.Drawing.Size(457, 575);
            this.gpMU.TabIndex = 0;
            this.gpMU.TabStop = false;
            // 
            // rbMUInactivo
            // 
            this.rbMUInactivo.AutoSize = true;
            this.rbMUInactivo.Location = new System.Drawing.Point(155, 471);
            this.rbMUInactivo.Name = "rbMUInactivo";
            this.rbMUInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbMUInactivo.TabIndex = 89;
            this.rbMUInactivo.TabStop = true;
            this.rbMUInactivo.Text = "Inactivo";
            this.rbMUInactivo.UseVisualStyleBackColor = true;
            // 
            // rbMUActivo
            // 
            this.rbMUActivo.AutoSize = true;
            this.rbMUActivo.Location = new System.Drawing.Point(94, 471);
            this.rbMUActivo.Name = "rbMUActivo";
            this.rbMUActivo.Size = new System.Drawing.Size(55, 17);
            this.rbMUActivo.TabIndex = 88;
            this.rbMUActivo.TabStop = true;
            this.rbMUActivo.Text = "Activo";
            this.rbMUActivo.UseVisualStyleBackColor = true;
            // 
            // btnMUUsuario
            // 
            this.btnMUUsuario.Location = new System.Drawing.Point(369, 545);
            this.btnMUUsuario.Name = "btnMUUsuario";
            this.btnMUUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnMUUsuario.TabIndex = 87;
            this.btnMUUsuario.Text = "Guardar";
            this.btnMUUsuario.UseVisualStyleBackColor = true;
            this.btnMUUsuario.Click += new System.EventHandler(this.btnMUUsuario_Click);
            // 
            // txtMUPassword
            // 
            this.txtMUPassword.Location = new System.Drawing.Point(94, 205);
            this.txtMUPassword.Name = "txtMUPassword";
            this.txtMUPassword.Size = new System.Drawing.Size(350, 20);
            this.txtMUPassword.TabIndex = 21;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(4, 208);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 13);
            this.label28.TabIndex = 86;
            this.label28.Text = "Contraseña";
            // 
            // txtMUUsuario
            // 
            this.txtMUUsuario.Location = new System.Drawing.Point(94, 175);
            this.txtMUUsuario.Name = "txtMUUsuario";
            this.txtMUUsuario.Size = new System.Drawing.Size(350, 20);
            this.txtMUUsuario.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 178);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 85;
            this.label29.Text = "Usuario";
            // 
            // lstMUSeleccionU
            // 
            this.lstMUSeleccionU.AllowUserToAddRows = false;
            this.lstMUSeleccionU.AllowUserToDeleteRows = false;
            this.lstMUSeleccionU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMUSeleccionU.Location = new System.Drawing.Point(7, 59);
            this.lstMUSeleccionU.Name = "lstMUSeleccionU";
            this.lstMUSeleccionU.ReadOnly = true;
            this.lstMUSeleccionU.Size = new System.Drawing.Size(436, 110);
            this.lstMUSeleccionU.TabIndex = 19;
            this.lstMUSeleccionU.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lstMUSeleccionU_CellMouseClick);
            // 
            // cmbMURol
            // 
            this.cmbMURol.FormattingEnabled = true;
            this.cmbMURol.Items.AddRange(new object[] {
            "1 - Usuario",
            "2 - Editor",
            "3 - Administrador",
            "4 - Root"});
            this.cmbMURol.Location = new System.Drawing.Point(94, 508);
            this.cmbMURol.Name = "cmbMURol";
            this.cmbMURol.Size = new System.Drawing.Size(349, 21);
            this.cmbMURol.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(151, 13);
            this.label23.TabIndex = 81;
            this.label23.Text = "Seleccione usuario a modificar";
            // 
            // btnMUBuscar
            // 
            this.btnMUBuscar.Location = new System.Drawing.Point(396, 14);
            this.btnMUBuscar.Name = "btnMUBuscar";
            this.btnMUBuscar.Size = new System.Drawing.Size(48, 23);
            this.btnMUBuscar.TabIndex = 18;
            this.btnMUBuscar.Text = "Buscar";
            this.btnMUBuscar.UseVisualStyleBackColor = true;
            // 
            // txtMUBuscar
            // 
            this.txtMUBuscar.Location = new System.Drawing.Point(105, 14);
            this.txtMUBuscar.Name = "txtMUBuscar";
            this.txtMUBuscar.Size = new System.Drawing.Size(284, 20);
            this.txtMUBuscar.TabIndex = 17;
            // 
            // btnMUCancelar
            // 
            this.btnMUCancelar.Location = new System.Drawing.Point(287, 545);
            this.btnMUCancelar.Name = "btnMUCancelar";
            this.btnMUCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMUCancelar.TabIndex = 33;
            this.btnMUCancelar.Text = "Cancelar";
            this.btnMUCancelar.UseVisualStyleBackColor = true;
            this.btnMUCancelar.Click += new System.EventHandler(this.btnNUCancelar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Rol";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "Status";
            // 
            // txtMUMail
            // 
            this.txtMUMail.Location = new System.Drawing.Point(94, 439);
            this.txtMUMail.Name = "txtMUMail";
            this.txtMUMail.Size = new System.Drawing.Size(350, 20);
            this.txtMUMail.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 442);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Correo electronico";
            // 
            // txtMUTel2
            // 
            this.txtMUTel2.Location = new System.Drawing.Point(94, 410);
            this.txtMUTel2.Name = "txtMUTel2";
            this.txtMUTel2.Size = new System.Drawing.Size(350, 20);
            this.txtMUTel2.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Telefono 2";
            // 
            // txtMUTel1
            // 
            this.txtMUTel1.Location = new System.Drawing.Point(94, 380);
            this.txtMUTel1.Name = "txtMUTel1";
            this.txtMUTel1.Size = new System.Drawing.Size(350, 20);
            this.txtMUTel1.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 383);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "Telefono 1";
            // 
            // txtMUDireccion2
            // 
            this.txtMUDireccion2.Location = new System.Drawing.Point(94, 350);
            this.txtMUDireccion2.Name = "txtMUDireccion2";
            this.txtMUDireccion2.Size = new System.Drawing.Size(350, 20);
            this.txtMUDireccion2.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 353);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 74;
            this.label17.Text = "Direccion 2";
            // 
            // txtMUDireccion
            // 
            this.txtMUDireccion.Location = new System.Drawing.Point(94, 319);
            this.txtMUDireccion.Name = "txtMUDireccion";
            this.txtMUDireccion.Size = new System.Drawing.Size(350, 20);
            this.txtMUDireccion.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 322);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Direccion";
            // 
            // txtMUApellidoM
            // 
            this.txtMUApellidoM.Location = new System.Drawing.Point(94, 290);
            this.txtMUApellidoM.Name = "txtMUApellidoM";
            this.txtMUApellidoM.Size = new System.Drawing.Size(350, 20);
            this.txtMUApellidoM.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Apellido Materno";
            // 
            // txtMUApellidoP
            // 
            this.txtMUApellidoP.Location = new System.Drawing.Point(94, 261);
            this.txtMUApellidoP.Name = "txtMUApellidoP";
            this.txtMUApellidoP.Size = new System.Drawing.Size(350, 20);
            this.txtMUApellidoP.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 71;
            this.label20.Text = "Apellido Paterno";
            // 
            // txtMUNombre
            // 
            this.txtMUNombre.Location = new System.Drawing.Point(94, 231);
            this.txtMUNombre.Name = "txtMUNombre";
            this.txtMUNombre.Size = new System.Drawing.Size(350, 20);
            this.txtMUNombre.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 234);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 67;
            this.label21.Text = "Nombre";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 65;
            this.label22.Text = "Modificar Usuarios";
            // 
            // tabEliminarUsuario
            // 
            this.tabEliminarUsuario.Controls.Add(this.lblEUSelected);
            this.tabEliminarUsuario.Controls.Add(this.lstEUlista);
            this.tabEliminarUsuario.Controls.Add(this.btnEUCancelar);
            this.tabEliminarUsuario.Controls.Add(this.btnEUEliminar);
            this.tabEliminarUsuario.Controls.Add(this.label24);
            this.tabEliminarUsuario.Controls.Add(this.btnEUBuscar);
            this.tabEliminarUsuario.Controls.Add(this.txtEUBuscarU);
            this.tabEliminarUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabEliminarUsuario.Name = "tabEliminarUsuario";
            this.tabEliminarUsuario.Size = new System.Drawing.Size(470, 588);
            this.tabEliminarUsuario.TabIndex = 2;
            this.tabEliminarUsuario.Text = "Eliminar Usuario";
            this.tabEliminarUsuario.UseVisualStyleBackColor = true;
            this.tabEliminarUsuario.Enter += new System.EventHandler(this.tabEliminarUsuario_Enter);
            // 
            // lblEUSelected
            // 
            this.lblEUSelected.AutoSize = true;
            this.lblEUSelected.Location = new System.Drawing.Point(10, 509);
            this.lblEUSelected.Name = "lblEUSelected";
            this.lblEUSelected.Size = new System.Drawing.Size(0, 13);
            this.lblEUSelected.TabIndex = 60;
            // 
            // lstEUlista
            // 
            this.lstEUlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstEUlista.Location = new System.Drawing.Point(13, 65);
            this.lstEUlista.Name = "lstEUlista";
            this.lstEUlista.Size = new System.Drawing.Size(454, 414);
            this.lstEUlista.TabIndex = 59;
            this.lstEUlista.Click += new System.EventHandler(this.lstEUlista_Click);
            // 
            // btnEUCancelar
            // 
            this.btnEUCancelar.Location = new System.Drawing.Point(311, 558);
            this.btnEUCancelar.Name = "btnEUCancelar";
            this.btnEUCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnEUCancelar.TabIndex = 38;
            this.btnEUCancelar.Text = "Cancelar";
            this.btnEUCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEUEliminar
            // 
            this.btnEUEliminar.Location = new System.Drawing.Point(392, 558);
            this.btnEUEliminar.Name = "btnEUEliminar";
            this.btnEUEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEUEliminar.TabIndex = 39;
            this.btnEUEliminar.Text = "Eliminar";
            this.btnEUEliminar.UseVisualStyleBackColor = true;
            this.btnEUEliminar.Click += new System.EventHandler(this.btnEUEliminar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Seleccione usuario a eliminar";
            // 
            // btnEUBuscar
            // 
            this.btnEUBuscar.Location = new System.Drawing.Point(419, 8);
            this.btnEUBuscar.Name = "btnEUBuscar";
            this.btnEUBuscar.Size = new System.Drawing.Size(48, 23);
            this.btnEUBuscar.TabIndex = 36;
            this.btnEUBuscar.Text = "Buscar";
            this.btnEUBuscar.UseVisualStyleBackColor = true;
            // 
            // txtEUBuscarU
            // 
            this.txtEUBuscarU.Location = new System.Drawing.Point(13, 10);
            this.txtEUBuscarU.Name = "txtEUBuscarU";
            this.txtEUBuscarU.Size = new System.Drawing.Size(382, 20);
            this.txtEUBuscarU.TabIndex = 35;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 636);
            this.Controls.Add(this.tabUserManagement);
            this.Name = "frmUserManagement";
            this.Text = "Manejo de usuarios";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.tabUserManagement.ResumeLayout(false);
            this.tabNuevoUsuario.ResumeLayout(false);
            this.tabNuevoUsuario.PerformLayout();
            this.gpNU.ResumeLayout(false);
            this.gpNU.PerformLayout();
            this.tabModificarUsuario.ResumeLayout(false);
            this.gpMU.ResumeLayout(false);
            this.gpMU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMUSeleccionU)).EndInit();
            this.tabEliminarUsuario.ResumeLayout(false);
            this.tabEliminarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstEUlista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUserManagement;
        private System.Windows.Forms.TabPage tabNuevoUsuario;
        private System.Windows.Forms.GroupBox gpNU;
        private System.Windows.Forms.Label lblMailCheck;
        private System.Windows.Forms.Button btnNUCancelar;
        private System.Windows.Forms.Button btnNUGuardar;
        private System.Windows.Forms.ComboBox cmbNURol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNUMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNUTelefono2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNUTelefono1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNUDireccion2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNUDireccion1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNUApellidoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNUPassword;
        private System.Windows.Forms.TextBox txtNUApellidoP;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNUUsuario;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtNUNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabModificarUsuario;
        private System.Windows.Forms.GroupBox gpMU;
        private System.Windows.Forms.TextBox txtMUPassword;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMUUsuario;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView lstMUSeleccionU;
        private System.Windows.Forms.ComboBox cmbMURol;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnMUBuscar;
        private System.Windows.Forms.TextBox txtMUBuscar;
        private System.Windows.Forms.Button btnMUCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMUMail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMUTel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMUTel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMUDireccion2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMUDireccion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMUApellidoM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMUApellidoP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMUNombre;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabEliminarUsuario;
        private System.Windows.Forms.Label lblEUSelected;
        private System.Windows.Forms.DataGridView lstEUlista;
        private System.Windows.Forms.Button btnEUCancelar;
        private System.Windows.Forms.Button btnEUEliminar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnEUBuscar;
        private System.Windows.Forms.TextBox txtEUBuscarU;
        private System.Windows.Forms.Button btnMUUsuario;
        private System.Windows.Forms.RadioButton rbNUInactivo;
        private System.Windows.Forms.RadioButton rbNUActivo;
        private System.Windows.Forms.RadioButton rbMUInactivo;
        private System.Windows.Forms.RadioButton rbMUActivo;
    }
}