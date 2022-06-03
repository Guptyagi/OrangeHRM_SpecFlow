

using NUnit.Framework;
using OpenQA.Selenium;

namespace OrangeHRMBDD.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions

    {
        private IWebDriver driver;

        [Given(@"I have browser with OrangeHRM Application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

        }

        [Then(@"I enter username as '([^']*)'")]
        public void ThenIEnterUsernameAs(string username)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(username);
        }

        [Then(@"I enter password as '([^']*)'")]
        public void ThenIEnterPasswordAs(string password)
        {
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
        }

        [Then(@"I click on login")]
        public void ThenIClickOnLogin()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }

        [Then(@"I should be able to access URL as '([^']*)'")]
        public void ThenIShouldBeAbleToAccessURLAs(string expectedURL)
        {
            Assert.That(driver.Url, Is.EqualTo(expectedURL));
        }
    }
}
