namespace AyPS
{
    partial class FrmReader
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
            this.components = new System.ComponentModel.Container();
            this.PBFeed = new System.Windows.Forms.PictureBox();
            this.CboDevices = new System.Windows.Forms.ComboBox();
            this.BtnGetFeed = new System.Windows.Forms.Button();
            this.TxtCapturedInfo = new System.Windows.Forms.TextBox();
            this.CBAdquire = new System.Windows.Forms.CheckBox();
            this.DGVAlreadyHere = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlreadyHere)).BeginInit();
            this.SuspendLayout();
            // 
            // PBFeed
            // 
            this.PBFeed.Location = new System.Drawing.Point(6, 6);
            this.PBFeed.Margin = new System.Windows.Forms.Padding(2);
            this.PBFeed.Name = "PBFeed";
            this.PBFeed.Size = new System.Drawing.Size(520, 430);
            this.PBFeed.TabIndex = 0;
            this.PBFeed.TabStop = false;
            // 
            // CboDevices
            // 
            this.CboDevices.FormattingEnabled = true;
            this.CboDevices.Location = new System.Drawing.Point(569, 6);
            this.CboDevices.Margin = new System.Windows.Forms.Padding(2);
            this.CboDevices.Name = "CboDevices";
            this.CboDevices.Size = new System.Drawing.Size(244, 24);
            this.CboDevices.TabIndex = 1;
            // 
            // BtnGetFeed
            // 
            this.BtnGetFeed.Location = new System.Drawing.Point(569, 37);
            this.BtnGetFeed.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGetFeed.Name = "BtnGetFeed";
            this.BtnGetFeed.Size = new System.Drawing.Size(101, 32);
            this.BtnGetFeed.TabIndex = 2;
            this.BtnGetFeed.Text = "Iniciar";
            this.BtnGetFeed.UseVisualStyleBackColor = true;
            this.BtnGetFeed.Click += new System.EventHandler(this.BtnGetFeed_Click);
            // 
            // TxtCapturedInfo
            // 
            this.TxtCapturedInfo.Enabled = false;
            this.TxtCapturedInfo.Location = new System.Drawing.Point(569, 153);
            this.TxtCapturedInfo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCapturedInfo.Multiline = true;
            this.TxtCapturedInfo.Name = "TxtCapturedInfo";
            this.TxtCapturedInfo.Size = new System.Drawing.Size(331, 266);
            this.TxtCapturedInfo.TabIndex = 3;
            // 
            // CBAdquire
            // 
            this.CBAdquire.AutoSize = true;
            this.CBAdquire.Location = new System.Drawing.Point(569, 115);
            this.CBAdquire.Name = "CBAdquire";
            this.CBAdquire.Size = new System.Drawing.Size(79, 21);
            this.CBAdquire.TabIndex = 4;
            this.CBAdquire.Text = "Adquirir";
            this.CBAdquire.UseVisualStyleBackColor = true;
            // 
            // DGVAlreadyHere
            // 
            this.DGVAlreadyHere.AllowUserToAddRows = false;
            this.DGVAlreadyHere.AllowUserToDeleteRows = false;
            this.DGVAlreadyHere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlreadyHere.Location = new System.Drawing.Point(919, 6);
            this.DGVAlreadyHere.Name = "DGVAlreadyHere";
            this.DGVAlreadyHere.ReadOnly = true;
            this.DGVAlreadyHere.RowTemplate.Height = 24;
            this.DGVAlreadyHere.Size = new System.Drawing.Size(440, 430);
            this.DGVAlreadyHere.TabIndex = 5;
            // 
            // FrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 450);
            this.Controls.Add(this.DGVAlreadyHere);
            this.Controls.Add(this.CBAdquire);
            this.Controls.Add(this.TxtCapturedInfo);
            this.Controls.Add(this.BtnGetFeed);
            this.Controls.Add(this.CboDevices);
            this.Controls.Add(this.PBFeed);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReader";
            this.Text = "FrmReader";
            this.Load += new System.EventHandler(this.FrmReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlreadyHere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBFeed;
        private System.Windows.Forms.ComboBox CboDevices;
        private System.Windows.Forms.Button BtnGetFeed;
        private System.Windows.Forms.TextBox TxtCapturedInfo;
        private System.Windows.Forms.CheckBox CBAdquire;
        private System.Windows.Forms.DataGridView DGVAlreadyHere;
        private System.Windows.Forms.Timer Timer;
    }
}