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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTel1.Text = "";
            mskTC.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtGorev.Text = "";
            rchAdres.Text = "";
            txtAd.Focus();
        }
        void Listele()
        {
            SqlCommand komut = new SqlCommand("select * From TBL_PERSONELLER",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtAd.Text);
            komut.Parameters.AddWithValue("@P2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",mskTel1.Text);
            komut.Parameters.AddWithValue("@P4",mskTC.Text);
            komut.Parameters.AddWithValue("@P5",txtMail.Text);
            komut.Parameters.AddWithValue("@P6",cmbIl.Text);
            komut.Parameters.AddWithValue("@P7",cmbIlce.Text);
            komut.Parameters.AddWithValue("@P8",rchAdres.Text);
            komut.Parameters.AddWithValue("@P9",txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Personel Ekleme İşlemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",cmbIl.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["AD"].ToString();
            txtSoyad.Text = dr["SOYAD"].ToString();
            txtGorev.Text = dr["GOREV"].ToString();
            mskTel1.Text = dr["TELEFON"].ToString();
            mskTC.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            cmbIl.Text = dr["IL"].ToString();
            cmbIlce.Text = dr["ILCE"].ToString();
            rchAdres.Text = dr["ADRES"].ToString();
        }

        private void btbSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_PERSONELLER where ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Personel Silme İşlmemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtAd.Text);
            komut.Parameters.AddWithValue("@P2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",mskTel1.Text);
            komut.Parameters.AddWithValue("@P4",mskTC.Text);
            komut.Parameters.AddWithValue("@P5",txtMail.Text);
            komut.Parameters.AddWithValue("@P6",cmbIl.Text);
            komut.Parameters.AddWithValue("@P7",cmbIlce.Text);
            komut.Parameters.AddWithValue("@P8",rchAdres.Text);
            komut.Parameters.AddWithValue("@P9",txtGorev.Text);
            komut.Parameters.AddWithValue("@P10",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Personel Güncelleme İşlemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
    }
}
