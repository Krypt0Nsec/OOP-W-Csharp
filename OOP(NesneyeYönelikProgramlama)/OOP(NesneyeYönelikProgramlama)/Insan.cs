using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class Insan
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public double Maas;
        public bool Cinsiyet;
        public int Dogumyılı;
        public static int Boy;

        public void Uyu(string _ad, string _soyad)
        {
            Console.WriteLine(_ad+ " " +_soyad+" Uyuyor");
        }

        public static int YasHesaplama(int _yas)
        {
            int gercekyas = 0;
            gercekyas = 2023 - _yas;
            Console.WriteLine(gercekyas);
            return gercekyas;
        }

        public void Mesaj(string _ad, string _soyad)
        {
            Console.WriteLine("Kişinin Adı "+ _ad + " Kişinin Soyadı "+ _soyad);

        }

        //boş Constructor
        public Insan()
        {

        }
		//parametre alan Constructor
		public Insan(string _ad)
        {
            Ad = _ad;
        }

		//Parametre alan Constructor
		public Insan(string _ad, string _soyad)
        {
            Ad = _ad;
            Soyad = _soyad;
        }
        public Insan(string _ad, string _soyad, int _yas, double _maas, bool _cinsiyet)
        {
            Ad = _ad;
            Soyad = _soyad;
            Yas = _yas;
            Maas = _maas;
            Cinsiyet= _cinsiyet;
        }
    }
}
    
