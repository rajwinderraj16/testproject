using ConsoleApp1.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    class Login
    {

        public void Loginfun()
        {
            //Enter the username
            //Open the browser
            //open the url


            commondriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            commondriver.driver.Manage().Window.Maximize();

            try
            {
                //Enter the username

                IWebElement name = commondriver.driver.FindElement(By.Id("UserName"));
                name.SendKeys("hari");


                //Enter the passowrd

                IWebElement pass = commondriver.driver.FindElement(By.Id("Password"));
                pass.SendKeys("123123");



               //Click on the login button


                IWebElement BTN = commondriver.driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                BTN.Click();

                }

                catch(Exception e)

                {

                Console.WriteLine("error occured during the launch of homepg " , e.Message);


               }

               commondriver.driver.Manage().Window.Maximize();

     
          /*--------------Verification  the HomePage with if/else---------------------------------------------------------

            IWebElement HOME = commondriver.driver. eFindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (HOME.Text == "Hello hari!")
            {
                Console.WriteLine("Text is displayed");

            }

            else
            {
                Console.WriteLine("Text  not  displayed");
            }*/
            //-----------------------------------------------------------------------------------------------------------------------------

            //---------------------------Assert Method--------------------------------------------------------------------------------

            IWebElement HOME = commondriver.driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            Assert.That(HOME.Text, Is.EqualTo("Hello hari!"));
        }



    }
}

