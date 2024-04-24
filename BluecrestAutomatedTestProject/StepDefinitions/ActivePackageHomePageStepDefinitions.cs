using BluecrestAutomatedTestProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace BluecrestAutomatedTestProject.StepDefinitions
{
    [Binding]
    public class ActivePackageHomePageStepDefinitions
    {
        ActivePackagePageObject activePackage = new ActivePackagePageObject();

        [Given(@"the user Navigate to Bluecrest Wellbeing Website ""([^""]*)""")]
        public void GivenTheUserNavigateToBluecrestWellbeingWebsite(string url)
        {
            activePackage.Navigate(url);
        }


        [Given(@"the user has accepted the privacy policy and close the popup")]
        public void GivenTheUserHasAcceptedThePrivacyPolicyAndCloseThePopup()
        {
            activePackage.ClickOnPopUps();
        }

        [When (@"User clicks on the Health Assessment Menu on the Header of the HomePage")]

        public void WhenUserClicksOnTheHealthAssessmentMenuOnTheHeaderOfTheHomePage()
        {
            activePackage.ClickOnHealthAssessmentMenu();
        }


        [When(@"the user clicks on the BookNow button for the Active Package")]
        public void WhenTheUserClicksOnTheBookNowButtonForTheActivePackage()
        {
            activePackage.ClickOnBookNow();
        }

        [When(@"User inputs location in the search field")]
        public void WhenUserInputsLocationInTheSearchField()
        {
            activePackage.EnterLocation();
        }

        [When(@"clicks the search button")]
        public void WhenClicksTheSearchButton()
        {
           activePackage.ClickOnSearch();
        }

       
        [When(@"the user selects a venue from the list")]
        public void WhenTheUserSelectsAVenueFromTheList()
        {
            activePackage.ClickOnVenueOne();
        }

       
        [When(@"selects a date and time")]
        public void WhenSelectsADateAndTime()
        {
            activePackage.ClickOnDayAndTime();
        }


        [When(@"clicks on confirm Button")]
        public void WhenClicksOnConfirmButton()
        {
            activePackage.ClickOnConfirmBtn();
        }

        [Then (@"views the Order Summary")]
        public void ThenViewsTheOrderSummary()
        {
            Assert.IsTrue(activePackage.IsOrderSummaryVisible());
        }

        [When(@"the user clicks on the continue button")]
        public void WhenTheUserClicksOnTheContinueButton()
        {
            activePackage.ClickOnContinueButton();
        }

        [When(@"User clicks on the View All the Health Check Button on the Body of the HomePage")]
        public void WhenUserClicksOnTheViewAllTheHealthCheckButtonOnTheBodyOfTheHomePage()
        {
            activePackage.ClickOnViewHealthPackage();
        }

        [Then(@"the user can view the personal details page")]
        public void ThenTheUserCanViewThePersonalDetailsPage()
        {
            Assert.IsTrue(activePackage.IsPersonalDetailsPgDisplayed());
        }

    }
}
