using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class WebTableAssignment
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {

            IWebElement data = chromeDriver.FindElement(By.XPath("//table[@name='courses']/tbody/tr[8]/td[2]"));
            Console.WriteLine(data.Text);
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
