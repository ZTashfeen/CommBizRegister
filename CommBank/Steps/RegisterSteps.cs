using CommBank.Drivers;
using TechTalk.SpecFlow;


namespace CommBank.Objects
{
    [Binding]
    public class RegisterSteps : WebDriver
    {
        public PageObject PO = new PageObject();
        [Given(@"I am on Commbiz Login Page and I click Register Online Now button")]
        public void GivenIAmOnCommbizLoginPageAndIClickRegisterOnlineNowButton()
        {
            NavigateToURL();
            PO.ClickRegister();
            
        }


        [Given(@"I select options on registeration Page and click ok")]
        public void GivenISelectOptionsOnRegisterationPageAndClickOk()
        {
            PO.CustomRegistration();

        }

        [When(@"I click next on custom registration information page")]
        public void WhenIClickNextOnCustomRegistrationInformationPage()
        {


            PO.InformationPage();

        }

        [When(@"i enter details and click next on registration page")]
        public void WhenIEnterDetailsAndClickNextOnRegistrationPage()
        {
            PO.RegisterationInfo();
        }

        [Then(@"Test is complete")]
        public void ThenRegistrationShouldBeSuccessful()
        {
           
            WebDriver.CleanUp();
        }
      }
}
