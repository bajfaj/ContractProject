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
    class LoginPage
    {
        // navigate method
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        // login button method
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement Login { get; set; }

        public void ClickLogin()
        {
            Login.Click();
        }

        // email 
        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement Email { get; set; }

        public void EnterEmail()
        {
            Email.SendKeys("bajfaj2@gmail.com");
        }

        // password
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement Password { get; set; }

        public void EnterPassword()
        {
            Password.SendKeys("toby2014");
        }

        // signin button
        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement Signin { get; set; }

        public void ClickSignin()
        {
            Signin.Click();
        }

         // valid login 
        [FindsBy(How = How.LinkText, Using = "Logout")]
        private IWebElement LogOut { get; set; }

        public void ClickLogOut()
        {
            LogOut.Click();
        }

        // invalid password
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement InvalidPassword { get; set; }

        public void EnterInvalidPassword()
        {
            InvalidPassword.SendKeys("WrongPassword");
        }

        // invalid login confirmation
         
        [FindsBy(How =How.CssSelector, Using = "#login-form > div.alert.alert-danger")]
        private IWebElement loginErrogMsg { get; set; }

        // private IWebElement ConfirmLogin { get; set; }

        public bool IsloginErrorMsgDisplayed()
        {
            return loginErrogMsg.Displayed;
        }  

        // invalid email address
        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement InvalidEmailAddress { get; set; }

        public void EnterInvalidEmailAddress(string inVemail)
        {
            InvalidEmailAddress.SendKeys(inVemail);
        }

        // blank email or no email address
        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement NoEmailAddress { get; set; }

        public void ClickonEmailAddress()
        {
            NoEmailAddress.Click();
        }

        // blank password or no password
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement NoPassword { get; set; }

        public void ClickonPassword()
        {
            NoPassword.Click();
        }
    }
}
