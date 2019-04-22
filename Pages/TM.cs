using ConsoleApp1.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

            //------------------To ADD NEW Record/Page object Model--------------------------------------------------------------

            //Click on the  Create new button

            Thread.Sleep(2000);
            IWebElement BTN3 = commondriver.driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
            BTN3.Click();


            //Click on the Code Textbox

            IWebElement Code1 = commondriver.driver.FindElement(By.XPath("//input[@id='Code']"));
            Code1.SendKeys("3635");


            //click the Description

            IWebElement Description = commondriver.driver.FindElement(By.Name("Description"));
            Description.SendKeys("Slack9");

            //Click on the Price Per Unit
            IWebElement PPU = commondriver.driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            PPU.SendKeys("666");


            //click on the save button
            IWebElement save = commondriver.driver.FindElement(By.Id("SaveButton"));
            save.Click();


        }

        /*---------------------------------Verification of the newly added code--------------------------------------------------------

                      Thread.Sleep(1000);

                      IWebElement lastpg = commondriver.driver.FindElement(By.XPath(" //span[@class='k-icon k-i-seek-e']"));
                      lastpg.Click();

                      Thread.Sleep(1000);
                      IWebElement descbox = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[9]/td[3]"));

                      if (descbox.Text == "slack9")
                      {
                          Console.WriteLine("New code has been added");
                      }

                      else
                      {
                          Console.WriteLine("code has not  added");
                      }
                      Thread.Sleep(10000);

                      }*/





        /*----------------------------------------------Assertion Method--------------------------------------------------------------

        Thread.Sleep(1000);

        IWebElement llastpg1 = commondriver.driver.FindElement(By.XPath(" //span[@class='k-icon k-i-seek-e']"));
        llastpg1.Click();

        Thread.Sleep(1000);

        IWebElement descbox1 = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[3]"));

        Assert.That(descbox1.Text, Is.EqualTo("Slack9"));


    }*/





        //----------------------------------------- Edit existing record with Generic Method----------------------------------------------------------


        public void edit1()
        {



            /* if (GenericMethods.isExist() == true)
             {
                 GenericMethods.Edit2(commondriver.driver, "200", "raj");
             }*/





            //------------------------------Edit the existing record on page1 with PageObjectModel----------------------------------------------------
            //------------Navigate  to the page5 from the lastpg-----------------------------------------------


            commondriver.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(5));

            IWebElement PG5 = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[1]/span"));
            PG5.Click();



            //Click on The edit button
            IWebElement EDIT = commondriver.driver.FindElement(By.XPath("//tr[3]//td[5]//a[1]"));
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
            cd.SendKeys("1986");

            // click the existing descrtion and clear the existing record
            IWebElement desc = commondriver.driver.FindElement(By.XPath("//*[@id='Description']"));
            desc.Clear();

            // enter the new descrption
            desc.SendKeys("drinks");

            // click the existing price per unit and clear the existing price per unit
            IWebElement pricepunit = commondriver.driver.FindElement(By.XPath("//input[@id='Price']"));

            //pricepunit.Clear();
            //pricepunit.SendKeys("777");



            // click on the save button
            IWebElement SAVE1 = commondriver.driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SAVE1.Click();

        }

        /*--------------------------------------Verification of the new updated record------------------------------------------------

                 //Thread.Sleep(2000);

                 //Navigate on to the page1

                 IWebElement   PPGg1 = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[5]/a"));
                 PPGg1.Click();

                 IWebElement newcode = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[1]"));
                 if (newcode.Text == "1986")
                 {
                     Console.WriteLine("1986 is present on the pageno 5");
                 }

                 else
                 {
                     Console.WriteLine("1986 is not  present on page no 5");
                 }*/




        /*-------------------------Assertion-------------------------------------------------------------------------------------------



        Thread.Sleep(1000);

        IWebElement newcode1 = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[1]"));


        Assert.That(newcode1.Text, Is.EqualTo("1986"));*/






        //--------------------------Delete the existing record on firstpage with Generic  Method-----------------------------------------------

        public void dell()

        {


            /*(GenericMethods.isExist() == true)
           {
               GenericMethods.delete(commondriver.driver);
           }*/





            //------ -------------------------Detele the existing record on page2 with Page Object Model---------------------------------------------



            //WebDriverWait wait = new WebDriverWait(commondriver.driver, TimeSpan.FromSeconds(10));
            //wait.Until(b => b.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[2]/a")));



            wait.waitt(commondriver.driver, 3, "//*[@id='tmsGrid']/div[4]/ul/li[2]/a");

            IWebElement frstpg2 = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[2]/a"));
            frstpg2.Click();


            Thread.Sleep(2000);

            //Click on The delete button

            IWebElement del = commondriver.driver.FindElement(By.XPath("//tr[1]//td[5]//a[2]"));
            del.Click();

            commondriver.driver.SwitchTo().Alert().Accept();


            /*--------------------------Verification of the deleted record-------------------------------------------------------------------

                       IWebElement descrpt = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));


                       if (descrpt.Text != "Testing to see if edit page works")
                       {
                           Console.WriteLine("record has been deleted");
                       }
                       else
                       {
                           Console.WriteLine("reocrd has not been deleted");
                       }*/




            /*----------------------Assertion-------------------------------------------------------------------------------------------------

            IWebElement descrpt1 = commondriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));

            Assert.That(descrpt1.Text, Is.Not.EqualTo("Testing to see if edit page works"));*/
        }

    }
}

    

    
