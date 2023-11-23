using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlow.Actions.Selenium;
using SpecFlow_Learning.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning.Pages__POM_
{
    public class HomePage : GlobalConfig
    {
        public HomePage(ScenarioContext scenarioContext) : base(scenarioContext) { }

        #region Elements' XPath

        private const string searchBarXPath = "//input[contains(@class,'header')]";       
        private const string categoryDropdownXPath = "//select[contains(@class,'header-search-select')]";
        private const string searchButtonXPath = "//button[contains(@class,'header-search-button')]";

        #endregion



        #region Page's Elements
        private IWebElement _searchBar
        {
            get
            {
                return getDriver().FindElement(By.XPath(searchBarXPath));
            }
        }

        private IWebElement _categoryDropdown
        {
            get
            {
                return getDriver().FindElement(By.XPath(categoryDropdownXPath));
            }
        }

        private IWebElement _searchButton
        {
            get
            {
                return getDriver().FindElement(By.XPath(searchButtonXPath));
            }
        }

        #endregion



        #region Methods

        public void SearchAnProduct(string product)
        {
            _searchBar.Clear();
            _searchBar.SendKeys(product);
            _searchBar.SendKeys(Keys.Enter);
        }

        public void SelectAnEspecificCategory(string category)
        {
            bool conditionToClick = false;
            SelectElement select = new SelectElement(_categoryDropdown);
            
            for (int i = 0; i < select.Options.Count; i++)
            {
                select.SelectByIndex(i);
                var optionText = select.SelectedOption.Text.ToString();
                conditionToClick = optionText.Contains(category);
                if (conditionToClick)
                {
                    i=select.Options.Count;                                       
                }
            }

            if (conditionToClick)
            {
                _searchButton.Click();
            }
        }

        #endregion
    }
}
