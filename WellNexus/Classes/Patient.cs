using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    public class Patient : User
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
        public void StarTest()
        {
            Test test = new Test(this.Id, DateTime.Now);

            for (int i = 0; i < 14; i++)
            {
                Exercise exercise = new Exercise(i, "Exercise", i);
                test.Exercises.Add(exercise);
            }

        }

        public void GetTestResult()
        {
            TestResults testResult = new TestResults(1, DateTime.Now, "");
            testResult.SeeResult();
        }

    }
}
