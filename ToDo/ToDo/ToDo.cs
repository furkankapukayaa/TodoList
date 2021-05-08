using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class ToDo : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public ToDo()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamamızda veri tabanı bulunmadığı için programı kapatıp açtığınızda her şey sıfırlanmaktadır. Bu sebeble işiniz bitince günün raporunu almayı unutmayın!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void allFormList_Click(object sender, EventArgs e)
        {
            icerikPanel.Controls.Clear();
            allForm allForm = new allForm();
            allForm.TopLevel = false;
            icerikPanel.Controls.Add(allForm);

            allForm.Show();
            allForm.Dock = DockStyle.Fill;
            allForm.BringToFront();
            allFormList.Visible = false;
            MessageBox.Show("Uygulamamızda veri tabanı bulunmadığı için programı kapatıp açtığınızda her şey sıfırlanmaktadır. Bu sebeble işiniz bitince günün raporunu almayı unutmayın!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                allFormList.Enabled = true;
            }
            else
            {
                allFormList.Enabled = false;
            }
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            allFormList.Enabled = false;
        }

        //icerikPanel.Controls.Clear();
        //icerikPanel.Controls.Add(welcomePic);
        //icerikPanel.Controls.Add(girisMetin);
    }
}
