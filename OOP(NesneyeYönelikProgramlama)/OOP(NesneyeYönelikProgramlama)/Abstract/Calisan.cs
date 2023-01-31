using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Abstract
{
	//abstract class lardan türeyen classlar mutlaka
	//eğer abstract ile başlayan merorlar var ise içlerini doldurmak zorundadırlar
	// tıpkı interface lerde olduğu gibi
	public abstract class Calisan
	{
		//bu classtan türeyen tüm classlar abstract ile başlayan metotları implement etmek zorundadırlar
		public abstract int MaasinizNedir();

		public void MesaiyeBasla()
		{

		}
	}
}
