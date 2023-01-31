using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTechLibrary
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
	}
}
