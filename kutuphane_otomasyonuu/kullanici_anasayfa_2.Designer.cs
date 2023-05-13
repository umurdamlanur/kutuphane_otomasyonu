namespace kutuphane_otomasyonuu
{
    partial class kullanici_anasayfa_2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combokod = new System.Windows.Forms.ComboBox();
            this.txtteslimalan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtteslimtarih = new System.Windows.Forms.DateTimePicker();
            this.dtalinantarih = new System.Windows.Forms.DateTimePicker();
            this.txtyazarad = new System.Windows.Forms.TextBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(386, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 348);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "aldığım kitaplar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(593, 308);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combokod);
            this.groupBox1.Controls.Add(this.txtteslimalan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtteslimtarih);
            this.groupBox1.Controls.Add(this.dtalinantarih);
            this.groupBox1.Controls.Add(this.txtyazarad);
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsayfa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtkad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 348);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kitap bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combokod
            // 
            this.combokod.FormattingEnabled = true;
            this.combokod.Items.AddRange(new object[] {
            "1",
            "2"});
            this.combokod.Location = new System.Drawing.Point(162, 52);
            this.combokod.Name = "combokod";
            this.combokod.Size = new System.Drawing.Size(197, 24);
            this.combokod.TabIndex = 7;
            this.combokod.SelectedIndexChanged += new System.EventHandler(this.combokod_SelectedIndexChanged);
            // 
            // txtteslimalan
            // 
            this.txtteslimalan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtteslimalan.Location = new System.Drawing.Point(162, 223);
            this.txtteslimalan.Name = "txtteslimalan";
            this.txtteslimalan.Size = new System.Drawing.Size(197, 22);
            this.txtteslimalan.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "teslim alan ad-soyad";
            // 
            // dtteslimtarih
            // 
            this.dtteslimtarih.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtteslimtarih.Location = new System.Drawing.Point(162, 195);
            this.dtteslimtarih.Name = "dtteslimtarih";
            this.dtteslimtarih.Size = new System.Drawing.Size(197, 22);
            this.dtteslimtarih.TabIndex = 18;
            // 
            // dtalinantarih
            // 
            this.dtalinantarih.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtalinantarih.Location = new System.Drawing.Point(162, 167);
            this.dtalinantarih.Name = "dtalinantarih";
            this.dtalinantarih.Size = new System.Drawing.Size(197, 22);
            this.dtalinantarih.TabIndex = 5;
            // 
            // txtyazarad
            // 
            this.txtyazarad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtyazarad.Location = new System.Drawing.Point(162, 108);
            this.txtyazarad.Name = "txtyazarad";
            this.txtyazarad.Size = new System.Drawing.Size(197, 22);
            this.txtyazarad.TabIndex = 17;
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btngüncelle.Location = new System.Drawing.Point(197, 274);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(117, 39);
            this.btngüncelle.TabIndex = 15;
            this.btngüncelle.Text = "bilgileri güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "aldığınız tarih";
            // 
            // txtsayfa
            // 
            this.txtsayfa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsayfa.Location = new System.Drawing.Point(162, 136);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(197, 22);
            this.txtsayfa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "kitabın sayfa sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "kitabın yazarı";
            // 
            // txtkad
            // 
            this.txtkad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkad.Location = new System.Drawing.Point(162, 80);
            this.txtkad.Name = "txtkad";
            this.txtkad.Size = new System.Drawing.Size(197, 22);
            this.txtkad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "kitabın adı";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Salmon;
            this.btnekle.Location = new System.Drawing.Point(57, 274);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(117, 39);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "bilgileri ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kitabın kodu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "teslim edeceğiniz tarih";
            // 
            // kullanici_anasayfa_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "kullanici_anasayfa_2";
            this.Text = "kullanici_anasayfa_2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtteslimalan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtteslimtarih;
        private System.Windows.Forms.DateTimePicker dtalinantarih;
        private System.Windows.Forms.TextBox txtyazarad;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combokod;
        private System.Windows.Forms.Label label5;
    }
}