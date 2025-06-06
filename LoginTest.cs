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
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("root");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login2()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("root1");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login3()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("at_approved_user@test.com");
            password.Click();
            password.SendKeys("test@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login4()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("at_approved_user@test.com");
            password.Click();
            password.SendKeys("tets@1234");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
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

        [TestMethod]
        public void Login6()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("root");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.XPath("//*[@id=\"login-form_password_help\"]/div")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login7()
        {
            string actual = "", expected = "";
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.XPath("//*[@id=\"login-form_email_help\"]/div")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login8()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("root");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login9()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("root");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login10()
        {
            string actual = "", expected = "";
            var username = driver!.FindElement(By.Id("login-form_email"));
            var password = driver.FindElement(By.Id("login-form_password"));
            var loginButton = driver.FindElement(By.ClassName("login-btn"));

            username.Click();
            username.SendKeys("root");
            password.Click();
            password.SendKeys("root@123");
            loginButton.Click();
            Thread.Sleep(2000);
            actual = driver.FindElement(By.ClassName("bn-sidebar-menu")).Displayed.ToString();
            expected = true.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
