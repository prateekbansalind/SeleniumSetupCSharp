using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTest
{
    public class SeleniumTest
    {
        IWebDriver driver; // declare the driver variable as Interface IWebdriver. 

        [SetUp]
        public void StartBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); // This line will basically eradicate the need of separate chrome driver.
            // chromedriver.exe on chrome browser

            // new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // Gecko driver for Firefox browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());



            //driver =  new ChromeDriver(); // this is to create a object of Chromedriver class. 
            //driver = new FirefoxDriver();

            // driver setting for edge
            driver = new EdgeDriver();


            //driver.Manage().Window.Maximize();
            driver.Manage().Window.Maximize(); // This helps to maximize the screen.
        }

        [Test]
        public void Test()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Url);
            TestContext.Progress.WriteLine(driver.Title);
            // driver.PageSource - to see the code behind the webpage. 

            //driver.Close();  // to close the original 1st webpage.
            //driver.Quit();   // to quit the whole webpages. 
        }
    }
}
