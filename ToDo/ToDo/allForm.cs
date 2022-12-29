using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ToDo
{
    public partial class allForm : Form
    {
        public allForm()
        {
            InitializeComponent();
        }

        private void allForm_Load(object sender, EventArgs e)
        {
            timer2.Start();
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(btnEkle, "Görev Ekle");
            Aciklama.SetToolTip(btnSil, "Seçilen Görevi Sil");
            Aciklama.SetToolTip(btnTamamlandi, "Seçilen Görevi Tamamlanan Listesine Aktar");
            Aciklama.SetToolTip(btnGeriAl, "Seçilen Görevi Tamamlanan Listesinden Geri Al");
            Aciklama.SetToolTip(listYapilacak, "Yapılacak Görevler");
            Aciklama.SetToolTip(listYapildi, "Tamamlanan Görevler");

            btnSifirla.Enabled = false;
            btnDur.Enabled = false;
            btnDevam.Enabled = false;
        }

        private void TbtnEkle_Click(object sender, EventArgs e)
        {
            if (tarihsec.Text != "Tarih Seçiniz..." && yapilacakis.Text != String.Empty && yapilacakis.Text != " ")
            {
                takvimlist.Items.Add(tarihsec.Text + " Tarihinde " + yapilacakis.Text + " Yapılacak!");
                yapilacakis.Clear();
            }
            else
            {
                MessageBox.Show("Tarih ve Görevi Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            yapilacakis.Clear();
            tarihsec.Text = "";
        }

        private void TbtnSil_Click(object sender, EventArgs e)
        {
            takvimlist.Items.RemoveAt(takvimlist.SelectedIndex);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tarihsec.Text = monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            say.Text = ((int.Parse(say.Text) - 1).ToString());
            if (int.Parse(say.Text) < 10)
            {
                say.ForeColor = Color.Red;
            }
            else
            {
                say.ForeColor = Color.Black;
            }
            if (int.Parse(say.Text) < 1)
            {
                timer1.Stop();
                MessageBox.Show("Süre doldu", "Bilgi");
                sure.Enabled = true;
                sure.Text = "";
                saat.Enabled = true;
                dakika.Enabled = true;
                saniye.Enabled = true;
                say.Text = "";
                saat.Checked = false;
                dakika.Checked = false;
                saniye.Checked = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text != " ")
            {
                listYapilacak.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Eklenecek Görev Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listYapilacak.SelectedIndex != -1 || listYapildi.SelectedIndex != -1)
            {
                if (listYapilacak.SelectedIndex != -1)
                {
                    listYapilacak.Items.RemoveAt(listYapilacak.SelectedIndex);
                }
                else
                {
                    listYapildi.Items.RemoveAt(listYapildi.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Silinecek Görev Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            for (int i = listYapilacak.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listYapildi.Items.Add(listYapilacak.SelectedItems[i]);
                listYapilacak.Items.RemoveAt(listYapilacak.SelectedIndices[i]);
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            for (int i = listYapildi.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listYapilacak.Items.Add(listYapildi.SelectedItems[i]);
                listYapildi.Items.RemoveAt(listYapildi.SelectedIndices[i]);
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            say.ForeColor = Color.Black;
            try
            {
                if (saat.Checked == true || dakika.Checked == true || saniye.Checked == true)
                {
                    if (sure.Text != "")
                    {
                        if (saat.Checked == true)
                        {
                            say.Text = ((int.Parse(sure.Text)) * 60 * 60).ToString();
                        }
                        else if (dakika.Checked == true)
                        {
                            say.Text = ((int.Parse(sure.Text)) * 60).ToString();
                        }
                        else if (saniye.Checked == true)
                        {
                            say.Text = ((int.Parse(sure.Text))).ToString();
                        }
                        timer1.Start();
                        sure.Clear();
                        sure.Enabled = false;
                        sure.Text = "Sayaç İşliyor!";
                        saat.Enabled = false;
                        dakika.Enabled = false;
                        saniye.Enabled = false;

                        btnBasla.Enabled = false;
                        btnSifirla.Enabled = true;
                        btnDur.Enabled = true;
                        btnDevam.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Süreyi girin.", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Süre tipini seçin.", "Hata");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata");
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sure.Enabled = true;
            sure.Text = "";
            saat.Enabled = true;
            dakika.Enabled = true;
            saniye.Enabled = true;
            say.Text = "";
            saat.Checked = false;
            dakika.Checked = false;
            saniye.Checked = false;
            btnBasla.Enabled = true;
            btnSifirla.Enabled = false;
            btnDur.Enabled = false;
            btnDevam.Enabled = false;
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sure.Text = "Sayaç Durdu!";
            sure.Enabled = false;
            saat.Enabled = false;
            dakika.Enabled = false;
            saniye.Enabled = false;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sure.Enabled = false;
            sure.Text = "Sayaç İşliyor!";
            saat.Enabled = false;
            dakika.Enabled = false;
            saniye.Enabled = false;
        }

        private void sure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        private void raporAl_Click(object sender, EventArgs e)
        {
            string yol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyadi = yol + "/ToDo Rapor.txt";
            StreamWriter sw = new StreamWriter(dosyadi);
            sw.WriteLine("Takvim Planı \n");
            for (int i = 0; i < takvimlist.Items.Count; i++)
            {
                sw.WriteLine(Convert.ToString(takvimlist.Items[i]));
            }
            sw.WriteLine("\n");
            sw.WriteLine("Yapılacaklar \n");
            for (int i = 0; i < listYapilacak.Items.Count; i++)
            {
                sw.WriteLine(Convert.ToString(listYapilacak.Items[i]));
            }
            sw.WriteLine("\n");
            sw.WriteLine("Yapılanlar \n");
            for (int i = 0; i < listYapildi.Items.Count; i++)
            {
                sw.WriteLine(Convert.ToString(listYapildi.Items[i]));
            }
            sw.WriteLine("\n");
            sw.Write("Furkan ToDo Sevgiler <3");
            sw.Close();

            MessageBox.Show("Raporunuz masaüstüne kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}