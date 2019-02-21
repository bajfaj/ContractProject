using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ContractProject.TraditionalSeleniumWithoutSpecFlow
{
    [TestClass]
    public class TraditionalSelenium
    {
        [TestMethod]
        public void BlueSkyFormValidation()
        {

            // 1. Create instance of the browser
            IWebDriver Driver;

            // 2. Open Browser
            Driver = new ChromeDriver();

            // 3. Do your Test
            // 3A. Open and Navigate to Website
            Driver.Navigate().GoToUrl("http://blueskycitadel.com/test-form-for-bluesky-automation-training/");
            // to maximise window
            Driver.Manage().Window.Maximize();

            //* 3B. Enter a text into form
            // i. Inspect your element (done with f12 developer tool or RCM)

            // ii. Decide on the attribute to use to find your element (e.g xpath, css or id. Decide to use id)
            
            // iii. Copy the attribute  ('nf-field-26')

            // iv. Write the code to find the element
           // Driver.FindElement(By.Id("nf-field-26"));

            // v. Perform the action i.e type into textbox)
            // enter firstname
            Driver.FindElement(By.Id("nf-field-26")).SendKeys("My FirstName");
            // enter last name
            Driver.FindElement(By.Id("nf-field-27")).SendKeys("My LastName");

            // 3C.1 Select a dropdown/droplist - Multi Select (Using i - iii above)
            // However with regards to i, Inspect your element for the SELECT DROPDOWN (NOT THE OPTION ITSELF YET)
            // iv. Write the code of find he element 
            // iv.a Now input the select web element for the dropdown
           // Driver.FindElement(By.Id("nf-field-41"));

            // iv.b Use the element you found with the selectelement instance
            SelectElement multiselect = new SelectElement(Driver.FindElement(By.Id("nf-field-41")));

            // iv.c Select the option from the list
            multiselect.SelectByValue("one");
           // multiselect.SelectByValue("two");
            multiselect.SelectByText("Three");

            //3c.2 Single select from a dropdown (using 3c.1 process above)
            /* SelectElement CountryDropdown = new SelectElement(Driver.FindElement(By.Id("nf-field-43")));
             CountryDropdown.SelectByValue("two"); */

            // another method for single select
            new SelectElement(Driver.FindElement(By.Id("nf-field-43"))).SelectByValue("two");

            // 3D. Click a Radio button 
            // i. Inspect your element for the RADIO (INPUT NOT THE LABEL)

            // ii. Decide on the attribute to use to find your element (e.f xpath or css)

            // iii. copy the attribute

            // iv. write the code to find the element
            // Anoter method:  Driver.FindElement(By.XPath("//*[@id='nf-field-31-0']"));
           // IWebElement radio = Driver.FindElement(By.XPath("//*[@id='nf-field-31-0']"));

            // v. click on the element
          //  radio.Click();
            Driver.FindElement(By.XPath("//*[@id='nf-field-31-1']")).Click();

            // 3d.2 Check boxes
            Driver.FindElement(By.XPath("//*[@id='nf-field-40-1']")).Click();

            // Typing into Paragraph textbox
            Driver.FindElement(By.CssSelector("#nf-field-44")).SendKeys("My long paragraph end here");

            // 3E. Click a Submit button
            Driver.FindElement(By.Id("nf-field-37")).Click();

            // 4. Close Browser
            Driver.Close();


        }
    }
}
