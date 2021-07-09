using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Taksi_Durak_Uygulaması
{
    public partial class Taksi_Durak : Form
    {      
        public Taksi_Durak()
        {
            InitializeComponent();                       
        }
        int aracsayisi=10; // duraktaki araç sayısını tutuyor.
        static string filename = "Veriler.txt"; // verileri kaydediceğim metin belgesinin yolu
        private void Taksi_Durak_Load(object sender, EventArgs e)
        {
            timer1.Start(); // form açıldığında zamanı gösteren timer ı başlattım.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();  // Tarih ve saati ilgili labellara yazdırdım.
            lblSaat.Text = DateTime.Now.ToShortTimeString();            
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtMusteriAdi.Text!="" && mskTelefon.Text != "" && txtAdres.Text != "" && txtArac.Text != "" && txtGidisYeri.Text != "" && mskMesafe.Text != "" && txtUcret.Text != "")
            {
                ListViewItem ekle = new ListViewItem(txtMusteriAdi.Text);
                ekle.SubItems.Add(mskTelefon.Text);
                ekle.SubItems.Add(txtAdres.Text);
                ekle.SubItems.Add(txtArac.Text);
                ekle.SubItems.Add(txtGidisYeri.Text);        // İlgili alanların boş olmaması halinde verileri listview e ekledim.
                ekle.SubItems.Add(mskMesafe.Text);
                ekle.SubItems.Add(txtUcret.Text);
                ekle.SubItems.Add(lblTarih.Text);
                listView1.Items.Add(ekle);
                lblToplamKayit.Text = listView1.Items.Count.ToString(); // kayıt sayısını yeniledim.               
                aracsayisi = aracsayisi - 1;  // oluşan kayıt için araç sırasını bir eksilttim.
                if (aracsayisi == 0)
                {
                    MessageBox.Show("Boşta araç yok, araç bekleniyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblAracSayisi.Text = "0";
                    btnKaydet.Enabled = false;  // eğer araç sayısı 0 olursa kayıt işlemini durdurdum.
                }
                else
                {
                    lblAracSayisi.Text = aracsayisi.ToString();
                }
            }
            else // eğer boş ise uyarı mesajı verdim.
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double mesafe, ucret;
            mesafe = Convert.ToInt32(mskMesafe.Text);  //burada km başına ücret hesabı yaptım.1000 m de bir 3 tl,artı açılış ücreti 5tl.
            ucret = ((mesafe / 1000) * 3)+5;
            ucret = Math.Round(ucret, 2);
            txtUcret.Text = ucret.ToString()+" TL";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSecilikayit.Text = listView1.SelectedItems.Count.ToString(); // seçili kayıtları ilgili label a yazdırdım.
            if (listView1.SelectedItems.Count != 0)   // eğer seçilen değer varsa sil butonu görünecek,yoksa görünmeyecek.
            {
                btnSil.Visible = true;
            }
            else
            {
                btnSil.Visible = false;
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) //işaretlenen kayıtları label a yazdırdım.
        {
            lblisaretlikayit.Text = listView1.CheckedItems.Count.ToString()+" (İşaretli kayıtlar tamamlanmış seferleri gösterir.)";           
            lblMusteriSayisi.Text = (listView1.Items.Count - listView1.CheckedIndices.Count).ToString(); 
            // müşteri sayısını listedeki kayıt - işaretli kayıtlar olarak aldım ki tamamlanmamış sefer sayısı kadar müşteri olsun.
        }

        private void btnTemizle_Click(object sender, EventArgs e)  // textbox ve maskedtextboxları temizledim.
        {
            txtMusteriAdi.Clear();
            mskTelefon.Clear();
            txtAdres.Clear();
            txtGidisYeri.Clear();
            mskMesafe.Clear();
            txtUcret.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)  // seçilen verileri silme işlemini sil butonuna atadım.
            {
                item.Remove();
                if (item.Checked == false) //eğer seferi tamamlanmadan silinen kayıt varsa eksilen araç sayısını tekrar yerine koydum.
                {
                    aracsayisi = aracsayisi + 1;
                    lblAracSayisi.Text = aracsayisi.ToString();
                }
            }
            lblMusteriSayisi.Text = (listView1.Items.Count - listView1.CheckedIndices.Count).ToString(); //müşteri sayısını güncelledim.
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)  // listedeki verilerin işaret durumuna göre araç sayılarını güncelledim.
            {
                aracsayisi = aracsayisi + 1;
                lblAracSayisi.Text = aracsayisi.ToString(); 
                btnKaydet.Enabled = true; // eğer araç değeri önceden 0 ise arttığı için enabled özelliğini tekrar tru yaptım.
            }
            else if (e.CurrentValue == CheckState.Checked)
            {
                aracsayisi = aracsayisi - 1;
                if (aracsayisi == 0)
                {
                    MessageBox.Show("Boşta araç yok, araç bekleniyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblAracSayisi.Text = "0";
                    btnKaydet.Enabled = false; // eğer işaretlenenlerin işareti kaldırılırsa araç sayısı azalacağı için tekrar 
                }                              // sıfır olursa kayıt butonunu devre dışı bıraktım.
                else
                {
                    lblAracSayisi.Text = aracsayisi.ToString();
                }  
            }
        }

        private void btnVerileriEkle_Click(object sender, EventArgs e) // verileri txt dosyamıza kaydediyoruz,ekliyoruz.
        {
            using (StreamWriter sw = File.AppendText(filename)) // appendtext kullanma sebebimiz önceki verilerin kaybolmaması 
            {
                if (listView1.CheckedItems.Count > 0) // listview boş değil ise ve işaretlenen yani seferi tamamlanmış durum varsa
                {
                    StringBuilder sb = new StringBuilder();                    
                    foreach (ListViewItem lvi in listView1.CheckedItems) // listview1 deki işaretli itemlerin içinden
                    {
                        sb = new StringBuilder();
                        foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text)); 
                        }
                        sw.WriteLine(sb.ToString());  // yine append kullanarak ekleme işlemini gerçekleştiriyoruz.
                    }
                    sw.WriteLine();
                    MessageBox.Show("Veriler Listeye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // boş ise uyarı veriyoruz
                {
                    MessageBox.Show("Liste boş iken veya tamamlanmış sefer yok iken veri ekleyemezsiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGörüntüle_Click(object sender, EventArgs e)
        {
            Veriler veri = new Veriler(); // dosyamızdaki verileri diğer formdaki listbox da görüntüledim.
            veri.Show();                  // bunun için diğer forma yönlendirdim.
        }
    }
}
