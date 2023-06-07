using System.Collections.Generic;

/****************************************************************************
**                           SAKARYA ÜNÝVERSÝTESÝ
**               BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**                  BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**                      PROGRAMLAMAYA GÝRÝÞÝ DERSÝ
**
**      ÖDEV NUMARASI: 1
**      ÖÐRENCÝ ADI: Egemen Bozca
**      ÖÐRENCÝ NUMARASI.: B221210037
**      DERS GRUBU…………: A
**      YOUTUBE LÝNKÝ… …: https://youtu.be/owLAyjWP9ew
****************************************************************************/
namespace NDP_Proje_Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            çarpýþma.Click += new EventHandler(button1_Click);
            çarpýþma.Click += new EventHandler(button2_Click);
        }

        //GroupBox 1 Kodlarý
        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt32(gp1uzunluk.Text);
            int en = Convert.ToInt32(gp1en.Text);
            int yükseklik = Convert.ToInt32(gp1yükseklik.Text);
            int x = Convert.ToInt32(this.gp1x.Text) + (pictureBox1.Width / 2);
            int y = -(Convert.ToInt32(this.gp1y.Text)) + (pictureBox1.Height / 2);
            int z = Convert.ToInt32(this.gp1z.Text) + (pictureBox1.Width / 2);
            int yarýçap = Convert.ToInt32(gp1yarýçap.Text);

            Graphics g1 = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Black);


            if (rbgp1nokta.Checked)
            {
                g1.FillEllipse(brush, x, y, 5, 5);
            }
            else if (rbgp1dd.Checked)
            {
                g1.DrawRectangle(pen, x, y, uzunluk, en);
            }
            else if (rbgp1çember.Checked)
            {
                g1.DrawEllipse(pen, x - yarýçap / 2, y - yarýçap / 2, yarýçap * 2, yarýçap * 2);
            }
            else if (rbgp1küre.Checked)
            {
                g1.FillEllipse(brush, x - yarýçap / 2, y - yarýçap / 2, yarýçap * 2, yarýçap * 2);
            }
            else if (rbgp1ddp.Checked)
            {
                g1.DrawRectangle(pen, x, y, uzunluk, en);
                g1.DrawRectangle(pen, x + yükseklik / 2, y - yükseklik / 2, uzunluk, en);

                g1.DrawLine(pen, x, y, x + yükseklik / 2, y - yükseklik / 2);
                g1.DrawLine(pen, x + uzunluk, y, x + uzunluk + yükseklik / 2, y - yükseklik / 2);
                g1.DrawLine(pen, x, y + en, x + yükseklik / 2, y - yükseklik / 2 + en);
                g1.DrawLine(pen, x + uzunluk, y + en, x + uzunluk + yükseklik / 2, y - yükseklik / 2 + en);

            }
            else if (rbgp1silindir.Checked)
            {
                g1.FillEllipse(brush, x - yarýçap / 2, y - yarýçap / 4, yarýçap, yarýçap / 2);
                g1.FillEllipse(brush, x - yarýçap / 2, y - (yarýçap / 4) - yükseklik, yarýçap, yarýçap / 2);
                g1.DrawLine(pen, x - yarýçap / 2, y + (yarýçap / 8), x - yarýçap / 2, y - yükseklik + (yarýçap / 8));
                g1.DrawLine(pen, x - yarýçap / 2 + yarýçap, y + yarýçap / 8, x - yarýçap / 2 + yarýçap, y - yükseklik + yarýçap / 8);

            }
        }

        private void rbgp1nokta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1nokta.Checked)
            {
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;

                gp1x.Visible = true;
                gp1y.Visible = true;
            }
            else
            {
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;

                gp1x.Visible = false;
                gp1y.Visible = false;
            }
        }

        private void rbgp1dd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1dd.Checked)
            {
                Lgp1uzunluk.Visible = true;
                Lgp1en.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;

                gp1uzunluk.Visible = true;
                gp1en.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
            }
            else
            {
                Lgp1uzunluk.Visible = false;
                Lgp1en.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;

                gp1uzunluk.Visible = false;
                gp1en.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
            }
        }

        private void rbgp1çember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1çember.Checked)
            {
                Lgp1yarýçap.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;

                gp1yarýçap.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
            }
            else
            {
                Lgp1yarýçap.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;

                gp1yarýçap.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
            }
        }

        private void rbgp1küre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1küre.Checked)
            {
                Lgp1yarýçap.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;
                Lgp1z.Visible = true;

                gp1yarýçap.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
                gp1z.Visible = true;
            }
            else
            {
                Lgp1yarýçap.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;
                Lgp1z.Visible = false;

                gp1yarýçap.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
                gp1z.Visible = false;
            }
        }

        private void rbgp1ddp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1ddp.Checked)
            {
                Lgp1uzunluk.Visible = true;
                Lgp1en.Visible = true;
                Lgp1yükseklik.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;
                Lgp1z.Visible = true;

                gp1uzunluk.Visible = true;
                gp1en.Visible = true;
                gp1yükseklik.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
                gp1z.Visible = true;
            }
            else
            {
                Lgp1uzunluk.Visible = false;
                Lgp1en.Visible = false;
                Lgp1yükseklik.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;
                Lgp1z.Visible = false;

                gp1uzunluk.Visible = false;
                gp1en.Visible = false;
                gp1yükseklik.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
                gp1z.Visible = false;
            }
        }

        private void rbgp1silindir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1silindir.Checked)
            {
                Lgp1yarýçap.Visible = true;
                Lgp1yükseklik.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;
                Lgp1z.Visible = true;

                gp1yarýçap.Visible = true;
                gp1yükseklik.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
                gp1z.Visible = true;
            }
            else
            {
                Lgp1yarýçap.Visible = false;
                Lgp1yükseklik.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;
                Lgp1z.Visible = false;

                gp1yarýçap.Visible = false;
                gp1yükseklik.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
                gp1z.Visible = false;
            }
        }
        //GroupBox 1 Komut Bitiþ

        //GroupBox 2 Komut Baþlangýç
        private void button2_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt32(gp2uzunluk.Text);
            int en = Convert.ToInt32(gp2en.Text);
            int yükseklik = Convert.ToInt32(gp2yükseklik.Text);
            int x = Convert.ToInt32(this.gp2x.Text) + (pictureBox1.Width / 2);
            int y = -(Convert.ToInt32(this.gp2y.Text)) + (pictureBox1.Height / 2);
            int z = Convert.ToInt32(this.gp2z.Text) + (pictureBox1.Width / 2);
            int yarýçap = Convert.ToInt32(gp2yarýçap.Text);

            Graphics g2 = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Red, 2);
            Brush brush = new SolidBrush(Color.Red);


            if (rbgp2nokta.Checked)
            {
                g2.FillEllipse(brush, x, y, 5, 5);
            }
            else if (rbgp2dd.Checked)
            {
                g2.DrawRectangle(pen, x, y, uzunluk, en);
            }
            else if (rbgp2çember.Checked)
            {
                g2.DrawEllipse(pen, x - yarýçap / 2, y - yarýçap / 2, yarýçap * 2, yarýçap * 2);
            }
            else if (rbgp2küre.Checked)
            {
                g2.FillEllipse(brush, x - yarýçap / 2, y - yarýçap / 2, yarýçap * 2, yarýçap * 2);
            }
            else if (rbgp2ddp.Checked)
            {
                g2.DrawRectangle(pen, x, y, uzunluk, en);
                g2.DrawRectangle(pen, x + yükseklik / 2, y - yükseklik / 2, uzunluk, en);

                g2.DrawLine(pen, x, y, x + yükseklik / 2, y - yükseklik / 2);
                g2.DrawLine(pen, x + uzunluk, y, x + uzunluk + yükseklik / 2, y - yükseklik / 2);
                g2.DrawLine(pen, x, y + en, x + yükseklik / 2, y - yükseklik / 2 + en);
                g2.DrawLine(pen, x + uzunluk, y + en, x + uzunluk + yükseklik / 2, y - yükseklik / 2 + en);

            }
            else if (rbgp2silindir.Checked)
            {
                g2.FillEllipse(brush, x - yarýçap / 2, y - yarýçap / 4, yarýçap, yarýçap / 2);
                g2.FillEllipse(brush, x - yarýçap / 2, y - (yarýçap / 4) - yükseklik, yarýçap, yarýçap / 2);
                g2.DrawLine(pen, x - yarýçap / 2, y + (yarýçap / 8), x - yarýçap / 2, y - yükseklik + (yarýçap / 8));
                g2.DrawLine(pen, x - yarýçap / 2 + yarýçap, y + yarýçap / 8, x - yarýçap / 2 + yarýçap, y - yükseklik + yarýçap / 8);
            }
        }

        private void rbgp2nokta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2nokta.Checked)
            {
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;

                gp2x.Visible = true;
                gp2y.Visible = true;
            }
            else
            {
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;

                gp2x.Visible = false;
                gp2y.Visible = false;
            }
        }

        private void rbgp2dd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2dd.Checked)
            {
                Lgp2uzunluk.Visible = true;
                Lgp2en.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;

                gp2uzunluk.Visible = true;
                gp2en.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
            }
            else
            {
                Lgp2uzunluk.Visible = false;
                Lgp2en.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;

                gp2uzunluk.Visible = false;
                gp2en.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
            }
        }

        private void rbgp2çember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2çember.Checked)
            {
                Lgp2yarýçap.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;

                gp2yarýçap.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
            }
            else
            {
                Lgp2yarýçap.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;

                gp2yarýçap.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
            }
        }

        private void rbgp2küre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2küre.Checked)
            {
                Lgp2yarýçap.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;
                Lgp2z.Visible = true;

                gp2yarýçap.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
                gp2z.Visible = true;
            }
            else
            {
                Lgp2yarýçap.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;
                Lgp2z.Visible = false;

                gp2yarýçap.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
                gp2z.Visible = false;
            }
        }

        private void rbgp2ddp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2ddp.Checked)
            {
                Lgp2uzunluk.Visible = true;
                Lgp2en.Visible = true;
                Lgp2yükseklik.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;
                Lgp2z.Visible = true;

                gp2uzunluk.Visible = true;
                gp2en.Visible = true;
                gp2yükseklik.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
                gp2z.Visible = true;
            }
            else
            {
                Lgp2uzunluk.Visible = false;
                Lgp2en.Visible = false;
                Lgp2yükseklik.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;
                Lgp2z.Visible = false;

                gp2uzunluk.Visible = false;
                gp2en.Visible = false;
                gp2yükseklik.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
                gp2z.Visible = false;
            }
        }

        private void rbgp2silindir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2silindir.Checked)
            {
                Lgp2yarýçap.Visible = true;
                Lgp2yükseklik.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;
                Lgp2z.Visible = true;

                gp2yarýçap.Visible = true;
                gp2yükseklik.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
                gp2z.Visible = true;
            }
            else
            {
                Lgp2yarýçap.Visible = false;
                Lgp2yükseklik.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;
                Lgp2z.Visible = false;

                gp2yarýçap.Visible = false;
                gp2yükseklik.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
                gp2z.Visible = false;
            }
        }

        private void çarpýþma_Click(object sender, EventArgs e)
        {
            int uzunluk1 = Convert.ToInt32(gp1uzunluk.Text);
            int en1 = Convert.ToInt32(gp1en.Text);
            int yükseklik1 = Convert.ToInt32(gp1yükseklik.Text);
            int x1 = Convert.ToInt32(this.gp1x.Text) + (pictureBox1.Width / 2);
            int y1 = -(Convert.ToInt32(this.gp1y.Text)) + (pictureBox1.Height / 2);
            int z1 = Convert.ToInt32(this.gp1z.Text) + (pictureBox1.Width / 2);
            int yarýçap1 = Convert.ToInt32(gp1yarýçap.Text);

            int uzunluk2 = Convert.ToInt32(gp2uzunluk.Text);
            int en2 = Convert.ToInt32(gp2en.Text);
            int yükseklik2 = Convert.ToInt32(gp2yükseklik.Text);
            int x2 = Convert.ToInt32(this.gp2x.Text) + (pictureBox1.Width / 2);
            int y2 = -(Convert.ToInt32(this.gp2y.Text)) + (pictureBox1.Height / 2);
            int z2 = Convert.ToInt32(this.gp2z.Text) + (pictureBox1.Width / 2);
            int yarýçap2 = Convert.ToInt32(gp2yarýçap.Text);


            //Nokta Çarpýþmasý
            if (rbgp1nokta.Checked && rbgp2dd.Checked)
            {
                if (x1<=x2+uzunluk2&&x1>=x2&&y1<=y2&&y1>=y2-en2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2çember.Checked)
            {
                if (Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)) <= yarýçap2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2küre.Checked)
            {
                double mesafe = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));


                if (mesafe<yarýçap2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2ddp.Checked)
            {
                if (x1 >= x2-(uzunluk2/2) && x1<=(x2 + uzunluk2/2)&&
                    x2 >= x2 - (en2 / 2) && y1 <= (y2 + en2 / 2) &&
                    z2 >= z2 - (yükseklik2 / 2) && z1 <= (z2 + yükseklik2 / 2))
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2silindir.Checked)
            {
                double mesafe2 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));


                if (mesafe2 < yarýçap2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }


            //Dikdörtgen Çarpýþmasý
            if (rbgp1dd.Checked && rbgp2nokta.Checked)
            {
                if (x2 <= x1 + uzunluk1 && x2 >= x1 && y2 <= y1 && y2 >= y1 - en1)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1dd.Checked && rbgp2dd.Checked)
            {
                if (Math.Abs(x1-x2)<uzunluk1 / 2 + uzunluk2 / 2 && Math.Abs(y1 - y2) < en1 / 2 + en2 / 2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1dd.Checked && rbgp2çember.Checked)
            {
                float testX = x2;
                float testY = y2;

                if (x2 < x1 + uzunluk1 / 2) { testX = x1 + uzunluk1 / 2; }

                else if (x2 > x1 + uzunluk1 / 2) { testX = x1 + uzunluk1 / 2 + uzunluk1; }
                if (y2 < y1 + en1 / 2) { testY = x1 + en1 / 2; }
                else if (y2 > y1 + en1 / 2) { testY = y1 + en1 / 2 + en1; }

                float distX = x2 - testX;
                float distY = y2 - testY;
                float distance = (float)Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

                if (distance<yarýçap2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }


            }

            //Çember Çarpýþmasý
            if (rbgp1çember.Checked && rbgp2nokta.Checked)
            {
                if (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) <= yarýçap1)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1çember.Checked && rbgp2dd.Checked)
            {
                float testX = x1;
                float testY = y1;

                if (x1 < x2 + uzunluk2 / 2) { testX = x2 + uzunluk2 / 2; }

                else if (x1 > x2 + uzunluk2 / 2) { testX = x2 + uzunluk2 / 2 + uzunluk2; }
                if (y1 < y2 + en2 / 2) { testY = x2 + en2 / 2; }
                else if (y1 > y2 + en2 / 2) { testY = y2 + en2 / 2 + en2; }

                float distX = x1 - testX;
                float distY = y1 - testY;
                float distance = (float)Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));

                if (distance < yarýçap1)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1çember.Checked && rbgp2çember.Checked)
            {
                if (Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1,2)) < (yarýçap1+yarýçap2))
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }

            //Küre Çarpýþmasý
            if (rbgp1küre.Checked && rbgp2nokta.Checked)
            {
                double mesafe3 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));


                if (mesafe3 < yarýçap1)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1küre.Checked && rbgp2küre.Checked)
            {
                if (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)) < (yarýçap1 + yarýçap2))
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1küre.Checked && rbgp2ddp.Checked)
            {
                double enkisamesafeX = Math.Max(x1 - x2, 0);
                enkisamesafeX = Math.Max(enkisamesafeX, x2 - x1 - uzunluk2);
                double enkisamesafeY = Math.Max(y1 - y2, 0);
                enkisamesafeY = Math.Max(enkisamesafeY, x2 - x1 - en2);
                double enkisamesafeZ = Math.Max(z1 - z2, 0);
                enkisamesafeZ = Math.Max(enkisamesafeZ, z2 - z1 - yükseklik2);

                double enkisamesafe = Math.Sqrt(Math.Pow(enkisamesafeX, 2) + Math.Pow(enkisamesafeY, 2) + Math.Pow(enkisamesafeZ, 2));

                if (enkisamesafe < yarýçap1)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1küre.Checked && rbgp2silindir.Checked)
            {
                float mx = Math.Abs(x1 - x2);
                float my = Math.Abs(y1 - y2);
                float mz = Math.Abs(z1 - z2);

                float dist = 0.0f;

                if(mx > (yarýçap2 / 2 + yarýçap1))
                {
                    dist += (float)Math.Pow(mx - yarýçap2 / 2 - yarýçap1, 2);
                }
                if (my > (yarýçap2 / 2 + yarýçap1))
                {
                    dist += (float)Math.Pow(my - yarýçap2 / 2 - yarýçap1, 2);
                }
                if (mz > (yarýçap2 / 2 + yarýçap1))
                {
                    dist += (float)Math.Pow(mz - yarýçap2 / 2 - yarýçap1, 2);

                }

                if (dist < Math.Pow(yarýçap1, 2))
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }

            //Dikdörtgen Prizma Çarpýþmasý
            if (rbgp1ddp.Checked && rbgp2nokta.Checked)
            {
                if (x2 >= x1 - (uzunluk1 / 2) && x2 <= (x1 + uzunluk1 / 2) &&
                   x1 >= x1 - (en1 / 2) && y2 <= (y1 + en1 / 2) &&
                   z1 >= z1 - (yükseklik1 / 2) && z2 <= (z1 + yükseklik1 / 2))
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1ddp.Checked && rbgp2küre.Checked)
            {
                double enkisamesafeX = Math.Max(x2 - x1, 0);
                enkisamesafeX = Math.Max(enkisamesafeX, x1 - x2 - uzunluk1);
                double enkisamesafeY = Math.Max(y2 - y1, 0);
                enkisamesafeY = Math.Max(enkisamesafeY, x1 - x2 - en1);
                double enkisamesafeZ = Math.Max(z2 - z1, 0);
                enkisamesafeZ = Math.Max(enkisamesafeZ, z1 - z2 - yükseklik1);

                double enkisamesafe = Math.Sqrt(Math.Pow(enkisamesafeX, 2) + Math.Pow(enkisamesafeY, 2) + Math.Pow(enkisamesafeZ, 2));

                if (enkisamesafe < yarýçap2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1ddp.Checked && rbgp2ddp.Checked)
            {
                double xoverlap = Math.Max(0, Math.Min(x1 + uzunluk1, x2 + uzunluk2) - Math.Max(x1, x2));
                double yoverlap = Math.Max(0, Math.Min(y1 + en1, y2 + en2) - Math.Max(y1, y2));
                double zoverlap = Math.Max(0, Math.Min(z1 + yükseklik1, z2 + yükseklik2) - Math.Max(z1, z2));

                if(xoverlap*yoverlap*zoverlap > 0)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }

            //Silindir Çarpýþmasý
            if (rbgp1silindir.Checked && rbgp2nokta.Checked)
            {
                double mesafe4 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


                if (mesafe4 < yarýçap1)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1silindir.Checked && rbgp2küre.Checked)
            {
                float mx = Math.Abs(x2 - x1);
                float my = Math.Abs(y2 - y1);
                float mz = Math.Abs(z2 - z1);

                float dist = 0.0f;

                if (mx > (yarýçap1 / 2 + yarýçap2))
                {
                    dist += (float)Math.Pow(mx - yarýçap1 / 2 - yarýçap2, 2);
                }
                if (my > (yarýçap1 / 2 + yarýçap2))
                {
                    dist += (float)Math.Pow(my - yarýçap1 / 2 - yarýçap2, 2);
                }
                if (mz > (yarýçap1 / 2 + yarýçap2))
                {
                    dist += (float)Math.Pow(mz - yarýçap1 / 2 - yarýçap2, 2);

                }

                if (dist < Math.Pow(yarýçap2, 2))
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
            else if (rbgp1silindir.Checked && rbgp2silindir.Checked)
            {
                float silindirmesafe = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

                if (silindirmesafe < yarýçap1/2+yarýçap2/2)
                {
                    label1.Text = ("Çarpýþma Gerçekleþir");
                }
                else
                {
                    label1.Text = ("Çarpýþma Gerçekleþmez");
                }
            }
        }
    }
}