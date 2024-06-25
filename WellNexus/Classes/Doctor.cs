using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Doctor : User
    {

        // variables

        public string Address { get; private set; }
        public int PhoneNummber { get; private set; }
        public List<Patient> Patients { get; private set; } = new List<Patient>();
        public List<TestResults> Results { get; private set; } = new List<TestResults>();
        public List<Message> Inbox { get; private set; } = new List<Message>();

        // constructor

        public Doctor(int id, string FirstName, string LastName, string Username, string Email, string Password, string Address, int PhoneNumber) : base(id, FirstName, LastName, Username, Email, Password)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.Address = Address;
            this.PhoneNummber = PhoneNumber;
        }

        // methods

    }
}
