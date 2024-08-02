
namespace YoutubeDownload
{
    partial class Form1
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
            this.URL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.Resolution = new System.Windows.Forms.Label();
            this.Select_Path = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(99, 216);
            this.URL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(48, 22);
            this.URL.TabIndex = 0;
            this.URL.Text = "URL :";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(216, 216);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(332, 27);
            this.txtURL.TabIndex = 1;
            // 
            // Resolution
            // 
            this.Resolution.AutoSize = true;
            this.Resolution.Location = new System.Drawing.Point(99, 287);
            this.Resolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(94, 22);
            this.Resolution.TabIndex = 2;
            this.Resolution.Text = "Resolution :";
            // 
            // Select_Path
            // 
            this.Select_Path.AutoSize = true;
            this.Select_Path.Location = new System.Drawing.Point(99, 485);
            this.Select_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Select_Path.Name = "Select_Path";
            this.Select_Path.Size = new System.Drawing.Size(96, 22);
            this.Select_Path.TabIndex = 3;
            this.Select_Path.Text = "Select Path :";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(216, 480);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(253, 27);
            this.txtPath.TabIndex = 5;
            // 
            // cboResolution
            // 
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.cboResolution.Location = new System.Drawing.Point(216, 287);
            this.cboResolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(185, 30);
            this.cboResolution.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(216, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(625, 32);
            this.progressBar1.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(853, 402);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(34, 22);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "0 %";
            this.lblProgress.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(708, 480);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(121, 47);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 590);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cboResolution);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.Select_Path);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.URL);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج لتحميل فيديوهات اليوتيوب";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label Resolution;
        private System.Windows.Forms.Label Select_Path;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnDownload;
    }
}

