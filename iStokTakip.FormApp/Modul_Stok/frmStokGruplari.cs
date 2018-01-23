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
    public partial class frmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        Mesajlar msj = new Mesajlar();
        Numara num = new Numara();

        public bool secim = false;
        int secimID = -1;
        bool edit = false;

        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var list = from s in db.TBL_STOKGRUPLARIs select s;
            gridStokGrup.DataSource = list;
            
        }
        void Temizle()
        {
            txtGrupAdi.ResetText();
            txtGrupKodu.ResetText();
            edit = false;
            Listele();
        }
        void Kaydet()
        {
            try
            {
                TBL_STOKGRUPLARI grup = new TBL_STOKGRUPLARI();
                grup.GRUPADI = txtGrupAdi.Text;
                grup.GRUPKODU = txtGrupKodu.Text;
                grup.GRUPSAVEUSER = AnaForm.UserID;
                grup.GRUPSAVEDATE = DateTime.Now;
                db.TBL_STOKGRUPLARIs.InsertOnSubmit(grup);
                db.SubmitChanges();
                msj.YeniKayit("Yeni grup kaydı oluşturuldu");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                msj.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                TBL_STOKGRUPLARI grup = db.TBL_STOKGRUPLARIs.FirstOrDefault(x => x.ID == secimID);
                grup.GRUPKODU = txtGrupKodu.Text;
                grup.GRUPADI = txtGrupAdi.Text;
                grup.GRUPEDITUSER = AnaForm.UserID;
                grup.GRUPEDITDATE = DateTime.Now;
                db.SubmitChanges();
                msj.Guncelle(true);
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                msj.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                db.TBL_STOKGRUPLARIs.DeleteOnSubmit(db.TBL_STOKGRUPLARIs.First(x => x.ID == secimID));
                db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                msj.Hata(e);
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimID > 0 && msj.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimID > 0 && msj.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                Kaydet();
            }
        }

        void Sec()
        {
            try
            {
                edit = true;
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                edit = false;
                secimID = -1;
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && secimID>0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }
    }
}