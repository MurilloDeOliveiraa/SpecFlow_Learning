using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning.StepDefinitions
{
    [Binding]
    public class LoginSteps2
    {
        [Given(@"I am in the login page")]
        public void GivenIAmInTheLoginPage()
        {
            
        }

        [When(@"I type my credentials")]
        [Scope(Feature = "UserLogin")]       
        public void WhenITypeMyUserCredentials()
        {
            Console.WriteLine("user");
            Debug.WriteLine("user");
        }

        [When(@"I type my credentials")]
        [Scope(Feature = "AdminLogin")]
        public void WhenITypeMyAdminCredentials()
        {
            Console.WriteLine("admin");
            Debug.WriteLine("admin");
        }

        [Then(@"I go to the home page")]
        public void ThenIGoToTheHomePage()
        {
           
        }

    }
}
