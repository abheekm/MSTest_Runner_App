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
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://10.64.1.98:30910/login");
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
            var username = driver!.FindElement(By.XPath("//*[@id=\"login-form_email\"]"));
            var password = driver.FindElement(By.XPath("//*[@id=\"login-form_password\"]/div/span/input"));
            var loginButton = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/div[4]/div/div/div/div/div/button"));

            username.Click();
            username.SendKeys("root");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/div/div/div[1]/aside/div/div[1]/div[3]/ul/li[1]")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login2()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.XPath("//*[@id=\"login-form_email\"]"));
            var password = driver.FindElement(By.XPath("//*[@id=\"login-form_password\"]/div/span/input"));
            var loginButton = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/div[4]/div/div/div/div/div/button"));

            username.Click();
            username.SendKeys("root1");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/div/div/div[1]/aside/div/div[1]/div[3]/ul/li[1]")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login3()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.XPath("//*[@id=\"login-form_email\"]"));
            var password = driver.FindElement(By.XPath("//*[@id=\"login-form_password\"]/div/span/input"));
            var loginButton = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/div[4]/div/div/div/div/div/button"));

            username.Click();
            username.SendKeys("at_approved_user@test.com");
            password.Click();
            password.SendKeys("test@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/div/div/div[1]/aside/div/div[1]/div[3]/ul/li[1]")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login4()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.XPath("//*[@id=\"login-form_email\"]"));
            var password = driver.FindElement(By.XPath("//*[@id=\"login-form_password\"]/div/span/input"));
            var loginButton = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/div[4]/div/div/div/div/div/button"));

            username.Click();
            username.SendKeys("at_approved_user@test.com");
            password.Click();
            password.SendKeys("tets@1234");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/div/div/div/div[1]/aside/div/div[1]/div[3]/ul/li[1]")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login5()
        {
            string actual = "", expected = "";

            actual = false.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
