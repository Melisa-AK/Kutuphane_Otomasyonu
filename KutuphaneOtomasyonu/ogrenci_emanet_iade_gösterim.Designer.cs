
namespace KutuphaneOtomasyonu
{
    partial class ogrenci_emanet_iade_gösterim
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
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.anasayfa.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.icons8_home_100;
            this.anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.Location = new System.Drawing.Point(1287, 24);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(122, 114);
            this.anasayfa.TabIndex = 14;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // yukleme_btn
            // 
            this.yukleme_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.yukleme_btn.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yukleme_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yukleme_btn.Location = new System.Drawing.Point(489, 298);
            this.yukleme_btn.Margin = new System.Windows.Forms.Padding(4);
            this.yukleme_btn.Name = "yukleme_btn";
            this.yukleme_btn.Size = new System.Drawing.Size(273, 58);
            this.yukleme_btn.TabIndex = 13;
            this.yukleme_btn.Text = "Tüm Kayıtlar";
            this.yukleme_btn.UseVisualStyleBackColor = false;
            this.yukleme_btn.Click += new System.EventHandler(this.yukleme_btn_Click);
            // 
            // liste_d
            // 
            this.liste_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liste_d.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.liste_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_d.Location = new System.Drawing.Point(13, 364);
            this.liste_d.Margin = new System.Windows.Forms.Padding(4);
            this.liste_d.Name = "liste_d";
            this.liste_d.RowHeadersWidth = 51;
            this.liste_d.Size = new System.Drawing.Size(749, 402);
            this.liste_d.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.arama_btn);
            this.groupBox1.Controls.Add(this.giris_t);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(732, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade edilen kitap";
            // 
            // arama_btn
            // 
            this.arama_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.arama_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.arama_btn.Location = new System.Drawing.Point(301, 92);
            this.arama_btn.Margin = new System.Windows.Forms.Padding(4);
            this.arama_btn.Name = "arama_btn";
            this.arama_btn.Size = new System.Drawing.Size(224, 47);
            this.arama_btn.TabIndex = 4;
            this.arama_btn.Text = "Arama Yap";
            this.arama_btn.UseVisualStyleBackColor = false;
            this.arama_btn.Click += new System.EventHandler(this.arama_btn_Click);
            // 
            // giris_t
            // 
            this.giris_t.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_t.Location = new System.Drawing.Point(213, 41);
            this.giris_t.Margin = new System.Windows.Forms.Padding(4);
            this.giris_t.Name = "giris_t";
            this.giris_t.Size = new System.Drawing.Size(403, 27);
            this.giris_t.TabIndex = 3;
            this.giris_t.Text = "Arama yapılacak öğrencinin numarası";
            this.giris_t.Click += new System.EventHandler(this.giris_t_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Numarası:";
            // 
            // ogrenci_emanet_iade_gösterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.emanetkitap1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1508, 805);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.yukleme_btn);
            this.Controls.Add(this.liste_d);
            this.Controls.Add(this.groupBox1);
            this.Name = "ogrenci_emanet_iade_gösterim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogrenci_emanet_iade_gösterim";
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}