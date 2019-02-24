using System;
using TechTalk.SpecFlow;

namespace MassiveDynamic...
{
    [Binding]
    public class LoginPageSteps
    {
        [Given(@"I have entered uername")]
        public void GivenIHaveEnteredUername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered password")]
        public void GivenIHaveEnteredPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be opening homepage")]
        public void ThenTheResultShouldBeOpeningHomepage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
