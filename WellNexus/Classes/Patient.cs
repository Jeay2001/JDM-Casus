using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Patient : User
    {
        // variables

        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> Appointments = new List<string>();
        public List<TestResults> Testresults = new List<TestResults>();

        // constructor

        public Patient(int id, string FirstName, string LastName, string Username, string Email, string Password, DateTime DateOfBirth) : base(id, FirstName, LastName, Username, Email, Password)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
            this.DateOfBirth = DateOfBirth;
        }
    }
}
