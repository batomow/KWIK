using System.Collections.Generic;
using System.Linq;

namespace KWIK
{
    class Sorter : IStringListReceiver, IStringListSender
    {
        private List<string> data;

        private void Sort()
        {
            Console.WriteLine("Quieres Sorteo Normal o Inverso?(n/i)"); 
            string flag = Console.ReadLine(); 
            if(flag != "i"){
                data = data.OrderBy(d => d).ToList();
            }else{
                data = data.OrderByDescending(d => h).ToList();
            }
        }

        public List<string> GetData()
        {
            return data;
        }

        public void SetData(List<string> data)
        {
            this.data = data;

            Sort();
        }
    }
}
