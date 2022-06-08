using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project1.Utilities;
using System;
using System.Threading;

namespace Project1
{
    [TestFixture]
    [Parallelizable]
    class TMtests : CommonDriver

    {
        
            
            TMPage tmpageobj = new TMPage();
            Homepage homepageobj = new Homepage();

        [Test, Order(1), Description("create time and material record with valid data")]
            public void CreateTMPage()
            {
            // Homepage object intialization and defining
                homepageobj.GoToTMpage(driver);

            //TMpage object intialization and defining
                tmpageobj.CreateTM(driver);
            }

            [Test, Order(2), Description("Edit time and material record created in test number 1")]
            public void EditTMPage()
            {
            // Homepage object intialization and defining
               homepageobj.GoToTMpage(driver);
            //EditTM page object intialization and defining
               tmpageobj.EditTM(driver);
            }

            [Test, Order(3), Description("Delete time and material record edited in test number 2")]
            public void DeleteTMPage()
            {
            // Homepage object intialization and defining
               homepageobj.GoToTMpage(driver);
            //EditTM page object intialization and defining
               tmpageobj.DeleteTM(driver);
            }
      
    }

}