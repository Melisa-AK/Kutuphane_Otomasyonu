
namespace KutuphaneOtomasyonu
{
    partial class ogrenci_islemleri
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
            this.ogrenci_listesi_d = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.adres_t = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_t = new System.Windows.Forms.TextBox();
            this.id_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bolum_t = new System.Windows.Forms.TextBox();
            this.numara_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim_t = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogr_ara_b = new System.Windows.Forms.Button();
            this.ogr_ara_t = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sil_b = new System.Windows.Forms.Button();
            this.guncelle_b = new System.Windows.Forms.Button();
            this.anasayfa = new System.Windows.Forms.Button();
            this.tum_b = new System.Windows.Forms.Button();
            this.ekle_b = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_listesi_d)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenci_listesi_d
            // 
            this.ogrenci_listesi_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenci_listesi_d.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ogrenci_listesi_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenci_listesi_d.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.ogrenci_listesi_d.Location = new System.Drawing.Point(629, 63);
            this.ogrenci_listesi_d.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogrenci_listesi_d.Name = "ogrenci_listesi_d";
            this.ogrenci_listesi_d.RowHeadersWidth = 51;
            this.ogrenci_listesi_d.RowTemplate.Height = 24;
            this.ogrenci_listesi_d.Size = new System.Drawing.Size(743, 639);
            this.ogrenci_listesi_d.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.adres_t);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.email_t);
            this.groupBox2.Controls.Add(this.id_t);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bolum_t);
            this.groupBox2.Controls.Add(this.numara_t);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.isim_t);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(44, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(579, 288);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PeachPuff;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Adres:";
            // 
            // adres_t
            // 
            this.adres_t.Font = new System.Drawing.Font("Gadugi", 9F);
            this.adres_t.Location = new System.Drawing.Point(113, 215);
            this.adres_t.Name = "adres_t";
            this.adres_t.Size = new System.Drawing.Size(323, 27);
            this.adres_t.TabIndex = 9;
            this.adres_t.Text = "İlçe girmeniz yeterlidir";
            this.adres_t.Click += new System.EventHandler(this.adres_t_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email:";
            // 
            // email_t
            // 
            this.email_t.Font = new System.Drawing.Font("Gadugi", 9F);
            this.email_t.Location = new System.Drawing.Point(113, 173);
            this.email_t.Name = "email_t";
            this.email_t.Size = new System.Drawing.Size(323, 27);
            this.email_t.TabIndex = 8;
            this.email_t.Text = "Size ulaşabilmemiz için mail giriniz";
            this.email_t.Click += new System.EventHandler(this.email_t_click);
            // 
            // id_t
            // 
            this.id_t.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_t.Location = new System.Drawing.Point(113, 32);
            this.id_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(323, 27);
            this.id_t.TabIndex = 7;
            this.id_t.Text = "Ekleme yaparken ,Lütfen Bu Alanı Boş Bırakınız.";
            this.id_t.Click += new System.EventHandler(this.id_t_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölüm:";
            // 
            // bolum_t
            // 
            this.bolum_t.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolum_t.Location = new System.Drawing.Point(113, 137);
            this.bolum_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bolum_t.Name = "bolum_t";
            this.bolum_t.Size = new System.Drawing.Size(323, 27);
            this.bolum_t.TabIndex = 4;
            this.bolum_t.Text = "Bölüm giriniz.\r\n";
            this.bolum_t.Click += new System.EventHandler(this.bolum_t_Click);
            // 
            // numara_t
            // 
            this.numara_t.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numara_t.Location = new System.Drawing.Point(113, 102);
            this.numara_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numara_t.Name = "numara_t";
            this.numara_t.Size = new System.Drawing.Size(323, 27);
            this.numara_t.TabIndex = 3;
            this.numara_t.Text = "Telefon Numarası";
            this.numara_t.Click += new System.EventHandler(this.numara_t_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad-Soyad:";
            // 
            // isim_t
            // 
            this.isim_t.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isim_t.Location = new System.Drawing.Point(113, 65);
            this.isim_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isim_t.Name = "isim_t";
            this.isim_t.Size = new System.Drawing.Size(323, 27);
            this.isim_t.TabIndex = 0;
            this.isim_t.Text = "Ad Soyad";
            this.isim_t.Click += new System.EventHandler(this.isim_t_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ogr_ara_b);
            this.groupBox1.Controls.Add(this.ogr_ara_t);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(44, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(579, 123);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            // 
            // ogr_ara_b
            // 
            this.ogr_ara_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ogr_ara_b.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_google_web_search_50;
            this.ogr_ara_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ogr_ara_b.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogr_ara_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ogr_ara_b.Location = new System.Drawing.Point(352, 27);
            this.ogr_ara_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogr_ara_b.Name = "ogr_ara_b";
            this.ogr_ara_b.Size = new System.Drawing.Size(84, 73);
            this.ogr_ara_b.TabIndex = 1;
            this.ogr_ara_b.UseVisualStyleBackColor = false;
            this.ogr_ara_b.Click += new System.EventHandler(this.ogr_ara_b_Click);
            // 
            // ogr_ara_t
            // 
            this.ogr_ara_t.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogr_ara_t.Location = new System.Drawing.Point(10, 31);
            this.ogr_ara_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogr_ara_t.Multiline = true;
            this.ogr_ara_t.Name = "ogr_ara_t";
            this.ogr_ara_t.Size = new System.Drawing.Size(323, 43);
            this.ogr_ara_t.TabIndex = 0;
            this.ogr_ara_t.Text = "Telefon numarası giriniz\r\n";
            this.ogr_ara_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ogr_ara_t.Click += new System.EventHandler(this.ogr_ara_t_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Dikkat!";
            // 
            // sil_b
            // 
            this.sil_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sil_b.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_trash_100;
            this.sil_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sil_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sil_b.Location = new System.Drawing.Point(329, 538);
            this.sil_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sil_b.Name = "sil_b";
            this.sil_b.Size = new System.Drawing.Size(131, 120);
            this.sil_b.TabIndex = 29;
            this.toolTip1.SetToolTip(this.sil_b, "Silmek İstediğiniz Öğrencinin ID bilgisini girerek silme işlemini gerçekleştirebi" +
        "lirsiniz.\r\n");
            this.sil_b.UseVisualStyleBackColor = false;
            this.sil_b.Click += new System.EventHandler(this.sil_b_Click);
            // 
            // guncelle_b
            // 
            this.guncelle_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guncelle_b.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_available_updates_100;
            this.guncelle_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guncelle_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guncelle_b.Location = new System.Drawing.Point(184, 538);
            this.guncelle_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guncelle_b.Name = "guncelle_b";
            this.guncelle_b.Size = new System.Drawing.Size(126, 121);
            this.guncelle_b.TabIndex = 28;
            this.toolTip1.SetToolTip(this.guncelle_b, "Güncellemek istediğiniz Öğrencinin ID bilgisini girerek , gerekli işlemleri yapab" +
        "ilirsiniz");
            this.guncelle_b.UseVisualStyleBackColor = false;
            this.guncelle_b.Click += new System.EventHandler(this.guncelle_b_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.anasayfa.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_end_button_100;
            this.anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.Location = new System.Drawing.Point(1379, 63);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(124, 116);
            this.anasayfa.TabIndex = 32;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // tum_b
            // 
            this.tum_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tum_b.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_transaction_list_100;
            this.tum_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tum_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tum_b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tum_b.Location = new System.Drawing.Point(485, 538);
            this.tum_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tum_b.Name = "tum_b";
            this.tum_b.Size = new System.Drawing.Size(125, 120);
            this.tum_b.TabIndex = 30;
            this.toolTip2.SetToolTip(this.tum_b, "Tüm öğrencileri Görmek için tıklayınız.");
            this.tum_b.UseVisualStyleBackColor = false;
            this.tum_b.Click += new System.EventHandler(this.tum_b_Click);
            // 
            // ekle_b
            // 
            this.ekle_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ekle_b.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_add_100;
            this.ekle_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekle_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ekle_b.Location = new System.Drawing.Point(39, 538);
            this.ekle_b.Margin = new System.Windows.Forms.Padding(0);
            this.ekle_b.Name = "ekle_b";
            this.ekle_b.Size = new System.Drawing.Size(126, 120);
            this.ekle_b.TabIndex = 27;
            this.ekle_b.UseVisualStyleBackColor = false;
            this.ekle_b.Click += new System.EventHandler(this.ekle_b_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // ogrenci_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1516, 1002);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.ogrenci_listesi_d);
            this.Controls.Add(this.tum_b);
            this.Controls.Add(this.sil_b);
            this.Controls.Add(this.guncelle_b);
            this.Controls.Add(this.ekle_b);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ogrenci_islemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenci_islemleri";
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_listesi_d)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.DataGridView ogrenci_listesi_d;
        private System.Windows.Forms.Button tum_b;
        private System.Windows.Forms.Button sil_b;
        private System.Windows.Forms.Button guncelle_b;
        private System.Windows.Forms.Button ekle_b;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bolum_t;
        private System.Windows.Forms.TextBox numara_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim_t;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ogr_ara_b;
        private System.Windows.Forms.TextBox ogr_ara_t;
        private System.Windows.Forms.TextBox email_t;
        private System.Windows.Forms.TextBox adres_t;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}