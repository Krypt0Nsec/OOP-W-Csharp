namespace WinFormsApp1
{
	partial class RandevuKayit
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbGoz = new System.Windows.Forms.ComboBox();
			this.cmbKulak = new System.Windows.Forms.ComboBox();
			this.cmbBurun = new System.Windows.Forms.ComboBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(181, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad : ";
			// 
			// txtAdi
			// 
			this.txtAdi.Location = new System.Drawing.Point(269, 103);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.Size = new System.Drawing.Size(121, 23);
			this.txtAdi.TabIndex = 1;
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.Location = new System.Drawing.Point(269, 148);
			this.txtSoyadi.Name = "txtSoyadi";
			this.txtSoyadi.Size = new System.Drawing.Size(121, 23);
			this.txtSoyadi.TabIndex = 3;
			this.txtSoyadi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(181, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Soyad : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(181, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Göz Rengi : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(181, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Kulak Şekli : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(181, 284);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Burun Şekli : ";
			// 
			// cmbGoz
			// 
			this.cmbGoz.FormattingEnabled = true;
			this.cmbGoz.Items.AddRange(new object[] {
            "Seçiniz",
            "Ela",
            "Yeşil",
            "Mavi",
            "Kahve Rengi"});
			this.cmbGoz.Location = new System.Drawing.Point(269, 192);
			this.cmbGoz.Name = "cmbGoz";
			this.cmbGoz.Size = new System.Drawing.Size(121, 23);
			this.cmbGoz.TabIndex = 7;
			// 
			// cmbKulak
			// 
			this.cmbKulak.FormattingEnabled = true;
			this.cmbKulak.Items.AddRange(new object[] {
            "Seçiniz",
            "Kepçe",
            "Kucuk Memeli",
            "Buyuk Memeli"});
			this.cmbKulak.Location = new System.Drawing.Point(269, 236);
			this.cmbKulak.Name = "cmbKulak";
			this.cmbKulak.Size = new System.Drawing.Size(121, 23);
			this.cmbKulak.TabIndex = 8;
			// 
			// cmbBurun
			// 
			this.cmbBurun.FormattingEnabled = true;
			this.cmbBurun.Items.AddRange(new object[] {
            "Seçiniz",
            "Uzun",
            "Kısa",
            "Kaydırak"});
			this.cmbBurun.Location = new System.Drawing.Point(269, 281);
			this.cmbBurun.Name = "cmbBurun";
			this.cmbBurun.Size = new System.Drawing.Size(121, 23);
			this.cmbBurun.TabIndex = 9;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(299, 331);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(91, 23);
			this.btnKaydet.TabIndex = 10;
			this.btnKaydet.Text = "Randevu Kayıt";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(181, 388);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Eklenen Kayıt : ";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// RandevuKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.cmbBurun);
			this.Controls.Add(this.cmbKulak);
			this.Controls.Add(this.cmbGoz);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSoyadi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAdi);
			this.Controls.Add(this.label1);
			this.Name = "RandevuKayit";
			this.Text = "RandevuKayit";
			this.Load += new System.EventHandler(this.RandevuKayit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox txtAdi;
		private TextBox txtSoyadi;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ComboBox cmbGoz;
		private ComboBox cmbKulak;
		private ComboBox cmbBurun;
		private Button btnKaydet;
		private Label label6;
	}
}