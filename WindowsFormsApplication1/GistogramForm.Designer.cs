namespace WindowsFormsApplication1
{
    partial class GistogramForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.sampleGistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.sampleGistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOpenClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(102, 18);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(39, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "lblPath";
            // 
            // sampleGistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.sampleGistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sampleGistogram.Legends.Add(legend1);
            this.sampleGistogram.Location = new System.Drawing.Point(52, 51);
            this.sampleGistogram.Name = "sampleGistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "pocket";
            this.sampleGistogram.Series.Add(series1);
            this.sampleGistogram.Size = new System.Drawing.Size(722, 532);
            this.sampleGistogram.TabIndex = 2;
            this.sampleGistogram.Text = "chart1";
            // 
            // GistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 595);
            this.Controls.Add(this.sampleGistogram);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.button1);
            this.Name = "GistogramForm";
            this.Text = "GistogramForm";
            ((System.ComponentModel.ISupportInitialize)(this.sampleGistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.DataVisualization.Charting.Chart sampleGistogram;
    }
}