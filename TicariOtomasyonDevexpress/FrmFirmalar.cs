using DevExpress.Utils.Behaviors;
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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtYetkiliGorev.Text = "";
            txtYetkili.Text = "";
            mskYetkiliTc.Text = "";
            txtSektor.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTel3.Text = "";
            txtMail.Text = "";
            mskFax.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergiDairesi.Text = "";
            rchAdres.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtAd.Focus();
        }
        void sehirListele()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        void cariKodAciklamalari()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 From TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rchKod1.Text = dr[0].ToString();
            }
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListele();
            cariKodAciklamalari();
            Temizle();
          
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                txtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                mskYetkiliTc.Text = dr["YETKILITC"].ToString();
                txtSektor.Text = dr["SEKTOR"].ToString();
                mskTel1.Text = dr["TELEFON1"].ToString();
                mskTel2.Text = dr["TELEFON2"].ToString();
                mskTel3.Text = dr["TELEFON3"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                mskFax.Text = dr["FAX"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                txtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                rchAdres.Text = dr["ADRES"].ToString();
                txtKod1.Text = dr["OZELKOD1"].ToString();
                txtKod2.Text = dr["OZELKOD2"].ToString();
                txtKod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@P3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@P4", mskYetkiliTc.Text);
            komut.Parameters.AddWithValue("@P5", txtSektor.Text);
            komut.Parameters.AddWithValue("@P6", mskTel1.Text);
            komut.Parameters.AddWithValue("@P7", mskTel2.Text);
            komut.Parameters.AddWithValue("@P8", mskTel3.Text);
            komut.Parameters.AddWithValue("@P9", txtMail.Text);
            komut.Parameters.AddWithValue("@P10", mskFax.Text);
            komut.Parameters.AddWithValue("@P11", cmbIl.Text);
            komut.Parameters.AddWithValue("@P12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P14", rchAdres.Text);
            komut.Parameters.AddWithValue("@P15", txtKod1.Text);
            komut.Parameters.AddWithValue("@P16", txtKod2.Text);
            komut.Parameters.AddWithValue("@P17", txtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Firma Ekleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            txtAd.Focus();
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

        private void btbSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From TBL_FIRMALAR where ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Firma Silme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@P1,YETKILISTATU=@P2,YETKILIADSOYAD=@P3,YETKILITC=@P4,SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,MAIL=@P9,FAX=@P10,IL=@P11,ILCE=@P12,VERGIDAIRE=@P13,ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17 where ID=@P18", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@P3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@P4", mskYetkiliTc.Text);
            komut.Parameters.AddWithValue("@P5", txtSektor.Text);
            komut.Parameters.AddWithValue("@P6", mskTel1.Text);
            komut.Parameters.AddWithValue("@P7", mskTel2.Text);
            komut.Parameters.AddWithValue("@P8", mskTel3.Text);
            komut.Parameters.AddWithValue("@P9", txtMail.Text);
            komut.Parameters.AddWithValue("@P10", mskFax.Text);
            komut.Parameters.AddWithValue("@P11", cmbIl.Text);
            komut.Parameters.AddWithValue("@P12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P14", rchAdres.Text);
            komut.Parameters.AddWithValue("@P15", txtKod1.Text);
            komut.Parameters.AddWithValue("@P16", txtKod2.Text);
            komut.Parameters.AddWithValue("@P17", txtKod3.Text);
            komut.Parameters.AddWithValue("@P18", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Firma Güncelleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Temizle();
        }
    }
}
