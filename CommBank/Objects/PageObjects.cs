using CommBank.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace CommBank.Objects
{

    public interface IPageObjects
    {
        void ClickRegister();
        void CustomRegistration();
        void InformationPage();
        void RegisterationInfo();
    }
    public class PageObject : WebDriver, IPageObjects
    {

        public static string Button = "#form1>div.regStyle>div.regContent>div>a";
        public static string Frame = "frmRegistration";
        public static string AdvanceRadio = "input[id=rdoAdvanced]";
        public static string CheckBox = "input[id=chkMMFXSelected]";
        public static string NextButton = "input[id=btnNext]";
        public static string Submit = "input[id=btnSubmit]";
        public static string UserName = "input[name=txtUserName]";
        public static string UserText = "Username";
        public static string Password = "input[id=txtPassword]";
        public static string PasswordText = "password";
        public static string PasswordReEnter = "input[id=txtReenterPassword]";
        public static string SecretQuestion1 = "#ddlSecret1>option:nth-child(11)";
        public static string SecretAnswer1 = "input[id=txtSecret1]";
        public static string SecretAnswer1Text = "Black";
        public static string SecretQuestion2 = "#ddlSecret2>option:nth-child(14)";
        public static string SecretAnswer2 = "input[id=txtSecret2]";
        public static string SecretAnswer2Text = "Toyota";
        public static string Register = "input[name=btnSubmit]";
        public static string ScreenshotLocation = "D:\\repos\\CommBank\\TestResults\\";

        public PageObject()
        {
        }
        public void ClickRegister()
        {
            Driver.SwitchTo().Frame(Frame);
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"1LoginPage.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(Button);
        }

        public void CustomRegistration()
        {
            WaitforElementVisible(AdvanceRadio);
            ClickByCSS(AdvanceRadio);
            ClickByCSS(CheckBox);
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"2CustomRegistration.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(NextButton);
        }

        public void InformationPage()
        {
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"3InformationPage.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(Submit);
        }

        public void RegisterationInfo()
        {
            SendKeysByCSS(UserName, UserText);
            SendKeysByCSS(Password, PasswordText);
            SendKeysByCSS(PasswordReEnter, PasswordText);
            ClickByCSS(SecretQuestion1);
            SendKeysByCSS(SecretAnswer1, SecretAnswer1Text);
            ClickByCSS(SecretQuestion2);
            SendKeysByCSS(SecretAnswer2, SecretAnswer2Text);
            Driver.TakeScreenshot().SaveAsFile(ScreenshotLocation+"4RegistrationInfo.jpg", ScreenshotImageFormat.Jpeg);
            ClickByCSS(Register);
        }
    }
}
