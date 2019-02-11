using ContractProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractProject.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        // Register button
        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement Register { get; set; }

        public void ClickRegister()
        {
            Register.Click();
        }

        // First Name
        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement FirstName { get; set; }

        public void EnterFirstName()
        {
            FirstName.SendKeys("Micheal");
        }

        // Last Name
        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement LastName { get; set; }

        public void EnterLastName()
        {
            LastName.SendKeys("Jordan");
        }

        // email address
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement EmailAddress { get; set; }

        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("mjordan@yahoo.com");
        }

        // mobile number
        [FindsBy(How = How.CssSelector, Using = "#mobile")]
        private IWebElement MobileNumber { get; set; }

        public void EnterMobileNumber()
        {
            MobileNumber.SendKeys("07987665434");
        }

        // Password
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        public void EnterPassword()
        {
            Password.SendKeys("Abcde1");
        }

        // Confirm Password
        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement ConfirmPassword { get; set; }

        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("abcde1");
        }

        // Signup button
        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement SignUp { get; set; }

        public void ClickSignUp()
        {
            SignUp.Click();
        }

        // should be registered confirmation using secure sign in button
        [FindsBy(How = How.XPath, Using = "//*[@id='login - form']/div[5]/buttonn")]
        private IWebElement SecureSignIn { get; set; }

        public void ClickSecureSignIn()
        {
            SecureSignIn.Click();
        }
    }
}
