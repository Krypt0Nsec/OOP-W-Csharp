using OOP_NesneyeYönelikProgramlama_.Interfaces.InterfacesSirket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Sirket
{
	public class Stajyer : Personel, IMaasHesapla
	{
		public void MaasHesapla(double _maas)
		{
			double sonuc = 0;
			sonuc = _maas;
			Console.WriteLine(sonuc);
		}

	}
}
