using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class Cocuk : Insan
    {
        public string Sifat;
        public string Eylem;
        public string Is;

        public void CocukMesaj(string _Ad, string _Soyad, string _Sifat)
        {
            Console.WriteLine(_Ad + " " + _Soyad + " " + _Sifat);
        }
    }
}
