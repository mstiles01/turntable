using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    class Program
    {
        static void Main(string[] args) {
       Radio aRadio = new Radio();
        Radio anotherRadio = new Radio();
        AllinOne AllinOneMachine = new AllinOne();
        AllinOne AnotherAllinOneMachine = new AllinOne();

        List<IRadio> IRadioList = new List<IRadio>() {
            aRadio,
            anotherRadio,
            AllinOneMachine,
            AnotherAllinOneMachine
        };
    }

    static void TestRadios(List<IRadio> radios) {
        foreach (IRadio radio in radios) {
            radio.TurnRadio();
            radio.TurnOff();
        }
    }

    static void TestTurnTables(List<ITurnTable> turnTables) {
        foreach (ITurnTable turnTable in turnTables) {
            turnTable.Play();
            turnTable.Stop();

        }
    }
    }
}
