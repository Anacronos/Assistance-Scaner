namespace AyPS
{
    partial class FrmUsersCodesGenerator
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.PBCode = new System.Windows.Forms.PictureBox();
            this.TxtRegistrationCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGroup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBCode)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(446, 17);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(420, 22);
            this.TxtName.TabIndex = 0;
            // 
            // PBCode
            // 
            this.PBCode.Location = new System.Drawing.Point(10, 16);
            this.PBCode.Margin = new System.Windows.Forms.Padding(2);
            this.PBCode.Name = "PBCode";
            this.PBCode.Size = new System.Drawing.Size(348, 337);
            this.PBCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBCode.TabIndex = 1;
            this.PBCode.TabStop = false;
            // 
            // TxtRegistrationCode
            // 
            this.TxtRegistrationCode.Location = new System.Drawing.Point(446, 52);
            this.TxtRegistrationCode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRegistrationCode.Name = "TxtRegistrationCode";
            this.TxtRegistrationCode.Size = new System.Drawing.Size(87, 22);
            this.TxtRegistrationCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matricula:";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(400, 316);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(170, 36);
            this.BtnGenerate.TabIndex = 7;
            this.BtnGenerate.Text = "Generar Codigo";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(585, 316);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(170, 36);
            this.BtnExport.TabIndex = 8;
            this.BtnExport.Text = "Exportar Codigo";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(763, 316);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(92, 36);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Limpiar";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grado\r\n y grupo:";
            // 
            // TxtGroup
            // 
            this.TxtGroup.Location = new System.Drawing.Point(446, 98);
            this.TxtGroup.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGroup.Name = "TxtGroup";
            this.TxtGroup.Size = new System.Drawing.Size(87, 22);
            this.TxtGroup.TabIndex = 10;
            // 
            // FrmUsersCodesGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGroup);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRegistrationCode);
            this.Controls.Add(this.PBCode);
            this.Controls.Add(this.TxtName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsersCodesGenerator";
            this.Text = "Generador de Codigos";
            this.Load += new System.EventHandler(this.FrmUsersCodesGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.PictureBox PBCode;
        private System.Windows.Forms.TextBox TxtRegistrationCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGroup;
    }
}

