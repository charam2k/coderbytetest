using ReqRes.Lib;
using ReqRes.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CoderByte.SpecFlow.Test.Steps
{
    [Binding]
    public sealed class CoderByteTestStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private long userId;
        private string endPointUrl;
        ResponseModel<ReqResDataModel> apiResponse;
        public CoderByteTestStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the URL is ""(.*)""")]
        public void GivenTheURLIs(string url)
        {
            this.endPointUrl = url;
        }


        [Given(@"the user id is (.*)")]
        public void GivenTheUserIdIs(int id)
        {
            this.userId = id;
        }

        [When(@"the end user perform GET Request")]
        public void WhenTheEndUserPerformGETRequest()
        {
            apiResponse = ReqResHelper.GetUser(this.endPointUrl, this.userId);
        }

        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int statusCode)
        {
            int apiStatusCode = (int)apiResponse.StatusCode;
            apiStatusCode.Should().Be(statusCode);
        }

        [Then(@"the user first_name should be ""(.*)""")]
        public void ThenTheUserFirst_NameShouldBe(string firstName)
        {
            apiResponse.Data.User.FirstName.Should().Be(firstName);
        }

        [Then(@"the user last_name should be ""(.*)""")]
        public void ThenTheUserLast_NameShouldBe(string lastName)
        {
            apiResponse.Data.User.LastName.Should().Be(lastName);
        }

    }
}
