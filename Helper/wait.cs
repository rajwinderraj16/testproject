using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Helper
{
    class wait
    {

        public static void waitt(IWebDriver driver, int timeseconds, string locatervalue)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeseconds));

            wait.Until(b => b.FindElement(By.XPath(locatervalue)));
        }
    }
}
