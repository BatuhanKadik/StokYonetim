using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iStokTakip.FormApp.Functions
{
   public class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj,"Yeni Kayıt Girişi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili stok kalıcı olarak güncellenecektir\nGüncelleme işlemini onaylıyor musunuz?","Güncelleme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili stok kalıcı olarak silinecektir\nSilme işlemini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt güncellenmiştir.","Kayıt güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Hata(Exception ex)
        {
            MessageBox.Show(ex.Message,"Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

    }
}
