using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    public abstract class User
    {
        // variables

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> notifications = new List<string>();

        //constructor

        public User(int id, string FirstName, string LastName, string Username, string Email, string Password)
        {
            this.Id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }

        //methods

        public void login(string Username, string Password)
        {
            if (this.Username == Username && this.Password == Password)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
    }
}
