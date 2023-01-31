namespace WinFormsApp1
{
	partial class ArabaKayitFormu
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbMarka = new System.Windows.Forms.ComboBox();
			this.cmbModel = new System.Windows.Forms.ComboBox();
			this.txtKapiSayisi = new System.Windows.Forms.TextBox();
			this.txtUretimYili = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.lblSonuc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Markası :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(97, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Modeli :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(97, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kapı Sayısı:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(97, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Üretim Yılı :";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// cmbMarka
			// 
			this.cmbMarka.FormattingEnabled = true;
			this.cmbMarka.Items.AddRange(new object[] {
            "Seçiniz",
            "Bmw",
            "Mercedes",
            "Porche"});
			this.cmbMarka.Location = new System.Drawing.Point(192, 96);
			this.cmbMarka.Name = "cmbMarka";
			this.cmbMarka.Size = new System.Drawing.Size(121, 23);
			this.cmbMarka.TabIndex = 7;
			this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// cmbModel
			// 
			this.cmbModel.FormattingEnabled = true;
			this.cmbModel.Items.AddRange(new object[] {
            ""});
			this.cmbModel.Location = new System.Drawing.Point(192, 136);
			this.cmbModel.Name = "cmbModel";
			this.cmbModel.Size = new System.Drawing.Size(121, 23);
			this.cmbModel.TabIndex = 8;
			this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
			// 
			// txtKapiSayisi
			// 
			this.txtKapiSayisi.Location = new System.Drawing.Point(192, 172);
			this.txtKapiSayisi.Name = "txtKapiSayisi";
			this.txtKapiSayisi.Size = new System.Drawing.Size(121, 23);
			this.txtKapiSayisi.TabIndex = 9;
			this.txtKapiSayisi.TextChanged += new System.EventHandler(this.txtKapiSayisi_TextChanged);
			// 
			// txtUretimYili
			// 
			this.txtUretimYili.Location = new System.Drawing.Point(192, 211);
			this.txtUretimYili.Name = "txtUretimYili";
			this.txtUretimYili.Size = new System.Drawing.Size(121, 23);
			this.txtUretimYili.TabIndex = 10;
			this.txtUretimYili.TextChanged += new System.EventHandler(this.txtUretimYili_TextChanged);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(238, 261);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 11;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// lblSonuc
			// 
			this.lblSonuc.AutoSize = true;
			this.lblSonuc.Location = new System.Drawing.Point(97, 328);
			this.lblSonuc.Name = "lblSonuc";
			this.lblSonuc.Size = new System.Drawing.Size(49, 15);
			this.lblSonuc.TabIndex = 12;
			this.lblSonuc.Text = "Sonuç : ";
			this.lblSonuc.Click += new System.EventHandler(this.label5_Click);
			// 
			// ArabaKayitFormu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblSonuc);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtUretimYili);
			this.Controls.Add(this.txtKapiSayisi);
			this.Controls.Add(this.cmbModel);
			this.Controls.Add(this.cmbMarka);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ArabaKayitFormu";
			this.Text = "ArabaKayitFormu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox cmbMarka;
		private ComboBox cmbModel;
		private TextBox txtKapiSayisi;
		private TextBox txtUretimYili;
		private Button btnKaydet;
		private Label lblSonuc;
	}
}