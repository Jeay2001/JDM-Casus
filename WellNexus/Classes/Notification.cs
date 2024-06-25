using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Notification
    {
        // variables
        public int Id { get; set; }
        public string Message { get; set; }
        public bool Seen { get; set; }
        public DateTime Datesent { get; set; }

        //constructor

        public Notification(int id, string Message)
        {
            this.Id = id;
            this.Message = Message;
            this.Seen = false;
            this.Datesent = DateTime.Today;
        }



    }
}
