using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRMBDD.Hooks;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMBDD.StepDefinitions
{
    
    [Binding]
    public class EmergencyContactStepDefinitions
    {
        private static Table _table;

        [When(@"I click on MyInfo")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.LinkText("My Info")).Click();
        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            AutomationHooks.driver.FindElement(By.LinkText("Emergency Contacts")).Click();

        }

        [When(@"I click add Emergency Contacts")]
        public void WhenIClickAddEmergencyContacts()
        {
            AutomationHooks.driver.FindElement(By.Id("btnAddContact")).Click();

        }

        [When(@"I fill the form")]
        public void WhenIFillTheForm(Table table)
        {
            _table = table;
            String ContactName = table.Rows[0]["contactname"];
            String Relationship = table.Rows[0]["relationship"];
            String HomePhone = table.Rows[0]["homephone"];
            String Mobile = table.Rows[0]["mobile"];
            String WorkPhone = table.Rows[0]["workphone"];

            AutomationHooks.driver.FindElement(By.Id("emgcontacts_name")).SendKeys(ContactName);
            AutomationHooks.driver.FindElement(By.Id("emgcontacts_relationship")).SendKeys(Relationship);
            AutomationHooks.driver.FindElement(By.Id("emgcontacts_homePhone")).SendKeys(HomePhone);
            AutomationHooks.driver.FindElement(By.Id("emgcontacts_mobilePhone")).SendKeys(Mobile);
            AutomationHooks.driver.FindElement(By.Id("emgcontacts_workPhone")).SendKeys(WorkPhone);
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            AutomationHooks.driver.FindElement(By.Id("btnSaveEContact")).Click();
        }

        [Then(@"I should get the name added to assigned contact table")]
        public void ThenIShouldGetTheNameAddedToAssignedContactTable()
        {

            String TableData=AutomationHooks.driver.FindElement(By.Id("emgcontact_list")).Text;
            Console.WriteLine(TableData);
            Assert.That(TableData.Contains(_table.Rows[0]["contactname"]));

        }
    }
}
