using System;

namespace KWIK
{
    class Program
    {
        static void Main(string[] args)
        {
            InputReader inputReader = new InputReader();
            CircularShifter circularShifter = new CircularShifter();
            Sorter sorter = new Sorter();
            Printer printer = new Printer();

            StringListPipe stringListPipe1 = new StringListPipe(inputReader, circularShifter);
            StringListPipe stringListPipe2 = new StringListPipe(circularShifter, sorter);
            StringListPipe stringListPipe3 = new StringListPipe(sorter, printer);

            stringListPipe1.TransportData();
            stringListPipe2.TransportData();
            stringListPipe3.TransportData();

            Console.ReadLine();
        }
    }
}
