using NUnit.Framework;
using SpecFlow_Learning.Classes;
using SpecFlow_Learning.Common.SeleniumExtensions;
using SpecFlow_Learning.Pages__POM_;
using SpecFlow_Learning.Pages__POM_.TesterGlobal_Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning.StepDefinitions
{
    [Binding]
    public class TesterGlobalStepDefinitions : GlobalConfig
    {
        public TesterGlobalStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"I navigate to the home page")]
        public void GivenINavigateToTheHomePage()
        {
            getDriver().Navigate().GoToUrl(SetUrl());
        }

        [When(@"I search for (.*) product")]
        public void WhenISearchForCameraProduct(string product)
        {
            Scenario["TestName"] = Scenario.ScenarioInfo.Title.ToString();
            HomePage _homePage = new HomePage(Scenario);
            _homePage.SearchAnProduct(product);
        }

        [Then(@"I'm redirected to the (.*) page")]
        public void ThenImRedirectedToTheCameraPage(string product)
        {
            Scenario["ProductName"] = product;
            ProductsPage _productsPage = new ProductsPage(Scenario);
            bool result = _productsPage.ValidateImOnTheProductPage(product);
            Assert.IsTrue(result);
        }

        [When(@"I select the (.*) category")]
        public void WhenISelectTheCalcadosCategory(string selectedCategory)
        {
            HomePage _homePage = new HomePage(Scenario);
            _homePage.SelectAnEspecificCategory(selectedCategory);
        }

        [Then(@"I add the an item to the cart")]
        public void WhenIAddTheAnItemToTheCart()
        {
            ProductsPage _productsPage = new ProductsPage(Scenario);
            _productsPage.ClickToAddProduct();
            _productsPage.ClicToSeeTheCart();
        }

        [Then(@"I should see the previous item added into the cart's page")]
        public void ThenIShouldSeeThePreviousItemAddedIntoTheCartsPage()
        {
            CartPage _cartPage = new CartPage(Scenario);
            bool result = _cartPage.CheckProductGrid(Scenario["ProductName"].ToString());
            Assert.IsTrue(result);
        }

        [Given(@"I fill the ""([^""]*)"" with the user informations")]
        public void GivenIFillTheWithTheUserInformations(string templateName, Table table)
        {
            Excel ex = new Excel();
            ex.AccessTemplate(templateName, table);
        }

    }
}
