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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            //Müsteri Bilgileri
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,TC,MAIL from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl_Musteriler.DataSource= dt;

            //Firma Bilgileri
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select AD,YETKİLİADSOYAD,YETKILITC,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR", bgl.baglanti());
            da2.Fill(dt2);
            gridControl_Firmalar.DataSource = dt2;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmm= new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if(dr != null )
            {
                frmm.mail = dr["MAIL"].ToString();
            }
            frmm.Show();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frr=new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frr.mail = dr["MAIL"].ToString();
            }
            frr.Show();
        }
    }
}
