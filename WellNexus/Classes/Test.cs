using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    public class Test
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
        public void StartExcerise()
        {
            Exercise exercise = new Exercise(this.Id, "Exercise", 1);
            exercise.Start(this.Id);
        }
        public void SubmitTest(string ResultData)
        {
            TestResults testResults = new TestResults(this.Id, this.TestDate, ResultData);
        }
        public void StartTimerTest() { }
        public void StopTimer() { }
        public void Submit() { }
        public void StartFirstExercise() { }
        public void SetInProgress() { }
        public void SeeResult() { }
        public void StartNextExercise() { }
        public void GivePermission() { }

    }
}
