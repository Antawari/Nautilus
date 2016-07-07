namespace Nautilus
{
    partial class Form_PLC
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
            this.tabPLC = new System.Windows.Forms.TabControl();
            this.tab_New_PLC = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPLC
            // 
            this.tabPLC.Controls.Add(this.tab_New_PLC);
            this.tabPLC.Controls.Add(this.tabPage2);
            this.tabPLC.Location = new System.Drawing.Point(13, 13);
            this.tabPLC.Name = "tabPLC";
            this.tabPLC.SelectedIndex = 0;
            this.tabPLC.Size = new System.Drawing.Size(1038, 592);
            this.tabPLC.TabIndex = 0;
            // 
            // tab_New_PLC
            // 
            this.tab_New_PLC.Location = new System.Drawing.Point(4, 22);
            this.tab_New_PLC.Name = "tab_New_PLC";
            this.tab_New_PLC.Padding = new System.Windows.Forms.Padding(3);
            this.tab_New_PLC.Size = new System.Drawing.Size(1030, 566);
            this.tab_New_PLC.TabIndex = 0;
            this.tab_New_PLC.Text = "tabPage1";
            this.tab_New_PLC.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form_PLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 617);
            this.Controls.Add(this.tabPLC);
            this.Name = "Form_PLC";
            this.Text = "PLC Manager";
            this.tabPLC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPLC;
        private System.Windows.Forms.TabPage tab_New_PLC;
        private System.Windows.Forms.TabPage tabPage2;
    }
}