
namespace ToDo
{
    partial class allForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tarih = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.yapilacakis = new System.Windows.Forms.TextBox();
            this.tarihsec = new System.Windows.Forms.Label();
            this.takvimlist = new System.Windows.Forms.ListBox();
            this.TbtnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TbtnSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.listYapildi = new System.Windows.Forms.ListBox();
            this.listYapilacak = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.say = new System.Windows.Forms.Label();
            this.btnDur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.TextBox();
            this.saniye = new System.Windows.Forms.CheckBox();
            this.dakika = new System.Windows.Forms.CheckBox();
            this.saat = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.raporAl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tarih
            // 
            this.tarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarih.Location = new System.Drawing.Point(5, 53);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(194, 31);
            this.tarih.TabIndex = 19;
            this.tarih.Text = "Güncelleniyor...";
            this.tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(293, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yapılacak İş :";
            // 
            // yapilacakis
            // 
            this.yapilacakis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yapilacakis.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.yapilacakis.Location = new System.Drawing.Point(104, 198);
            this.yapilacakis.Name = "yapilacakis";
            this.yapilacakis.Size = new System.Drawing.Size(176, 32);
            this.yapilacakis.TabIndex = 22;
            // 
            // tarihsec
            // 
            this.tarihsec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tarihsec.AutoSize = true;
            this.tarihsec.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihsec.Location = new System.Drawing.Point(100, 176);
            this.tarihsec.Name = "tarihsec";
            this.tarihsec.Size = new System.Drawing.Size(101, 19);
            this.tarihsec.TabIndex = 21;
            this.tarihsec.Text = "Tarih Seçiniz...";
            // 
            // takvimlist
            // 
            this.takvimlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.takvimlist.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.takvimlist.FormattingEnabled = true;
            this.takvimlist.HorizontalScrollbar = true;
            this.takvimlist.ItemHeight = 23;
            this.takvimlist.Location = new System.Drawing.Point(293, 205);
            this.takvimlist.Name = "takvimlist";
            this.takvimlist.Size = new System.Drawing.Size(234, 142);
            this.takvimlist.TabIndex = 26;
            // 
            // TbtnEkle
            // 
            this.TbtnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbtnEkle.BackColor = System.Drawing.Color.Transparent;
            this.TbtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TbtnEkle.FlatAppearance.BorderSize = 0;
            this.TbtnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TbtnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TbtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TbtnEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.TbtnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TbtnEkle.ImageKey = "plus.png";
            this.TbtnEkle.ImageList = this.ımageList1;
            this.TbtnEkle.Location = new System.Drawing.Point(95, 242);
            this.TbtnEkle.Name = "TbtnEkle";
            this.TbtnEkle.Size = new System.Drawing.Size(140, 40);
            this.TbtnEkle.TabIndex = 25;
            this.TbtnEkle.Text = "Görev Ekle";
            this.TbtnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TbtnEkle.UseVisualStyleBackColor = false;
            this.TbtnEkle.Click += new System.EventHandler(this.TbtnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "cancel.png");
            this.ımageList1.Images.SetKeyName(2, "back-arrow.png");
            this.ımageList1.Images.SetKeyName(3, "plus.png");
            this.ımageList1.Images.SetKeyName(4, "report.png");
            // 
            // TbtnSil
            // 
            this.TbtnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbtnSil.BackColor = System.Drawing.Color.Transparent;
            this.TbtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TbtnSil.FlatAppearance.BorderSize = 0;
            this.TbtnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TbtnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TbtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TbtnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.TbtnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TbtnSil.ImageKey = "cancel.png";
            this.TbtnSil.ImageList = this.ımageList1;
            this.TbtnSil.Location = new System.Drawing.Point(95, 288);
            this.TbtnSil.Name = "TbtnSil";
            this.TbtnSil.Size = new System.Drawing.Size(131, 39);
            this.TbtnSil.TabIndex = 24;
            this.TbtnSil.Text = "Görevi Sil";
            this.TbtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TbtnSil.UseVisualStyleBackColor = false;
            this.TbtnSil.Click += new System.EventHandler(this.TbtnSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(17, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 32);
            this.textBox1.TabIndex = 31;
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTamamlandi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamamlandi.FlatAppearance.BorderSize = 0;
            this.btnTamamlandi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTamamlandi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTamamlandi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamlandi.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.btnTamamlandi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTamamlandi.ImageKey = "check.png";
            this.btnTamamlandi.ImageList = this.ımageList1;
            this.btnTamamlandi.Location = new System.Drawing.Point(219, 263);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(166, 41);
            this.btnTamamlandi.TabIndex = 29;
            this.btnTamamlandi.Text = "Tamamlandı";
            this.btnTamamlandi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTamamlandi.UseVisualStyleBackColor = true;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // listYapildi
            // 
            this.listYapildi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listYapildi.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.listYapildi.FormattingEnabled = true;
            this.listYapildi.ItemHeight = 23;
            this.listYapildi.Location = new System.Drawing.Point(391, 46);
            this.listYapildi.Name = "listYapildi";
            this.listYapildi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listYapildi.Size = new System.Drawing.Size(164, 211);
            this.listYapildi.TabIndex = 28;
            // 
            // listYapilacak
            // 
            this.listYapilacak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listYapilacak.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listYapilacak.FormattingEnabled = true;
            this.listYapilacak.ItemHeight = 23;
            this.listYapilacak.Location = new System.Drawing.Point(221, 46);
            this.listYapilacak.Name = "listYapilacak";
            this.listYapilacak.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listYapilacak.Size = new System.Drawing.Size(164, 211);
            this.listYapilacak.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.label1.Location = new System.Drawing.Point(387, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tamamlananlar";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Yapılacaklar";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "plus.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(17, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 40);
            this.btnEkle.TabIndex = 33;
            this.btnEkle.Text = "Görev Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "cancel.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(17, 198);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 39);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Görevi Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeriAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriAl.FlatAppearance.BorderSize = 0;
            this.btnGeriAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeriAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.btnGeriAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeriAl.ImageKey = "back-arrow.png";
            this.btnGeriAl.ImageList = this.ımageList1;
            this.btnGeriAl.Location = new System.Drawing.Point(433, 263);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(122, 41);
            this.btnGeriAl.TabIndex = 30;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // say
            // 
            this.say.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say.AutoSize = true;
            this.say.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say.Location = new System.Drawing.Point(202, 240);
            this.say.Name = "say";
            this.say.Size = new System.Drawing.Size(0, 31);
            this.say.TabIndex = 43;
            // 
            // btnDur
            // 
            this.btnDur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDur.Location = new System.Drawing.Point(223, 179);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(86, 48);
            this.btnDur.TabIndex = 42;
            this.btnDur.Text = "Sayacı Durdur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBasla.Location = new System.Drawing.Point(39, 179);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(86, 48);
            this.btnBasla.TabIndex = 41;
            this.btnBasla.Text = "Sayacı Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // sure
            // 
            this.sure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sure.Location = new System.Drawing.Point(131, 133);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(178, 31);
            this.sure.TabIndex = 40;
            this.sure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sure_KeyPress);
            // 
            // saniye
            // 
            this.saniye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saniye.AutoSize = true;
            this.saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.saniye.Location = new System.Drawing.Point(224, 84);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(69, 20);
            this.saniye.TabIndex = 39;
            this.saniye.Text = "Saniye";
            this.saniye.UseVisualStyleBackColor = true;
            // 
            // dakika
            // 
            this.dakika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dakika.AutoSize = true;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dakika.Location = new System.Drawing.Point(223, 58);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(70, 20);
            this.dakika.TabIndex = 38;
            this.dakika.Text = "Dakika";
            this.dakika.UseVisualStyleBackColor = true;
            // 
            // saat
            // 
            this.saat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.Location = new System.Drawing.Point(223, 32);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(55, 20);
            this.saat.TabIndex = 37;
            this.saat.Text = "Saat";
            this.saat.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSifirla.Location = new System.Drawing.Point(131, 179);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(86, 48);
            this.btnSifirla.TabIndex = 46;
            this.btnSifirla.Text = "Sayacı Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDevam.Location = new System.Drawing.Point(315, 179);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(86, 48);
            this.btnDevam.TabIndex = 45;
            this.btnDevam.Text = "Sayacı Devam Ettir";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(102, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Süre Tipini Seçin :";
            // 
            // raporAl
            // 
            this.raporAl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.raporAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raporAl.ImageKey = "report.png";
            this.raporAl.ImageList = this.ımageList1;
            this.raporAl.Location = new System.Drawing.Point(936, 530);
            this.raporAl.Name = "raporAl";
            this.raporAl.Size = new System.Drawing.Size(177, 73);
            this.raporAl.TabIndex = 48;
            this.raporAl.Text = "Günün Raporunu Al";
            this.raporAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raporAl.UseVisualStyleBackColor = true;
            this.raporAl.Click += new System.EventHandler(this.raporAl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnDevam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.say);
            this.groupBox1.Controls.Add(this.btnSifirla);
            this.groupBox1.Controls.Add(this.btnDur);
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.dakika);
            this.groupBox1.Controls.Add(this.sure);
            this.groupBox1.Controls.Add(this.saniye);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(342, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 288);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zamanı Kontrol Et";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.listYapildi);
            this.groupBox2.Controls.Add(this.btnGeriAl);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.btnTamamlandi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listYapilacak);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(634, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 361);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılacaklar Listesi";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Controls.Add(this.TbtnSil);
            this.groupBox3.Controls.Add(this.TbtnEkle);
            this.groupBox3.Controls.Add(this.takvimlist);
            this.groupBox3.Controls.Add(this.tarih);
            this.groupBox3.Controls.Add(this.tarihsec);
            this.groupBox3.Controls.Add(this.yapilacakis);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(51, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 385);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Önce Planlama";
            // 
            // allForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 731);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raporAl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "allForm";
            this.Text = "allForm";
            this.Load += new System.EventHandler(this.allForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yapilacakis;
        private System.Windows.Forms.Label tarihsec;
        private System.Windows.Forms.ListBox takvimlist;
        private System.Windows.Forms.Button TbtnEkle;
        private System.Windows.Forms.Button TbtnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.ListBox listYapildi;
        private System.Windows.Forms.ListBox listYapilacak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Label say;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.CheckBox saniye;
        private System.Windows.Forms.CheckBox dakika;
        private System.Windows.Forms.CheckBox saat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button raporAl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}