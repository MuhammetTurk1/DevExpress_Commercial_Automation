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

namespace Ticari_Otamasyon2
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void giderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDERLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource= dt;
             
        }
        void temizle()
        {
            txt_ID.Text = "";
            cmb_AY.Text = "";
            CMB_YIL.Text = "";
            txt_ELEKTIRIK.Text = "";
            txt_SU.Text = "";
            txt_DOĞALGAZ.Text = "";
            txt_INTERNET.Text = "";
            txt_MAASLAR.Text = "";
            txt_EKSTRA.Text = "";
            richtxt_NOTLAR.Text = "";
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();
            temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string sql = ("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) ");

            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmb_AY.Text);
            komut.Parameters.AddWithValue("@p2", CMB_YIL.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse( txt_ELEKTIRIK.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txt_SU.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txt_DOĞALGAZ.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_INTERNET.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txt_MAASLAR.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txt_EKSTRA.Text));
            komut.Parameters.AddWithValue("@p9", richtxt_NOTLAR.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("verileriniz başarı ile kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }

         
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null) 
            {
                txt_ID.Text = dr["ID"].ToString();
                cmb_AY.Text = dr["AY"].ToString();
                CMB_YIL.Text = dr["YIL"].ToString();
                txt_ELEKTIRIK.Text = dr["ELEKTRIK"].ToString();
                txt_SU.Text = dr["SU"].ToString();
                txt_DOĞALGAZ.Text = dr["DOGALGAZ"].ToString();
                txt_INTERNET.Text = dr["INTERNET"].ToString();
                txt_MAASLAR.Text = dr["MAASLAR"].ToString();
                txt_EKSTRA.Text = dr["EKSTRA"].ToString();
                richtxt_NOTLAR.Text = dr["NOTLAR"].ToString();
               

            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sql = ("delete from TBL_GIDERLER where ID =@p1");
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderListesi();
            MessageBox.Show("Gider listenizden silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            temizle();

        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            string sql = ("update TBL_GIDERLER set  AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR= @p9 where ID=@p10");
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_AY.Text);
            komut.Parameters.AddWithValue("@p2", CMB_YIL.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txt_ELEKTIRIK.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txt_SU.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txt_DOĞALGAZ.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_INTERNET.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txt_MAASLAR.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txt_EKSTRA.Text));
            komut.Parameters.AddWithValue("@p9", richtxt_NOTLAR.Text);
            komut.Parameters.AddWithValue("@p10",txt_ID.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("güncelleme işleminiz başarı ile gerçekleşmiştir","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            giderListesi();
            temizle();
        }
    }
}
