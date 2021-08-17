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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void FaturaBilgileriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURABILGI",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            txtID.Text = "";
            txtSeriNo.Text = "";
            txtSiraNo.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtVergiDaire.Text = ""; 
            txtAlici.Text = "";
            txtTeslimEden.Text = "";
            txtTeslimAlan.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            FaturaBilgileriListele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(txtFiyat.Text);
            miktar = Convert.ToDouble(txtAdet.Text);
            tutar = miktar * fiyat;
            txtTutar.Text = tutar.ToString();
            SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@P1,@P2,@P3,@P4,@P5)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@P1", txtUrun.Text);
            komut2.Parameters.AddWithValue("@P2", txtAdet.Text);
            komut2.Parameters.AddWithValue("@P3", txtFiyat.Text);
            komut2.Parameters.AddWithValue("@P4", txtTutar.Text);
            komut2.Parameters.AddWithValue("@P5", txtFaturaID.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            FaturaBilgileriListele();
            Temizle();
            MessageBox.Show("Fatura Detay Ekleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtID.Text = dr["FATURABILGIID"].ToString();
                txtSeriNo.Text = dr["SERI"].ToString();
                txtSiraNo.Text = dr["SIRANO"].ToString();
                mskTarih.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txtVergiDaire.Text = dr["VERGIDAIRE"].ToString();
                txtAlici.Text = dr["ALICI"].ToString();
                txtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                txtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnBilgiKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtSeriNo.Text);
            komut.Parameters.AddWithValue("@P2", txtSiraNo.Text);
            komut.Parameters.AddWithValue("@P3", mskTarih.Text);
            komut.Parameters.AddWithValue("@P4", mskSaat.Text);
            komut.Parameters.AddWithValue("@P5", txtVergiDaire.Text);
            komut.Parameters.AddWithValue("@P6", txtAlici.Text);
            komut.Parameters.AddWithValue("@P7", txtTeslimEden.Text);
            komut.Parameters.AddWithValue("@P8", txtTeslimAlan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle();
            FaturaBilgileriListele();
            MessageBox.Show("Fatura Nilgileri Kaydetme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btbSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtFaturaID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            FaturaBilgileriListele();
            Temizle();
            MessageBox.Show("Fatura Detay Silme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
