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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        void firmaListesi()
        {
            string sql = ("select * from TBL_FIRMALAR ");

            SqlDataAdapter da = new SqlDataAdapter(sql,bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListesi();
            sehirListele();
            temizle();
            cariKodAciklama();

        }
        void sehirListele()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_ILLER ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                cmb_IL.Properties.Items.Add(dr[0]);
            }

        }

        void temizle()
        {
            txt_ID.Text = "";
            txt_Ad.Text = "";
            txt_Yetkili.Text = "";
            txt_YGörev.Text = "";
            msktxt_TC.Text = "";
            txt_Sektör.Text = "";
            msktxt_Telefon1.Text = "";
            msktxt_Telefon2.Text = "";
            msktxt_Telefon3.Text = "";
            txt_Mail.Text = "";
            msktxt_Fax.Text = "";
            cmb_IL.Text = "";
            cmb_Ilce.Text = "";
            txt_VergiDairesi.Text = "";
            richBox_Adres.Text = "";
            txt_Kod1.Text = "";
            txt_Kod2.Text = "";
            txt_Kod3.Text = "";
        }

        void cariKodAciklama()
        {
            SqlCommand komut = new SqlCommand("select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rich_Kod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txt_ID.Text = dr["ID"].ToString();
                txt_Ad.Text = dr["AD"].ToString();
                txt_Yetkili.Text = dr["YETKİLİSTATÜ"].ToString();
                txt_YGörev.Text = dr["YETKİLİADSOYAD"].ToString();
                msktxt_TC.Text = dr["YETKILITC"].ToString();
                txt_Sektör.Text = dr["SEKTOR"].ToString();
                msktxt_Telefon1.Text = dr["TELEFON1"].ToString();
                msktxt_Telefon2.Text = dr["TELEFON2"].ToString();
                msktxt_Telefon3.Text = dr["TELEFON3"].ToString();
                txt_Mail.Text = dr["MAIL"].ToString();
                msktxt_Fax.Text = dr["FAX"].ToString();
                cmb_IL.Text = dr["IL"].ToString();
                cmb_Ilce.Text = dr["ILCE"].ToString();
                txt_VergiDairesi.Text = dr["VERGİDAİRE"].ToString();
                richBox_Adres.Text = dr["ADRES"].ToString();
                rich_Kod1.Text = dr["OZELKOD1"].ToString();
                txt_Kod2.Text = dr["OZELKOD2"].ToString();
                txt_Kod3.Text = dr["OZELKOD3"].ToString();
                 
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string sql = ("insert into TBL_FIRMALAR (AD,YETKİLİSTATÜ,YETKİLİADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGİDAİRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17) ");
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
           

            komut.Parameters.AddWithValue("@p1", txt_Ad.Text.Trim());
            komut.Parameters.AddWithValue("@p2", txt_Yetkili.Text.Trim());
            komut.Parameters.AddWithValue("@p3", txt_YGörev.Text.Trim());
            komut.Parameters.AddWithValue("@p4", msktxt_TC.Text.Trim());
            komut.Parameters.AddWithValue("@p5", txt_Sektör.Text.Trim());
            komut.Parameters.AddWithValue("@p6", msktxt_Telefon1.Text.Trim());
            komut.Parameters.AddWithValue("@p7", msktxt_Telefon2.Text.Trim());
            komut.Parameters.AddWithValue("@p8", msktxt_Telefon3.Text.Trim());
            komut.Parameters.AddWithValue("@p9", txt_Mail.Text.Trim());
            komut.Parameters.AddWithValue("@p10", msktxt_Fax.Text.Trim());
            komut.Parameters.AddWithValue("@p11", cmb_IL.Text.Trim());
            komut.Parameters.AddWithValue("@p12", cmb_Ilce.Text.Trim());
            komut.Parameters.AddWithValue("@p13", txt_VergiDairesi.Text.Trim());
            komut.Parameters.AddWithValue("@p14", richBox_Adres.Text.Trim());
            komut.Parameters.AddWithValue("@p15", rich_Kod1.Text.Trim());
            komut.Parameters.AddWithValue("@p16", rich_Kod2.Text.Trim());
            komut.Parameters.AddWithValue("@p17", rich_Kod3.Text.Trim());

            komut.ExecuteNonQuery();
            firmaListesi();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("kaydetme işleminiz gerçekleşmiştir","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
 
 
        }

        private void cmb_IL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Ilce.Properties.Items.Clear();
            cmb_Ilce.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmb_IL.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Ilce.Properties.Items.Add(dr[0]);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FIRMALAR where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            bgl.baglanti().Close();
            MessageBox.Show("seçili ürününüz silinmiştir ","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            komut.ExecuteNonQuery();
            temizle();
            firmaListesi();
           

        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            var sql = ("update TBL_FIRMALAR set AD=@p1,YETKİLİSTATÜ=@p2,YETKİLİADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGİDAİRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 where ID=@p18 ");
            SqlCommand komut = new SqlCommand(sql,bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Yetkili.Text);
            komut.Parameters.AddWithValue("@p3", txt_YGörev.Text);
            komut.Parameters.AddWithValue("@p4", msktxt_TC.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sektör.Text);
            komut.Parameters.AddWithValue("@p6", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p7", msktxt_Telefon2.Text);
            komut.Parameters.AddWithValue("@p8", msktxt_Telefon3.Text);
            komut.Parameters.AddWithValue("@p9", txt_Mail.Text);
            komut.Parameters.AddWithValue("@p10", msktxt_Fax.Text);
            komut.Parameters.AddWithValue("@p11", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p12", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p13", txt_VergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14", richBox_Adres.Text);
            komut.Parameters.AddWithValue("@p15", rich_Kod1.Text);
            komut.Parameters.AddWithValue("@p16", rich_Kod2.Text);
            komut.Parameters.AddWithValue("@p17", rich_Kod3.Text);


            komut.Parameters.AddWithValue("@p18", txt_ID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmaListesi();
            temizle();
            MessageBox.Show("Müsteriniz sisteme güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
