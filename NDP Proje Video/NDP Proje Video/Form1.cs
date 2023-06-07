using System.Collections.Generic;

/****************************************************************************
**                           SAKARYA �N�VERS�TES�
**               B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**                  B�LG�SAYAR M�HEND�SL��� B�L�M�
**                      PROGRAMLAMAYA G�R��� DERS�
**
**      �DEV NUMARASI: 1
**      ��RENC� ADI: Egemen Bozca
**      ��RENC� NUMARASI.: B221210037
**      DERS GRUBU����: A
**      YOUTUBE L�NK݅ �: https://youtu.be/owLAyjWP9ew
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
            �arp��ma.Click += new EventHandler(button1_Click);
            �arp��ma.Click += new EventHandler(button2_Click);
        }

        //GroupBox 1 Kodlar�
        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt32(gp1uzunluk.Text);
            int en = Convert.ToInt32(gp1en.Text);
            int y�kseklik = Convert.ToInt32(gp1y�kseklik.Text);
            int x = Convert.ToInt32(this.gp1x.Text) + (pictureBox1.Width / 2);
            int y = -(Convert.ToInt32(this.gp1y.Text)) + (pictureBox1.Height / 2);
            int z = Convert.ToInt32(this.gp1z.Text) + (pictureBox1.Width / 2);
            int yar��ap = Convert.ToInt32(gp1yar��ap.Text);

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
            else if (rbgp1�ember.Checked)
            {
                g1.DrawEllipse(pen, x - yar��ap / 2, y - yar��ap / 2, yar��ap * 2, yar��ap * 2);
            }
            else if (rbgp1k�re.Checked)
            {
                g1.FillEllipse(brush, x - yar��ap / 2, y - yar��ap / 2, yar��ap * 2, yar��ap * 2);
            }
            else if (rbgp1ddp.Checked)
            {
                g1.DrawRectangle(pen, x, y, uzunluk, en);
                g1.DrawRectangle(pen, x + y�kseklik / 2, y - y�kseklik / 2, uzunluk, en);

                g1.DrawLine(pen, x, y, x + y�kseklik / 2, y - y�kseklik / 2);
                g1.DrawLine(pen, x + uzunluk, y, x + uzunluk + y�kseklik / 2, y - y�kseklik / 2);
                g1.DrawLine(pen, x, y + en, x + y�kseklik / 2, y - y�kseklik / 2 + en);
                g1.DrawLine(pen, x + uzunluk, y + en, x + uzunluk + y�kseklik / 2, y - y�kseklik / 2 + en);

            }
            else if (rbgp1silindir.Checked)
            {
                g1.FillEllipse(brush, x - yar��ap / 2, y - yar��ap / 4, yar��ap, yar��ap / 2);
                g1.FillEllipse(brush, x - yar��ap / 2, y - (yar��ap / 4) - y�kseklik, yar��ap, yar��ap / 2);
                g1.DrawLine(pen, x - yar��ap / 2, y + (yar��ap / 8), x - yar��ap / 2, y - y�kseklik + (yar��ap / 8));
                g1.DrawLine(pen, x - yar��ap / 2 + yar��ap, y + yar��ap / 8, x - yar��ap / 2 + yar��ap, y - y�kseklik + yar��ap / 8);

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

        private void rbgp1�ember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1�ember.Checked)
            {
                Lgp1yar��ap.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;

                gp1yar��ap.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
            }
            else
            {
                Lgp1yar��ap.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;

                gp1yar��ap.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
            }
        }

        private void rbgp1k�re_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1k�re.Checked)
            {
                Lgp1yar��ap.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;
                Lgp1z.Visible = true;

                gp1yar��ap.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
                gp1z.Visible = true;
            }
            else
            {
                Lgp1yar��ap.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;
                Lgp1z.Visible = false;

                gp1yar��ap.Visible = false;
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
                Lgp1y�kseklik.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;
                Lgp1z.Visible = true;

                gp1uzunluk.Visible = true;
                gp1en.Visible = true;
                gp1y�kseklik.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
                gp1z.Visible = true;
            }
            else
            {
                Lgp1uzunluk.Visible = false;
                Lgp1en.Visible = false;
                Lgp1y�kseklik.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;
                Lgp1z.Visible = false;

                gp1uzunluk.Visible = false;
                gp1en.Visible = false;
                gp1y�kseklik.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
                gp1z.Visible = false;
            }
        }

        private void rbgp1silindir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp1silindir.Checked)
            {
                Lgp1yar��ap.Visible = true;
                Lgp1y�kseklik.Visible = true;
                Lgp1x.Visible = true;
                Lgp1y.Visible = true;
                Lgp1z.Visible = true;

                gp1yar��ap.Visible = true;
                gp1y�kseklik.Visible = true;
                gp1x.Visible = true;
                gp1y.Visible = true;
                gp1z.Visible = true;
            }
            else
            {
                Lgp1yar��ap.Visible = false;
                Lgp1y�kseklik.Visible = false;
                Lgp1x.Visible = false;
                Lgp1y.Visible = false;
                Lgp1z.Visible = false;

                gp1yar��ap.Visible = false;
                gp1y�kseklik.Visible = false;
                gp1x.Visible = false;
                gp1y.Visible = false;
                gp1z.Visible = false;
            }
        }
        //GroupBox 1 Komut Biti�

        //GroupBox 2 Komut Ba�lang��
        private void button2_Click(object sender, EventArgs e)
        {
            int uzunluk = Convert.ToInt32(gp2uzunluk.Text);
            int en = Convert.ToInt32(gp2en.Text);
            int y�kseklik = Convert.ToInt32(gp2y�kseklik.Text);
            int x = Convert.ToInt32(this.gp2x.Text) + (pictureBox1.Width / 2);
            int y = -(Convert.ToInt32(this.gp2y.Text)) + (pictureBox1.Height / 2);
            int z = Convert.ToInt32(this.gp2z.Text) + (pictureBox1.Width / 2);
            int yar��ap = Convert.ToInt32(gp2yar��ap.Text);

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
            else if (rbgp2�ember.Checked)
            {
                g2.DrawEllipse(pen, x - yar��ap / 2, y - yar��ap / 2, yar��ap * 2, yar��ap * 2);
            }
            else if (rbgp2k�re.Checked)
            {
                g2.FillEllipse(brush, x - yar��ap / 2, y - yar��ap / 2, yar��ap * 2, yar��ap * 2);
            }
            else if (rbgp2ddp.Checked)
            {
                g2.DrawRectangle(pen, x, y, uzunluk, en);
                g2.DrawRectangle(pen, x + y�kseklik / 2, y - y�kseklik / 2, uzunluk, en);

                g2.DrawLine(pen, x, y, x + y�kseklik / 2, y - y�kseklik / 2);
                g2.DrawLine(pen, x + uzunluk, y, x + uzunluk + y�kseklik / 2, y - y�kseklik / 2);
                g2.DrawLine(pen, x, y + en, x + y�kseklik / 2, y - y�kseklik / 2 + en);
                g2.DrawLine(pen, x + uzunluk, y + en, x + uzunluk + y�kseklik / 2, y - y�kseklik / 2 + en);

            }
            else if (rbgp2silindir.Checked)
            {
                g2.FillEllipse(brush, x - yar��ap / 2, y - yar��ap / 4, yar��ap, yar��ap / 2);
                g2.FillEllipse(brush, x - yar��ap / 2, y - (yar��ap / 4) - y�kseklik, yar��ap, yar��ap / 2);
                g2.DrawLine(pen, x - yar��ap / 2, y + (yar��ap / 8), x - yar��ap / 2, y - y�kseklik + (yar��ap / 8));
                g2.DrawLine(pen, x - yar��ap / 2 + yar��ap, y + yar��ap / 8, x - yar��ap / 2 + yar��ap, y - y�kseklik + yar��ap / 8);
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

        private void rbgp2�ember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2�ember.Checked)
            {
                Lgp2yar��ap.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;

                gp2yar��ap.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
            }
            else
            {
                Lgp2yar��ap.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;

                gp2yar��ap.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
            }
        }

        private void rbgp2k�re_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2k�re.Checked)
            {
                Lgp2yar��ap.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;
                Lgp2z.Visible = true;

                gp2yar��ap.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
                gp2z.Visible = true;
            }
            else
            {
                Lgp2yar��ap.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;
                Lgp2z.Visible = false;

                gp2yar��ap.Visible = false;
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
                Lgp2y�kseklik.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;
                Lgp2z.Visible = true;

                gp2uzunluk.Visible = true;
                gp2en.Visible = true;
                gp2y�kseklik.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
                gp2z.Visible = true;
            }
            else
            {
                Lgp2uzunluk.Visible = false;
                Lgp2en.Visible = false;
                Lgp2y�kseklik.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;
                Lgp2z.Visible = false;

                gp2uzunluk.Visible = false;
                gp2en.Visible = false;
                gp2y�kseklik.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
                gp2z.Visible = false;
            }
        }

        private void rbgp2silindir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgp2silindir.Checked)
            {
                Lgp2yar��ap.Visible = true;
                Lgp2y�kseklik.Visible = true;
                Lgp2x.Visible = true;
                Lgp2y.Visible = true;
                Lgp2z.Visible = true;

                gp2yar��ap.Visible = true;
                gp2y�kseklik.Visible = true;
                gp2x.Visible = true;
                gp2y.Visible = true;
                gp2z.Visible = true;
            }
            else
            {
                Lgp2yar��ap.Visible = false;
                Lgp2y�kseklik.Visible = false;
                Lgp2x.Visible = false;
                Lgp2y.Visible = false;
                Lgp2z.Visible = false;

                gp2yar��ap.Visible = false;
                gp2y�kseklik.Visible = false;
                gp2x.Visible = false;
                gp2y.Visible = false;
                gp2z.Visible = false;
            }
        }

        private void �arp��ma_Click(object sender, EventArgs e)
        {
            int uzunluk1 = Convert.ToInt32(gp1uzunluk.Text);
            int en1 = Convert.ToInt32(gp1en.Text);
            int y�kseklik1 = Convert.ToInt32(gp1y�kseklik.Text);
            int x1 = Convert.ToInt32(this.gp1x.Text) + (pictureBox1.Width / 2);
            int y1 = -(Convert.ToInt32(this.gp1y.Text)) + (pictureBox1.Height / 2);
            int z1 = Convert.ToInt32(this.gp1z.Text) + (pictureBox1.Width / 2);
            int yar��ap1 = Convert.ToInt32(gp1yar��ap.Text);

            int uzunluk2 = Convert.ToInt32(gp2uzunluk.Text);
            int en2 = Convert.ToInt32(gp2en.Text);
            int y�kseklik2 = Convert.ToInt32(gp2y�kseklik.Text);
            int x2 = Convert.ToInt32(this.gp2x.Text) + (pictureBox1.Width / 2);
            int y2 = -(Convert.ToInt32(this.gp2y.Text)) + (pictureBox1.Height / 2);
            int z2 = Convert.ToInt32(this.gp2z.Text) + (pictureBox1.Width / 2);
            int yar��ap2 = Convert.ToInt32(gp2yar��ap.Text);


            //Nokta �arp��mas�
            if (rbgp1nokta.Checked && rbgp2dd.Checked)
            {
                if (x1<=x2+uzunluk2&&x1>=x2&&y1<=y2&&y1>=y2-en2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2�ember.Checked)
            {
                if (Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)) <= yar��ap2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2k�re.Checked)
            {
                double mesafe = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));


                if (mesafe<yar��ap2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2ddp.Checked)
            {
                if (x1 >= x2-(uzunluk2/2) && x1<=(x2 + uzunluk2/2)&&
                    x2 >= x2 - (en2 / 2) && y1 <= (y2 + en2 / 2) &&
                    z2 >= z2 - (y�kseklik2 / 2) && z1 <= (z2 + y�kseklik2 / 2))
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1nokta.Checked && rbgp2silindir.Checked)
            {
                double mesafe2 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));


                if (mesafe2 < yar��ap2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }


            //Dikd�rtgen �arp��mas�
            if (rbgp1dd.Checked && rbgp2nokta.Checked)
            {
                if (x2 <= x1 + uzunluk1 && x2 >= x1 && y2 <= y1 && y2 >= y1 - en1)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1dd.Checked && rbgp2dd.Checked)
            {
                if (Math.Abs(x1-x2)<uzunluk1 / 2 + uzunluk2 / 2 && Math.Abs(y1 - y2) < en1 / 2 + en2 / 2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1dd.Checked && rbgp2�ember.Checked)
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

                if (distance<yar��ap2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }


            }

            //�ember �arp��mas�
            if (rbgp1�ember.Checked && rbgp2nokta.Checked)
            {
                if (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) <= yar��ap1)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1�ember.Checked && rbgp2dd.Checked)
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

                if (distance < yar��ap1)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1�ember.Checked && rbgp2�ember.Checked)
            {
                if (Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1,2)) < (yar��ap1+yar��ap2))
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }

            //K�re �arp��mas�
            if (rbgp1k�re.Checked && rbgp2nokta.Checked)
            {
                double mesafe3 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));


                if (mesafe3 < yar��ap1)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1k�re.Checked && rbgp2k�re.Checked)
            {
                if (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)) < (yar��ap1 + yar��ap2))
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1k�re.Checked && rbgp2ddp.Checked)
            {
                double enkisamesafeX = Math.Max(x1 - x2, 0);
                enkisamesafeX = Math.Max(enkisamesafeX, x2 - x1 - uzunluk2);
                double enkisamesafeY = Math.Max(y1 - y2, 0);
                enkisamesafeY = Math.Max(enkisamesafeY, x2 - x1 - en2);
                double enkisamesafeZ = Math.Max(z1 - z2, 0);
                enkisamesafeZ = Math.Max(enkisamesafeZ, z2 - z1 - y�kseklik2);

                double enkisamesafe = Math.Sqrt(Math.Pow(enkisamesafeX, 2) + Math.Pow(enkisamesafeY, 2) + Math.Pow(enkisamesafeZ, 2));

                if (enkisamesafe < yar��ap1)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1k�re.Checked && rbgp2silindir.Checked)
            {
                float mx = Math.Abs(x1 - x2);
                float my = Math.Abs(y1 - y2);
                float mz = Math.Abs(z1 - z2);

                float dist = 0.0f;

                if(mx > (yar��ap2 / 2 + yar��ap1))
                {
                    dist += (float)Math.Pow(mx - yar��ap2 / 2 - yar��ap1, 2);
                }
                if (my > (yar��ap2 / 2 + yar��ap1))
                {
                    dist += (float)Math.Pow(my - yar��ap2 / 2 - yar��ap1, 2);
                }
                if (mz > (yar��ap2 / 2 + yar��ap1))
                {
                    dist += (float)Math.Pow(mz - yar��ap2 / 2 - yar��ap1, 2);

                }

                if (dist < Math.Pow(yar��ap1, 2))
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }

            //Dikd�rtgen Prizma �arp��mas�
            if (rbgp1ddp.Checked && rbgp2nokta.Checked)
            {
                if (x2 >= x1 - (uzunluk1 / 2) && x2 <= (x1 + uzunluk1 / 2) &&
                   x1 >= x1 - (en1 / 2) && y2 <= (y1 + en1 / 2) &&
                   z1 >= z1 - (y�kseklik1 / 2) && z2 <= (z1 + y�kseklik1 / 2))
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1ddp.Checked && rbgp2k�re.Checked)
            {
                double enkisamesafeX = Math.Max(x2 - x1, 0);
                enkisamesafeX = Math.Max(enkisamesafeX, x1 - x2 - uzunluk1);
                double enkisamesafeY = Math.Max(y2 - y1, 0);
                enkisamesafeY = Math.Max(enkisamesafeY, x1 - x2 - en1);
                double enkisamesafeZ = Math.Max(z2 - z1, 0);
                enkisamesafeZ = Math.Max(enkisamesafeZ, z1 - z2 - y�kseklik1);

                double enkisamesafe = Math.Sqrt(Math.Pow(enkisamesafeX, 2) + Math.Pow(enkisamesafeY, 2) + Math.Pow(enkisamesafeZ, 2));

                if (enkisamesafe < yar��ap2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1ddp.Checked && rbgp2ddp.Checked)
            {
                double xoverlap = Math.Max(0, Math.Min(x1 + uzunluk1, x2 + uzunluk2) - Math.Max(x1, x2));
                double yoverlap = Math.Max(0, Math.Min(y1 + en1, y2 + en2) - Math.Max(y1, y2));
                double zoverlap = Math.Max(0, Math.Min(z1 + y�kseklik1, z2 + y�kseklik2) - Math.Max(z1, z2));

                if(xoverlap*yoverlap*zoverlap > 0)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }

            //Silindir �arp��mas�
            if (rbgp1silindir.Checked && rbgp2nokta.Checked)
            {
                double mesafe4 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


                if (mesafe4 < yar��ap1)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1silindir.Checked && rbgp2k�re.Checked)
            {
                float mx = Math.Abs(x2 - x1);
                float my = Math.Abs(y2 - y1);
                float mz = Math.Abs(z2 - z1);

                float dist = 0.0f;

                if (mx > (yar��ap1 / 2 + yar��ap2))
                {
                    dist += (float)Math.Pow(mx - yar��ap1 / 2 - yar��ap2, 2);
                }
                if (my > (yar��ap1 / 2 + yar��ap2))
                {
                    dist += (float)Math.Pow(my - yar��ap1 / 2 - yar��ap2, 2);
                }
                if (mz > (yar��ap1 / 2 + yar��ap2))
                {
                    dist += (float)Math.Pow(mz - yar��ap1 / 2 - yar��ap2, 2);

                }

                if (dist < Math.Pow(yar��ap2, 2))
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
            else if (rbgp1silindir.Checked && rbgp2silindir.Checked)
            {
                float silindirmesafe = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

                if (silindirmesafe < yar��ap1/2+yar��ap2/2)
                {
                    label1.Text = ("�arp��ma Ger�ekle�ir");
                }
                else
                {
                    label1.Text = ("�arp��ma Ger�ekle�mez");
                }
            }
        }
    }
}