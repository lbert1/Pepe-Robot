using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Pepe
{
    class Robot
    {
        private ChromeOptions Options { get; set; }
        private ChromeDriver RoboDriver { get; set; }
        private WebDriverWait Wait { get; set; }
        public Robot()
        {
            // CRIAR OPÇÕES DO NAVEGADOR SELENIUM
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("no-sandbox");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--window-size=1024, 1280");
            Options = options;

            // CRIAR SERVIÇOS DO NAVEGADOR SELENIUM
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            // CRIAR OBJETO ROBO PARA NAVEGAÇÃO
            var roboDriver = new ChromeDriver(service, options);
            var wait = new WebDriverWait(roboDriver, TimeSpan.FromSeconds(10));
            Wait = wait;
            RoboDriver = roboDriver;
        }
        #region Methods Robot
        public void SkipAlert()
        {
            var i = 0;
            while (i++ < 10000)
            {
                try
                {
                    RoboDriver.SwitchTo().Alert().Accept();
                    break;
                }
                catch (NoAlertPresentException)
                {
                    Thread.Sleep(1);
                }
            }
        }
        //AGUARDAR FORÇADO
        public void ForceSleep(int time)
        {
            RoboDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
            Thread.Sleep(time);
        }
        //NAVEGAR PARA O SITE(URL)
        public void GoToUrl(string Url)
        {
            RoboDriver.Navigate().GoToUrl(Url);
        }
        //FECHAR ROBO
        public void RobotQuit()
        {
            RoboDriver.Quit();
        }
        //PROCURAR TAG ID E CLICAR
        public void ClickById(ChromeWebElement webElement, string IdTag)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(IdTag)));
            RoboDriver.FindElementById(IdTag).Click();
        }
        //PROCURAR TAG ID E ESCREVER
        public void WriteById(string IdTag, string Write)
        {
            Wait.Until(d => RoboDriver.FindElementById(IdTag));
            RoboDriver.FindElementById(IdTag).SendKeys(Write);
        }
        //PROCURAR POR XPATH LER E RETORNAR VALOR
        public string ReadByXPath(string XPath, string attribute)
        {
            string SetRead;
            Wait.Until(d => RoboDriver.FindElementByXPath(XPath));
            SetRead = RoboDriver.FindElementByXPath(XPath).GetAttribute(attribute);
            return SetRead;
        }
        #endregion
    }
}
