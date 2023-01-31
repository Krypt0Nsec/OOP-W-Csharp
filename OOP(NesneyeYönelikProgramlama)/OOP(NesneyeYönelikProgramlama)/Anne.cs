using OOP_NesneyeYönelikProgramlama_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class Anne : Insan,IOzellik,IOzellik2
    {
        public void Oku(string adi)
        {
            Console.WriteLine(adi + " okuyor...");

        }

        public void Yaz(string adi)
        {
            Console.WriteLine(adi + " Yazıyor...");
        }
    }
}
