using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_.Odev
{
    public class Araba
    { //başlangıç scope u
        public string Marka;
        public string Model;
        public int ModelYili;
        public int KapiSayisi;

        //Dışarıdan string parametre alan adı Git
        //olan ve geriye değer döndürmeye bit metot tanımladık
        //access modifiers geridönüştipi (void) metodAdı()

        public void Git(string _Marka, string _Model)
        {
            Console.WriteLine(_Marka + " " + _Model + " Gidiyor");
        }

        public void Odev(string _Marka, string _Model)
        {
            Console.WriteLine("Arabanın Markası "+_Marka + " Arabanın Modeli " + _Model );
        }
    }// bitiş scope u

}
