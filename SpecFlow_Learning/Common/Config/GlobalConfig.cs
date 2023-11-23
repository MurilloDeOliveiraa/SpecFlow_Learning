using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_Learning.Classes
{
    [Binding]
    public class GlobalConfig : Base
    {
        #region Scenario Context
                         
        private readonly ScenarioContext _scenarioContext;
        public ScenarioContext Scenario => _scenarioContext;

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        /// <param name="scenarioContext"></param>
        public GlobalConfig(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        #endregion                
    }
}
