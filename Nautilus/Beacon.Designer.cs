﻿namespace Nautilus
{
    partial class frmBeacon
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
            this.dgBeacon = new System.Windows.Forms.DataGridView();
            this.myMap = new System.Windows.Forms.Integration.ElementHost();
            this.mapa = new Nautilus.Map();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeacon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBeacon
            // 
            this.dgBeacon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBeacon.Location = new System.Drawing.Point(12, 13);
            this.dgBeacon.Name = "dgBeacon";
            this.dgBeacon.Size = new System.Drawing.Size(192, 308);
            this.dgBeacon.TabIndex = 1;
            // 
            // myMap
            // 
            this.myMap.Location = new System.Drawing.Point(221, 13);
            this.myMap.Name = "myMap";
            this.myMap.Size = new System.Drawing.Size(626, 445);
            this.myMap.TabIndex = 5;
            this.myMap.Text = "elementHost1";
            this.myMap.Child = this.mapa;
            // 
            // frmBeacon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 467);
            this.Controls.Add(this.myMap);
            this.Controls.Add(this.dgBeacon);
            this.Name = "frmBeacon";
            this.Text = "Beacon";
            this.Load += new System.EventHandler(this.Beacon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBeacon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgBeacon;
        private System.Windows.Forms.Integration.ElementHost myMap;
        private Map mapa;
    }
}