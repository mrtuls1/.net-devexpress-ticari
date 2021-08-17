namespace TicariOtomasyonDevexpress
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.mskIban = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btbSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(78, 332);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 33);
            this.btnTemizle.TabIndex = 34;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(21, 305);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 13);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "Firma Adı: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(38, 201);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Yetkili: ";
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Location = new System.Drawing.Point(78, 172);
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(146, 20);
            this.mskHesapNo.TabIndex = 25;
            // 
            // mskIban
            // 
            this.mskIban.Location = new System.Drawing.Point(78, 146);
            this.mskIban.Name = "mskIban";
            this.mskIban.Size = new System.Drawing.Size(146, 20);
            this.mskIban.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFirma);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.txtHesapTuru);
            this.groupBox1.Controls.Add(this.mskTel);
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.Controls.Add(this.txtYetkili);
            this.groupBox1.Controls.Add(this.cmbIlce);
            this.groupBox1.Controls.Add(this.cmbIl);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.mskHesapNo);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.mskIban);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btbSil);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtSube);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtBankaAdi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(1244, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 643);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbFirma
            // 
            this.cmbFirma.Location = new System.Drawing.Point(78, 302);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFirma.Properties.Appearance.Options.UseFont = true;
            this.cmbFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFirma.Size = new System.Drawing.Size(146, 20);
            this.cmbFirma.TabIndex = 48;
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(78, 250);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(146, 20);
            this.mskTarih.TabIndex = 46;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(78, 276);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Size = new System.Drawing.Size(146, 20);
            this.txtHesapTuru.TabIndex = 45;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(78, 224);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(146, 20);
            this.mskTel.TabIndex = 44;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(29, 227);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(43, 13);
            this.labelControl12.TabIndex = 43;
            this.labelControl12.Text = "Telefon: ";
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(78, 198);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(146, 20);
            this.txtYetkili.TabIndex = 42;
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(78, 94);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(146, 20);
            this.cmbIlce.TabIndex = 39;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(78, 68);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(146, 20);
            this.cmbIl.TabIndex = 38;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(48, 97);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "İlçe: ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(59, 71);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(13, 13);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "İl: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Hesap No: ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(78, 449);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(146, 33);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btbSil
            // 
            this.btbSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btbSil.Appearance.Options.UseFont = true;
            this.btbSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btbSil.ImageOptions.Image")));
            this.btbSil.Location = new System.Drawing.Point(78, 410);
            this.btbSil.Name = "btbSil";
            this.btbSil.Size = new System.Drawing.Size(146, 33);
            this.btbSil.TabIndex = 21;
            this.btbSil.Text = "Sil";
            this.btbSil.Click += new System.EventHandler(this.btbSil_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(41, 149);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "IBAN: ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(78, 371);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 33);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 279);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Hesap Türü: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(41, 253);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Tarih: ";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(78, 120);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(146, 20);
            this.txtSube.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Şube: ";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(78, 42);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(146, 20);
            this.txtBankaAdi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Banka Ad: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(78, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 20);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID: ";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(7, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1231, 643);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.MaskedTextBox mskIban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private DevExpress.XtraEditors.TextEdit txtHesapTuru;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btbSil;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbFirma;
    }
}