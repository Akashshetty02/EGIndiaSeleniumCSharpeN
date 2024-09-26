using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

internal class ActionsEg

{

    IWebDriver driver;

    [SetUp]

    public void StartBrowser()

    {

        // confifgure the web driver manager to set up the chrome capabilities

        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

        // intialize the web driver 

        driver = new FirefoxDriver();

        // launch the forefox browser

        driver.Navigate().GoToUrl("https://www.amazon.in/");

        driver.Manage().Window.Maximize();

    }

    [Test]

    public void testcase1()

    {


        IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

        new Actions(driver)

          .DoubleClick(TdyDeal)

          .Perform();

        Thread.Sleep(1000);



    }

    [TearDown]

    public void tearDownbrowser()

    {

        driver.Close();

    }


}




internal class ClickHold

{

    IWebDriver driver;

    [SetUp]

    public void StartBrowser()

    {

        // confifgure the web driver manager to set up the chrome capabilities

        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

        // intialize the web driver 

        driver = new FirefoxDriver();

        // launch the forefox browser

        driver.Navigate().GoToUrl("https://www.amazon.in/");

        driver.Manage().Window.Maximize();

    }

    [Test]

    public void testcase1()

    {

        IWebElement Primes = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

        IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

        new Actions(driver)

          .MoveToElement(Primes)

          .MoveToElement(LatestMovies)

          .Click();

        Thread.Sleep(1000);

        //Assert.AreEqual("Prime", driver.FindElement(By.XPath("//span[normalize-space()='Prime']")).Text);

    }

    [TearDown]

    public void tearDownbrowser()

    {

        driver.Close();

    }




    internal class ContextClick

    {

        IWebDriver driver;

        [SetUp]

        public void StartBrowser()

        {

            // confifgure the web driver manager to set up the chrome capabilities

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // intialize the web driver 

            driver = new FirefoxDriver();

            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();

        }

        [Test]

        public void testcase1()

        {

            IWebElement TdyDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

            new Actions(driver)

              .ContextClick(TdyDeal)

              .Perform();

            Thread.Sleep(1000);

        }

        [TearDown]

        public void tearDownbrowser()

        {

            driver.Close();

        }

    }
}
 