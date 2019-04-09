namespace AyPS
{
    partial class FrmMainMenu
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
            this.BtnChecker = new System.Windows.Forms.Button();
            this.BtnCodeGenerator = new System.Windows.Forms.Button();
            this.CboClass = new System.Windows.Forms.ComboBox();
            this.TxtElapsed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnChecker
            // 
            this.BtnChecker.Location = new System.Drawing.Point(12, 12);
            this.BtnChecker.Name = "BtnChecker";
            this.BtnChecker.Size = new System.Drawing.Size(141, 79);
            this.BtnChecker.TabIndex = 0;
            this.BtnChecker.Text = "Pasar Lista";
            this.BtnChecker.UseVisualStyleBackColor = true;
            this.BtnChecker.Click += new System.EventHandler(this.BtnChecker_Click);
            // 
            // BtnCodeGenerator
            // 
            this.BtnCodeGenerator.Location = new System.Drawing.Point(12, 113);
            this.BtnCodeGenerator.Name = "BtnCodeGenerator";
            this.BtnCodeGenerator.Size = new System.Drawing.Size(141, 79);
            this.BtnCodeGenerator.TabIndex = 1;
            this.BtnCodeGenerator.Text = "Crear Codigos";
            this.BtnCodeGenerator.UseVisualStyleBackColor = true;
            this.BtnCodeGenerator.Click += new System.EventHandler(this.BtnCodeGenerator_Click);
            // 
            // CboClass
            // 
            this.CboClass.FormattingEnabled = true;
            this.CboClass.Location = new System.Drawing.Point(265, 23);
            this.CboClass.Name = "CboClass";
            this.CboClass.Size = new System.Drawing.Size(160, 24);
            this.CboClass.TabIndex = 2;
            // 
            // TxtElapsed
            // 
            this.TxtElapsed.Location = new System.Drawing.Point(265, 69);
            this.TxtElapsed.Name = "TxtElapsed";
            this.TxtElapsed.Size = new System.Drawing.Size(100, 22);
            this.TxtElapsed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duracion";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtElapsed);
            this.Controls.Add(this.CboClass);
            this.Controls.Add(this.BtnCodeGenerator);
            this.Controls.Add(this.BtnChecker);
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChecker;
        private System.Windows.Forms.Button BtnCodeGenerator;
        private System.Windows.Forms.ComboBox CboClass;
        private System.Windows.Forms.TextBox TxtElapsed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}