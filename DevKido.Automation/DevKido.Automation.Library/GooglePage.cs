using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DevKido.Automation.Library
{
    public class GooglePage
    {
        public static string CheckGooglePage()
        {
            IWebDriver driver = new ChromeDriver("C:\\chromedriver");

           driver.Url = "https://www.google.com/";
            // OR we can use below line instead of driver.Url 
            //driver.Navigate().GoToUrl("https://www.google.com/");

            //Wait for 5 second
            Thread.Sleep(5000);
            
            string CheckText = driver.FindElement(By.ClassName("gb_P")).Text;

            driver.Quit();

            return CheckText;
        }
    }
}
