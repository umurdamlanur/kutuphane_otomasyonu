namespace kutuphane_otomasyonuu
{
    partial class giris_sayfasi_1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkullanicigirisi = new System.Windows.Forms.Button();
            this.txtkullanicisifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadmingirisi = new System.Windows.Forms.Button();
            this.txtadminsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadminad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kütüphaneye hoşgeldiniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkullanicigirisi);
            this.groupBox1.Controls.Add(this.txtkullanicisifre);
            this.groupBox1.Controls.Add(this.txtkullaniciad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(176, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kullanıcı girişi";
            // 
            // btnkullanicigirisi
            // 
            this.btnkullanicigirisi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnkullanicigirisi.Location = new System.Drawing.Point(63, 130);
            this.btnkullanicigirisi.Name = "btnkullanicigirisi";
            this.btnkullanicigirisi.Size = new System.Drawing.Size(80, 30);
            this.btnkullanicigirisi.TabIndex = 4;
            this.btnkullanicigirisi.Text = "giriş";
            this.btnkullanicigirisi.UseVisualStyleBackColor = false;
            this.btnkullanicigirisi.Click += new System.EventHandler(this.btnkullanicigirisi_Click);
            // 
            // txtkullanicisifre
            // 
            this.txtkullanicisifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkullanicisifre.Location = new System.Drawing.Point(92, 86);
            this.txtkullanicisifre.Name = "txtkullanicisifre";
            this.txtkullanicisifre.Size = new System.Drawing.Size(100, 22);
            this.txtkullanicisifre.TabIndex = 3;
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkullaniciad.Location = new System.Drawing.Point(92, 47);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(100, 22);
            this.txtkullaniciad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "kullanıcı adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnadmingirisi);
            this.groupBox2.Controls.Add(this.txtadminsifre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtadminad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(382, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "admin girişi";
            // 
            // btnadmingirisi
            // 
            this.btnadmingirisi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnadmingirisi.Location = new System.Drawing.Point(63, 130);
            this.btnadmingirisi.Name = "btnadmingirisi";
            this.btnadmingirisi.Size = new System.Drawing.Size(80, 30);
            this.btnadmingirisi.TabIndex = 9;
            this.btnadmingirisi.Text = "giriş";
            this.btnadmingirisi.UseVisualStyleBackColor = false;
            this.btnadmingirisi.Click += new System.EventHandler(this.btnadmingirisi_Click);
            // 
            // txtadminsifre
            // 
            this.txtadminsifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtadminsifre.Location = new System.Drawing.Point(92, 86);
            this.txtadminsifre.Name = "txtadminsifre";
            this.txtadminsifre.Size = new System.Drawing.Size(100, 22);
            this.txtadminsifre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "kullanıcı adı:";
            // 
            // txtadminad
            // 
            this.txtadminad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtadminad.Location = new System.Drawing.Point(92, 47);
            this.txtadminad.Name = "txtadminad";
            this.txtadminad.Size = new System.Drawing.Size(100, 22);
            this.txtadminad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "şifre:";
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnkayıtol.Location = new System.Drawing.Point(166, 30);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(80, 30);
            this.btnkayıtol.TabIndex = 5;
            this.btnkayıtol.Text = "kayıt ol!";
            this.btnkayıtol.UseVisualStyleBackColor = false;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnkayıtol);
            this.groupBox3.Location = new System.Drawing.Point(176, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "hesabınız yok ise kaydolun!";
            // 
            // giris_sayfasi_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "giris_sayfasi_1";
            this.Text = "giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkullanicigirisi;
        private System.Windows.Forms.TextBox txtkullanicisifre;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnadmingirisi;
        private System.Windows.Forms.TextBox txtadminsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadminad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkayıtol;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

