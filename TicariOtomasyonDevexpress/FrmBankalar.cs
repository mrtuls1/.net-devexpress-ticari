using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyonDevexpress
{
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand("Execute BankaBilgileri", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.baglanti().Close();

        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR",bgl.baglanti());
            da.Fill(dt);
            cmbFirma.Properties.NullText = "Lütfen Firma Seçiniz";
            cmbFirma.Properties.ValueMember = "ID";
            cmbFirma.Properties.DisplayMember = "AD";
            cmbFirma.Properties.DataSource = dt;
        }

        void Temizle()
        {
            txtID.Text = "";
            txtBankaAdi.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtSube.Text = "";
            mskIban.Text = "";
            mskHesapNo.Text = "";
            txtYetkili.Text = "";
            mskTel.Text = "";
            mskTarih.Text = "";
            txtHesapTuru.Text = "";
            cmbFirma.Text = "";
            mskTarih.Text = "";

        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
            firmaListesi();
            Temizle();
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@P2",cmbIl.Text);
            komut.Parameters.AddWithValue("@P3",cmbIlce.Text);
            komut.Parameters.AddWithValue("@P4",txtSube.Text);
            komut.Parameters.AddWithValue("@P5",mskIban.Text);
            komut.Parameters.AddWithValue("@P6",mskHesapNo.Text);
            komut.Parameters.AddWithValue("@P7",txtYetkili.Text);
            komut.Parameters.AddWithValue("@P8",mskTel.Text);
            komut.Parameters.AddWithValue("@P9",mskTarih.Text);
            komut.Parameters.AddWithValue("@P10",txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11",cmbFirma.EditValue);
            if(cmbFirma.EditValue!= null)
            {
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Listele();
                Temizle();
                MessageBox.Show("Banka Ekleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Firma Seçiniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }
        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE From TBL_ILCELER Where SEHIR=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", cmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr= gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtBankaAdi.Text = dr["BANKAADI"].ToString();
            cmbIl.Text = dr["IL"].ToString();
            cmbIlce.Text = dr["ILCE"].ToString();
            txtSube.Text = dr["SUBE"].ToString();
            mskIban.Text = dr["IBAN"].ToString();
            mskHesapNo.Text = dr["HESAPNO"].ToString();
            txtYetkili.Text = dr["YETKILI"].ToString();
            mskTel.Text = dr["TELEFON"].ToString();
            mskTarih.Text = dr["TARIH"].ToString();
            txtHesapTuru.Text = dr["HESAPTURU"].ToString();
           // cmbFirma.Text = dr["FIRMAID"].ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btbSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_BANKALAR where ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            Temizle();
            MessageBox.Show("Banka Silme İşlemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_BANKALAR set BANKAADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 where ID=@P12", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@P2",cmbIl.Text);
            komut.Parameters.AddWithValue("@P3",cmbIlce.Text);
            komut.Parameters.AddWithValue("@P4",txtSube.Text);
            komut.Parameters.AddWithValue("@P5",mskIban.Text);
            komut.Parameters.AddWithValue("@P6",mskHesapNo.Text);
            komut.Parameters.AddWithValue("@P7",txtYetkili.Text);
            komut.Parameters.AddWithValue("@P8",mskTel.Text);
            komut.Parameters.AddWithValue("@P9",mskTarih.Text);
            komut.Parameters.AddWithValue("@P10",txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11",cmbFirma.EditValue);
            komut.Parameters.AddWithValue("@P12",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            Temizle();
            MessageBox.Show("Banka Güncelleme İşlemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
