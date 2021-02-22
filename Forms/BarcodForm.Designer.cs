
namespace SomeApps.Forms
{
    partial class BarcodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodForm));
            this.txtQR = new System.Windows.Forms.TextBox();
            this.txtBarcod = new System.Windows.Forms.TextBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnBarcod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQR
            // 
            this.txtQR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQR.Location = new System.Drawing.Point(117, 41);
            this.txtQR.Multiline = true;
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(259, 20);
            this.txtQR.TabIndex = 2;
            // 
            // txtBarcod
            // 
            this.txtBarcod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBarcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcod.Location = new System.Drawing.Point(117, 12);
            this.txtBarcod.Multiline = true;
            this.txtBarcod.Name = "txtBarcod";
            this.txtBarcod.Size = new System.Drawing.Size(259, 20);
            this.txtBarcod.TabIndex = 1;
            // 
            // btnQR
            // 
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQR.Location = new System.Drawing.Point(382, 39);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(113, 23);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "QR Kod Oluştur";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnBarcod
            // 
            this.btnBarcod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarcod.Location = new System.Drawing.Point(382, 10);
            this.btnBarcod.Name = "btnBarcod";
            this.btnBarcod.Size = new System.Drawing.Size(113, 23);
            this.btnBarcod.TabIndex = 3;
            this.btnBarcod.Text = "Barkod Oluştur";
            this.btnBarcod.UseVisualStyleBackColor = true;
            this.btnBarcod.Click += new System.EventHandler(this.btnBarcod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(117, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 179);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Text Of Barcod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text Of QR Code";
            // 
            // BarcodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(526, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.txtBarcod);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnBarcod);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BarcodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Barcod & QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.TextBox txtBarcod;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnBarcod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}