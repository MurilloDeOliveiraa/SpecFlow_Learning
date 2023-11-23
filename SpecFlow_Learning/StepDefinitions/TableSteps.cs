using SpecFlow_Learning.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using Gherkin;

namespace SpecFlow_Learning.StepDefinitions
{
    [Binding]
    public class TableSteps
    {
        public readonly Person person;

        public TableSteps(Person person)
        {
            this.person=person;
        }

        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            Console.WriteLine("LOGIN PAGE");
        }

        [Given(@"I type my credentials")]        
        public void GivenITypeMyCredentials(Table table)
        {
            // Para pegar dados de apenas de uma tabela com 1 linha
            /*
            Person personDetails = table.CreateInstance<Person>();
            Console.WriteLine(personDetails.username);
            Console.WriteLine(personDetails.password);
            */
            //=======================================================================================
            //Para pegar dados de uma tabela com várias linhas
            /*
            var datas = table.CreateSet<Person>();

            foreach (var person in datas)
            {
                Console.WriteLine(person.username);
                Console.WriteLine(person.password);
                Console.WriteLine("================");
            }*/
            //=======================================================================================
            //Work with Dynamic Assist
            /*
            var details = table.CreateDynamicSet();

            foreach (var person in details)
            {
                Console.WriteLine(person.username);
                Console.WriteLine(person.password);
                Console.WriteLine("================");
            }*/
            //=======================================================================================
            //Changing context using the same step in 2 scenarios 
            var list = table.Rows.ToList();
            var fieldKeys = list[0].Keys.ElementAt(0).ToString();
            var fieldValues = list[0].Values.ElementAt(0).ToString();
            int idadeMurillo = 26, idadeLaryssa = 23;

            string resultado = idadeMurillo >= idadeLaryssa ? "Murillo é mais velho" : "Laryssa é mais velha";
            var data = table.CreateDynamicSet();

            //foreach (var item in data)
            //{
            //    person.username = item.username;
            //    person.password = Convert.ToString(item.password);
            //    //string murillo = typeof(123);
            //}



        }                

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            Console.WriteLine("LOGIN BUTTON");
        }

        [Then(@"I navigate to the home page")]
        public void ThenINavigateToTheHomePage()
        {
            Console.WriteLine("HOME PAGE");
        }

        [Given(@"I type (.*) and (.*)")]
        public void GivenITypeMyMurilloAnd(string username, string password)
        {
            Console.WriteLine("username = " + username);
            Console.WriteLine("password = " + password);


        }

        public class Murillo 
        {
            public int wear { get; set; }
            public int spell { get; set; }
        }


    }
}
