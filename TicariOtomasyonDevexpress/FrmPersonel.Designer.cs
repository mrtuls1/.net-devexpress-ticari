namespace TicariOtomasyonDevexpress
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.mskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtGorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btbSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(64, 195);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(150, 20);
            this.cmbIlce.TabIndex = 30;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(64, 169);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(150, 20);
            this.cmbIl.TabIndex = 29;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(30, 198);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 13);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "İlçe: ";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(64, 117);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(150, 20);
            this.mskTC.TabIndex = 27;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(34, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "TC: ";
            // 
            // mskTel1
            // 
            this.mskTel1.Location = new System.Drawing.Point(64, 91);
            this.mskTel1.Mask = "(999) 000-0000";
            this.mskTel1.Name = "mskTel1";
            this.mskTel1.Size = new System.Drawing.Size(150, 20);
            this.mskTel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.txtGorev);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.cmbIlce);
            this.groupBox1.Controls.Add(this.cmbIl);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.mskTC);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.mskTel1);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btbSil);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.rchAdres);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(1239, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 640);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(64, 349);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 33);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(64, 221);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(150, 20);
            this.txtGorev.TabIndex = 32;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(16, 224);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(38, 13);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Görevi: ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(64, 466);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 33);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btbSil
            // 
            this.btbSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btbSil.Appearance.Options.UseFont = true;
            this.btbSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btbSil.ImageOptions.Image")));
            this.btbSil.Location = new System.Drawing.Point(64, 427);
            this.btbSil.Name = "btbSil";
            this.btbSil.Size = new System.Drawing.Size(150, 33);
            this.btbSil.TabIndex = 21;
            this.btbSil.Text = "Sil";
            this.btbSil.Click += new System.EventHandler(this.btbSil_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(11, 94);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(43, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Telefon: ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(64, 388);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 33);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(64, 247);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(150, 96);
            this.rchAdres.TabIndex = 15;
            this.rchAdres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(19, 247);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Adres: ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(41, 172);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(13, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İl: ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(64, 143);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(150, 20);
            this.txtMail.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(29, 146);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Mail: ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(64, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Soyadı:  ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(64, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(64, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID: ";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
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
            this.gridControl1.Location = new System.Drawing.Point(7, 9);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1226, 643);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox mskTel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btbSil;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox rchAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtGorev;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}