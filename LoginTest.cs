using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MSTest_Runner_App
{
    [TestClass]
    public sealed class LoginTest
    {
        private ChromeDriver? driver;

        [TestInitialize]
        public void TestInit()
        {
            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox"); // Important for CI environments
            options.AddArgument("--disable-dev-shm-usage"); // Helps with resource limitations
            options.AddArgument("--disable-gpu"); // Optional but recommended in headless mode
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver!.Close();
            driver.Quit();
            driver = null;
        }

        [TestMethod]
        public void Login1()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("user-name"));
            var password = driver.FindElement(By.Id("password"));
            var loginButton = driver.FindElement(By.Id("login-button"));

            username.Click();
            username.SendKeys("standard_user");
            password.Click();
            password.SendKeys("secret_sauce");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("app_logo")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login2()
        {
            string actual = "", expected = "";

            actual = false.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
