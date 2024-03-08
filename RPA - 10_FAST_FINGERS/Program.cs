using OpenQA.Selenium;
using RPA___10_FAST_FINGERS.RPA;
using RPA___10_FAST_FINGERS.Uteis;

class Program
{
    internal static void Main()
    {
        IWebDriver driver =  Driver.Config();

        driver.Navigate().GoToUrl("https://10fastfingers.com/typing-test/portuguese");


        U_Selenium.Find_Click(driver,
            element: "//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]",
            seconds: 10);

        U_Selenium.Find_Text(driver);

        U_Selenium.Find_Alert(driver);

        string wpm = U_Selenium.Find_Text_Return(driver,
            element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[1]/td/strong",
            seconds: 30);

        string Keystrokes = U_Selenium.Find_Text_Return(driver,
            element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[2]/td[2]/small/span[1]",
            seconds: 30);

        string Accuracy = U_Selenium.Find_Text_Return(driver,
            element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[3]/td[2]/strong",
            seconds: 30);

        string Correct_words = U_Selenium.Find_Text_Return(driver,
            element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[4]/td[2]/strong",
            seconds: 30);

        string Wrong_words = U_Selenium.Find_Text_Return(driver,
            element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[5]/td[2]/strong",
            seconds: 30);
        
        
        driver.Quit();
    }
}