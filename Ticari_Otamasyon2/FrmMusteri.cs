using DevExpress.XtraDashboardLayout;
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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERILER ",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource= dt;

        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_ILLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_IL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {

            txt_ID.Text = "";
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            msktxt_Telefon1.Text = "";
            msdtxt_Telefon2.Text = "";
            mskdtxt_Tc.Text = "";
            txt_Mail.Text = "";
            cmb_IL.Text = "";
            cmb_Ilce.Text = "";
            richtxt_Adres.Text = "";
            txt_VergiDairesi.Text = "";
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            temizle();


        }

        private void cmb_IL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Ilce.Properties.Items.Clear();
            cmb_Ilce.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_IL.SelectedIndex+1);
            SqlDataReader dr =komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Ilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string sql = ("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRESI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)");
            SqlCommand komut = new SqlCommand(sql,bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p4", msdtxt_Telefon2.Text);
            komut.Parameters.AddWithValue("@p5", mskdtxt_Tc.Text);
            komut.Parameters.AddWithValue("@p6", txt_Mail.Text);
            komut.Parameters.AddWithValue("@p7", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p8", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p9", richtxt_Adres.Text);
            komut.Parameters.AddWithValue("@p10", txt_VergiDairesi.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteriniz sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txt_ID.Text = dr["ID"].ToString();
                txt_Ad.Text = dr["AD"].ToString();
                txt_Soyad.Text = dr["SOYAD"].ToString();
                msktxt_Telefon1.Text = dr["TELEFON"].ToString();
                msdtxt_Telefon2.Text = dr["TELEFON2"].ToString();
                mskdtxt_Tc.Text = dr["TC"].ToString();
                txt_Mail.Text = dr["MAIL"].ToString();
                cmb_IL.Text = dr["IL"].ToString();
                cmb_Ilce.Text = dr["ILCE"].ToString();
                richtxt_Adres.Text = dr["ADRES"].ToString();
                txt_VergiDairesi.Text = dr["VERGIDAIRESI"].ToString();

            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_MUSTERILER where ID = @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            
            bgl.baglanti().Close();
            var a = MessageBox.Show("müşteri silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            komut.ExecuteNonQuery();
            listele();
            temizle();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        { 
          SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set " +
          "AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC= @p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRESI=@p10 where ID=@p11",bgl.baglanti());


            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p4", msdtxt_Telefon2.Text);
            komut.Parameters.AddWithValue("@p5", mskdtxt_Tc.Text);
            komut.Parameters.AddWithValue("@p6", txt_Mail.Text);
            komut.Parameters.AddWithValue("@p7", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p8", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p9", richtxt_Adres.Text);
            komut.Parameters.AddWithValue("@p10", txt_VergiDairesi.Text);

            komut.Parameters.AddWithValue("@p11", txt_ID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteriniz sisteme güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            temizle();
            listele();

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_Güncelle_Click_1(object sender, EventArgs e)
        {

        }
    }
}
