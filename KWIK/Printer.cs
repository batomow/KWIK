using System;
using System.Collections.Generic;

namespace KWIK
{
    class Printer : IStringListReceiver, IStringListSender
    {
        private List<string> data;

        private void Print()
        {
            Console.WriteLine("Cuales lineas quiere remover?");  
            int counter = 1; 
            foreach(string line in data){
                Console.WriteLine(counter + "\t" + line); 
                counter++; 
            }
            List<int> indexes = new List<int>(); 
            int output; 
            while(Int.TryParse(ReadLine(), out output)){
                indexes.add(output); 
            }
            foreach(int index in indexes)
                data[index-1] = ""; 
            while(data.Contains(""))
                data.Remove(""); 
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
