using System;
using System.Collections.Generic;

namespace KWIK
{
    class Printer : IStringListReceiver, IStringListSender
    {
        private List<string> data;

        private void Print()
        {
            foreach(string s in data)
            {
                Console.WriteLine(s);
            }
        }

        public List<string> GetData()
        {
            return data;
        }

        public void SetData(List<string> data)
        {
            this.data = data;

            Print();
        }
    }
}
