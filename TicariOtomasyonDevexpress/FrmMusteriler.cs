using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TicariOtomasyonDevexpress
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
            Temizle();
        }
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergiDairesi.Text = "";
            rchAdres.Text = "";
            txtAd.Focus();
        }
        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE From TBL_ILCELER Where SEHIR=@P1",bgl.baglanti());
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
            txtAd.Text = dr["ADI"].ToString();
            txtSoyad.Text = dr["SOYADI"].ToString();
            mskTel1.Text = dr["TELEFON"].ToString();
            mskTel2.Text = dr["TELEFON2"].ToString();
            mskTC.Text = dr["TC"].ToString();
            txtMail.Text = dr["MAIL"].ToString();
            cmbIl.Text = dr["IL"].ToString();
            cmbIlce.Text = dr["ILCE"].ToString();
            txtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
            rchAdres.Text = dr["ADRES"].ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (ADI,SOYADI,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRE,ADRES) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtAd.Text);
            komut.Parameters.AddWithValue("@P2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3",mskTel1.Text);
            komut.Parameters.AddWithValue("@P4",mskTel2.Text);
            komut.Parameters.AddWithValue("@P5",mskTC.Text);
            komut.Parameters.AddWithValue("@P6",txtMail.Text);
            komut.Parameters.AddWithValue("@P7",cmbIl.Text);
            komut.Parameters.AddWithValue("@P8",cmbIlce.Text);
            komut.Parameters.AddWithValue("@P9",rchAdres.Text);
            komut.Parameters.AddWithValue("@P10",txtVergiDairesi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Müşteri Ekleme Başarılı");

        }

        private void btbSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            Listele();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set ADI=@P1,SOYADI=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,VERGIDAIRE=@P9,ADRES=@P10 where ID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskTel1.Text);
            komut.Parameters.AddWithValue("@P4", mskTel2.Text);
            komut.Parameters.AddWithValue("@P5", mskTC.Text);
            komut.Parameters.AddWithValue("@P6", txtMail.Text);
            komut.Parameters.AddWithValue("@P7", cmbIl.Text);
            komut.Parameters.AddWithValue("@P8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P10", rchAdres.Text);
            komut.Parameters.AddWithValue("@P9", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
