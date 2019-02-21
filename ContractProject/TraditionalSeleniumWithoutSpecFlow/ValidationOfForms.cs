using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ContractProject.TraditionalSeleniumWithoutSpecFlow
{
    [TestClass]
    public class ValidationOfForms
    { 
        [TestMethod]
        public void ValidateTest()
        {

            OpenQA.Selenium.IWebDriver Driver;

            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("http://blueskycitadel.com/test-form-for-bluesky-automation-training/");
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Id("nf-field-26")).SendKeys("My FirstName");
          
            Driver.FindElement(By.Id("nf-field-27")).SendKeys("My LastName");
           
            SelectElement multiselect = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));

            multiselect.SelectByValue("one");
            multiselect.SelectByText("Three");

            new SelectElement(Driver.FindElement(By.Id("nf-field-43"))).SelectByValue("two");

            Driver.FindElement(By.XPath("//*[@id='nf-field-31-1']")).Click();

            Driver.FindElement(By.XPath("//*[@id='nf-field-40-1']")).Click();

            Driver.FindElement(By.CssSelector("#nf-field-44")).SendKeys("My long paragraph end here");

            Driver.FindElement(By.Id("nf-field-37")).Click();

            // validation message is displayed
            // 1. find the element
           // Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p"));

            // 2. Add the action to perform or confirm the validation is displayed
            // Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed;

          /* Thread.Sleep(5000);
            // 3. Assert the displayed object
           Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed);

            // can now then add comment if for assertion if fails
            Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed, "The message is not displayed");
            */

            /* waiting can be used for the following. 
            1. for page to load
            2. for a java script or ajax to finish
            3. when new form or message is displayed on a form
            */

           /* // Implicit Wait 
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed);
            Assert.IsTrue(Driver.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p")).Displayed, "The message is not displayed");
            */

            // Tell your webdriver to poll the dom certain amounnt of time in rder to find the element
            // by defualt this is set to zero

            // Explicit Wait
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver web) =>
            {
                web.FindElement(By.CssSelector("#nf-form-4-cont > div > div.nf-response-msg > p"));
                return true;
            });

            // fluent waits

            Driver.Close();

        }
    }
}