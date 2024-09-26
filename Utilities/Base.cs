using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace nunittest.Utilities
{
    internal class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
        }

        [TearDown]
        public void StopBrowser()
        {
            driver.Close();


        }

    }
}