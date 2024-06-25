using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Parent : User
    {

        // variables

        public string Address { get; set; }
        public bool ConsentGiven { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<TestResults> Results { get; set; } = new List<TestResults>();

        // constructor
        public Parent(int id, string FirstName, string LastName, string Username, string Email, string Password, string Address) : base(id, FirstName, LastName, Username, Email, Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.Address = Address;
            this.ConsentGiven = false;
        }

        // methods

        public void GiveConsent()
        {
            this.ConsentGiven = true;
        }

        public void AcceptExercise()
        {
            Console.WriteLine("Exercise accepted");
        }

        public void DeclineExercise()
        {
            Console.WriteLine("Exercise declined");
        }
    }
}
