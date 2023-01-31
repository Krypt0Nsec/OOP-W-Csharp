using OOP_NesneyeYönelikProgramlama_.Interfaces.InterfacesSirket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Sirket
{
	//abstract class lardan türeyen classlar mutlaka
	//eğer abstract ile başlayan merorlar var ise içlerini doldurmak zorundadırlar
	// tıpkı interface lerde olduğu gibi
	public class GenelMudur : Personel
	{
		public void MaasHesapla(double _maas)
		{
			double sonuc = 0;
			sonuc = _maas;
			Console.WriteLine(sonuc);
		}

	}
}
