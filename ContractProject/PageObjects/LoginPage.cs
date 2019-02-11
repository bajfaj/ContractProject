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

        /* login verification for invalid login
        // option or methhod 1 
        [FindsBy(How =How.XPath, Using = "//*[@id='login - form']/div[1]")]
        private IWebElement loginErrogMsg { get; set; }

        // private IWebElement ConfirmLogin { get; set; }

        public bool IsloginErrorMsgDisplayed()
        {
            return loginErrogMsg.Displayed;
        }  */

        // valid login 
        [FindsBy(How = How.LinkText, Using = "Logout")]
        private IWebElement LogOut { get; set; }

        public void ClickLogOut()
        {
            LogOut.Click();
        }
    }
}
