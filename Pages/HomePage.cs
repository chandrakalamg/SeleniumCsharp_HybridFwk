using HybridFwk_POM_SeleniumProject.util;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.BasePage
{
    public class HomePage
        {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement AcceptCookiesButton => driver.FindElement(By.XPath("//a[text()='Accept cookie usage']"));
        private IWebElement cookieBanner => driver.FindElement(By.Id("cookie-bar"));
        private IWebElement SearchBox => driver.FindElement(By.Id("search-input"));
         private IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id='search-icon']"));
        private IWebElement Countriesselect => driver.FindElement(By.XPath("//select[@id='ddl-countries']"));

        //By SearchButton = By.XPath("//*[@id='search-icon']");
        // By SearchBox = By.Id("search-input");
        //By cookieBanner = By.Id("cookie-bar");

        public void AcceptCookies()
        {
           try
            {
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //wait.Until(ExpectedConditions.ElementToBeClickable(AcceptCookiesButton));
                //WaitForElement.WaitForElementToBeVisible(driver,cookieBanner);
                AcceptCookiesButton.Click();
            }
            catch (WebDriverTimeoutException)
            {
                // Cookies popup not displayed, ignore
            }
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public SearchPage SearchText(string searchText)
        {
            WaitForElement.WaitForElementToBeVisible(driver,SearchButton);
            // driver.FindElement(SearchButton).Click();
            SearchButton.Click();
            SearchBox.SendKeys(searchText);
            // driver.FindElement(SearchButton).Click();
            SearchButton.Click();
            return new SearchPage(driver);
        }

        public RegionsPage NavigateToRegionsPage(string region)
        {
            SelectElement dropDown = new SelectElement(Countriesselect);
            
            if (region.Equals(""))
            {
                Console.WriteLine("Region is Empty");
            }
            else
            {
                dropDown.SelectByText(region);
            }
            return new RegionsPage(driver);
        }
    }
}

