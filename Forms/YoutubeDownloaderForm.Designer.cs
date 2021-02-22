
namespace SomeApps.Forms
{
    partial class YoutubeDownloaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeDownloaderForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.radioMP4 = new System.Windows.Forms.RadioButton();
            this.radioMP3 = new System.Windows.Forms.RadioButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(110, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 17);
            this.lblHeader.TabIndex = 28;
            this.lblHeader.Text = "Youtube MP3 / MP4 Download Program";
            // 
            // btnDownload
            // 
            this.btnDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.BackgroundImage")));
            this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDownload.Location = new System.Drawing.Point(309, 83);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(50, 42);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // radioMP4
            // 
            this.radioMP4.AutoSize = true;
            this.radioMP4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioMP4.Location = new System.Drawing.Point(229, 89);
            this.radioMP4.Name = "radioMP4";
            this.radioMP4.Size = new System.Drawing.Size(50, 19);
            this.radioMP4.TabIndex = 3;
            this.radioMP4.Text = "MP4";
            this.radioMP4.UseVisualStyleBackColor = true;
            this.radioMP4.CheckedChanged += new System.EventHandler(this.radioMP4_CheckedChanged);
            // 
            // radioMP3
            // 
            this.radioMP3.AutoSize = true;
            this.radioMP3.Checked = true;
            this.radioMP3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioMP3.Location = new System.Drawing.Point(173, 89);
            this.radioMP3.Name = "radioMP3";
            this.radioMP3.Size = new System.Drawing.Size(50, 19);
            this.radioMP3.TabIndex = 2;
            this.radioMP3.TabStop = true;
            this.radioMP3.Text = "MP3";
            this.radioMP3.UseVisualStyleBackColor = true;
            this.radioMP3.CheckedChanged += new System.EventHandler(this.radioMP3_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUrl.Location = new System.Drawing.Point(158, 57);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(251, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Format:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "VideoURL:";
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(93, 150);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(316, 18);
            this.lblState.TabIndex = 29;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YoutubeDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(525, 177);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.radioMP4);
            this.Controls.Add(this.radioMP3);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YoutubeDownloaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Video & MP3 Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RadioButton radioMP4;
        private System.Windows.Forms.RadioButton radioMP3;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
    }
}