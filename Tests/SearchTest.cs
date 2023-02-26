using AventStack.ExtentReports;
using HybridFwk_POM_SeleniumProject.BasePage;
using HybridFwk_POM_SeleniumProject.util;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.Tests
{
    public class SearchTest : BaseTest
    {

        [Test]
        public void SearchText()
        {
            String searchtext = "Audit";
            ExtentReport.CreateTest($"TestName : Search_{searchtext}");
            try
            {
                HomePage homePage = new HomePage(driver);
                SearchPage searchPage = new SearchPage(driver);
                homePage.SearchText(searchtext);
                String searchResult = searchPage.VerifySearchResult("searchtext");
                if (searchResult.Contains("Displaying 0 of 0 results"))
                {
                    ExtentReport.LogTestStep(Status.Pass, searchResult);
                }
                else
                {
                    String firstsearchLink = searchPage.VerifysearchLinks();
                    //Console.WriteLine("Number of results " + searchResult + " and First search result is " + firstsearchLink);
                    ExtentReport.LogTestStep(Status.Pass, "Number of results " + searchResult + " and First search result is " + firstsearchLink);
                }

            }
            catch (AssertionException ex)
            {
                ExtentReport.LogTestStep(Status.Fail, ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                ExtentReport.LogTestStep(Status.Error, ex.Message);
                throw;
            }
        }
    }
}
