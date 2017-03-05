using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Feb2017
{
    class Program
    {
        public static object NEXT_SCREEN_DBID_listbox { get; private set; }
        public static object NEXT_SCREEN_DBID_option_selected { get; private set; }

        static void Main(string[] args)
        {
            //Define Chrome WebDriver
            IWebDriver driver = new ChromeDriver();
           

            //Launch Url
            driver.Navigate().GoToUrl("https://demo.econz.co.nz:1000/AdminPortal/Account/Login/exptest");
             
            //Maximize Browser


            //Username Definition and Input
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("jiya");

            //Password Definition and Input
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("Jiya@345");

            //Login Button Definition and Click
            IWebElement LoginButton = driver.FindElement(By.XPath("/ html / body / div[3] / form / div / div / div / div[2] / div[3] / input"));
            LoginButton.Click();

            //Verification
            String Welcome = driver.FindElement(By.XPath("//*[@id='container']/div/div/h2")).Text;
            if (Welcome == "Welcome")
                Console.WriteLine("Login Test Passed");
            else
                Console.WriteLine("Login Test Failed");

            //Userinterface dropdown definiton and click
            IWebElement UserInterface = driver.FindElement(By.LinkText("User Interface"));
            UserInterface.Click();
            //Button Definiton and click
            IWebElement Button = driver.FindElement(By.LinkText("Buttons"));
            Button.Click();

            //Add New Record button definition and Click
            IWebElement AddNewRecordButton = driver.FindElement(By.XPath("//*[@id='grid']/div[1]/a"));
            AddNewRecordButton.Click();

            //Verification of Create Window
            String Create = driver.FindElement(By.XPath("/html/body/div[6]/div[1]/span")).Text;
            if (Create == "Create")
            
                Console.WriteLine("Create window Test Passed");
                else
                Console.WriteLine("Create window Test Failed");
            //Button name definiton
            IWebElement ButtonName = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[2]/input"));
            ButtonName.SendKeys("Archana");

            //Button Display Title
            IWebElement ButtonDisplayTitle = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[4]/input"));
            ButtonDisplayTitle.SendKeys("Archu");

            //Button Logo Definition
       
            IWebElement ButtonLogo = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[6]/span/span/span[1]"));
            ButtonLogo.Click();
            Thread.Sleep(2000);

            IWebElement BLSelection = driver.FindElement(By.XPath("/html/body/div[7]/div/ul/li[4]/table/tbody/tr/td[1]/div"));
            BLSelection.Click();
            Thread.Sleep(2000);
            //Pre-Condition Definition
            IWebElement PreCondition = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[8]/input"));
            PreCondition.SendKeys("xyz");

            //Next Screen
            IWebElement NextScreen = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[10]/span/span/span[1]"));
            NextScreen.Click();

            Thread.Sleep(8000);
            IWebElement NSSelection = driver.FindElement(By.XPath("//*[@id='NEXT_SCREEN_DBID_listbox']/li[3]"));
            NSSelection.Click();
            Thread.Sleep(8000);


            //Value Update Definition
            IWebElement ValueUpdate = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[12]/input"));
            ValueUpdate.SendKeys("update");
            Thread.Sleep(2000);

            //Next State Definiton
            IWebElement NextState = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[14]/span/span/span[1]"));
            NextState.Click();
            Thread.Sleep(5000);
            IWebElement NTSelection = driver.FindElement(By.XPath("//*[@id='NEXT_STATE_DBID_listbox']/li[8]"));
            NTSelection.Click();
            Thread.Sleep(5000);

            //Pending State Definition 
            IWebElement PendingState = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[16]/span/span/span[1]"));
            PendingState.Click();
            Thread.Sleep(5000);
            IWebElement PSSelection = driver.FindElement(By.XPath("//*[@id='PENDING_STATE_DBID_listbox']/li[5]"));
            PSSelection.Click();
            Thread.Sleep(2000);

            //Entity Type Definiton
            IWebElement EntityType = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[18]/span/span/span[1]"));
            EntityType.Click();
            Thread.Sleep(5000);
            IWebElement ETSelection = driver.FindElement(By.XPath("//*[@id='ETT_DBID_listbox']/li[3]"));
            ETSelection.Click();
            Thread.Sleep(2000);
            //Override Theme ? Definition
            IWebElement OverrideTheme = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[20]/span[1]/span/span[1]"));
            OverrideTheme.Click();
            Thread.Sleep(2000);
            IWebElement ORSelection = driver.FindElement(By.XPath("/html/body/div[12]/div/ul/li[1]"));
            ORSelection.Click();
            Thread.Sleep(2000);

            //BG Colour Definiton
            //Colour efiniton
            //Border Colour efiniton

            IWebElement CreateButton = driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[27]/a[1]"));
            CreateButton.Click();
        }
    }
}
