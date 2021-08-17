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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            mskYil.Text = "";
            nudAdet.Text = "";
            txtAlis.Text = "";
            txtSatis.Text = "";
            rchDetay.Text = "";
            txtAd.Focus();
        }
    private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT into TBL_URUNLER (URUNAD,URUNMARKA,MODEL,YIL,ADET,ALISFIYAT,SATIS,DETAY) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtMarka.Text);
            komut.Parameters.AddWithValue("@P4", mskYil.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse(nudAdet.Text).ToString());
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtAlis.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtSatis.Text));
            komut.Parameters.AddWithValue("@P8", rchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Ürün Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Urunler where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            Listele();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["URUNMARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYil.Text = dr["YIL"].ToString();
            nudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            txtAlis.Text = dr["ALISFIYAT"].ToString();
            txtSatis.Text = dr["SATIS"].ToString();
            rchDetay.Text = dr["DETAY"].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@P1,URUNMARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATIS=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtMarka.Text);
            komut.Parameters.AddWithValue("@P3", txtModel.Text);
            komut.Parameters.AddWithValue("@P4", mskYil.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse(nudAdet.Text).ToString());
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtAlis.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtSatis.Text));
            komut.Parameters.AddWithValue("@P8", rchDetay.Text);
            komut.Parameters.AddWithValue("@P9", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
