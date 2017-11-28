namespace WindowsFormsApplication1
{
    partial class AcuuracyAndAnomalyForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblOriginSample = new System.Windows.Forms.Label();
            this.lblModSample = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpenClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(94, 18);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path";
            // 
            // lblOriginSample
            // 
            this.lblOriginSample.AutoSize = true;
            this.lblOriginSample.Location = new System.Drawing.Point(10, 39);
            this.lblOriginSample.Name = "lblOriginSample";
            this.lblOriginSample.Size = new System.Drawing.Size(72, 13);
            this.lblOriginSample.TabIndex = 2;
            this.lblOriginSample.Text = "Origin Samlpe";
            // 
            // lblModSample
            // 
            this.lblModSample.AutoSize = true;
            this.lblModSample.Location = new System.Drawing.Point(10, 63);
            this.lblModSample.Name = "lblModSample";
            this.lblModSample.Size = new System.Drawing.Size(69, 13);
            this.lblModSample.TabIndex = 3;
            this.lblModSample.Text = "Mod. Sample";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(13, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Mod.  Sample";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // AcuuracyAndAnomalyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 419);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblModSample);
            this.Controls.Add(this.lblOriginSample);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnOpen);
            this.Name = "AcuuracyAndAnomalyForm";
            this.Text = "AcuuracyAndAnomalyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblOriginSample;
        private System.Windows.Forms.Label lblModSample;
        private System.Windows.Forms.Button btnSave;
    }
}