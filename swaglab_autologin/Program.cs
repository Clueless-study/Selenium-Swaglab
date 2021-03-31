using System.Threading;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace swaglab_autologin
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.saucedemo.com/");


            driver.FindElementById("user-name").SendKeys("standard_user");
            driver.FindElementById("password").SendKeys("secret_sauce");
            Thread.Sleep(2000);
            driver.FindElementById("login-button").Click();
            Thread.Sleep(2000);


            driver.FindElementByClassName("btn_primary").Click();
            Thread.Sleep(1000);
            driver.FindElementByClassName("btn_primary").Click();
            Thread.Sleep(1000);


            driver.FindElementByClassName("shopping_cart_container").Click();
            Thread.Sleep(2000);


            driver.FindElementByClassName("btn_action").Click();
            Thread.Sleep(2000);


            driver.FindElementById("first-name").SendKeys("Martin");
            Thread.Sleep(1000);
            driver.FindElementById("last-name").SendKeys("BEN");
            Thread.Sleep(1000);
            driver.FindElementById("postal-code").SendKeys("4800");
            Thread.Sleep(1000);
            driver.FindElementByClassName("btn_primary").Click();
            Thread.Sleep(2000);
            driver.FindElementByClassName("btn_action").Click();


            Thread.Sleep(1500);
            driver.Quit();

        }
    }
}
