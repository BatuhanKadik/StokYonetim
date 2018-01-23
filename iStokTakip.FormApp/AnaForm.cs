using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using iStokTakip.FormApp.Functions;

namespace iStokTakip.FormApp
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Formlar formlar = new Formlar();

        public static int UserID = -1;
        public static int Aktarma = -1;

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokKarti();
        }

        private void barBtnStokListe_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokListesi();
        }

        private void barnBtnStokGrup_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokGruplari();
        }

        private void barBtnStokHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokHareketleri();
        }
    }
}