
using OpenQA.Selenium;
using RPA___10_FAST_FINGERS.DB;
using RPA___10_FAST_FINGERS.RPA;
using RPA___10_FAST_FINGERS.Uteis;

class Program
{
    internal static void Main()
    {
        IWebDriver driver = Driver.Config();
        try
        {
            

            driver.Navigate().GoToUrl("https://10fastfingers.com/typing-test/portuguese");


            U_Selenium.Find_Click(driver,
                element: "//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]",
                seconds: 10);

            U_Selenium.Find_Text(driver);

            U_Selenium.Find_Alert(driver);

            string wpm = U_Selenium.Find_Text_Return(driver,
                element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[1]/td/strong",
                seconds: 30);

            wpm = wpm.Replace("WPM", "");

            int wpmInt = int.Parse(wpm);
            Console.WriteLine($"WPM: {wpmInt}");


            string Keystrokes = U_Selenium.Find_Text_Return(driver,
                element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[2]/td[2]/small/span[1]",
                seconds: 30);
            Console.WriteLine($"Keystrokes: {Keystrokes}");


            string Accuracy = U_Selenium.Find_Text_Return(driver,
                element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[3]/td[2]/strong",
                seconds: 30);

            Accuracy = Accuracy.Replace("%", "");
            int Accuracyint = int.Parse(Accuracy);
            Console.WriteLine($"Accuracy: {Accuracy}");


            string Correct_words = U_Selenium.Find_Text_Return(driver,
                element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[4]/td[2]/strong",
                seconds: 30);
            Console.WriteLine($"Correct_words: {Correct_words}");


            string Wrong_words = U_Selenium.Find_Text_Return(driver,
                element: "/html/body/div[5]/div/div[4]/div/div[1]/div[12]/div[2]/div[1]/table/tbody/tr[5]/td[2]/strong",
                seconds: 30);
            Console.WriteLine($"Wrong_words: {Wrong_words}");

            driver.Quit();

            Connection.Insert_Data(wpm: wpmInt,
                keystrokes: int.Parse(Keystrokes),
                acurracy: Accuracyint,
                correct_words: int.Parse(Correct_words),
                wrong_words: int.Parse(Wrong_words));


        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            driver.Quit() ;
        }
    }
}