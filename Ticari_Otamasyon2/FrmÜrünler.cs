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

namespace Ticari_Otamasyon2
{
    public partial class FrmÜrünler : Form
    {
        public FrmÜrünler()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl =new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource= dt;    
 
        }
        private void FrmÜrünler_Load(object sender, EventArgs e)
        {
            
            listele();
            temizle();
        }

        void temizle()
        {
            
            txt_ID.Text = "";
            txt_ÜrünAdı.Text = "";
            txt_Markası.Text = "";
            txt_Modeli.Text = "";
            mskTxt_Yıl.Text = "";
            nud_Adet.Text = "";
            txt_AlışFiyatı.Text = "";
            txt_SatışFiyati.Text = "";
            richtxt_Detay.Text = "";
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //verileri kaydetme
            string sql = ("INSERT INTO TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFİYAT,SATISFIYATI,DETAY) VALUES (@URUNAD,@MARKA,@MODEL,@YIL,@ADET,@ALISFİYAT,@SATISFIYATI,@DETAY)");
            SqlCommand komut = new SqlCommand(sql,bgl.baglanti());
            
            komut.Parameters.AddWithValue("@URUNAD", txt_ÜrünAdı.Text);
            komut.Parameters.AddWithValue("@MARKA", txt_Markası.Text);
            komut.Parameters.AddWithValue("@MODEL", txt_Modeli.Text);
            komut.Parameters.AddWithValue("@YIL", mskTxt_Yıl.Text);
            komut.Parameters.AddWithValue("@ADET", int.Parse((nud_Adet.Value).ToString()));
            komut.Parameters.AddWithValue("@ALISFİYAT", decimal.Parse(txt_SatışFiyati.Text));
            komut.Parameters.AddWithValue("@SATISFIYATI",decimal.Parse(txt_SatışFiyati.Text));
            komut.Parameters.AddWithValue("@DETAY", richtxt_Detay.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("ürünler sisteme eklendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("p1",txt_ID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürünlerinizi silmek istediğinize emin misiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            listele();
            temizle();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_ID.Text = dr["ID"].ToString();
            txt_ÜrünAdı.Text = dr["URUNAD"].ToString();
            txt_Markası.Text = dr["MARKA"].ToString();
            txt_Modeli.Text = dr["MODEL"].ToString();
            mskTxt_Yıl.Text = dr["YIL"].ToString();
            nud_Adet.Text = dr["ADET"].ToString();
            txt_AlışFiyatı.Text = dr["ALISFİYAT"].ToString();
            txt_SatışFiyati.Text = dr["SATISFIYATI"].ToString() ;
            richtxt_Detay.Text = dr["DETAY"].ToString();
             
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set   URUNAD=@p1 ,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFİYAT=@p6,SATISFIYATI=@p7,DETAY=@p8 where ID =@p9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ÜrünAdı.Text);
            komut.Parameters.AddWithValue("@p2", txt_Markası.Text);
            komut.Parameters.AddWithValue("@p3", txt_Modeli.Text);
            komut.Parameters.AddWithValue("@p4", mskTxt_Yıl.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nud_Adet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_SatışFiyati.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txt_SatışFiyati.Text));
            komut.Parameters.AddWithValue("@p8", richtxt_Detay.Text);
            komut.Parameters.AddWithValue("@p9", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün bilgisi güncellendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
            temizle();

        }
    }
}
