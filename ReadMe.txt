1. I am using C#, Selenium with Specflow and use chrome for my project. 
2. WebDriver.cs class initialises the ChromeDriver and navigate to commbiz login page, it also contains selenium functionality as well as Cleanup procedure. 
3. Register.feature consists of specflow scenario
4. RegisterSteps.cs consists of binding steps. 
5. PageObjects.cs consists of all the UI elements and methods. 


Test Name:	VerifyIAmAbleToRegisterToCommbizUsingAdvanceControlAndForeignExchangeOptions_
Test FullName:	CommBank.Features.RegisterFeature.VerifyIAmAbleToRegisterToCommbizUsingAdvanceControlAndForeignExchangeOptions_
Test Source:	D:\repos\CommBank\CommBank\Features\Register.feature : line 4
Test Outcome:	Passed
Test Duration:	0:00:26.2417313

Result StandardOutput:	
-> Loading plugin D:\repos\CommBank\CommBank\bin\Debug\net472\TechTalk.SpecFlow.MSTest.SpecFlowPlugin.dll
-> Using default config
Given I am on Commbiz Login Page and I click Register Online Now button
-> done: RegisterSteps.GivenIAmOnCommbizLoginPageAndIClickRegisterOnlineNowButton() (9.2s)
And I select options on registeration Page and click ok
-> done: RegisterSteps.GivenISelectOptionsOnRegisterationPageAndClickOk() (1.5s)
When I click next on custom registration information page
-> done: RegisterSteps.WhenIClickNextOnCustomRegistrationInformationPage() (1.2s)
When i enter details and click next on registration page
-> done: RegisterSteps.WhenIEnterDetailsAndClickNextOnRegistrationPage() (2.0s)
Then Test is complete
Cleanup process started
-> done: RegisterSteps.ThenRegistrationShouldBeSuccessful() (11.9s)

