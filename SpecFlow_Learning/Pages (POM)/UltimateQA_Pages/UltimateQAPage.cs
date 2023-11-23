using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;

namespace SpecFlow_Learning.Classes
{
    public class UltimateQAPage : GlobalConfig
    {
       public UltimateQAPage(ScenarioContext scenarioContext) : base(scenarioContext) { }

        #region Locators
        private By dropdownLocator = By.XPath("//div[@class='et_pb_blurb_description']//select");
        private const string dropdownXPath = "//div[@class='et_pb_blurb_description']//select";
        private const string radioButtonXPath = "//input[@value='";

        #endregion

        #region IWebElements

        private IWebElement dropdown
        {
            get
            {
                return getDriver().FindElement(dropdownLocator);
            }           
        }

        #endregion


        public void LoadBrowser()
        {
            SetBrowser();
            getDriver().Navigate().GoToUrl(SetUrl());
            getDriver().Manage().Window.Maximize();
        }

        public void SelectRadioButton(string value)
        {
            try
            {
                var elementXpath = $"{radioButtonXPath}{value}']";
                var element = getDriver().FindElement(By.XPath(elementXpath));

                Actions action1 = new Actions(getDriver());
                action1.ScrollToElement(element).Perform();

                element.Click();
            }
            catch(Exception ex)
            {
                getDriver().Close();
                getDriver().Quit();
                throw ex;                
            }
            finally
            {                
                Debug.WriteLine("Passed!");
                Console.WriteLine("Passed!");
            }
        }

        public void SelectDropdown()
        {
            try
            {
                By dropdownXpath = By.XPath(dropdownXPath);
                var element = getDriver().FindElement(dropdownXpath);

                WebDriverWait wait = new WebDriverWait(getDriver(), TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementIsVisible(dropdownXpath));

                Actions action1 = new Actions(getDriver());
                action1.ScrollToElement(element).Perform();                

                SelectElement select = new SelectElement(element);
                select.SelectByValue(Scenario["Option"].ToString().ToLower());               
            }
            catch (Exception ex)
            {
                getDriver().Close();
                getDriver().Quit();
                throw ex;
            }
            finally
            {
                Debug.WriteLine("Passed!");
                Console.WriteLine("Passed!");
            }
        }              
    }
}
