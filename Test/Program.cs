using ConsoleApp1.Helper;
using ConsoleApp1.Pages;
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
    class Program
    {
        static void Main(string[] args)
        {
            //initializing driver
            commondriver.driver = new ChromeDriver();


            //login object and loggin into turnup
            Login lg = new Login();
            lg.Loginfun();

            //homepage object and navigate to homepage

            Homepg hmog = new Homepg();
            hmog.homepg();

            //tm page object and edit the existing record

            TM timenmat = new TM();
            timenmat.edit();

            timenmat.del();

            timenmat.add();
        }
    }
}