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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void musteriIletisimBilgileriTablosu()
        {
            SqlCommand komut = new SqlCommand("Select ADI,SOYADI,TELEFON,TELEFON2,MAIL,ADRES  From TBL_MUSTERILER", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.baglanti().Close();
        }
        void firmaIletisimBilgileriTablosu()
        {
            SqlCommand komut = new SqlCommand("Select AD,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL,ADRES From TBL_FIRMALAR",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            musteriIletisimBilgileriTablosu();
            firmaIletisimBilgileriTablosu();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail fr = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr !=null)
            {
                fr.mail = dr["MAIL"].ToString();
            }
            fr.Show();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail fr = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr !=null)
            {
                fr.mail = dr["MAIL"].ToString();
            }
            fr.Show();
        }
    }
}
