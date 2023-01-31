using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class ArabaKayitFormu : Form
	{
		string seciliOlanMarka = "";
		string seciliOlanModel = "";
		public ArabaKayitFormu()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			seciliOlanMarka = cmbMarka.SelectedItem.ToString();
			cmbModel.Items.Clear();
			
			if (seciliOlanMarka == "Bmw")
			{
				cmbModel.Items.Add("Model Seçiniz");
				cmbModel.Items.Add("x5");
				cmbModel.Items.Add("x6");
			}
			else if (seciliOlanMarka == "Mercedes")
			{
				cmbModel.Items.Add("Model Seçiniz");
				cmbModel.Items.Add("XL");
				cmbModel.Items.Add("ML");
			}
			else if (seciliOlanMarka == "Porche")
			{
				cmbModel.Items.Add("Model Seçiniz");
				cmbModel.Items.Add("Carrera");
				cmbModel.Items.Add("Kurşuni Gri");

			}
			else
			{
				cmbModel.Items.Add("Model Seçiniz");

			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (cmbMarka.Text == "" || cmbMarka.Text == "Seçiniz")
			{
				MessageBox.Show("Lütfen Bir Marka Seçiniz");
			}
			else if (cmbModel.Text == "" || cmbModel.Text=="Model Seçiniz")
			{
				MessageBox.Show("Lütfen Bir Model Seçiniz");

			}
			else if (txtKapiSayisi.Text.Length == 0)
			{
				MessageBox.Show("Lütfen Kapı Sayısı Giriniz");

			}
			else if (txtUretimYili.Text.Length == 0)
			{
				MessageBox.Show("Lütfen Üretim Yılını Giriniz");

			}
			else
			{
				lblSonuc.Text = "Seçili Olan Marka : " + seciliOlanMarka + ", Seçili Olan Model : " + seciliOlanModel + ", Kapı Sayısı : " + txtKapiSayisi.Text + ", Üretim Yılı : " + txtUretimYili.Text;
			}

		}

		private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			seciliOlanModel = cmbModel.SelectedItem.ToString();
		}

		private void txtKapiSayisi_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtUretimYili_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
			
		}
	}
}
