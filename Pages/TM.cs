using ConsoleApp1.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    class TM
    {
      
            

        
        public void add()
        {
            //------------------To ADD NEW Record---------

            //Click on the  Create new button


            IWebElement BTN3 = commondriver.driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            BTN3.Click();


            //Click on the Code Textbox

            IWebElement Code1 = commondriver.driver.FindElement(By.XPath("//input[@id='Code']"));
            Code1.SendKeys("20000000");


            //click the Description

            IWebElement Description = commondriver.driver.FindElement(By.Name("Description"));
            Description.SendKeys("slack2");

            //Click on the Price Per Unit
            IWebElement PPU = commondriver.driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            PPU.SendKeys("77");


            //click on the save button
            IWebElement save = commondriver.driver.FindElement(By.Id("SaveButton"));
            save.Click();

            Thread.Sleep(10000);



        }
        // Edit existing record

        public void edit()
        {

           // IWebElement PG4 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[4]/a"));
            //PG4.Click();

            IWebElement EDIT = commondriver.driver.FindElement(By.XPath("//tr[10]//td[5]//a[1]"));

            EDIT.Click();

            IWebElement desc = commondriver.driver.FindElement(By.XPath("//*[@id='Description']"));

            desc.SendKeys("Rajjashan");

            IWebElement SAVE1 = commondriver.driver.FindElement(By.XPath("//input[@type='submit']"));
            SAVE1.Click();


            if (desc.Text == "Rajjashan")
            {
                Console.WriteLine(" RECORD HAS BEEN UPDATED");
            }
            else
            {
                Console.WriteLine("record could not update");


            }
        }

        //Ddelete A Record

        public void del()
        {
            //click on the delete button

            IWebElement del = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[10]/td[5]/a[2]"));
            del.Click();

            Thread.Sleep(10000);
            commondriver.driver.SwitchTo().Alert().Accept();


        }
    }
    }

