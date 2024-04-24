using BluecrestAutomatedTestProject.Hooks;
using BluecrestAutomatedTestProject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace BluecrestAutomatedTestProject.PageObject
{

    public class ActivePackagePageObject
    {
        public IWebDriver driver;

        public WebDriverWait wait;

        public WaitElement waitElement;


        public ActivePackagePageObject()

        {
            driver = BaseTest.driver;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            waitElement = new WaitElement();
        }

       
        //Page Elements 

        private By closePopUp = By.XPath("//button[@title='Close']");
        private By iAcceptPopUP = By.CssSelector("#onetrust-accept-btn-handler");
       
        private By bookNow = By.XPath("(//span[contains(text(), 'Book now')])[1]");

        private By enterLocation = By.Id("address-search");
      
        private By searchButton = By.XPath("//input[@aria-labelledby='address-search']");

        private By venueOne = By.XPath("//button[@id='venue-835']");

        private By date = By.XPath ("(//button[@role='option'])[8]");

        private By appointmentTime = By.XPath(" (//div[contains(text(), 'PM')])[8]");
            
        private By confirmBtn = By.XPath("(//button [@data-link_category='Continue'])[1]");

        private By orderSummary =By.XPath("//h5[contains(text(),'Active Package')]");

        private By continueBtn = By.XPath("//a [@data-link_category='Continue']");

        private By personalDetailsPage = By.XPath("//h1[normalize-space()='Personal details']");

        private By hAssessmentMenu = By.XPath("//span[@class='navbar_link__TtsBe']");
        private By healthMOts = By.XPath("//a[contains(text(),'Health MOTs')]");

        private By viewHealthPackage = By.XPath("//button[@aria-label='View All Health Checks']");



        //Page Methods

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);

            waitElement.WaitForElement();

        }


        public void ClickOnPopUps()
        {
           
           
           IWebElement closeBAC = wait.Until(ExpectedConditions.ElementExists(closePopUp));

            closeBAC.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHieght)");
                       
            
            IWebElement acceptbutton = wait.Until(ExpectedConditions.ElementExists(iAcceptPopUP));

            acceptbutton.Click();

        }

        // Click on BookNow on ActivePackage

        public void ClickOnBookNow()

        {

            waitElement.WaitForElement();
          

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHieght)");

            waitElement.WaitForElement();


            IWebElement bookNowHomepage = wait.Until(ExpectedConditions.ElementExists(bookNow));

            waitElement.WaitForElement();

            bookNowHomepage.Click();

        }


        //User chooses a location
        public void EnterLocation ()
        {
                                                        
            IWebElement inputField = wait.Until(ExpectedConditions.ElementExists(enterLocation));
            inputField.SendKeys("Newcastle UponTyne");
                        
        }

        public void ClickOnSearch()
        {
           driver.FindElement(searchButton).Click();
        }

        public void ClickOnVenueOne()
        {
           
         
            IWebElement venueLocation = wait.Until(ExpectedConditions.ElementExists(venueOne));
            venueLocation.Click();
        }   
      
        public void ClickOnDayAndTime ()

        {
       
          
            IWebElement selectDate = wait.Until(ExpectedConditions.ElementExists(date));
            selectDate.Click();
                          
           
            IWebElement selectTime= wait.Until(ExpectedConditions.ElementExists(appointmentTime));
            selectTime.Click();
                        
        }

        // Click on confirm Btn
        public void ClickOnConfirmBtn()
        {
            
            driver.FindElement(confirmBtn).Click();
        }


        // Click on Continue Button
        public void ClickOnContinueButton()
        {

            waitElement.WaitForElement();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHieght)");

            waitElement.WaitForElement();

            IWebElement continueButton = wait.Until(ExpectedConditions.ElementExists(continueBtn));

            continueButton.Click();
        }


       // click on Health Assessment Menu
        public void ClickOnHealthAssessmentMenu()
        {
            driver.FindElement(hAssessmentMenu).Click();

            driver.FindElement(healthMOts).Click();
        }


        //Validate User can View  the Order Summary

        public bool IsOrderSummaryVisible()

        {
            return driver.FindElement(orderSummary).Displayed;
        }

        public void ClickOnViewHealthPackage()
        {
            driver.FindElement(viewHealthPackage).Click();
        }

        //Validate User can view the Personal details
        public bool IsPersonalDetailsPgDisplayed()
        {
            return driver.FindElement(personalDetailsPage).Displayed;
        }
    }
}
