using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class Matematik
    {
        //Geriye int tipinde değer dönen
        //2 tane inte tiğinde parametre alan 
        //adı topla bir metot tanımı yapıyoruz
        //access modifiers geridönüştipi metodadi()
        
        public int Topla(int Sayi1, int Sayi2)
        {
            int toplam = 0;
            toplam = Sayi1 + Sayi2;
            Console.WriteLine(toplam);
            return toplam;
        }

        public int Cikar(int Sayi1, int Sayi2)
        {
            int sonuc = 0;
            sonuc = Sayi1 - Sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
        public int Carpma(int Sayi1, int Sayi2)
        {
            int sonuc = 1;
            sonuc = Sayi1 * Sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
        public int Bolme(int Sayi1, int Sayi2)
        {
            int sonuc = 1;
            sonuc = Sayi1 / Sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
    }
}
