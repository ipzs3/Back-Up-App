namespace WSH_Back_Up
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxNetwork = new System.Windows.Forms.TextBox();
            this.textBoxCloud = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.lableNetwork = new System.Windows.Forms.Label();
            this.labelCloud = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSrcBrowse = new System.Windows.Forms.Button();
            this.buttonNetworkBrowse = new System.Windows.Forms.Button();
            this.buttonCloudBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(67, 305);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(100, 25);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(58, 82);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(190, 20);
            this.textBoxSource.TabIndex = 2;
            this.textBoxSource.Text = "C:\\Users\\Admin\\Desktop\\Source";
            // 
            // textBoxNetwork
            // 
            this.textBoxNetwork.Location = new System.Drawing.Point(58, 139);
            this.textBoxNetwork.Name = "textBoxNetwork";
            this.textBoxNetwork.Size = new System.Drawing.Size(190, 20);
            this.textBoxNetwork.TabIndex = 3;
            this.textBoxNetwork.Text = "C:\\Users\\Admin\\Desktop\\Network";
            // 
            // textBoxCloud
            // 
            this.textBoxCloud.Location = new System.Drawing.Point(58, 198);
            this.textBoxCloud.Name = "textBoxCloud";
            this.textBoxCloud.Size = new System.Drawing.Size(190, 20);
            this.textBoxCloud.TabIndex = 4;
            this.textBoxCloud.Text = "C:\\Users\\Admin\\Desktop\\Cloud";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(55, 66);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 5;
            this.labelSource.Text = "Source";
            // 
            // lableNetwork
            // 
            this.lableNetwork.AutoSize = true;
            this.lableNetwork.Location = new System.Drawing.Point(55, 123);
            this.lableNetwork.Name = "lableNetwork";
            this.lableNetwork.Size = new System.Drawing.Size(103, 13);
            this.lableNetwork.TabIndex = 6;
            this.lableNetwork.Text = "Network Destination";
            // 
            // labelCloud
            // 
            this.labelCloud.AutoSize = true;
            this.labelCloud.Location = new System.Drawing.Point(55, 182);
            this.labelCloud.Name = "labelCloud";
            this.labelCloud.Size = new System.Drawing.Size(90, 13);
            this.labelCloud.TabIndex = 7;
            this.labelCloud.Text = "Cloud Destination";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(132, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 24);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Back Up App";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSrcBrowse
            // 
            this.buttonSrcBrowse.Location = new System.Drawing.Point(255, 80);
            this.buttonSrcBrowse.Name = "buttonSrcBrowse";
            this.buttonSrcBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcBrowse.TabIndex = 9;
            this.buttonSrcBrowse.Text = "Browse";
            this.buttonSrcBrowse.UseVisualStyleBackColor = true;
            this.buttonSrcBrowse.Click += new System.EventHandler(this.buttonSrcBrowse_Click);
            // 
            // buttonNetworkBrowse
            // 
            this.buttonNetworkBrowse.Location = new System.Drawing.Point(255, 137);
            this.buttonNetworkBrowse.Name = "buttonNetworkBrowse";
            this.buttonNetworkBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonNetworkBrowse.TabIndex = 10;
            this.buttonNetworkBrowse.Text = "Browse";
            this.buttonNetworkBrowse.UseVisualStyleBackColor = true;
            this.buttonNetworkBrowse.Click += new System.EventHandler(this.buttonNetworkBrowse_Click_1);
            // 
            // buttonCloudBrowse
            // 
            this.buttonCloudBrowse.Location = new System.Drawing.Point(255, 196);
            this.buttonCloudBrowse.Name = "buttonCloudBrowse";
            this.buttonCloudBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonCloudBrowse.TabIndex = 11;
            this.buttonCloudBrowse.Text = "Browse";
            this.buttonCloudBrowse.UseVisualStyleBackColor = true;
            this.buttonCloudBrowse.Click += new System.EventHandler(this.buttonCloudBrowse_Click_1);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(55, 241);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(48, 13);
            this.labelProgress.TabIndex = 12;
            this.labelProgress.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(58, 257);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonCloudBrowse);
            this.Controls.Add(this.buttonNetworkBrowse);
            this.Controls.Add(this.buttonSrcBrowse);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCloud);
            this.Controls.Add(this.lableNetwork);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.textBoxCloud);
            this.Controls.Add(this.textBoxNetwork);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Back Up App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxNetwork;
        private System.Windows.Forms.TextBox textBoxCloud;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label lableNetwork;
        private System.Windows.Forms.Label labelCloud;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSrcBrowse;
        private System.Windows.Forms.Button buttonNetworkBrowse;
        private System.Windows.Forms.Button buttonCloudBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

