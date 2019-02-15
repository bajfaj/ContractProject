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

        public void EnterEmailAddress(string email)
        {
            EmailAddress.SendKeys(email);
        }

        // mobile number
        [FindsBy(How = How.CssSelector, Using = "#mobile")]
        private IWebElement MobileNumber { get; set; }

        public void EnterMobileNumber(string mobileNumber)
        {
            MobileNumber.SendKeys("079855");
        }

        // Password
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        public void EnterPassword(string passwordText)
        {
            Password.SendKeys(passwordText);
        }

        // Confirm Password
        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement ConfirmPassword { get; set; }

        public void EnterConfirmPassword(string confirmPasswordText)
        {
            ConfirmPassword.SendKeys(confirmPasswordText);
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

        // second registration confirmation
        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement SuccessMessage { get; set; }

               public bool SuccessMessageIsDispayed()
        {
            try
            {
                return SuccessMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
            return SuccessMessage.Displayed;
        }

        // password short message 
        [FindsBy(How = How.CssSelector, Using = "#signup-form > div:nth-child(5) > label.error")]
        private IWebElement passwordTooShortMsg { get; set; }

        public string GetTextForPasswordTooShort()
        {
            // return passwordTooShortMsg.Text; (method 1)
            // Another method below
            string text = passwordTooShortMsg.Text;
            return text;  
        }

        public bool PasswordTooShortMsgIsDisplayed()
        {
            try
            {
                return passwordTooShortMsg.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // invalid email address message
        [FindsBy(How = How.CssSelector, Using = "#signup-form > div:nth-child(3) > label.error")]
        private IWebElement InvalidEmailMsg { get; set; }

        public string GetTextForInvalidEmail()
        {
            /* string text = InvalidEmailMsg.Text;
             return text; OR BELOW */
            return InvalidEmailMsg.Text;
        }

        // MOBILE TOO SHORT
        [FindsBy(How = How.CssSelector, Using = "#signup-form > div:nth-child(4) > label.error")]
        private IWebElement MobileTooShortMsg { get; set; }

        public string GetTextForMobileTooShort()
        {
            return MobileTooShortMsg.Text;
        }
    }
}
