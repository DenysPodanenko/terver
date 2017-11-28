namespace WindowsFormsApplication1
{
    partial class ProbabilityValuesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblTitleMean = new System.Windows.Forms.Label();
            this.lblTitleExces = new System.Windows.Forms.Label();
            this.lblTitleVariance = new System.Windows.Forms.Label();
            this.lblTitleAsymetry = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblVariance = new System.Windows.Forms.Label();
            this.lblAsymetry = new System.Windows.Forms.Label();
            this.lblExces = new System.Windows.Forms.Label();
            this.lblTitleStandartDeviation = new System.Windows.Forms.Label();
            this.lblStandartDeviation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOpenClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(94, 18);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(40, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "txtPath";
            // 
            // lblTitleMean
            // 
            this.lblTitleMean.AutoSize = true;
            this.lblTitleMean.Location = new System.Drawing.Point(12, 39);
            this.lblTitleMean.MinimumSize = new System.Drawing.Size(40, 0);
            this.lblTitleMean.Name = "lblTitleMean";
            this.lblTitleMean.Size = new System.Drawing.Size(40, 13);
            this.lblTitleMean.TabIndex = 2;
            this.lblTitleMean.Text = "Mean";
            // 
            // lblTitleExces
            // 
            this.lblTitleExces.AutoSize = true;
            this.lblTitleExces.Location = new System.Drawing.Point(12, 91);
            this.lblTitleExces.Name = "lblTitleExces";
            this.lblTitleExces.Size = new System.Drawing.Size(36, 13);
            this.lblTitleExces.TabIndex = 3;
            this.lblTitleExces.Text = "Exces";
            // 
            // lblTitleVariance
            // 
            this.lblTitleVariance.AutoSize = true;
            this.lblTitleVariance.Location = new System.Drawing.Point(12, 52);
            this.lblTitleVariance.Name = "lblTitleVariance";
            this.lblTitleVariance.Size = new System.Drawing.Size(49, 13);
            this.lblTitleVariance.TabIndex = 4;
            this.lblTitleVariance.Text = "Variance";
            // 
            // lblTitleAsymetry
            // 
            this.lblTitleAsymetry.AutoSize = true;
            this.lblTitleAsymetry.Location = new System.Drawing.Point(13, 78);
            this.lblTitleAsymetry.Name = "lblTitleAsymetry";
            this.lblTitleAsymetry.Size = new System.Drawing.Size(49, 13);
            this.lblTitleAsymetry.TabIndex = 5;
            this.lblTitleAsymetry.Text = "Asymetry";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(114, 39);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(35, 13);
            this.lblMean.TabIndex = 6;
            this.lblMean.Text = "label1";
            // 
            // lblVariance
            // 
            this.lblVariance.AutoSize = true;
            this.lblVariance.Location = new System.Drawing.Point(114, 52);
            this.lblVariance.Name = "lblVariance";
            this.lblVariance.Size = new System.Drawing.Size(35, 13);
            this.lblVariance.TabIndex = 7;
            this.lblVariance.Text = "label2";
            // 
            // lblAsymetry
            // 
            this.lblAsymetry.AutoSize = true;
            this.lblAsymetry.Location = new System.Drawing.Point(114, 78);
            this.lblAsymetry.Name = "lblAsymetry";
            this.lblAsymetry.Size = new System.Drawing.Size(35, 13);
            this.lblAsymetry.TabIndex = 8;
            this.lblAsymetry.Text = "label3";
            // 
            // lblExces
            // 
            this.lblExces.AutoSize = true;
            this.lblExces.Location = new System.Drawing.Point(114, 91);
            this.lblExces.Name = "lblExces";
            this.lblExces.Size = new System.Drawing.Size(35, 13);
            this.lblExces.TabIndex = 9;
            this.lblExces.Text = "label4";
            // 
            // lblTitleStandartDeviation
            // 
            this.lblTitleStandartDeviation.AutoSize = true;
            this.lblTitleStandartDeviation.Location = new System.Drawing.Point(13, 65);
            this.lblTitleStandartDeviation.Name = "lblTitleStandartDeviation";
            this.lblTitleStandartDeviation.Size = new System.Drawing.Size(95, 13);
            this.lblTitleStandartDeviation.TabIndex = 10;
            this.lblTitleStandartDeviation.Text = "Standart Deviation";
            // 
            // lblStandartDeviation
            // 
            this.lblStandartDeviation.AutoSize = true;
            this.lblStandartDeviation.Location = new System.Drawing.Point(114, 65);
            this.lblStandartDeviation.Name = "lblStandartDeviation";
            this.lblStandartDeviation.Size = new System.Drawing.Size(35, 13);
            this.lblStandartDeviation.TabIndex = 11;
            this.lblStandartDeviation.Text = "label2";
            // 
            // ProbabilityValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 416);
            this.Controls.Add(this.lblStandartDeviation);
            this.Controls.Add(this.lblTitleStandartDeviation);
            this.Controls.Add(this.lblExces);
            this.Controls.Add(this.lblAsymetry);
            this.Controls.Add(this.lblVariance);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.lblTitleAsymetry);
            this.Controls.Add(this.lblTitleVariance);
            this.Controls.Add(this.lblTitleExces);
            this.Controls.Add(this.lblTitleMean);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.button1);
            this.Name = "ProbabilityValuesForm";
            this.Text = "ProbabilityValues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblTitleMean;
        private System.Windows.Forms.Label lblTitleExces;
        private System.Windows.Forms.Label lblTitleVariance;
        private System.Windows.Forms.Label lblTitleAsymetry;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblVariance;
        private System.Windows.Forms.Label lblAsymetry;
        private System.Windows.Forms.Label lblExces;
        private System.Windows.Forms.Label lblTitleStandartDeviation;
        private System.Windows.Forms.Label lblStandartDeviation;
    }
}