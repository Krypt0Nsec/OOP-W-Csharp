using OOP_NesneyeYönelikProgramlama_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NesneyeYönelikProgramlama_
{
    public class UsluCocuk : Cocuk, IAskereGit,IEhliyetAl

    {
        public void AskereGit(string _ad)
        {
            Console.WriteLine(_ad + " askere gidiyor");

        }

        public void EhliyetAl(string _ad)
        {
            Console.WriteLine(_ad + " ehliyet alıyor");
        }
    }
}
