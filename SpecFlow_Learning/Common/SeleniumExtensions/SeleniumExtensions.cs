using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlow_Learning.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning.Common.SeleniumExtensions
{
    public class SeleniumExtensions : GlobalConfig
    {
        public SeleniumExtensions(ScenarioContext scenarioContext) : base(scenarioContext) { } 
        
        public string WaitForElement(IWebElement element, out bool found)
        {
            WebDriverWait wait = new WebDriverWait(getDriver(), TimeSpan.FromSeconds(10));
            found = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(element));            
            return element.Text.ToString();
        }

        
    }
}
