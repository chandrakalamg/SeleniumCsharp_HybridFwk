using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.BasePage
{
    public class SearchPage
    {
       private readonly IWebDriver driver;

            public SearchPage(IWebDriver driver)
            {
                this.driver = driver;
            }

        //locators

        IWebElement SearchResultLnkText => driver.FindElement(By.XPath("//*[@class='row event-row']//a"));
        IWebElement SearchResultdisplay => driver.FindElement(By.XPath("//div[contains(text(),'Displaying')]"));


        public String VerifySearchResult(String input)
        {
            String seacrhsstring = SearchResultdisplay.Text;
            //seacrhsstring.Contains("Displaying 0 of 0 results") 
            return seacrhsstring;
        }

        public String VerifysearchLinks()
        {
            String linktext = SearchResultLnkText.Text;
            return linktext;
        }

        //public int GetSearchResultCount()
        //{
        //    IWebElement searchCountElement = driver.FindElement(By.Id("search-count"));
        //    string searchCountText = searchCountElement.Text.Replace(",", "");
        //    int searchCount = int.Parse(searchCountText);
        //    return searchCount;
        //}

        //public string GetFirstSearchResultLinkText()
        //{
        //    IWebElement firstResultLink = driver.FindElement(By.CssSelector(".search-results .result-item a"));
        //    return firstResultLink.Text;
        //}

        //public SearchPage ValidateSearchResults()
        //{
        //    IWebElement searchResults = driver.FindElement(By.CssSelector(".search-results"));
        //    Assert.That(searchResults.Displayed, "Search results are not displayed");
        //    return this;
        //}

        //public SearchPage ValidateSearchCount(int expectedCount = 0)
        //{
        //    if (expectedCount == 0)
        //    {
        //        expectedCount = GetSearchResultCount();
        //    }
        //    Assert.That(GetSearchResultCount() >= expectedCount, $"Actual search count: {GetSearchResultCount()} is less than expected search count: {expectedCount}");
        //    return this;
        //}


    }
    }


