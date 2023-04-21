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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            txt_ID.Text = "";
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            msktxt_Telefon1.Text = "";
            mskdtxt_Tc.Text = "";
            txt_Mail.Text = "";
            cmb_IL.Text = "";
            cmb_Ilce.Text = "";
            richtxt_Adres.Text = "";
            txt_Görev.Text = "";

        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_IL.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }


        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            
            listele();
            sehirListesi();
            Temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string sql = ("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GÖREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)");
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p4", mskdtxt_Tc.Text);
            komut.Parameters.AddWithValue("@p5", txt_Mail.Text);
            komut.Parameters.AddWithValue("@p6", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p7", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p8", richtxt_Adres.Text);
            komut.Parameters.AddWithValue("@p9", txt_Görev.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteriniz sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void cmb_IL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Ilce.Properties.Items.Clear();
            cmb_Ilce.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_IL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Ilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_PERSONELLER where ID = @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);

            bgl.baglanti().Close();
            var a = MessageBox.Show("müşteri silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            komut.ExecuteNonQuery();
            listele();

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
                mskdtxt_Tc.Text = dr["TC"].ToString();
                txt_Mail.Text = dr["MAIL"].ToString();
                cmb_IL.Text = dr["IL"].ToString();
                cmb_Ilce.Text = dr["ILCE"].ToString();
                richtxt_Adres.Text = dr["ADRES"].ToString();
                txt_Görev.Text = dr["GÖREV"].ToString();
            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_PERSONELLER set " +
          "AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GÖREV=@p9 where ID=@p10", bgl.baglanti());


            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p4", mskdtxt_Tc.Text);
            komut.Parameters.AddWithValue("@p5", txt_Mail.Text);
            komut.Parameters.AddWithValue("@p6", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p7", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p8", richtxt_Adres.Text);
            komut.Parameters.AddWithValue("@p9", txt_Görev.Text);

            komut.Parameters.AddWithValue("@p10", txt_ID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteriniz sisteme güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Temizle();
            listele();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
