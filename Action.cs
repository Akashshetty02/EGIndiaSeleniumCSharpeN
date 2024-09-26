using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace nunittest.Selenium
{
    internal class Action
    {
        private IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase()
        {
            IWebElement todaydeal = driver.FindElement(By.XPath(""));
            new Actions(driver)
                .DoubleClick(todaydeal)
                .Perform();
            Thread.Sleep(2000);


          
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}