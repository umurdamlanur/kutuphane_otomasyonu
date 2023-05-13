namespace kutuphane_otomasyonuu
{
    partial class anasayfa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtyayintarihi = new System.Windows.Forms.DateTimePicker();
            this.txtyazarad = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayineviadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayintarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblkitappBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphane_otomasyonuDataSet1 = new kutuphane_otomasyonuu.kutuphane_otomasyonuDataSet1();
            this.tblkitapbilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphane_otomasyonuDataSet = new kutuphane_otomasyonuu.kutuphane_otomasyonuDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbl_kitap_bilgileriTableAdapter = new kutuphane_otomasyonuu.kutuphane_otomasyonuDataSetTableAdapters.tbl_kitap_bilgileriTableAdapter();
            this.tbl_kitappTableAdapter = new kutuphane_otomasyonuu.kutuphane_otomasyonuDataSet1TableAdapters.tbl_kitappTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkitappBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane_otomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkitapbilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane_otomasyonuDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kitabın kodu";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnekle.Location = new System.Drawing.Point(135, 274);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(117, 39);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "bilgileri ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtyayintarihi);
            this.groupBox1.Controls.Add(this.txtyazarad);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.txtkonu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtyayinevi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsayfa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtkad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtkod);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kitap bilgileri";
            // 
            // dtyayintarihi
            // 
            this.dtyayintarihi.Location = new System.Drawing.Point(154, 190);
            this.dtyayintarihi.Name = "dtyayintarihi";
            this.dtyayintarihi.Size = new System.Drawing.Size(197, 22);
            this.dtyayintarihi.TabIndex = 5;
            // 
            // txtyazarad
            // 
            this.txtyazarad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtyazarad.Location = new System.Drawing.Point(154, 106);
            this.txtyazarad.Name = "txtyazarad";
            this.txtyazarad.Size = new System.Drawing.Size(197, 22);
            this.txtyazarad.TabIndex = 17;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Tomato;
            this.btnsil.Location = new System.Drawing.Point(211, 329);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(117, 39);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "bilgileri sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btngüncelle.Location = new System.Drawing.Point(63, 329);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(117, 39);
            this.btngüncelle.TabIndex = 15;
            this.btngüncelle.Text = "bilgileri güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // txtkonu
            // 
            this.txtkonu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkonu.Location = new System.Drawing.Point(154, 218);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(197, 22);
            this.txtkonu.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "kitabın konusu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "yayın tarihi";
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtyayinevi.Location = new System.Drawing.Point(154, 162);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.Size = new System.Drawing.Size(197, 22);
            this.txtyayinevi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "yayın evi adı";
            // 
            // txtsayfa
            // 
            this.txtsayfa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtsayfa.Location = new System.Drawing.Point(154, 134);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(197, 22);
            this.txtsayfa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "kitabın sayfa sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "kitabın yazarı";
            // 
            // txtkad
            // 
            this.txtkad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkad.Location = new System.Drawing.Point(154, 78);
            this.txtkad.Name = "txtkad";
            this.txtkad.Size = new System.Drawing.Size(197, 22);
            this.txtkad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "kitabın adı";
            // 
            // txtkod
            // 
            this.txtkod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkod.Location = new System.Drawing.Point(154, 50);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(197, 22);
            this.txtkod.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.kadDataGridViewTextBoxColumn,
            this.yazaradDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.yayineviadDataGridViewTextBoxColumn,
            this.yayintarihiDataGridViewTextBoxColumn,
            this.konusuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblkitappBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "kod";
            this.kodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.Width = 80;
            // 
            // kadDataGridViewTextBoxColumn
            // 
            this.kadDataGridViewTextBoxColumn.DataPropertyName = "k_ad";
            this.kadDataGridViewTextBoxColumn.HeaderText = "k_ad";
            this.kadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kadDataGridViewTextBoxColumn.Name = "kadDataGridViewTextBoxColumn";
            this.kadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazaradDataGridViewTextBoxColumn
            // 
            this.yazaradDataGridViewTextBoxColumn.DataPropertyName = "yazar_ad";
            this.yazaradDataGridViewTextBoxColumn.HeaderText = "yazar_ad";
            this.yazaradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazaradDataGridViewTextBoxColumn.Name = "yazaradDataGridViewTextBoxColumn";
            this.yazaradDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfasayisiDataGridViewTextBoxColumn
            // 
            this.sayfasayisiDataGridViewTextBoxColumn.DataPropertyName = "sayfa_sayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.HeaderText = "sayfa_sayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfasayisiDataGridViewTextBoxColumn.Name = "sayfasayisiDataGridViewTextBoxColumn";
            this.sayfasayisiDataGridViewTextBoxColumn.Width = 80;
            // 
            // yayineviadDataGridViewTextBoxColumn
            // 
            this.yayineviadDataGridViewTextBoxColumn.DataPropertyName = "yayinevi_ad";
            this.yayineviadDataGridViewTextBoxColumn.HeaderText = "yayinevi_ad";
            this.yayineviadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayineviadDataGridViewTextBoxColumn.Name = "yayineviadDataGridViewTextBoxColumn";
            this.yayineviadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayintarihiDataGridViewTextBoxColumn
            // 
            this.yayintarihiDataGridViewTextBoxColumn.DataPropertyName = "yayin_tarihi";
            this.yayintarihiDataGridViewTextBoxColumn.HeaderText = "yayin_tarihi";
            this.yayintarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayintarihiDataGridViewTextBoxColumn.Name = "yayintarihiDataGridViewTextBoxColumn";
            this.yayintarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // konusuDataGridViewTextBoxColumn
            // 
            this.konusuDataGridViewTextBoxColumn.DataPropertyName = "konusu";
            this.konusuDataGridViewTextBoxColumn.HeaderText = "konusu";
            this.konusuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konusuDataGridViewTextBoxColumn.Name = "konusuDataGridViewTextBoxColumn";
            this.konusuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblkitappBindingSource
            // 
            this.tblkitappBindingSource.DataMember = "tbl_kitapp";
            this.tblkitappBindingSource.DataSource = this.kutuphane_otomasyonuDataSet1;
            // 
            // kutuphane_otomasyonuDataSet1
            // 
            this.kutuphane_otomasyonuDataSet1.DataSetName = "kutuphane_otomasyonuDataSet1";
            this.kutuphane_otomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblkitapbilgileriBindingSource
            // 
            this.tblkitapbilgileriBindingSource.DataMember = "tbl_kitap_bilgileri";
            this.tblkitapbilgileriBindingSource.DataSource = this.kutuphane_otomasyonuDataSet;
            // 
            // kutuphane_otomasyonuDataSet
            // 
            this.kutuphane_otomasyonuDataSet.DataSetName = "kutuphane_otomasyonuDataSet";
            this.kutuphane_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 398);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".";
            // 
            // tbl_kitap_bilgileriTableAdapter
            // 
            this.tbl_kitap_bilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_kitappTableAdapter
            // 
            this.tbl_kitappTableAdapter.ClearBeforeFill = true;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "anasayfa";
            this.Text = "admin anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkitappBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane_otomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkitapbilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphane_otomasyonuDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtyazarad;
        private System.Windows.Forms.DateTimePicker dtyayintarihi;
        private kutuphane_otomasyonuDataSet kutuphane_otomasyonuDataSet;
        private System.Windows.Forms.BindingSource tblkitapbilgileriBindingSource;
        private kutuphane_otomasyonuDataSetTableAdapters.tbl_kitap_bilgileriTableAdapter tbl_kitap_bilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayineviadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayintarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konusuDataGridViewTextBoxColumn;
        private kutuphane_otomasyonuDataSet1 kutuphane_otomasyonuDataSet1;
        private System.Windows.Forms.BindingSource tblkitappBindingSource;
        private kutuphane_otomasyonuDataSet1TableAdapters.tbl_kitappTableAdapter tbl_kitappTableAdapter;
    }
}