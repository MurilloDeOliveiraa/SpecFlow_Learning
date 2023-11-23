using OpenQA.Selenium;
using SpecFlow_Learning.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning.Pages__POM_.TesterGlobal_Pages
{
    public class CartPage : GlobalConfig
    {
        public CartPage(ScenarioContext scenarioContext) : base(scenarioContext) { }

        #region Elements' XPath

        private const string productGridXPath = "//td[@class='product-name']//a";

        #endregion



        #region Page's Elements
        private IWebElement _productGrid
        {
            get
            {
                return getDriver().FindElement(By.XPath(productGridXPath));
            }
        }
        #endregion



        #region Methods
        public bool CheckProductGrid(string expectedValue)
        {
            bool comparison;
            string currentValue = _productGrid.Text.ToString();
            return comparison = currentValue.Equals(expectedValue);
        }
        #endregion
    }
}
