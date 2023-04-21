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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURABILGI ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sil()
        {
            txt_ID.Text = "";
            txt_SERİ.Text = "";
            txt_SIRA.Text = "";
            msktxt_TARİH.Text = "";
            msk_SAAT.Text = "";
            txt_VergiDairesi.Text = "";
            txt_Alıcı.Text = "";
            txt_T_Eden.Text = "";
            txt_T_Alan.Text = "";
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Listele();
            sil();
            txt_Tutar.Enabled = false;

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //if (txt_FaturaUrunId.Text=="")
            //{
            //    SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) " +
            //        "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

            //    komut.Parameters.AddWithValue("@p1", txt_SERİ.Text);
            //    komut.Parameters.AddWithValue("@p2", txt_SIRA.Text);
            //    komut.Parameters.AddWithValue("@p3", msktxt_TARİH.Text);
            //    komut.Parameters.AddWithValue("@p4", msk_SAAT.Text);
            //    komut.Parameters.AddWithValue("@p5", txt_VergiDairesi.Text);
            //    komut.Parameters.AddWithValue("@p6", txt_Alıcı.Text);
            //    komut.Parameters.AddWithValue("@p7", txt_T_Eden.Text);
            //    komut.Parameters.AddWithValue("@p8", txt_T_Alan.Text);

            //    komut.ExecuteNonQuery();
            //    bgl.baglanti().Close();
            //    MessageBox.Show("fatura bilgisi sisteme kaydedldi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    Listele();
            //    sil();

            //}

            //if (txt_FaturaUrunId.Text !="")
            //{


            //    SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) " +
            //       "values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

            //    komut2.Parameters.AddWithValue("@p1",txt_urunAdı.Text);
            //    komut2.Parameters.AddWithValue("@p2", txt_Miktari.Text);
            //    komut2.Parameters.AddWithValue("@p3", txt_Fiayti.Text);
            //    komut2.Parameters.AddWithValue("@p4", txt_Tutar.Text);
            //    komut2.Parameters.AddWithValue("@p5", txt_FaturaUrunId.Text);

            //    komut2.ExecuteNonQuery();
            //    bgl.baglanti().Close();
            //    MessageBox.Show("faturaya ait ürün sisteme kaydedldi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Listele();
            //    sil();


            //}
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txt_ID.Text = dr["FATURABILGIID"].ToString();
                txt_SERİ.Text = dr["SERI"].ToString();
                txt_SIRA.Text = dr["SIRANO"].ToString();
                msktxt_TARİH.Text = dr["TARIH"].ToString();
                msk_SAAT.Text = dr["SAAT"].ToString();
                txt_VergiDairesi.Text = dr["VERGIDAIRE"].ToString();
                txt_Alıcı.Text = dr["ALICI"].ToString();
                txt_T_Eden.Text = dr["TESLIMEDEN"].ToString();
                txt_T_Alan.Text = dr["TESLIMALAN"].ToString();
                //txt_FaturaUrunId.Text = dr["FATURAURUNID"].ToString();
                //txt_Miktari.Text = dr["MIKTAR"].ToString();
                //txt_Fiayti.Text = dr["FIYAT"].ToString();
                //txt_Tutar.Text = dr["TUTAR"].ToString();
                //txt_ID.Text = dr["FATURAID"].ToString();
                 
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void txt_Fiayti_EditValueChanged(object sender, EventArgs e)
        {

            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(txt_Fiayti.Text);
            miktar = Convert.ToDouble(txt_Miktari.Text);
            tutar = miktar * fiyat;
            txt_Tutar.Text = tutar.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            var a = MessageBox.Show("müşteri silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            if (txt_FaturaUrunId.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) " +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txt_SERİ.Text);
                komut.Parameters.AddWithValue("@p2", txt_SIRA.Text);
                komut.Parameters.AddWithValue("@p3", msktxt_TARİH.Text);
                komut.Parameters.AddWithValue("@p4", msk_SAAT.Text);
                komut.Parameters.AddWithValue("@p5", txt_VergiDairesi.Text);
                komut.Parameters.AddWithValue("@p6", txt_Alıcı.Text);
                komut.Parameters.AddWithValue("@p7", txt_T_Eden.Text);
                komut.Parameters.AddWithValue("@p8", txt_T_Alan.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("fatura bilgisi sisteme kaydedldi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                sil();

            }

            if (txt_FaturaUrunId.Text != "")
            {


                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) " +
                   "values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1", txt_urunAdı.Text);
                komut2.Parameters.AddWithValue("@p2", txt_Miktari.Text);
                komut2.Parameters.AddWithValue("@p3", txt_Fiayti.Text);
                komut2.Parameters.AddWithValue("@p4", txt_Tutar.Text);
                komut2.Parameters.AddWithValue("@p5", txt_FaturaUrunId.Text);

                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("faturaya ait ürün sisteme kaydedldi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                sil();


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txt_FaturaUrunId.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) " +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txt_SERİ.Text);
                komut.Parameters.AddWithValue("@p2", txt_SIRA.Text);
                komut.Parameters.AddWithValue("@p3", msktxt_TARİH.Text);
                komut.Parameters.AddWithValue("@p4", msk_SAAT.Text);
                komut.Parameters.AddWithValue("@p5", txt_VergiDairesi.Text);
                komut.Parameters.AddWithValue("@p6", txt_Alıcı.Text);
                komut.Parameters.AddWithValue("@p7", txt_T_Eden.Text);
                komut.Parameters.AddWithValue("@p8", txt_T_Alan.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("fatura bilgisi sisteme kaydedldi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                sil();

            }

            if (txt_FaturaUrunId.Text != "")
            {


                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) " +
                   "values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1", txt_urunAdı.Text);
                komut2.Parameters.AddWithValue("@p2", txt_Miktari.Text);
                komut2.Parameters.AddWithValue("@p3", txt_Fiayti.Text);
                komut2.Parameters.AddWithValue("@p4", txt_Tutar.Text);
                komut2.Parameters.AddWithValue("@p5", txt_FaturaUrunId.Text);

                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("faturaya ait ürün sisteme kaydedldi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                sil();


            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            var sql = ("update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9");
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_SERİ.Text);
            komut.Parameters.AddWithValue("@p2", txt_SIRA.Text);
            komut.Parameters.AddWithValue("@p3", msktxt_TARİH.Text);
            komut.Parameters.AddWithValue("@p4", msk_SAAT.Text);
            komut.Parameters.AddWithValue("@p5", txt_VergiDairesi.Text);
            komut.Parameters.AddWithValue("@p6", txt_Alıcı.Text);
            komut.Parameters.AddWithValue("@p7", txt_T_Eden.Text);
            komut.Parameters.AddWithValue("@p8", txt_T_Alan.Text);


            komut.Parameters.AddWithValue("@p9", txt_ID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            sil();
            MessageBox.Show("Müsteriniz sisteme güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
