namespace Ticari_Otamasyon2
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MailAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txt_Konu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.richbox_Mesaj = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Gönder = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MailAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Konu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi :";
            // 
            // txt_MailAdresi
            // 
            this.txt_MailAdresi.Location = new System.Drawing.Point(128, 156);
            this.txt_MailAdresi.Name = "txt_MailAdresi";
            this.txt_MailAdresi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MailAdresi.Properties.Appearance.Options.UseFont = true;
            this.txt_MailAdresi.Size = new System.Drawing.Size(238, 26);
            this.txt_MailAdresi.TabIndex = 1;
            // 
            // txt_Konu
            // 
            this.txt_Konu.Location = new System.Drawing.Point(128, 188);
            this.txt_Konu.Name = "txt_Konu";
            this.txt_Konu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Konu.Properties.Appearance.Options.UseFont = true;
            this.txt_Konu.Size = new System.Drawing.Size(238, 26);
            this.txt_Konu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu :";
            // 
            // richbox_Mesaj
            // 
            this.richbox_Mesaj.Location = new System.Drawing.Point(128, 220);
            this.richbox_Mesaj.Name = "richbox_Mesaj";
            this.richbox_Mesaj.Size = new System.Drawing.Size(238, 159);
            this.richbox_Mesaj.TabIndex = 4;
            this.richbox_Mesaj.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 134);
            this.panel1.TabIndex = 6;
            // 
            // btn_Gönder
            // 
            this.btn_Gönder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gönder.Appearance.Options.UseFont = true;
            this.btn_Gönder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Gönder.ImageOptions.Image")));
            this.btn_Gönder.Location = new System.Drawing.Point(158, 385);
            this.btn_Gönder.Name = "btn_Gönder";
            this.btn_Gönder.Size = new System.Drawing.Size(187, 35);
            this.btn_Gönder.TabIndex = 7;
            this.btn_Gönder.Text = "Gönder";
            this.btn_Gönder.Click += new System.EventHandler(this.btn_Gönder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(87, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail Gönderme Paneli";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 438);
            this.Controls.Add(this.btn_Gönder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richbox_Mesaj);
            this.Controls.Add(this.txt_Konu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MailAdresi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MailAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Konu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_MailAdresi;
        private DevExpress.XtraEditors.TextEdit txt_Konu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richbox_Mesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Gönder;
    }
}