// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

Console.WriteLine("Hello, World!");

IWebDriver driver = new ChromeDriver();
WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

driver.Url = "https://www.trendyol.com/";

/*IWebElement aramaKutusu = 
    driver.FindElement(By.XPath("//*[@id=\"sfx-discovery-search-suggestions\"]/div/div[1]/input"));
aramaKutusu.SendKeys("Test");*/

IWebElement aramaButonu2 = driver.FindElement(By.XPath("//*[@id=\"onetrust-accept-btn-handler\"]"));
aramaButonu2.Click();
// Arama butonunu bulma
IWebElement aramaButonu = 
    driver.FindElement(By.XPath("//*[@id=\"account-navigation-container\"]/div/div[1]/div[1]"));
aramaButonu.Click();

IWebElement eposta =
    driver.FindElement(By.XPath("//*[@id=\"login-email\"]"));
eposta.SendKeys("testDeneme");

IWebElement password =
    driver.FindElement(By.XPath("//*[@id=\"login-password-input\"]"));
password.SendKeys("testDeneme");

IWebElement giris =
    driver.FindElement(By.XPath("//*[@id=\"login-register\"]/div[3]/div[1]/form/button"));
giris.Click();


// İşlemler bittikten sonra tarayıcıyı kapat
driver.Quit();
