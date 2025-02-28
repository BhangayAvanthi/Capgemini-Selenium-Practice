using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace TestProject1
{
   public class SeleniumHelper
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait _wait;

        public SeleniumHelper(IWebDriver driver,int timeoutInminss=2)
        {
            this.driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromMinutes(timeoutInminss));
        }

        public void NavigateUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickElement(By locator)
        {
            //the below expectedconditons and elementtobeclickable is handled thoruh the using SeleniumExtras.WaitHelpers; package
            _wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public void EnterTxt(By locator,string txt)
        {
            var element = _wait.Until(ExpectedConditions.ElementExists(locator));
            element.Clear();
            element.SendKeys(txt);
        }
    }
}
