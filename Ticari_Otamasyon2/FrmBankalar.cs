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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();         //PROSEDURU KULLANMA (execute TABLO İSMİ)
            SqlDataAdapter da = new SqlDataAdapter("execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txt_ID.Text = "";
            txt_BankaAdı.Text = "";
            cmb_IL.Text = "";
            cmb_Ilce.Text = "";
            txt_Sube.Text = "";
            txt_Iban.Text = "";
            txt_HesapNo.Text = "";
            txt_Yetkili.Text = "";
            msktxt_Telefon1.Text = "";
            mskdtxt_Tarih.Text = "";
            txt_HesapTürü.Text = "";
            lookUpEdit1.Text = "";
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListele();
            firmaListesi();
            temizle();
        }
      
        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD from TBL_FIRMALAR ", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            string sql = ("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) " +
                  " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)");

            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_BankaAdı.Text);
            komut.Parameters.AddWithValue("@p2", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p3", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p4", txt_Sube.Text);
            komut.Parameters.AddWithValue("@p5", txt_Iban.Text);
            komut.Parameters.AddWithValue("@p6", txt_HesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txt_Yetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p9", mskdtxt_Tarih.Text);
            komut.Parameters.AddWithValue("@p10", txt_HesapTürü.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Müsteriniz sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
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
        }




        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txt_ID.Text = dr["ID"].ToString();
                txt_BankaAdı.Text = dr["BANKAADI"].ToString();
                cmb_IL.Text = dr["IL"].ToString();
                cmb_Ilce.Text = dr["ILCE"].ToString();
                txt_Sube.Text = dr["SUBE"].ToString();
                txt_Iban.Text = dr["IBAN"].ToString();
                txt_HesapNo.Text = dr["HESAPNO"].ToString();
                txt_Yetkili.Text = dr["YETKILI"].ToString();
                msktxt_Telefon1.Text = dr["TELEFON"].ToString();
                mskdtxt_Tarih.Text = dr["TARIH"].ToString();
                txt_HesapTürü.Text = dr["HESAPTURU"].ToString();
                // lookUpEdit1.Text = dr["FIRMAID"].ToString();


            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sql = ("delete from TBL_BANKALAR where ID=@p1");
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            temizle();


        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            string sql = ("update TBL_BANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6," +
                "YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12");
            
            SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_BankaAdı.Text);
            komut.Parameters.AddWithValue("@p2", cmb_IL.Text);
            komut.Parameters.AddWithValue("@p3", cmb_Ilce.Text);
            komut.Parameters.AddWithValue("@p4", txt_Sube.Text);
            komut.Parameters.AddWithValue("@p5", txt_Iban.Text);
            komut.Parameters.AddWithValue("@p6", txt_HesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txt_Yetkili.Text);
            komut.Parameters.AddWithValue("@p8", msktxt_Telefon1.Text);
            komut.Parameters.AddWithValue("@p9", mskdtxt_Tarih.Text);
            komut.Parameters.AddWithValue("@p10", txt_HesapTürü.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);

            komut.Parameters.AddWithValue("@p12",txt_ID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Güncellemne işleminiz başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();

        }
    }
}
