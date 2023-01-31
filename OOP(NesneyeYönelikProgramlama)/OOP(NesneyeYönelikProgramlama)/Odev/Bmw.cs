using OOP_NesneyeYönelikProgramlama_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Odev
{
	public class Bmw : Araba, IArabaOzellik
	{
		public void CokHizli(string _ad)
		{
			Console.WriteLine(_ad + " Cok hizli gidiyor");
		}

		public void DenizdeYuz(string _ad)
		{
			Console.WriteLine(_ad + " Denizde Yüzüyor");
		}

		public void HavadaUc(string _ad)
		{
			Console.WriteLine(_ad + " Havada Ucuyor");
		}
	}
}
