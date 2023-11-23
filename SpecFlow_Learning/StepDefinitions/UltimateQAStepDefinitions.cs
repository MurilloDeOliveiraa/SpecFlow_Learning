using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlow_Learning.Classes;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace SpecFlow_Learning.StepDefinitions
{
    [Binding]
    public class UltimateQAStepDefinitions : GlobalConfig      
    {
        public UltimateQAStepDefinitions(ScenarioContext scenarioContext) :base(scenarioContext) { }

        UltimateQAPage page;
        

        [Given(@"I'm on the ultimateQA page")]
        public void GivenImOnTheUltimateQAPage()
        {
            getDriver().Navigate().GoToUrl(SetUrl());
        }
        

        [When(@"I select ""([^""]*)"" on the dropdown section")]
        public void WhenISelectOnTheDropdownSection(string option)
        {
            page = new UltimateQAPage(Scenario);
            Scenario["Option"] = option;
            page.SelectDropdown();
        }

        [Then(@"I should see the previous option selected")]
        public void ThenIShouldSeeThePreviousOptionSelected()
        {
            try
            {            
                By dropdownXpath = By.XPath("//div[@class='et_pb_blurb_description']//select//option[@value='audi']");
                var dropdown = getDriver().FindElement(dropdownXpath).Text.ToString();
                string expectedText = Scenario["Option"].ToString();
                Assert.IsTrue(dropdown.Equals(expectedText));             
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Logger.Info();
            }
        }

        [When(@"I select the ""([^""]*)"" radio button")]
        public void WhenISelectTheRadioButton(string radioButton)
        {
            page = new UltimateQAPage(Scenario);
            page.SelectRadioButton(radioButton);
        }

        [Then(@"I should see the correct radio button selected")]
        public void ThenIShouldSeeTheCorrectRadioButtonSelected()
        {
            
        }

    }
}
