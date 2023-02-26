using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace HybridFwk_POM_SeleniumProject.util
{
    public class WaitForElement 
    {
        //public static void WaitForElementVisible(By locator, int timeoutInSeconds)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        //    wait.Until(ExpectedConditions.ElementIsVisible(locator));
        //}

       
        public static IWebElement WaitForElementToBeVisible(IWebDriver driver,IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(20));
            
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By locator, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static bool WaitForElementToBePresent(IWebDriver driver, By locator, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            try
            {
                wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

