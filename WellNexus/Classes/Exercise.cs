using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    public class Exercise
    {

        // variables

        public int Id { get; set; }
        public string Name { get; set; }
        public int number { get; set; }

        // constructor

        public Exercise(int id, string Name, int number)
        {
            this.Id = id;
            this.Name = Name;
            this.number = number;
        }

        // Methods

        public void StartExercise(int Id)
        {
            Console.WriteLine("Exercise started");
        }
    }
}
