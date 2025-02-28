using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1;


namespace TestProject1.Tests
{
    class UnitTest2
    {

        private IWebDriver driver;
        private SeleniumHelper helper;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            helper = new SeleniumHelper(driver);
        }

        [Test]
        public void LoginToWeb()
        {
            helper.NavigateUrl("http://eaapp.somee.com/");
            helper.ClickElement(By.Id("loginLink"));
            helper.EnterTxt(By.Id("UserName"),"admin");
            helper.EnterTxt(By.Id("Password"), "password");
            helper.ClickElement(By.Id("loginIn"));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
