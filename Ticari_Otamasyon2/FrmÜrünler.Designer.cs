namespace Ticari_Otamasyon2
{
    partial class FrmÜrünler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÜrünler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.mskTxt_Yıl = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ÜrünAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Markası = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Modeli = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_AlışFiyatı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SatışFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.richtxt_Detay = new System.Windows.Forms.RichTextBox();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.nud_Adet = new System.Windows.Forms.NumericUpDown();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Güncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ÜrünAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Markası.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Modeli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AlışFiyatı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SatışFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-6, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1078, 459);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(88, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(118, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(152, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // mskTxt_Yıl
            // 
            this.mskTxt_Yıl.Location = new System.Drawing.Point(118, 133);
            this.mskTxt_Yıl.Mask = "0000";
            this.mskTxt_Yıl.Name = "mskTxt_Yıl";
            this.mskTxt_Yıl.Size = new System.Drawing.Size(152, 21);
            this.mskTxt_Yıl.TabIndex = 2;
            this.mskTxt_Yıl.ValidatingType = typeof(int);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ÜRÜN ADI:";
            // 
            // txt_ÜrünAdı
            // 
            this.txt_ÜrünAdı.Location = new System.Drawing.Point(118, 55);
            this.txt_ÜrünAdı.Name = "txt_ÜrünAdı";
            this.txt_ÜrünAdı.Size = new System.Drawing.Size(152, 20);
            this.txt_ÜrünAdı.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(40, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MARKASI :";
            // 
            // txt_Markası
            // 
            this.txt_Markası.Location = new System.Drawing.Point(118, 81);
            this.txt_Markası.Name = "txt_Markası";
            this.txt_Markası.Size = new System.Drawing.Size(152, 20);
            this.txt_Markası.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(48, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "MODELİ :";
            // 
            // txt_Modeli
            // 
            this.txt_Modeli.Location = new System.Drawing.Point(118, 107);
            this.txt_Modeli.Name = "txt_Modeli";
            this.txt_Modeli.Size = new System.Drawing.Size(152, 20);
            this.txt_Modeli.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(79, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "YIL :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(65, 165);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "ADET :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(18, 200);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(94, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "ALIŞ FİYATI :";
            // 
            // txt_AlışFiyatı
            // 
            this.txt_AlışFiyatı.Location = new System.Drawing.Point(118, 195);
            this.txt_AlışFiyatı.Name = "txt_AlışFiyatı";
            this.txt_AlışFiyatı.Size = new System.Drawing.Size(152, 20);
            this.txt_AlışFiyatı.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(9, 224);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "SATIŞ FİYATI :";
            // 
            // txt_SatışFiyati
            // 
            this.txt_SatışFiyati.Location = new System.Drawing.Point(118, 221);
            this.txt_SatışFiyati.Name = "txt_SatışFiyati";
            this.txt_SatışFiyati.Size = new System.Drawing.Size(152, 20);
            this.txt_SatışFiyati.TabIndex = 15;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(57, 246);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "DETAY :";
            // 
            // richtxt_Detay
            // 
            this.richtxt_Detay.Location = new System.Drawing.Point(120, 247);
            this.richtxt_Detay.Name = "richtxt_Detay";
            this.richtxt_Detay.Size = new System.Drawing.Size(150, 121);
            this.richtxt_Detay.TabIndex = 17;
            this.richtxt_Detay.Text = "";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.ImageOptions.Image")));
            this.btn_Kaydet.Location = new System.Drawing.Point(120, 374);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(150, 23);
            this.btn_Kaydet.TabIndex = 18;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // nud_Adet
            // 
            this.nud_Adet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_Adet.Location = new System.Drawing.Point(120, 163);
            this.nud_Adet.Name = "nud_Adet";
            this.nud_Adet.Size = new System.Drawing.Size(150, 26);
            this.nud_Adet.TabIndex = 19;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Güncelle);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Controls.Add(this.nud_Adet);
            this.groupControl1.Controls.Add(this.btn_Kaydet);
            this.groupControl1.Controls.Add(this.richtxt_Detay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txt_SatışFiyati);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txt_AlışFiyatı);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_Modeli);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_Markası);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_ÜrünAdı);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.mskTxt_Yıl);
            this.groupControl1.Controls.Add(this.txt_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1078, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(297, 459);
            this.groupControl1.TabIndex = 1;
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Güncelle.ImageOptions.Image")));
            this.btn_Güncelle.Location = new System.Drawing.Point(120, 432);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Size = new System.Drawing.Size(150, 23);
            this.btn_Güncelle.TabIndex = 21;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.ImageOptions.Image")));
            this.btn_Sil.Location = new System.Drawing.Point(120, 403);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(150, 23);
            this.btn_Sil.TabIndex = 20;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // FrmÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 484);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmÜrünler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmÜrünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ÜrünAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Markası.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Modeli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AlışFiyatı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SatışFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private System.Windows.Forms.MaskedTextBox mskTxt_Yıl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ÜrünAdı;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Markası;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Modeli;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_AlışFiyatı;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_SatışFiyati;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox richtxt_Detay;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.NumericUpDown nud_Adet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Güncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
    }
}