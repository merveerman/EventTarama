
namespace EventTarama
{
    partial class MainForm
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
            this.btnSetAndScan = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.lstAlerts = new System.Windows.Forms.ListBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetAndScan
            // 
            this.btnSetAndScan.Location = new System.Drawing.Point(23, 23);
            this.btnSetAndScan.Name = "btnSetAndScan";
            this.btnSetAndScan.Size = new System.Drawing.Size(349, 38);
            this.btnSetAndScan.TabIndex = 0;
            this.btnSetAndScan.Text = "Yükleme ve Taramayı Başlat";
            this.btnSetAndScan.UseVisualStyleBackColor = true;
            this.btnSetAndScan.Click += new System.EventHandler(this.btnSetAndScan_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(23, 194);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(349, 37);
            this.prgBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayaç : ";
            // 
            // tmrProgress
            // 
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // lstAlerts
            // 
            this.lstAlerts.FormattingEnabled = true;
            this.lstAlerts.Items.AddRange(new object[] {
            " "});
            this.lstAlerts.Location = new System.Drawing.Point(478, 23);
            this.lstAlerts.Name = "lstAlerts";
            this.lstAlerts.Size = new System.Drawing.Size(341, 264);
            this.lstAlerts.TabIndex = 3;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(155, 108);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(10, 13);
            this.lblCounter.TabIndex = 4;
            this.lblCounter.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Progress : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lstAlerts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.btnSetAndScan);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetAndScan;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.ListBox lstAlerts;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label label3;
    }
}

