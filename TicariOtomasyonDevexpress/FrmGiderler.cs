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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_GIDERLER",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }
        void Temizle()
        {
            txtID.Text = "";
            cmbAy.Text = "";
            cmbYil.Text = "";
            txtElektrik.Text = "";
            txtSu.Text = "";
            txtDogalGaz.Text = "";
            txtInternet.Text = "";
            txtMaas.Text = "";
            txtEkstra.Text = "";
            rchNotlar.Text = "";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",cmbAy.Text);
            komut.Parameters.AddWithValue("@P2",cmbYil.Text);
            komut.Parameters.AddWithValue("@P3",decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@P4",decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@P5",decimal.Parse(txtDogalGaz.Text));
            komut.Parameters.AddWithValue("@P6",decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@P7",decimal.Parse(txtMaas.Text));
            komut.Parameters.AddWithValue("@P8",decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@P9",rchNotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Gider Ekleme İşlemi Başarılı", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtID.Text = dr["ID"].ToString();
                cmbAy.Text = dr["AY"].ToString();
                cmbYil.Text = dr["YIL"].ToString();
                txtElektrik.Text = dr["ELEKTRIK"].ToString();
                txtSu.Text = dr["SU"].ToString();
                txtDogalGaz.Text = dr["DOGALGAZ"].ToString();
                txtInternet.Text = dr["INTERNET"].ToString();
                txtMaas.Text = dr["MAASLAR"].ToString();
                txtEkstra.Text = dr["EKSTRA"].ToString();
                rchNotlar.Text = dr["NOTLAR"].ToString();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btbSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_GIDERLER where ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            Temizle();
            MessageBox.Show("Silme İşlemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_GIDERLER set AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",cmbAy.Text);
            komut.Parameters.AddWithValue("@P2",cmbYil.Text);
            komut.Parameters.AddWithValue("@P3",decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@P4",decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@P5",decimal.Parse(txtDogalGaz.Text));
            komut.Parameters.AddWithValue("@P6",decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@P7",decimal.Parse(txtMaas.Text));
            komut.Parameters.AddWithValue("@P8",decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@P9",rchNotlar.Text);
            komut.Parameters.AddWithValue("@P10",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            Temizle();
            MessageBox.Show("Gider Güncelleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
