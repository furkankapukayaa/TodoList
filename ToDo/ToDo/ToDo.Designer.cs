
namespace ToDo
{
    partial class ToDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo));
            this.btnİcons = new System.Windows.Forms.ImageList(this.components);
            this.girisMetin = new System.Windows.Forms.Label();
            this.icerikPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.allFormList = new System.Windows.Forms.Button();
            this.welcomePic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.todoBaslik = new System.Windows.Forms.Label();
            this.todoPic = new System.Windows.Forms.PictureBox();
            this.icerikPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePic)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnİcons
            // 
            this.btnİcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnİcons.ImageStream")));
            this.btnİcons.TransparentColor = System.Drawing.Color.Transparent;
            this.btnİcons.Images.SetKeyName(0, "cancel.png");
            this.btnİcons.Images.SetKeyName(1, "info.png");
            this.btnİcons.Images.SetKeyName(2, "minimize.png");
            // 
            // girisMetin
            // 
            this.girisMetin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisMetin.AutoSize = true;
            this.girisMetin.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisMetin.Location = new System.Drawing.Point(385, 278);
            this.girisMetin.Name = "girisMetin";
            this.girisMetin.Size = new System.Drawing.Size(443, 216);
            this.girisMetin.TabIndex = 2;
            this.girisMetin.Text = "Hoş Geldin ! \r\nFurkan To Do List basit bir\r\n yapılacak görevlerin yazılıp yönetil" +
    "mesi\r\ntakvim ile zaman planlama,\r\nsayaç ile etkili zaman geçirmek için\r\nyazılmış" +
    " bir programdır.";
            this.girisMetin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icerikPanel
            // 
            this.icerikPanel.Controls.Add(this.allFormList);
            this.icerikPanel.Controls.Add(this.checkBox1);
            this.icerikPanel.Controls.Add(this.girisMetin);
            this.icerikPanel.Controls.Add(this.welcomePic);
            this.icerikPanel.Location = new System.Drawing.Point(224, 40);
            this.icerikPanel.Name = "icerikPanel";
            this.icerikPanel.Size = new System.Drawing.Size(1202, 717);
            this.icerikPanel.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(446, 510);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(332, 32);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Tamamdır planlamaya geçiyorum :)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // allFormList
            // 
            this.allFormList.BackColor = System.Drawing.Color.Transparent;
            this.allFormList.BackgroundImage = global::ToDo.Properties.Resources.btn;
            this.allFormList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.allFormList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allFormList.FlatAppearance.BorderSize = 0;
            this.allFormList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.allFormList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.allFormList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allFormList.Font = new System.Drawing.Font("Poppins Light", 13.75F);
            this.allFormList.ForeColor = System.Drawing.Color.White;
            this.allFormList.ImageList = this.btnİcons;
            this.allFormList.Location = new System.Drawing.Point(458, 548);
            this.allFormList.Name = "allFormList";
            this.allFormList.Size = new System.Drawing.Size(300, 75);
            this.allFormList.TabIndex = 5;
            this.allFormList.Text = "Hadi Planlamaya Geçelim!\r\n";
            this.allFormList.UseVisualStyleBackColor = false;
            this.allFormList.Click += new System.EventHandler(this.allFormList_Click);
            // 
            // welcomePic
            // 
            this.welcomePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomePic.Image = global::ToDo.Properties.Resources.welcome;
            this.welcomePic.Location = new System.Drawing.Point(518, 128);
            this.welcomePic.Name = "welcomePic";
            this.welcomePic.Size = new System.Drawing.Size(158, 147);
            this.welcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcomePic.TabIndex = 1;
            this.welcomePic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ToDo.Properties.Resources.btngra;
            this.panel1.Controls.Add(this.btnBilgi);
            this.panel1.Controls.Add(this.btnKucult);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 40);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnBilgi
            // 
            this.btnBilgi.BackColor = System.Drawing.Color.Transparent;
            this.btnBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBilgi.FlatAppearance.BorderSize = 0;
            this.btnBilgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBilgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilgi.ForeColor = System.Drawing.Color.Transparent;
            this.btnBilgi.ImageKey = "info.png";
            this.btnBilgi.ImageList = this.btnİcons;
            this.btnBilgi.Location = new System.Drawing.Point(1294, 2);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(39, 35);
            this.btnBilgi.TabIndex = 5;
            this.btnBilgi.UseVisualStyleBackColor = false;
            this.btnBilgi.Click += new System.EventHandler(this.btnBilgi_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.Transparent;
            this.btnKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKucult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.ForeColor = System.Drawing.Color.Transparent;
            this.btnKucult.ImageKey = "minimize.png";
            this.btnKucult.ImageList = this.btnİcons;
            this.btnKucult.Location = new System.Drawing.Point(1339, 2);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(39, 35);
            this.btnKucult.TabIndex = 4;
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.Transparent;
            this.btnKapat.ImageKey = "cancel.png";
            this.btnKapat.ImageList = this.btnİcons;
            this.btnKapat.Location = new System.Drawing.Point(1384, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(39, 35);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuPanel.BackgroundImage = global::ToDo.Properties.Resources.btngra;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.Controls.Add(this.todoBaslik);
            this.menuPanel.Controls.Add(this.todoPic);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(224, 767);
            this.menuPanel.TabIndex = 0;
            // 
            // todoBaslik
            // 
            this.todoBaslik.AutoSize = true;
            this.todoBaslik.BackColor = System.Drawing.Color.Transparent;
            this.todoBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.todoBaslik.Location = new System.Drawing.Point(10, 414);
            this.todoBaslik.Name = "todoBaslik";
            this.todoBaslik.Size = new System.Drawing.Size(199, 32);
            this.todoBaslik.TabIndex = 1;
            this.todoBaslik.Text = "Furkan To Do List";
            this.todoBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todoPic
            // 
            this.todoPic.BackColor = System.Drawing.Color.Transparent;
            this.todoPic.Image = ((System.Drawing.Image)(resources.GetObject("todoPic.Image")));
            this.todoPic.Location = new System.Drawing.Point(51, 309);
            this.todoPic.Name = "todoPic";
            this.todoPic.Size = new System.Drawing.Size(97, 102);
            this.todoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.todoPic.TabIndex = 1;
            this.todoPic.TabStop = false;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 758);
            this.Controls.Add(this.icerikPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.icerikPanel.ResumeLayout(false);
            this.icerikPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox todoPic;
        private System.Windows.Forms.Label todoBaslik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.ImageList btnİcons;
        private System.Windows.Forms.PictureBox welcomePic;
        private System.Windows.Forms.Label girisMetin;
        private System.Windows.Forms.Panel icerikPanel;
        private System.Windows.Forms.Button allFormList;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

