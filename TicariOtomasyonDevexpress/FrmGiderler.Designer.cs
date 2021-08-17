namespace TicariOtomasyonDevexpress
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInternet = new DevExpress.XtraEditors.TextEdit();
            this.txtMaas = new DevExpress.XtraEditors.TextEdit();
            this.txtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.txtSu = new DevExpress.XtraEditors.TextEdit();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btbSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDogalGaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogalGaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(10, 9);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1226, 643);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(64, 221);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(150, 20);
            this.txtEkstra.TabIndex = 32;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(21, 224);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(37, 13);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Ekstra: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInternet);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.txtElektrik);
            this.groupBox1.Controls.Add(this.txtSu);
            this.groupBox1.Controls.Add(this.cmbYil);
            this.groupBox1.Controls.Add(this.cmbAy);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.txtEkstra);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btbSil);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.rchNotlar);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.txtDogalGaz);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(1242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 640);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(64, 169);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(150, 20);
            this.txtInternet.TabIndex = 41;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(64, 195);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(150, 20);
            this.txtMaas.TabIndex = 40;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(64, 92);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(150, 20);
            this.txtElektrik.TabIndex = 39;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(64, 117);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(150, 20);
            this.txtSu.TabIndex = 38;
            // 
            // cmbYil
            // 
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cmbYil.Location = new System.Drawing.Point(64, 65);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(150, 21);
            this.cmbYil.TabIndex = 37;
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Location = new System.Drawing.Point(64, 39);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(150, 21);
            this.cmbAy.TabIndex = 36;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 198);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(44, 13);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "Maaşlar: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(39, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(19, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Su: ";
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
            this.labelControl9.Location = new System.Drawing.Point(17, 94);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Elektrik: ";
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
            // rchNotlar
            // 
            this.rchNotlar.Location = new System.Drawing.Point(64, 247);
            this.rchNotlar.Name = "rchNotlar";
            this.rchNotlar.Size = new System.Drawing.Size(150, 96);
            this.rchNotlar.TabIndex = 15;
            this.rchNotlar.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 247);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Notlar: ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 172);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İternet: ";
            // 
            // txtDogalGaz
            // 
            this.txtDogalGaz.Location = new System.Drawing.Point(64, 143);
            this.txtDogalGaz.Name = "txtDogalGaz";
            this.txtDogalGaz.Size = new System.Drawing.Size(150, 20);
            this.txtDogalGaz.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 146);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Doğalgaz: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Yıl: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ay: ";
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
            this.labelControl1.Location = new System.Drawing.Point(40, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID: ";
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGiderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogalGaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.TextEdit txtEkstra;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btbSil;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox rchNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtDogalGaz;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtElektrik;
        private DevExpress.XtraEditors.TextEdit txtSu;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.ComboBox cmbAy;
        private DevExpress.XtraEditors.TextEdit txtInternet;
        private DevExpress.XtraEditors.TextEdit txtMaas;
    }
}