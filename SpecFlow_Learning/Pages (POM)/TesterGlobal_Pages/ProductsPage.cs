using NUnit.Framework;
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
    public class ProductsPage : GlobalConfig
    {
        public ProductsPage(ScenarioContext scenarioContext) : base(scenarioContext) { }

        #region Elements' XPath
        
        private const string productPathXPath = "//div[contains(@class,'woo-breadcrumbs')]";
        private const string addProductButtonXPath = "//button[contains(@class,'cart_button')]";
        private const string cartButtonXPath = "//div[@role='alert']//a[@class='button wc-forward wp-element-button'][normalize-space()='Ver carrinho']";

        #endregion



        #region Page's Elements
        private IWebElement _productPath
        {
            get
            {
                return getDriver().FindElement(By.XPath(productPathXPath));
            }
        }

        private IWebElement _addProductButton
        {
            get
            {
                return getDriver().FindElement(By.XPath(addProductButtonXPath));
            }
        }

        private IWebElement _cartButton
        {
            get
            {
                return getDriver().FindElement(By.XPath(cartButtonXPath));
            }
        }
        #endregion



        #region Methods
        public bool ValidateImOnTheProductPage(string product)
        {
            bool result;
            string pagePath = _productPath.Text.ToString();
            return result = pagePath.Contains(product);            
        }

        public void ClickToAddProduct()
        {
            _addProductButton.Click();
        }

        public void ClicToSeeTheCart()
        {
            _cartButton.Click();
        }
        #endregion
    }
}
