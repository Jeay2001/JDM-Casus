using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Message
    {

        // variables

        public int Id { get; private set; }
        public string Text { get; private set; }
        public bool Seen { get; private set; }
        public DateTime Datesent { get; private set; }
        public int SenderId { get; private set; }
        public int ReceiverId { get; private set; }

        //constructor

        public Message(int id, string Text, int SenderId, int ReceiverId)
        {
            this.Id = id;
            this.Text = Text;
            this.Seen = false;
            this.Datesent = DateTime.Today;
            this.SenderId = SenderId;
            this.ReceiverId = ReceiverId;
        }

        // Methods

        public void SendMessage(string Message)
        {
            Console.WriteLine("Message sent");
        }

        public void SelectMessage(int Id)
        {
            Console.WriteLine("Message selected");
        }

        public void GetAllMessages()
        {
            Console.WriteLine("All messages selected");
        }

    }
}
