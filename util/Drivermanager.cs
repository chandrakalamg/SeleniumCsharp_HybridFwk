using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace HybridFwk_POM_SeleniumProject.util
{
    public class Drivermanager
    {

        //protected static IWebDriver driver;
        //protected static WaitForElement wait = new WaitForElement();

        public static IWebDriver CreateWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
           // ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
    }
}
