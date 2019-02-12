using ContractProject.PageObjects;
using ContractProject.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ContractProject.StepsDefinations
{
    [Binding]
    public class LoginSteps
    {
        LoginPage thelogin;

        public LoginSteps()
        {
            thelogin = new LoginPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            thelogin.ClickLogin();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            thelogin.EnterEmail();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            thelogin.EnterPassword();
        }
        
        [When(@"I click on the signin button")]
        public void WhenIClickOnTheSigninButton()
        {
            thelogin.ClickSignin();
        }
        
        // verification process
        // 1. pageobject - create an element
        // 2. pageobject - create a method to confirm if the element is visible
        // 3. on the step defination - call the method

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()

        {
            thelogin.ClickLogOut();
        }

        // invalid password
        [When(@"I enter an invalid password")]
        public void WhenIEnterAnInvalidPassword()
        {
            thelogin.EnterInvalidPassword();
        }

        // invalid login confirmation

        [Then(@"user should be unable to login")]
        public void ThenUserShouldBeUnableToLogin()
        {
            thelogin.IsloginErrorMsgDisplayed();
        }

        // invalid email address passing in parameters
        [When(@"I enter an invalid email ""(.*)""")]
        public void WhenIEnterAnInvalidEmail(string inVemail)
        {
            thelogin.EnterInvalidEmailAddress(inVemail);
        }

        // empty or blank email address
        [When(@"I enter no email address")]
        public void WhenIEnterNoEmailAddress()
        {
            thelogin.ClickonEmailAddress();
        }

        // empty password or blank password
        [When(@"I enter no password")]
        public void WhenIEnterNoPassword()
        {
            thelogin.ClickonPassword();
        }
    }
}
