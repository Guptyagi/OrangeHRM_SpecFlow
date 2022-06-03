

using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRMBDD.Hooks;

namespace OrangeHRMBDD.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions

    {
        //private IWebDriver driver;

        [Given(@"I have browser with OrangeHRM Application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");
            AutomationHooks.driver = new ChromeDriver();
            AutomationHooks.driver.Manage().Window.Maximize();
            AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            AutomationHooks.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

        }

        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            AutomationHooks.driver.FindElement(By.Id("txtUsername")).SendKeys(username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            AutomationHooks.driver.FindElement(By.Id("txtPassword")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            AutomationHooks.driver.FindElement(By.Id("btnLogin")).Click();
        }

        [Then(@"I should be able to access URL as '([^']*)'")]
        public void ThenIShouldBeAbleToAccessURLAs(string expectedURL)
        {
            Assert.That(AutomationHooks.driver.Url, Is.EqualTo(expectedURL));
        }

        [Then(@"I should get an error Message as '([^']*)'")]
        public void ThenIShouldGetAnErrorMessageAs(string ErrorMessage)
        {
            String errorMessage= AutomationHooks.driver.FindElement(By.XPath("//span[@id='spanMessage']")).Text.Trim();
            Assert.That(errorMessage.Contains(ErrorMessage),"Assertion on Invalid Credentials");
        
        }


    }
}
