using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Reply
    {

        // variables

        public int Id { get; private set; }
        public string Message { get; private set; }
        public int messageId { get; private set; }

        // constructor

        public Reply(int id, string Message, int messageId)
        {
            this.Id = id;
            this.Message = Message;
            this.messageId = messageId;
        }

        // Methods

        public void SendReply(int Id)
        {
            Console.WriteLine("Reply sent");
        }
    }
}
