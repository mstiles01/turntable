using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void TestRadios(List<IRadio> radios) {
            foreach(IRadio radio in radios) {
                radio.TurnRadio();
                radio.TurnRadio();
            }
        }
    }
}
