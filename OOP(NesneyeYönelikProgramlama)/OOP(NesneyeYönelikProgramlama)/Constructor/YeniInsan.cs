using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Constructor
{
	public class YeniInsan
	{
		public string Ad;
		public string Soyad;
		public Kafa kafa;

		public YeniInsan(Kafa kafa, string Ad, string Soyad)
		{
			this.kafa = kafa;
			this.Ad = Ad;
			this.Soyad = Soyad;
		}

		public void Yaz()
		{
			Console.WriteLine("Kişinin Adı : "+ Ad + ", Kişinin Soyadı : " + Soyad + ", Göz Rengi : "+ kafa.goz.Renk +", burnu : "+ kafa.burun.Sekil + ", Kulağı : "+ kafa.kulak.Sekil);
		}
	}
}
