using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class BrowserCommands
    {
        private IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        }

        
        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            // store the list of checkboxes
            IReadOnlyList<IWebElement> Checkboxs = driver.FindElements(By.XPath("//input[@type = 'radio']"));

            foreach (IWebElement e in Checkboxs)
            {
                // fetches the text of the element
                Console.WriteLine(e.Text);
                // clicks on the check boxes one by one
                e.Click();
            }


        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}