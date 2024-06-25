using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class Test
    {

        // variables

        public int Id { get; set; }
        public DateTime TestDate { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

        // constructor

        public Test(int id, DateTime TestDate)
        {
            this.Id = id;
            this.TestDate = TestDate;
        }

        // methods

        public void SubmitTest(string ResultData)
        {
            TestResults testResults = new TestResults(this.Id, this.TestDate, ResultData);
        }
    }
}
