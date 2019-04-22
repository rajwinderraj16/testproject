using ConsoleApp1.Helper;
using ConsoleApp1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Test
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
        }
            /*----------------------------------Simple Approach to create the test cases----------------------------------//


            IWebDriver driver = new ChromeDriver();

            //Navigate To Time And Material Website

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");


            //Maximise the browser window

            driver.Manage().Window.Maximize();

            //Enter the username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");


            //Enter the password

            IWebElement pass = driver.FindElement(By.Id("Password"));
            pass.SendKeys("123123");

            //click on the login button

            IWebElement logbtn = driver.FindElement(By.XPath("//input[@value='Log in']"));

            logbtn.Click();


            //------------ Verification of the Homepage with If/else----------------------- :


            

            IWebElement text = driver.FindElement(By.XPath("//a[contains(text(),'Hello hari!')]"));

            if (text.Text == "Hello hari!")
            {
                Console.WriteLine("Text is displayed");
            }
            else
            {
                Console.WriteLine("Text did not dispaly");
            }

            //---------------Navigate to the the Time and Material page-------------------------------------

            //Click on The Admininstration dropdown 

            IWebElement admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));

            admin.Click();

            // Select the Time & Material option:

            IWebElement TM = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));

            TM.Click();
            //------------------------------------------------------------------------------------------------------------



            //------------------------Create new  record--------------------------------------------------------------

            IWebElement creatbtn = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatbtn.Click();

            //select the dropdown button 

            IWebElement material = driver.FindElement(By.XPath("//span[contains(text(),'select')]"));
            material.Click();

            // select the material option

            IWebElement material1 = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            material1.Click();

            // Enter the code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("8787");

            //Enter the description
            IWebElement decs = driver.FindElement(By.Name("Description"));
            decs.SendKeys("selenium121212");

            // Enter the price per unit
            IWebElement ppu = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            ppu.SendKeys("15000");

            //click on the save button
            IWebElement save = driver.FindElement(By.Id("SaveButton"));
            save.Click();

            //-------------------Verification of the newly added record-------------------------------------------

            //navigate to the last page

            Thread.Sleep(2000);

            IWebElement lastpg = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpg.Click();

            IWebElement newrec = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[3]"));

            if (newrec.Text == "selenium121212")
            {
                Console.WriteLine("NEW RECORD HAS BEEN ADDED SUCESSFULLY");
            }

            else
            {
                Console.WriteLine("new record has not been added");
            }


            //-------------------------------Edit the existing record on page5----------------------------------------------------

            /*Navigate on to the page5

            Thread.Sleep(3000);

            IWebElement PG5 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[5]/a"));
            PG5.Click();

            //Click on The edit button
            IWebElement EDIT = driver.FindElement(By.XPath("//tr[3]//td[5]//a[1]"));
            EDIT.Click();

            //select the dropdown button 

            IWebElement material3 = driver.FindElement(By.XPath("//span[contains(text(),'select')]"));
            material3.Click();

            // select the Time option

            IWebElement material4 = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            material4.Click();

            Thread.Sleep(1000);

            //select the code and  clear the existing code
            IWebElement cd = driver.FindElement(By.XPath("//input[@id='Code']"));
            cd.Clear();

            // enter the new code
            cd.SendKeys("198686");

            // click the existing descrtion and clear the existing record
            IWebElement desc = driver.FindElement(By.XPath("//*[@id='Description']"));
            desc.Clear();

            // enter the new descrption
            desc.SendKeys("drinksdrinks");

            // click the existing price per unit and clear the existing price per unit
            //IWebElement pricepunit = driver.FindElement(By.XPath("//input[@id='Price']"));

            //pricepunit.Clear();
            //pricepunit.SendKeys("77777");



            // click on the save button
            IWebElement SAVE1 = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SAVE1.Click();


            Thread.Sleep(2000);


            //-----------------------------Verification of the new updated record------------------------------------------


            //Navigate on to the page5
            IWebElement PGg5 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[5]/a"));
            PGg5.Click();

            IWebElement newcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[1]"));
            if (newcode.Text == "198686")
            {
                Console.WriteLine("198686 is present on the pageno 5");
            }

            else
            {
                Console.WriteLine("198686 is not  present on page no 5");
            }


 //----------------------------Delete the existing record on firstpage------------------------------------------------------

            //Navigate on to the firstpage

            //IWebElement frstpg1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[1]/span"));
            //frstpg1.Click();


            Thread.Sleep(2000);

            //Click on The delete button

            IWebElement del = driver.FindElement(By.XPath("//tr[9]//td[5]//a[2]"));
            del.Click();

            driver.SwitchTo().Alert().Accept();



//-------------------------------------Verification of the deleted record----------------------------------------------

            IWebElement descrpt = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[9]/td[3]"));


            if (descrpt.Text != "desc")
            {
                Console.WriteLine("record has been deleted");
            }
            else
            {
                Console.WriteLine("reocrd has not been deleted");
            }


   //----------------------------------------Page object model-------------------------------------------------------------------//

            
            
            //initializing driver

            commondriver.driver = new ChromeDriver();

            commondriver.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(10));

            //login object and loggin into turnup

            Login lg = new Login();
            lg.Loginfun();

            //homepage object and navigate to homepage

            Homepg hmog = new Homepg();
            hmog.homepg();

            //TM page object and edit the existing record

            TM timenmat = new TM();

            timenmat.add();
            timenmat.edit1();
            timenmat.dell();


            }*/



            //----------------------------------------------------------------------------------------------------------------------------//



            //----------------------------------------------Nunit Framework------------------------------------------------------------------//


        [SetUp]
        public void Setup()
        {

            commondriver.driver = new ChromeDriver();


            //login object and loggin into turnup

            Login lg = new Login();

            lg.Loginfun();


            Homepg hmog = new Homepg();
            hmog.homepg();


        }

        [Test]
        public void testadd()

        {
            TM timenmat = new TM();
            timenmat.add();
        }
     

        [Test]
        public void testedit1()
        {

            TM timenmat = new TM();
            timenmat.edit1();

        }

        [Test]

        public void testdell()
        {

            TM timenmat = new TM();
            timenmat.dell();

        }

        [TearDown]
        public void closebrowser()

        {
            commondriver.driver.Close();
        }
    }
    }














