using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace ContractProject.API
{
    [TestClass]
    public class APITEST1
    {
        [TestMethod]
        public void APITestMethod1()
        {
            var client = new RestClient("https://petstore.swagger.io/v2/pet/20");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "87808b5c-fe20-48b1-b6c6-cc6b45da3e26");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            string status = response.StatusCode.ToString();
            // string errorMessage = response.ErrorMessage.ToString();
            string isSuccessful = response.IsSuccessful.ToString();

            Assert.AreEqual(status, "OK");
            //  errorMessage.Should().BeNull();
            isSuccessful.Should().Be("True");

        }
    }
}
