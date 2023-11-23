using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecFlow_Learning.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning
{
    public class Program 
    {
        //public Program(ScenarioContext scenarioContext) : base(scenarioContext) { }        

        public static void Main(string[] args)
        {                        
        }


        [Test]
        public void testingDictionary()
        {
            Dictionary<String, int> pessoaIdade = new Dictionary<string, int>();
            pessoaIdade.Add("Murillo", 26);
            pessoaIdade.Add("Laryssa", 23);

            Debug.WriteLine(pessoaIdade);
            Console.WriteLine(pessoaIdade);
        }

        [Test]
        public void testingTuple()
        {
            Tuple<string, string, string> meuNome = new Tuple<string, string, string>("", "", "");

            (List<string> nome, List<double> salário) empregados = (new List<string>(), new List<double>());
            empregados.nome.Add("Murillo");
            empregados.salário.Add(8500.0);

            Console.WriteLine(empregados);
            var nome = empregados.nome.ElementAt(0).ToString();
            var salario = empregados.salário.ElementAt(0).ToString();

            Debug.WriteLine(nome);
            Debug.WriteLine(salario);


        }









        /*
        #region Hooks
        [SetUp]
        public void SetUp()
        {            
            page.LoadBrowser();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            //getDriver().Close();
            //getDriver().Quit();
        }
        #endregion


        #region Tests
        [Test]
        public void SelectingRadioButtons()
        {            
            //Clicking on a specific radio button, throught it's text
            page.SelectRadioButton("other");           
        }

        [Test]
        public void SelectingDropdown()
        {                                   
            page.SelectDropdown();             
        }
        #endregion
    }*/
    }
}

