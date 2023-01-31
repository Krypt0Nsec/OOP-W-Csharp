using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class Insan
    {
        public static int YasHesaplama(int _yas)
        {
            int gercekyas = 0;
            gercekyas = 2023 - _yas;
            Console.WriteLine(gercekyas);
            return gercekyas;
        }
    }
}
    
