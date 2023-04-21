using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otamasyon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FrmÜrünler fr;
        private void btn_Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr== null)
            {
                fr = new FrmÜrünler();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        FrmMusteri fr2;
        private void btn_Musteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmMusteri();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FrmFirmalar frm3;
        private void btn_Firmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3==null)
            {
                frm3 = new FrmFirmalar();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        FrmPersonel Frm4;
        private void btn_Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Frm4==null)
            {
                Frm4 = new FrmPersonel();
                Frm4.MdiParent = this;
                Frm4.Show();
            }
        }
        FrmRehber frm5;
        private void btn_Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm5==null)
            {
                frm5 = new FrmRehber();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        FrmGiderler frm6;
        private void btn_Giderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6==null)
            {
                frm6 = new FrmGiderler();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        FrmBankalar frm7;
        private void btn_Bankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null)
            {
                frm7 = new FrmBankalar();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
        FrmFaturalar frm8;
        private void btn_faturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null)
            {
                frm8 = new FrmFaturalar();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }
    }
}
