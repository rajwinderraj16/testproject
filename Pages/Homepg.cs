using ConsoleApp1.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    class Homepg
    {
        public void homepg()
        {

            //click on the Administration dropdown

            IWebElement BTN1 = commondriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            BTN1.Click();


            //click on the Time/Material option
            IWebElement BTN2 = commondriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            BTN2.Click();
        }
    }
}
