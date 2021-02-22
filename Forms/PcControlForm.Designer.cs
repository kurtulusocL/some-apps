
namespace SomeApps.Forms
{
    partial class PcControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PcControlForm));
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtPcName = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnMac = new System.Windows.Forms.Button();
            this.btnPcName = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMac
            // 
            this.txtMac.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMac.Location = new System.Drawing.Point(12, 154);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(142, 21);
            this.txtMac.TabIndex = 6;
            // 
            // txtPcName
            // 
            this.txtPcName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPcName.Location = new System.Drawing.Point(12, 98);
            this.txtPcName.Name = "txtPcName";
            this.txtPcName.Size = new System.Drawing.Size(142, 21);
            this.txtPcName.TabIndex = 4;
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIp.Location = new System.Drawing.Point(12, 41);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(142, 21);
            this.txtIp.TabIndex = 2;
            // 
            // btnMac
            // 
            this.btnMac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMac.Location = new System.Drawing.Point(12, 125);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(112, 23);
            this.btnMac.TabIndex = 5;
            this.btnMac.Text = "Mac Adresi =>";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // btnPcName
            // 
            this.btnPcName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPcName.Location = new System.Drawing.Point(12, 69);
            this.btnPcName.Name = "btnPcName";
            this.btnPcName.Size = new System.Drawing.Size(112, 23);
            this.btnPcName.TabIndex = 3;
            this.btnPcName.Text = "Bilgisayar Adı =>";
            this.btnPcName.UseVisualStyleBackColor = true;
            this.btnPcName.Click += new System.EventHandler(this.btnPcName_Click);
            // 
            // btnIP
            // 
            this.btnIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIP.Location = new System.Drawing.Point(12, 12);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(112, 23);
            this.btnIP.TabIndex = 1;
            this.btnIP.Text = "Ip Adresi =>";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // PcControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(247, 190);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.txtPcName);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnMac);
            this.Controls.Add(this.btnPcName);
            this.Controls.Add(this.btnIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PcControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.TextBox txtPcName;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnMac;
        private System.Windows.Forms.Button btnPcName;
        private System.Windows.Forms.Button btnIP;
    }
}