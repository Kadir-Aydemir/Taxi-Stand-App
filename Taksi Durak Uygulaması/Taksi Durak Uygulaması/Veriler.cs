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
    public partial class Veriler : Form
    {
        public Veriler()
        {
            InitializeComponent();
        }
        static string filename = "Veriler.txt"; // dosya yolumuzu burayada tanımladım.

        private void Veriler_Load(object sender, EventArgs e) // form yüklendiğinde listbox a verileri çektim
        {
               StreamReader oku;
               oku = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + filename);
               string yazi;
               while ((yazi = oku.ReadLine()) != null) //satır boş olana kadar satır satır okumaya devam eder
               {
                   listBox1.Items.Add(yazi.ToString());
               }
               oku.Close();//okumayı kapat 
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close(); // form penceresini kapatır.
        }

        private void btnVerileriSil_Click(object sender, EventArgs e)
        {
            string[] dosya_satirlar = File.ReadAllLines(filename); // dosyanın tüm satırlarını oku
            string[] dosya_satirlar_yeni = new string[dosya_satirlar.Length - 1];

            int j = 0;
            for (int i = 0; i < dosya_satirlar.Length; i++) // i 0 dan başlasın satırımızın uzunluğu boyunca devam etsin
            {
                if (i + 1 != listBox1.SelectedIndex) 
                {
                    dosya_satirlar_yeni[j++] = dosya_satirlar[i]; // satır silindikten sonra altındaki satır onun yerine geçer
                }
            }
            File.WriteAllLines(filename, dosya_satirlar_yeni);
            listBox1.Items.Clear();
            StreamReader oku;
            oku = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + filename);
            string yazi;
            while ((yazi = oku.ReadLine()) != null) //sonunda listbox ı temizleyip güncel verileri yazdırdım.
            {
                listBox1.Items.Add(yazi.ToString());
            }
            oku.Close(); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int secilen = listBox1.SelectedIndex; // listbox daki seçtiğimiz verileri richtextbox a yazdırdım
                string[] dosya_satirlar = File.ReadAllLines(filename); // oradan güncelleyebilmek için satırı
                richTextBox1.Text = dosya_satirlar[secilen];
            }
            catch
            {

            }
        }

        private void btnVerileriGüncelle_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "") // rchtxbx boş değilse 
            {
                try // dene
                {
                    string[] dosya_satirlar = File.ReadAllLines(filename); // dosyamız
                    int secilen = listBox1.SelectedIndex; // listbox da seçilen index
                    dosya_satirlar[secilen] = richTextBox1.Text; // okunan satırların içinden seçilen satır
                    File.WriteAllLines(filename, dosya_satirlar); // richtextbox dan gelen değeri dosyamıza yazıp kaydediyoruz.
                    listBox1.Items.Clear();
                    StreamReader oku;
                    oku = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + filename);
                    string yazi;
                    while ((yazi = oku.ReadLine()) != null) //sonunda listbox ı temizleyip güncel verileri yazdırdım.
                    {
                        listBox1.Items.Add(yazi.ToString());
                    }
                    oku.Close();
                    richTextBox1.Clear();
                    MessageBox.Show("Veri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch // eğer satır seçilmeden butona basılırsa uyarı vericek.
                {
                    MessageBox.Show("Lütfen güncellenecek satırı seçin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // boş ise uyarı vericek
            {
                MessageBox.Show("Boş veri girdiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
