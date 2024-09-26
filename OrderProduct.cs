using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;

namespace nunittest.Selenium
{
    internal class OrderProduct
    {
        private IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            Thread.Sleep(2000);
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {
            Thread.Sleep(2000);
            IWebElement name = driver.FindElement(By.Id("user-name"));
            name.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement login = driver.FindElement(By.Id("login-button"));
            login.Click();

            Thread.Sleep(2000);
            IWebElement addToCartButton = driver.FindElement(By.XPath("//button[contains(text(),'Add to cart')]"));
            addToCartButton.Click();

            Thread.Sleep(2000);
            IWebElement shoppingCartLink = driver.FindElement(By.ClassName("shopping_cart_link"));
            shoppingCartLink.Click();

            Thread.Sleep(2000);
            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();

            Thread.Sleep(2000);
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys("Akash");

            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys("Shetty");

            IWebElement postalCode = driver.FindElement(By.Id("postal-code"));
            postalCode.SendKeys("12345");

            IWebElement continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();

            Thread.Sleep(2000);
            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();

            Thread.Sleep(2000);
            IWebElement thankYouText = driver.FindElement(By.ClassName("complete-header"));
            if (thankYouText.Text == "THANK YOU FOR YOUR ORDER")
            {
                Console.WriteLine("Order placed successfully!");
            }
            else
            {
                Console.WriteLine("Order placement failed.");
            }
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}