using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace ContractProject.StepsDefinations
{
    [Binding]
    public class APIWithSpecFlowSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have my EndPoint")]
        public void GivenIHaveMyEndPoint()
        {
           client = new RestClient("https://petstore.swagger.io/v2/pet/20");
        }
        
        [Given(@"I send a ""(.*)""")]
        public void GivenISendA(string p0)
        {
            request = new RestRequest(Method.GET);
        }
        
        [When(@"I execute the response")]
        public void WhenIExecuteTheResponse()
        {
            request.AddHeader("Postman-Token", "87808b5c-fe20-48b1-b6c6-cc6b45da3e26");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            response = client.Execute(request);
        }
        
        [Then(@"the response is succesfull")]
        public void ThenTheResponseIsSuccesfull()
        {
            string status = response.StatusCode.ToString();
            // string errorMessage = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();

            Assert.AreEqual(status, "OK");
            //  errorMessage.Should().BeNull();
            isSuccessful.Should().Be("True");
        }
    }
}
