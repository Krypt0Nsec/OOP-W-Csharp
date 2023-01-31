using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Sirket
{
	public class Personel
	{

		public string Ad;
		public string Soyad;
		public int Yas;
		public double Maas;
		public bool Cinsiyet;
		public int Dogumyılı;
		public static int Boy;
		public string Pozisyon;

		public void Hesapla(double maas)
		{
			double sonuc = 0;
			sonuc = maas;
			Console.WriteLine("Toplam Maas: "+sonuc);
		}
	}
}
