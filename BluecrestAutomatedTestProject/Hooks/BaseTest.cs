using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Edge;
using System.Diagnostics;

namespace BluecrestAutomatedTestProject.Hooks
{
    [Binding]
    public sealed class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
