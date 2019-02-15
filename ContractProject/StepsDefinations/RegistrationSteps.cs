using ContractProject.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Threading;
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
            registration.EnterEmailAddress("newemail@gmail.com");
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNumber("07952665987");
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword("Abcde1");
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword("Abcde1");
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

        [Then(@"Registration second confirmation")]
        public void ThenRegistrationSecondConfirmation()
        {
            // wait statement
            Thread.Sleep(5000);

            // nunit assertion
            Assert.IsTrue(registration.SuccessMessageIsDispayed(), "Error Message: Registration Failed");

            // fluent assertion. FluentAssertions nugget packaged is required to be added
            registration.SuccessMessageIsDispayed().Should().BeTrue("Error Message: Registration Failed");

            // another option of assertion
            registration.SuccessMessageIsDispayed().Should().Be(true);
        }

        // invalid password
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string passwordEntered)
        {
            registration.EnterPassword(passwordEntered);
        }

        // invalid password confirm password 2
        [When(@"I confirm password ""(.*)""")]
        public void WhenIConfirmPassword(string confirmPasswordEntered)
        {
            registration.EnterConfirmPassword(confirmPasswordEntered);
        }

        // short 5 password message
        [Then(@"the password is too short error message is displayed")]
        public void ThenThePasswordIsTooShortErrorMessageIsDisplayed()
        {
            Thread.Sleep(5000);
            // registration.PasswordTooShortMsgIsDisplayed().Should().BeTrue("Password is not short");
            Assert.IsTrue(registration.PasswordTooShortMsgIsDisplayed(), "Error Message: Password is short");
        }

        [Then(@"the error message ""(.*)"" is displayed for the ""(.*)""")]
        public void ThenTheErrorMessageIsDisplayedForThe(string message, string test)
        {
            // if statements for multiple tests
            if (test == "PasswordTooShort")
                registration.GetTextForPasswordTooShort().Should().Be(message);
            else if (test == "InvalidEmail")
                registration.GetTextForInvalidEmail().Should().Be(message);
            else if (test == "MobileTooShort")
                registration.GetTextForMobileTooShort().Should().Be(message);
            // registration.PasswordTooShortMsgIsDisplayed();
        }

    }
}
