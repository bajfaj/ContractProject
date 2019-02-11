using ContractProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ContractProject
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registration;

        public RegistrationSteps()
        {
            registration = new RegistrationPage();
        }

        [When(@"Click on the register link")]
        public void WhenClickOnTheRegisterLink()
        {
            registration.ClickRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter lastname")]
        public void WhenIEnterLastname()
        {
            registration.EnterLastName();
        }
        
        [When(@"I enter emailaddress")]
        public void WhenIEnterEmailaddress()
        {
            registration.EnterEmailAddress();
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNumber();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword();
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            registration.ClickSignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            registration.ClickSecureSignIn();
        }
    }
}
