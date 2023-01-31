using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoTechLibrary;

namespace WinFormsApp1
{
	public partial class RandevuKayit : Form
	{
		public RandevuKayit()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			//Goz goz = new Goz(cmbGoz.SelectedItem.ToString());
			//Kulak kulak = new Kulak(cmbKulak.SelectedItem.ToString());
			//Burun burun = new Burun(cmbBurun.SelectedItem.ToString());
			//Kafa kafa = new Kafa(goz, kulak, burun);
			//YeniInsan yeniInsan = new YeniInsan(kafa, txtAdi.Text, txtSoyadi.Text);
		}

		private void RandevuKayit_Load(object sender, EventArgs e)
		{

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			

			if (txtAdi.Text.Length == 0)
			{
				MessageBox.Show("Lütfen Bir Ad Giriniz");
			}
			else if (txtSoyadi.Text.Length == 0)
			{
				MessageBox.Show("Lütfen Bir Soyad Giriniz");

			}

			else if (cmbBurun.Text == "" || cmbBurun.Text == "Seçiniz")
			{
				MessageBox.Show("Lütfen Bir Burun Seçiniz");
			}
			else if (cmbGoz.Text == "" || cmbGoz.Text == "Model Seçiniz")
			{
				MessageBox.Show("Lütfen Bir Goz Seçiniz");

			}
			else if (cmbKulak.Text== ""|| cmbKulak.Text == "Seçiniz")
			{
				MessageBox.Show("Lütfen Kapı Kulak Seçiniz");

			}
			else
			{
				label6.Text = "Kişini Adı : " + txtAdi.Text + ", Kişinin Soyadı : " + txtSoyadi.Text + ", Goz Rengi : " + cmbGoz.SelectedItem.ToString() + ", Kulak Şekli : " + cmbKulak.SelectedItem.ToString() + ", Burun Şekli : " + cmbBurun.SelectedItem.ToString();
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
