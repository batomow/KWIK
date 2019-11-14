using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWIK
{
    class StringListPipe
    {
        private IStringListSender sender;
        private IStringListReceiver receiver;

        public StringListPipe(IStringListSender sender, IStringListReceiver receiver)
        {
            this.sender = sender;
            this.receiver = receiver;
        }

        public void TransportData()
        {
            receiver.SetData(sender.GetData());
        }
    }
}
