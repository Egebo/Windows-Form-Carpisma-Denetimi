namespace NDP_Proje_Video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            rbgp1silindir = new RadioButton();
            rbgp1ddp = new RadioButton();
            rbgp1nokta = new RadioButton();
            rbgp1küre = new RadioButton();
            rbgp1çember = new RadioButton();
            rbgp1dd = new RadioButton();
            gp1yarıçap = new TextBox();
            gp1z = new TextBox();
            gp1y = new TextBox();
            gp1x = new TextBox();
            gp1yükseklik = new TextBox();
            gp1en = new TextBox();
            Lgp1yarıçap = new Label();
            Lgp1z = new Label();
            Lgp1y = new Label();
            Lgp1x = new Label();
            Lgp1yükseklik = new Label();
            Lgp1en = new Label();
            Lgp1uzunluk = new Label();
            gp1uzunluk = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            rbgp2silindir = new RadioButton();
            rbgp2ddp = new RadioButton();
            rbgp2nokta = new RadioButton();
            rbgp2küre = new RadioButton();
            rbgp2çember = new RadioButton();
            rbgp2dd = new RadioButton();
            gp2yarıçap = new TextBox();
            gp2z = new TextBox();
            gp2y = new TextBox();
            gp2x = new TextBox();
            gp2yükseklik = new TextBox();
            gp2en = new TextBox();
            Lgp2yarıçap = new Label();
            Lgp2z = new Label();
            Lgp2y = new Label();
            Lgp2x = new Label();
            Lgp2yükseklik = new Label();
            Lgp2en = new Label();
            Lgp2uzunluk = new Label();
            gp2uzunluk = new TextBox();
            label1 = new Label();
            çarpışma = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(755, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(773, 448);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(rbgp1silindir);
            groupBox1.Controls.Add(rbgp1ddp);
            groupBox1.Controls.Add(rbgp1nokta);
            groupBox1.Controls.Add(rbgp1küre);
            groupBox1.Controls.Add(rbgp1çember);
            groupBox1.Controls.Add(rbgp1dd);
            groupBox1.Controls.Add(gp1yarıçap);
            groupBox1.Controls.Add(gp1z);
            groupBox1.Controls.Add(gp1y);
            groupBox1.Controls.Add(gp1x);
            groupBox1.Controls.Add(gp1yükseklik);
            groupBox1.Controls.Add(gp1en);
            groupBox1.Controls.Add(Lgp1yarıçap);
            groupBox1.Controls.Add(Lgp1z);
            groupBox1.Controls.Add(Lgp1y);
            groupBox1.Controls.Add(Lgp1x);
            groupBox1.Controls.Add(Lgp1yükseklik);
            groupBox1.Controls.Add(Lgp1en);
            groupBox1.Controls.Add(Lgp1uzunluk);
            groupBox1.Controls.Add(gp1uzunluk);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 448);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlk Şekil";
            // 
            // button1
            // 
            button1.Location = new Point(237, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Şekil Çiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbgp1silindir
            // 
            rbgp1silindir.AutoSize = true;
            rbgp1silindir.Location = new Point(281, 72);
            rbgp1silindir.Name = "rbgp1silindir";
            rbgp1silindir.Size = new Size(77, 28);
            rbgp1silindir.TabIndex = 19;
            rbgp1silindir.TabStop = true;
            rbgp1silindir.Text = "Silindir";
            rbgp1silindir.UseVisualStyleBackColor = true;
            rbgp1silindir.CheckedChanged += rbgp1silindir_CheckedChanged;
            // 
            // rbgp1ddp
            // 
            rbgp1ddp.AutoSize = true;
            rbgp1ddp.Location = new Point(110, 72);
            rbgp1ddp.Name = "rbgp1ddp";
            rbgp1ddp.Size = new Size(165, 28);
            rbgp1ddp.TabIndex = 18;
            rbgp1ddp.TabStop = true;
            rbgp1ddp.Text = "Dikdörtgen Prizma";
            rbgp1ddp.UseVisualStyleBackColor = true;
            rbgp1ddp.CheckedChanged += rbgp1ddp_CheckedChanged;
            // 
            // rbgp1nokta
            // 
            rbgp1nokta.AutoSize = true;
            rbgp1nokta.Location = new Point(23, 29);
            rbgp1nokta.Name = "rbgp1nokta";
            rbgp1nokta.Size = new Size(74, 28);
            rbgp1nokta.TabIndex = 17;
            rbgp1nokta.TabStop = true;
            rbgp1nokta.Text = "Nokta";
            rbgp1nokta.UseVisualStyleBackColor = true;
            rbgp1nokta.CheckedChanged += rbgp1nokta_CheckedChanged;
            // 
            // rbgp1küre
            // 
            rbgp1küre.AutoSize = true;
            rbgp1küre.Location = new Point(32, 72);
            rbgp1küre.Name = "rbgp1küre";
            rbgp1küre.Size = new Size(65, 28);
            rbgp1küre.TabIndex = 16;
            rbgp1küre.TabStop = true;
            rbgp1küre.Text = "Küre";
            rbgp1küre.UseVisualStyleBackColor = true;
            rbgp1küre.CheckedChanged += rbgp1küre_CheckedChanged;
            // 
            // rbgp1çember
            // 
            rbgp1çember.AutoSize = true;
            rbgp1çember.Location = new Point(251, 29);
            rbgp1çember.Name = "rbgp1çember";
            rbgp1çember.Size = new Size(90, 28);
            rbgp1çember.TabIndex = 15;
            rbgp1çember.TabStop = true;
            rbgp1çember.Text = "Çember";
            rbgp1çember.UseVisualStyleBackColor = true;
            rbgp1çember.CheckedChanged += rbgp1çember_CheckedChanged;
            // 
            // rbgp1dd
            // 
            rbgp1dd.AutoSize = true;
            rbgp1dd.Location = new Point(110, 29);
            rbgp1dd.Name = "rbgp1dd";
            rbgp1dd.Size = new Size(109, 28);
            rbgp1dd.TabIndex = 14;
            rbgp1dd.TabStop = true;
            rbgp1dd.Text = "Dikdörtgen";
            rbgp1dd.UseVisualStyleBackColor = true;
            rbgp1dd.CheckedChanged += rbgp1dd_CheckedChanged;
            // 
            // gp1yarıçap
            // 
            gp1yarıçap.Location = new Point(131, 340);
            gp1yarıçap.Name = "gp1yarıçap";
            gp1yarıçap.Size = new Size(125, 30);
            gp1yarıçap.TabIndex = 13;
            gp1yarıçap.Text = "0";
            // 
            // gp1z
            // 
            gp1z.Location = new Point(131, 301);
            gp1z.Name = "gp1z";
            gp1z.Size = new Size(125, 30);
            gp1z.TabIndex = 12;
            gp1z.Text = "0";
            // 
            // gp1y
            // 
            gp1y.Location = new Point(131, 262);
            gp1y.Name = "gp1y";
            gp1y.Size = new Size(125, 30);
            gp1y.TabIndex = 11;
            gp1y.Text = "0";
            // 
            // gp1x
            // 
            gp1x.Location = new Point(133, 223);
            gp1x.Name = "gp1x";
            gp1x.Size = new Size(125, 30);
            gp1x.TabIndex = 10;
            gp1x.Text = "0";
            // 
            // gp1yükseklik
            // 
            gp1yükseklik.Location = new Point(133, 184);
            gp1yükseklik.Name = "gp1yükseklik";
            gp1yükseklik.Size = new Size(125, 30);
            gp1yükseklik.TabIndex = 9;
            gp1yükseklik.Text = "0";
            // 
            // gp1en
            // 
            gp1en.Location = new Point(131, 145);
            gp1en.Name = "gp1en";
            gp1en.Size = new Size(125, 30);
            gp1en.TabIndex = 8;
            gp1en.Text = "0";
            // 
            // Lgp1yarıçap
            // 
            Lgp1yarıçap.AutoSize = true;
            Lgp1yarıçap.Location = new Point(29, 340);
            Lgp1yarıçap.Name = "Lgp1yarıçap";
            Lgp1yarıçap.Size = new Size(66, 24);
            Lgp1yarıçap.TabIndex = 7;
            Lgp1yarıçap.Text = "Yarıçap";
            // 
            // Lgp1z
            // 
            Lgp1z.AutoSize = true;
            Lgp1z.Location = new Point(29, 302);
            Lgp1z.Name = "Lgp1z";
            Lgp1z.Size = new Size(87, 24);
            Lgp1z.TabIndex = 6;
            Lgp1z.Text = "Z Konumu";
            // 
            // Lgp1y
            // 
            Lgp1y.AutoSize = true;
            Lgp1y.Location = new Point(29, 264);
            Lgp1y.Name = "Lgp1y";
            Lgp1y.Size = new Size(88, 24);
            Lgp1y.TabIndex = 5;
            Lgp1y.Text = "Y Konumu";
            // 
            // Lgp1x
            // 
            Lgp1x.AutoSize = true;
            Lgp1x.Location = new Point(30, 226);
            Lgp1x.Name = "Lgp1x";
            Lgp1x.Size = new Size(88, 24);
            Lgp1x.TabIndex = 4;
            Lgp1x.Text = "X Konumu";
            // 
            // Lgp1yükseklik
            // 
            Lgp1yükseklik.AutoSize = true;
            Lgp1yükseklik.Location = new Point(29, 188);
            Lgp1yükseklik.Name = "Lgp1yükseklik";
            Lgp1yükseklik.Size = new Size(77, 24);
            Lgp1yükseklik.TabIndex = 3;
            Lgp1yükseklik.Text = "Yükseklik";
            // 
            // Lgp1en
            // 
            Lgp1en.AutoSize = true;
            Lgp1en.Location = new Point(29, 150);
            Lgp1en.Name = "Lgp1en";
            Lgp1en.Size = new Size(30, 24);
            Lgp1en.TabIndex = 2;
            Lgp1en.Text = "En";
            // 
            // Lgp1uzunluk
            // 
            Lgp1uzunluk.AutoSize = true;
            Lgp1uzunluk.Location = new Point(29, 112);
            Lgp1uzunluk.Name = "Lgp1uzunluk";
            Lgp1uzunluk.Size = new Size(68, 24);
            Lgp1uzunluk.TabIndex = 1;
            Lgp1uzunluk.Text = "Uzunluk";
            // 
            // gp1uzunluk
            // 
            gp1uzunluk.Location = new Point(131, 106);
            gp1uzunluk.Name = "gp1uzunluk";
            gp1uzunluk.Size = new Size(125, 30);
            gp1uzunluk.TabIndex = 0;
            gp1uzunluk.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(rbgp2silindir);
            groupBox2.Controls.Add(rbgp2ddp);
            groupBox2.Controls.Add(rbgp2nokta);
            groupBox2.Controls.Add(rbgp2küre);
            groupBox2.Controls.Add(rbgp2çember);
            groupBox2.Controls.Add(rbgp2dd);
            groupBox2.Controls.Add(gp2yarıçap);
            groupBox2.Controls.Add(gp2z);
            groupBox2.Controls.Add(gp2y);
            groupBox2.Controls.Add(gp2x);
            groupBox2.Controls.Add(gp2yükseklik);
            groupBox2.Controls.Add(gp2en);
            groupBox2.Controls.Add(Lgp2yarıçap);
            groupBox2.Controls.Add(Lgp2z);
            groupBox2.Controls.Add(Lgp2y);
            groupBox2.Controls.Add(Lgp2x);
            groupBox2.Controls.Add(Lgp2yükseklik);
            groupBox2.Controls.Add(Lgp2en);
            groupBox2.Controls.Add(Lgp2uzunluk);
            groupBox2.Controls.Add(gp2uzunluk);
            groupBox2.Location = new Point(378, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 448);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "İlk Şekil";
            // 
            // button2
            // 
            button2.Location = new Point(234, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "Şekil Çiz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rbgp2silindir
            // 
            rbgp2silindir.AutoSize = true;
            rbgp2silindir.Location = new Point(281, 72);
            rbgp2silindir.Name = "rbgp2silindir";
            rbgp2silindir.Size = new Size(77, 28);
            rbgp2silindir.TabIndex = 19;
            rbgp2silindir.TabStop = true;
            rbgp2silindir.Text = "Silindir";
            rbgp2silindir.UseVisualStyleBackColor = true;
            rbgp2silindir.CheckedChanged += rbgp2silindir_CheckedChanged;
            // 
            // rbgp2ddp
            // 
            rbgp2ddp.AutoSize = true;
            rbgp2ddp.Location = new Point(110, 72);
            rbgp2ddp.Name = "rbgp2ddp";
            rbgp2ddp.Size = new Size(165, 28);
            rbgp2ddp.TabIndex = 18;
            rbgp2ddp.TabStop = true;
            rbgp2ddp.Text = "Dikdörtgen Prizma";
            rbgp2ddp.UseVisualStyleBackColor = true;
            rbgp2ddp.CheckedChanged += rbgp2ddp_CheckedChanged;
            // 
            // rbgp2nokta
            // 
            rbgp2nokta.AutoSize = true;
            rbgp2nokta.Location = new Point(23, 29);
            rbgp2nokta.Name = "rbgp2nokta";
            rbgp2nokta.Size = new Size(74, 28);
            rbgp2nokta.TabIndex = 17;
            rbgp2nokta.TabStop = true;
            rbgp2nokta.Text = "Nokta";
            rbgp2nokta.UseVisualStyleBackColor = true;
            rbgp2nokta.CheckedChanged += rbgp2nokta_CheckedChanged;
            // 
            // rbgp2küre
            // 
            rbgp2küre.AutoSize = true;
            rbgp2küre.Location = new Point(32, 72);
            rbgp2küre.Name = "rbgp2küre";
            rbgp2küre.Size = new Size(65, 28);
            rbgp2küre.TabIndex = 16;
            rbgp2küre.TabStop = true;
            rbgp2küre.Text = "Küre";
            rbgp2küre.UseVisualStyleBackColor = true;
            rbgp2küre.CheckedChanged += rbgp2küre_CheckedChanged;
            // 
            // rbgp2çember
            // 
            rbgp2çember.AutoSize = true;
            rbgp2çember.Location = new Point(251, 29);
            rbgp2çember.Name = "rbgp2çember";
            rbgp2çember.Size = new Size(90, 28);
            rbgp2çember.TabIndex = 15;
            rbgp2çember.TabStop = true;
            rbgp2çember.Text = "Çember";
            rbgp2çember.UseVisualStyleBackColor = true;
            rbgp2çember.CheckedChanged += rbgp2çember_CheckedChanged;
            // 
            // rbgp2dd
            // 
            rbgp2dd.AutoSize = true;
            rbgp2dd.Location = new Point(110, 29);
            rbgp2dd.Name = "rbgp2dd";
            rbgp2dd.Size = new Size(109, 28);
            rbgp2dd.TabIndex = 14;
            rbgp2dd.TabStop = true;
            rbgp2dd.Text = "Dikdörtgen";
            rbgp2dd.UseVisualStyleBackColor = true;
            rbgp2dd.CheckedChanged += rbgp2dd_CheckedChanged;
            // 
            // gp2yarıçap
            // 
            gp2yarıçap.Location = new Point(135, 340);
            gp2yarıçap.Name = "gp2yarıçap";
            gp2yarıçap.Size = new Size(125, 30);
            gp2yarıçap.TabIndex = 13;
            gp2yarıçap.Text = "0";
            // 
            // gp2z
            // 
            gp2z.Location = new Point(135, 301);
            gp2z.Name = "gp2z";
            gp2z.Size = new Size(125, 30);
            gp2z.TabIndex = 12;
            gp2z.Text = "0";
            // 
            // gp2y
            // 
            gp2y.Location = new Point(135, 262);
            gp2y.Name = "gp2y";
            gp2y.Size = new Size(125, 30);
            gp2y.TabIndex = 11;
            gp2y.Text = "0";
            // 
            // gp2x
            // 
            gp2x.Location = new Point(137, 223);
            gp2x.Name = "gp2x";
            gp2x.Size = new Size(125, 30);
            gp2x.TabIndex = 10;
            gp2x.Text = "0";
            // 
            // gp2yükseklik
            // 
            gp2yükseklik.Location = new Point(137, 184);
            gp2yükseklik.Name = "gp2yükseklik";
            gp2yükseklik.Size = new Size(125, 30);
            gp2yükseklik.TabIndex = 9;
            gp2yükseklik.Text = "0";
            // 
            // gp2en
            // 
            gp2en.Location = new Point(135, 145);
            gp2en.Name = "gp2en";
            gp2en.Size = new Size(125, 30);
            gp2en.TabIndex = 8;
            gp2en.Text = "0";
            // 
            // Lgp2yarıçap
            // 
            Lgp2yarıçap.AutoSize = true;
            Lgp2yarıçap.Location = new Point(33, 340);
            Lgp2yarıçap.Name = "Lgp2yarıçap";
            Lgp2yarıçap.Size = new Size(66, 24);
            Lgp2yarıçap.TabIndex = 7;
            Lgp2yarıçap.Text = "Yarıçap";
            // 
            // Lgp2z
            // 
            Lgp2z.AutoSize = true;
            Lgp2z.Location = new Point(33, 302);
            Lgp2z.Name = "Lgp2z";
            Lgp2z.Size = new Size(87, 24);
            Lgp2z.TabIndex = 6;
            Lgp2z.Text = "Z Konumu";
            // 
            // Lgp2y
            // 
            Lgp2y.AutoSize = true;
            Lgp2y.Location = new Point(33, 264);
            Lgp2y.Name = "Lgp2y";
            Lgp2y.Size = new Size(88, 24);
            Lgp2y.TabIndex = 5;
            Lgp2y.Text = "Y Konumu";
            // 
            // Lgp2x
            // 
            Lgp2x.AutoSize = true;
            Lgp2x.Location = new Point(34, 226);
            Lgp2x.Name = "Lgp2x";
            Lgp2x.Size = new Size(88, 24);
            Lgp2x.TabIndex = 4;
            Lgp2x.Text = "X Konumu";
            // 
            // Lgp2yükseklik
            // 
            Lgp2yükseklik.AutoSize = true;
            Lgp2yükseklik.Location = new Point(33, 188);
            Lgp2yükseklik.Name = "Lgp2yükseklik";
            Lgp2yükseklik.Size = new Size(77, 24);
            Lgp2yükseklik.TabIndex = 3;
            Lgp2yükseklik.Text = "Yükseklik";
            // 
            // Lgp2en
            // 
            Lgp2en.AutoSize = true;
            Lgp2en.Location = new Point(33, 150);
            Lgp2en.Name = "Lgp2en";
            Lgp2en.Size = new Size(30, 24);
            Lgp2en.TabIndex = 2;
            Lgp2en.Text = "En";
            // 
            // Lgp2uzunluk
            // 
            Lgp2uzunluk.AutoSize = true;
            Lgp2uzunluk.Location = new Point(33, 112);
            Lgp2uzunluk.Name = "Lgp2uzunluk";
            Lgp2uzunluk.Size = new Size(68, 24);
            Lgp2uzunluk.TabIndex = 1;
            Lgp2uzunluk.Text = "Uzunluk";
            // 
            // gp2uzunluk
            // 
            gp2uzunluk.Location = new Point(135, 106);
            gp2uzunluk.Name = "gp2uzunluk";
            gp2uzunluk.Size = new Size(125, 30);
            gp2uzunluk.TabIndex = 0;
            gp2uzunluk.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1105, 533);
            label1.Name = "label1";
            label1.Size = new Size(52, 24);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // çarpışma
            // 
            çarpışma.Location = new Point(962, 587);
            çarpışma.Name = "çarpışma";
            çarpışma.Size = new Size(304, 65);
            çarpışma.TabIndex = 22;
            çarpışma.Text = "Çarpışma Denetimi";
            çarpışma.UseVisualStyleBackColor = true;
            çarpışma.Click += çarpışma_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1091, 501);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 23;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1540, 664);
            Controls.Add(button3);
            Controls.Add(çarpışma);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Egemen Bozca B221210037 Proje";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox gp1uzunluk;
        private Label Lgp1yarıçap;
        private Label Lgp1z;
        private Label Lgp1y;
        private Label Lgp1x;
        private Label Lgp1yükseklik;
        private Label Lgp1en;
        private Label Lgp1uzunluk;
        private TextBox gp1yarıçap;
        private TextBox gp1z;
        private TextBox gp1y;
        private TextBox gp1x;
        private TextBox gp1yükseklik;
        private TextBox gp1en;
        private Button button1;
        private RadioButton rbgp1silindir;
        private RadioButton rbgp1ddp;
        private RadioButton rbgp1nokta;
        private RadioButton rbgp1küre;
        private RadioButton rbgp1çember;
        private RadioButton rbgp1dd;
        private GroupBox groupBox2;
        private Button button2;
        private RadioButton rbgp2silindir;
        private RadioButton rbgp2ddp;
        private RadioButton rbgp2nokta;
        private RadioButton rbgp2küre;
        private RadioButton rbgp2çember;
        private RadioButton rbgp2dd;
        private TextBox gp2yarıçap;
        private TextBox gp2z;
        private TextBox gp2y;
        private TextBox gp2x;
        private TextBox gp2yükseklik;
        private TextBox gp2en;
        private Label Lgp2yarıçap;
        private Label Lgp2z;
        private Label Lgp2y;
        private Label Lgp2x;
        private Label Lgp2yükseklik;
        private Label Lgp2en;
        private Label Lgp2uzunluk;
        private TextBox gp2uzunluk;
        private Label label1;
        private Button çarpışma;
        private Button button3;
    }
}