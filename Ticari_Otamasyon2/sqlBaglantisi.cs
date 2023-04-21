using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otamasyon2
{
     class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3DI31D0;Initial Catalog=MuhammedTurk;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
