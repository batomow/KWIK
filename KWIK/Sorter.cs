using System.Collections.Generic;
using System.Linq;

namespace KWIK
{
    class Sorter : IStringListReceiver, IStringListSender
    {
        private List<string> data;

        private void Sort()
        {
            data = data.OrderBy(d => d).ToList();
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
