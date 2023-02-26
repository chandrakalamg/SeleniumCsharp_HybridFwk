using HybridFwk_POM_SeleniumProject.util;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.Tests
{
        [TestFixture]
        public class BaseTest
        {
            protected IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            ExtentReport.StartReport();
        }

        [SetUp]
        public void SetUp()
        {
            //ExtentReport.StartReport();
            driver = Drivermanager.CreateWebDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.rsmuk.com/");

        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
           // ExtentReport.StopReport();
        }

        [OneTimeTearDown]
        public void Stop()
        {
            ExtentReport.StopReport();
        }

    }
}

