using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace LearnSelenium
{
    public class OldLocators
    {
        IWebDriver driver;
        // Xpath, css, id, classname, name, tagname
        public void StartBrowser()
        {
            //Methods -geturl , click-
            //Commands go through chromedriver.exe on chrome browser
            //Specific version of chrome browser
            //WebDriverManager = compatible chromedriver.exe
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  //maximizes browser window
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }

        [Test]
        public void LocatorIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("username")).Clear();
        }
    }
}
