using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Learning.Classes
{
    public class Client
    {
        private string Name { get; set; }
        private int Age { get; set; }

        private DateTime BornDate { get; set; }


        public Client(string name, int age , DateTime bornDate )
        {
            this.Name = name;
            this.Age = age;
            this.BornDate = bornDate;
        }

        public List<String> CreateCreds(string name, int age)
        {
            List<String> creds = new List<String>();
            creds.Add(name+DateTime.Now.Day.ToString()+DateTime.Now.Month.ToString()+DateTime.Now.Year.ToString());
            creds.Add(age.ToString());
            return creds;
        }
    }
}
