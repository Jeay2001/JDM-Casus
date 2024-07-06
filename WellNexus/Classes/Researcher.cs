using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    public class Researcher : User
    {

        // variables

        public List<Patient> Patients { get; private set; } = new List<Patient>();
        public List<TestResults> Results { get; private set; } = new List<TestResults>();

        // constructor

        public Researcher(int id, string FirstName, string LastName, string Username, string Email, string Password) : base(id, FirstName, LastName, Username, Email, Password)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }

        // methods
        
    }
}
