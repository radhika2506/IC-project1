using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Project1
{
    class TMtests
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();

            //Loginpage object intialization and defining
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.Loginsteps(driver);

            // Homepage object intialization and defining
            Homepage homepageobj = new Homepage();
            homepageobj.GoToTMpage(driver);

            //TMpage object intialization and defining
            TMpage tmpageobj = new TMpage();
            tmpageobj.CreateTM(driver);

            // Edit object intialization and defining
            tmpageobj.EditTM(driver);


            // deleteobject intialization and defining

            tmpageobj.DeleteTM(driver);
































        }
    }
}
