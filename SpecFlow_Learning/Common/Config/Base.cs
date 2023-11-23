using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Learning.Classes
{
    public class Base
    {
        #region Private Variables

        private static WebDriver Driver;
        private string Url;

        #endregion

        #region SetUp Methods
        public void SetBrowser()
        {
            if (ConfigurationManager.AppSettings["Browser"] == "CHROME")
            {
                Driver = new ChromeDriver();
            }
            else if (ConfigurationManager.AppSettings["Browser"] == "EDGE")
            {
                Driver = new EdgeDriver();
            }
            getDriver().Manage().Window.Maximize();
        }

        public string SetUrl()
        {

            if (ConfigurationManager.AppSettings["Environment"] == "PROD")
            {
                Url = "https://ultimateqa.com/simple-html-elements-for-automation/";
            }
            else if (ConfigurationManager.AppSettings["Environment"] == "QA")
            {
                Url = "https://automacao.testerglobal.com/";
            }
            else
            {
                Url = "This Url was not found in our DB";
            }

            return Url;
        }


        public static WebDriver getDriver()
        {
            return Driver;
        }

        #endregion
    }
}
