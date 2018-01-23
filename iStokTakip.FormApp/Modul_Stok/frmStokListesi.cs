using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iStokTakip.FormApp.Functions;

namespace iStokTakip.FormApp.Modul_Stok
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        public bool secim = false;
        int secimId = -1;

        DatabaseDataContext db = new DatabaseDataContext();

        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in db.TBL_STOKLARs
                      where s.STOKADI.Contains("txtStokAdi.Text") && 
                      s.STOKBARKOD.Contains("txtBarkod.Text") && 
                      s.STOKKODU.Contains("txtStokKodu.Text")
                      select s; 

            gridListe.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtStokKodu.ResetText();
            txtStokAdi.ResetText();
            txtBarkod.ResetText();
        }
        
        void Sec()
        {
            try
            {
                secimId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception)
            {

                secimId = -1;
            }
        }

        private void gridListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && secimId>0)
            {
                AnaForm.Aktarma = secimId;
                this.Close();
            }
        }
    }
}