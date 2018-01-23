using iStokTakip.FormApp.Modul_Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStokTakip.FormApp.Functions
{
    public class Formlar
    {
        public void StokListesi(bool Secim = false)
        {
            frmStokListesi frm = new frmStokListesi();
            if (Secim)
            {
                frm.secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }
        public void StokGruplari(bool Secim = false)
        {
            frmStokGruplari frm = new frmStokGruplari();
            if (Secim) frm.secim = Secim;
            frm.ShowDialog();
            
        }
        public void StokHareketleri(bool Ac = false)
        {

        }
        public void StokKarti(bool Ac=false)
        {
            frmStokKarti frm = new frmStokKarti();
            frm.ShowDialog();
        }

    }
}
