using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyonDevexpress
{
    class SqlBaglantisi
    {

        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-3331999;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}
