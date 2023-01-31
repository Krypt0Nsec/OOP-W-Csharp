using OOP_NesneyeYönelikProgramlama_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class AkilliCocuk : Cocuk, IAskereGit, IEhliyetAl, IClubeGit
    {
        //multiple inheritance mümkün interface ile yapabiliriz ama bir class ı birden fazla classtan türetemeyiz
        public void AskereGit(string _ad)
        {
            Console.WriteLine(_ad + " askere gidiyor");

        }

        public void ClubeGit(string _ad)
        {
            Console.WriteLine(_ad + " Clube gidiyor");

        }

        public void EhliyetAl(string _ad)
        {
            Console.WriteLine(_ad + " ehliyet alıyor");
        }
    }
}
