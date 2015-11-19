using OpenQA.Selenium;
using Specflow_Selenium_PO_Example2.Step_Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Specflow_Selenium_PO_Example2.Utils;
using OpenQA.Selenium.Support.UI;

namespace Specflow_Selenium_PO_Example2.Pages
{
    [Binding]
    class BasePage // :  Base
    {
        readonly IWebDriver driver;
        public BasePage() {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        /// <summary>
        /// Enters text into an element
        /// </summary>
        /// <param name="inputText">The text to input</param>
        /// <param name="locator">The element to enter text into</param>
        public void type (String inputText, By locator) {
            find(locator).SendKeys(inputText);
        }
        /// <summary>
        /// Waits up to 15 seconds for an element to be visible, then returns it
        /// </summary>
        /// <param name="locator">The element to find</param>
        /// <returns>WebDriver IWebElement</returns>
        public IWebElement find(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15);
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        /// <summary>
        /// Opens the BaseUrl appended with the page url
        /// </summary>
        /// <param name="url"></param>
        public void visit(String url)
        {
            driver.Navigate().GoToUrl(Config.BaseUrl + url);
                
        }

        /// <summary>
        /// Left clicks an element
        /// </summary>
        /// <param name="locator">The element to click</param>
        public void click(By locator)
        {
            find(locator).Click();
        }

        /// <summary>
        /// gets the inner HTML test of an element
        /// </summary>
        /// <param name="locator">The element which contains the text</param>
        /// <returns></returns>
        public String getText(By locator)
        {
            return find(locator).Text;
        }

        /// <summary>
        /// Checks whether an element is displayed and enabled
        /// </summary>
        /// <param name="locator">The element to be checked</param>
        /// <returns>True if the element is visible and enabled</returns>
        public Boolean isDisplayed(By locator)
        {
            try
            {
                return find(locator).Displayed && find(locator).Enabled;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        
        /// <summary>
        /// Submits a form
        /// </summary>
        /// <param name="locator"></param>
        public void submit(By locator)
        {
            find(locator).Submit();
        }
    }
}
