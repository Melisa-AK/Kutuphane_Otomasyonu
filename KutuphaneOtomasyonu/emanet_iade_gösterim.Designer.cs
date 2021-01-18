
namespace KutuphaneOtomasyonu
{
    partial class emanet_iade_gösterim
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
            this.anasayfa = new System.Windows.Forms.Button();
            this.yukleme_btn = new System.Windows.Forms.Button();
            this.liste_d = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arama_btn = new System.Windows.Forms.Button();
            this.giris_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ozellik_c = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ktp_ara_t = new System.Windows.Forms.TextBox();
            this.kategori_cmb = new System.Windows.Forms.ComboBox();
            this.ktp_ara_b = new System.Windows.Forms.Button();
            this.liste_2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_2)).BeginInit();
            this.SuspendLayout();
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.Maroon;
            this.anasayfa.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_home_100;
            this.anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.Location = new System.Drawing.Point(1356, 13);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(105, 102);
            this.anasayfa.TabIndex = 10;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // yukleme_btn
            // 
            this.yukleme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yukleme_btn.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yukleme_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yukleme_btn.Location = new System.Drawing.Point(568, 601);
            this.yukleme_btn.Margin = new System.Windows.Forms.Padding(4);
            this.yukleme_btn.Name = "yukleme_btn";
            this.yukleme_btn.Size = new System.Drawing.Size(216, 58);
            this.yukleme_btn.TabIndex = 9;
            this.yukleme_btn.Text = "Tüm Kayıtlar";
            this.yukleme_btn.UseVisualStyleBackColor = false;
            this.yukleme_btn.Click += new System.EventHandler(this.cagirma_btn_Click);
            // 
            // liste_d
            // 
            this.liste_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liste_d.BackgroundColor = System.Drawing.Color.SeaShell;
            this.liste_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_d.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.liste_d.Location = new System.Drawing.Point(82, 360);
            this.liste_d.Margin = new System.Windows.Forms.Padding(4);
            this.liste_d.Name = "liste_d";
            this.liste_d.RowHeadersWidth = 51;
            this.liste_d.Size = new System.Drawing.Size(702, 233);
            this.liste_d.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.arama_btn);
            this.groupBox1.Controls.Add(this.giris_t);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ozellik_c);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(174, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 178);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade edilen kitap";
            // 
            // arama_btn
            // 
            this.arama_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.arama_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.arama_btn.Location = new System.Drawing.Point(239, 122);
            this.arama_btn.Margin = new System.Windows.Forms.Padding(4);
            this.arama_btn.Name = "arama_btn";
            this.arama_btn.Size = new System.Drawing.Size(135, 39);
            this.arama_btn.TabIndex = 4;
            this.arama_btn.Text = "Arama Yap";
            this.arama_btn.UseVisualStyleBackColor = false;
            this.arama_btn.Click += new System.EventHandler(this.arama_btn_Click);
            // 
            // giris_t
            // 
            this.giris_t.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.giris_t.Location = new System.Drawing.Point(216, 81);
            this.giris_t.Margin = new System.Windows.Forms.Padding(4);
            this.giris_t.Name = "giris_t";
            this.giris_t.Size = new System.Drawing.Size(230, 28);
            this.giris_t.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Bilgisi:";
            // 
            // ozellik_c
            // 
            this.ozellik_c.Font = new System.Drawing.Font("Gadugi", 9.2F);
            this.ozellik_c.FormattingEnabled = true;
            this.ozellik_c.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur"});
            this.ozellik_c.Location = new System.Drawing.Point(216, 30);
            this.ozellik_c.Margin = new System.Windows.Forms.Padding(4);
            this.ozellik_c.Name = "ozellik_c";
            this.ozellik_c.Size = new System.Drawing.Size(230, 27);
            this.ozellik_c.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabı şuna göre ara:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ktp_ara_t);
            this.groupBox2.Controls.Add(this.kategori_cmb);
            this.groupBox2.Controls.Add(this.ktp_ara_b);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(846, 163);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(310, 178);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kriter Seçiniz\r\n";
            // 
            // ktp_ara_t
            // 
            this.ktp_ara_t.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktp_ara_t.Location = new System.Drawing.Point(5, 110);
            this.ktp_ara_t.Margin = new System.Windows.Forms.Padding(4);
            this.ktp_ara_t.Name = "ktp_ara_t";
            this.ktp_ara_t.Size = new System.Drawing.Size(189, 25);
            this.ktp_ara_t.TabIndex = 3;
            this.ktp_ara_t.Text = "Kitap Bilgisi";
            this.ktp_ara_t.Click += new System.EventHandler(this.ktp_ara_t_Click);
            // 
            // kategori_cmb
            // 
            this.kategori_cmb.Font = new System.Drawing.Font("Gadugi", 7.8F);
            this.kategori_cmb.FormattingEnabled = true;
            this.kategori_cmb.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur",
            "kitapnumara"});
            this.kategori_cmb.Location = new System.Drawing.Point(5, 80);
            this.kategori_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kategori_cmb.Name = "kategori_cmb";
            this.kategori_cmb.Size = new System.Drawing.Size(191, 24);
            this.kategori_cmb.TabIndex = 2;
            this.kategori_cmb.SelectedIndexChanged += new System.EventHandler(this.kategori_cmb_SelectedIndexChanged);
            // 
            // ktp_ara_b
            // 
            this.ktp_ara_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ktp_ara_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ktp_ara_b.Location = new System.Drawing.Point(211, 83);
            this.ktp_ara_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ktp_ara_b.Name = "ktp_ara_b";
            this.ktp_ara_b.Size = new System.Drawing.Size(99, 38);
            this.ktp_ara_b.TabIndex = 1;
            this.ktp_ara_b.Text = "Ara";
            this.ktp_ara_b.UseVisualStyleBackColor = false;
            this.ktp_ara_b.Click += new System.EventHandler(this.ktp_ara_b_Click);
            // 
            // liste_2
            // 
            this.liste_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liste_2.BackgroundColor = System.Drawing.Color.SeaShell;
            this.liste_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.liste_2.Location = new System.Drawing.Point(792, 360);
            this.liste_2.Margin = new System.Windows.Forms.Padding(4);
            this.liste_2.Name = "liste_2";
            this.liste_2.RowHeadersWidth = 51;
            this.liste_2.Size = new System.Drawing.Size(652, 233);
            this.liste_2.TabIndex = 30;
            // 
            // emanet_iade_gösterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.girisim_kitap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 826);
            this.Controls.Add(this.liste_2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.yukleme_btn);
            this.Controls.Add(this.liste_d);
            this.Controls.Add(this.groupBox1);
            this.Name = "emanet_iade_gösterim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanet_iade_gösterim";
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Button yukleme_btn;
        private System.Windows.Forms.DataGridView liste_d;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button arama_btn;
        private System.Windows.Forms.TextBox giris_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ozellik_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ktp_ara_t;
        private System.Windows.Forms.ComboBox kategori_cmb;
        private System.Windows.Forms.Button ktp_ara_b;
        private System.Windows.Forms.DataGridView liste_2;
    }
}