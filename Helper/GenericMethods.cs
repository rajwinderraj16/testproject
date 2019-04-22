using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Helper
{
    class GenericMethods
    {

        public static void Edit2(IWebDriver driver, string code, string description)
        {

            commondriver.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(5));

            //Click on The edit button
            IWebElement EDIT = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            EDIT.Click();

            //select the dropdown button 

            IWebElement material3 = commondriver.driver.FindElement(By.XPath("//span[contains(text(),'select')]"));
            material3.Click();

            // select the Time option

            IWebElement material4 = commondriver.driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            material4.Click();

            Thread.Sleep(1000);

            //select the code and  clear the existing code
            IWebElement cd = commondriver.driver.FindElement(By.XPath("//input[@id='Code']"));
            cd.Clear();

            // enter the new code
            cd.SendKeys(code);

            // click the existing descrtion and clear the existing record
            IWebElement desc = commondriver.driver.FindElement(By.XPath("//*[@id='Description']"));
            desc.Clear();

            // enter the new descrption
            desc.SendKeys(description);

            // click the existing price per unit and clear the existing price per unit
            //IWebElement pricepunit = commondriver.driver.FindElement(By.XPath("//input[@id='Price']"));

            //pricepunit.Clear();
            //pricepunit.SendKeys("code");



            // click on the save button
            IWebElement SAVE1 = commondriver.driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SAVE1.Click();

        }



        
        //-------------Generic Method to check if the record is exist or not-------------------------------------------------------------

        public static bool isExist()
        {
            Thread.Sleep(1000);
            IWebElement record = commondriver.driver.FindElement(By.XPath("//tr[1]//td[5]//a[2]"));

            if (record.Displayed)
            {
                return true;
            }
            return false;
        }


        
        
        
        
//------------------------Generic Method to delete the existing record-----------------------------------------------------------
        public static void delete(IWebDriver driver)
        {
        //Click on The delete button

           IWebElement del = commondriver.driver.FindElement(By.XPath("//tr[1]//td[5]//a[2]"));
           del.Click();

           commondriver.driver.SwitchTo().Alert().Accept();


        }



    }
}




