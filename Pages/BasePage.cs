using HybridFwk_POM_SeleniumProject.util;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace HybridFwk_POM_SeleniumProject.BasePage
{
    public class BasePage
    { }
    //        protected static IWebDriver driver;
    //        protected static WaitForElement wait;
    //        public void BasePage() {



    //            driver = new ChromeDriver();
    //            driver.Manage().Window.Maximize();
    //            driver.Manage().Cookies.DeleteAllCookies(); 
    //            driver.Navigate().GoToUrl("https://www.rsmuk.com/");
    //            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
    //        }


    //        [TearDown]
    //        public void Teardown()
    //        {
    //            if (driver != null)
    //            {
    //                driver.Quit();
    //            }
    //        }

    //    }

    //}
    //        //[SetUp]
    //        //public void Setup()
    //        //{
    //        //    new DriverManager().SetUpDriver(new ChromeConfig());
    //        //    var options = new ChromeOptions();
    //        //    options.AddArgument("--start-maximized");
    //        //    this.driver = new ChromeDriver(options);
    //        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    //        //    driver.Manage().Window.Maximize();
    //        //}

    //        //

    //        //public void AcceptCookies()
    //        //    {
    //        //        try
    //        //        {
    //        //            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("onetrust-accept-btn-handler"))).Click();
    //        //        }
    //        //        catch (WebDriverTimeoutException)
    //        //        {
    //        //            // Cookies popup not displayed, ignore
    //        //        }
    //    }

    //protected IWebElement WaitUntilElementIsVisible(By by, int timeoutInSeconds = 10)
    //{
    //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
    //    return wait.Until(ExpectedConditions.ElementIsVisible(by));
    //}
    //public void NavigateTo(string url)
    //    {
    //        driver.Navigate().GoToUrl(url);
    //    }

    //protected void ClickElement(IWebElement element)
    //{
    //    element.Click();
    //}

    //protected void SendKeysToElement(IWebElement element, string text)
    //{
    //    element.Clear();
    //    element.SendKeys(text);
    //}

    //protected string GetElementText(IWebElement element)
    //{
    //    return element.Text.Trim();
    //}

    //[TearDown]
    //public void Cleanup()
    //{
    //    driver.Quit();
    //}




}