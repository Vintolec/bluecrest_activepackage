using BluecrestAutomatedTestProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluecrestAutomatedTestProject.Support
{
    public class WaitElement
    {
        public IWebDriver driver;

        public WaitElement()
        {
            driver = BaseTest.driver;
        }

        public void WaitForElement()
        {
            Thread.Sleep(3000);
        }
    }
}
