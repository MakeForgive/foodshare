using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestFoodShare
{
    public class Tests
    {


        IWebDriver driver;
      //  WebDriverWait wait;
        [SetUp]
        public void Setup()

        {
            driver = new ChromeDriver();
          //  wait =  new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //navigate the HOME PAGE

            driver.Navigate().GoToUrl("http://localhost:3000/");

            /* driver.Navigate().GoToUrl("http://localhost:3000/login");
              driver.Navigate().GoToUrl("http://localhost:3000/adminDash");
             driver.Navigate().GoToUrl("http://localhost:3000/adminDash/userAccounts");
            driver.Navigate().GoToUrl("http://localhost:3000/adminDash/RecipientAccounts");
              driver.Navigate().GoToUrl("http://localhost:3000/adminDash/donationHistory");
              driver.Navigate().GoToUrl("http://localhost:3000/adminDash/recipientRequestHistory");*/

        }

        //TEST LOGIN FOR ADMIN
        
       /* [Test]
           public void TestAdmin()
           {
               //LOGIN PAGE
                  driver.Navigate().GoToUrl("http://localhost:3000/login");

               //CLICKING ADMIN BUTTON
               IWebElement AdminButton = driver.FindElement(By.XPath("//input[@value='Admin']"));
              AdminButton.Click();

                 //ADMIN EMAIL
                 IWebElement Adminemail = driver.FindElement(By.XPath("//input[@type='email']"));
                 Adminemail.SendKeys("admin2024@gmail.com");

                 //PASSWORD
                IWebElement Password = driver.FindElement(By.XPath("//input[@type='password']"));
                Password.SendKeys("Admin@2024");

    
                //SUBMIT BUTTON
                  // IWebElement showButton = driver.FindElement(By.XPath("//button[@type='button']"));
                  //  showButton.Click();


                   //SUBMIT BUTTON
                  IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
                 submitButton.Submit();


          }/*


     /*  [TearDown]
         public void TearDown()
         {
             driver.Close();
         }

        
        */
         //TESTING DASHBOARD
       /* [Test]    



         public void TestDashboard() 

         {
             //DASHBOARD PAGE 
              driver.Navigate().GoToUrl("http://localhost:3000/adminDash");


           //CLICK DASHBOARD
            IWebElement dashboard = driver.FindElement(By.XPath("//button[contains(@class, 'mb-2 text-start btn btn-outline-secondary')]"));
            dashboard.Click();
           

             //CLICK DONOR ACCOUNT
             driver.Navigate().GoToUrl("http://localhost:3000/adminDash/userAccounts");
            IWebElement donorAccount = driver.FindElement(By.XPath("//button[contains(@class, 'mb-2 text-start btn btn-secondary')]"));
                        donorAccount.Click();

             //CLICK REIPIENT ACCOUNT
            driver.Navigate().GoToUrl("http://localhost:3000/adminDash/RecipientAccounts");
             IWebElement recipientAccount = driver.FindElement(By.XPath("//button[contains(@class, 'mb-2 text-start btn btn-secondary')]"));
             recipientAccount.Click();
              
              //REMOVE RECIPIENT ACCOUNT
            //  IWebElement removeRecipient = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-outline-danger btn-sm')]"));
            //removeRecipient.Click();



             //CLICK DONATION HISTORY
           driver.Navigate().GoToUrl("http://localhost:3000/adminDash/donationHistory");
             IWebElement donationHistory = driver.FindElement(By.XPath("//button[contains(@class, 'mb-2 text-start btn btn-secondary')]"));
             donationHistory.Click();

              //CLICK RECIPIENT HISTORY
           driver.Navigate().GoToUrl("http://localhost:3000/adminDash/recipientRequestHistory");
             IWebElement recipientHistory = driver.FindElement(By.XPath("//button[contains(@class, 'mb-2 text-start btn btn-secondary')]"));
             recipientHistory.Click();

            //NO BACKEN YET
           // driver.Navigate().GoToUrl("http://localhost:3000/adminDash/profile");
            // IWebElement profile = driver.FindElement(By.LinkText("#"));
             //profile.Click();

           //CLICK LOGOUT BUTTOM
          //  IWebElement logout = driver.FindElement(By.CssSelector("a.text-white  nav-link"));
           // logout.Click();


           }
        
        // TEST SIGNUP RECIPIENT
       /* [Test]

        public void TestSignUp()
        {

           driver.Navigate().GoToUrl("http://localhost:3000/recepientsignup");
          // IWebElement SignUp = driver.FindElement(By.XPath("//button[@type='button']"));
         // SignUp.Click();

            // IWebElement Recipent = driver.FindElement(ByXPath(""));
          // IWebElement dropdownButton = driver.FindElement(By.XPath("//button[contains(@class,'dropdown-toggle')]"));
           // dropdownButton.Click();

            //driver.Navigate().GoToUrl("http://localhost:3000/recepientsignup");
          // IWebElement recipientOption = driver.FindElement(By.XPath("//a[@href='/recepientsignup']"));
          // recipientOption.Click();

            //INSERTING THE ELEMENTS DITAILS 

            //organisation_name
            IWebElement organization_name = driver.FindElement(By.XPath("//input[@type='text']"));
            organization_name.SendKeys("forgive");


            //EMAIL
            IWebElement recipientEmail = driver.FindElement(By.XPath("//input[@type='email']"));
            recipientEmail.SendKeys("recipient@gmail.com");

            //TELPHONE
            IWebElement telphone = driver.FindElement(By.XPath("//input[@type='tel']"));
            telphone.SendKeys("012 345 6789");

            //BUSSINESS ADDRESS
            IWebElement bussinessAdress = driver.FindElement(By.XPath("//input[@type='text1']"));
            bussinessAdress.SendKeys("TUT");

            //PASSWORD
            IWebElement recipientPassword = driver.FindElement(By.XPath("//input[@type='password']"));
            recipientPassword.SendKeys("recipient@2024");

            //CONFIRM PASSWORD
            IWebElement confirmPassword = driver.FindElement(By.XPath("//input[@type='password1']"));
            confirmPassword.SendKeys("recipient@2024");

            //SUBMIT
          IWebElement signUp = driver.FindElement(By.XPath("//button[@type='submit']"));
          signUp.Submit();
        }*/

        //RECIPIENT LOGIN
       /* [Test]

        public void TestLogin()

        {
            //LOGIN PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/login");


            //CLICK RECIPIENT BUTTON
            IWebElement recipientButton = driver.FindElement(By.XPath("//input[@value='Recipient']"));
            recipientButton.Click();


            //RECIPIENT EMAIL
            IWebElement recipientemail = driver.FindElement(By.XPath("//input[@type='email']"));
            recipientemail.SendKeys("recipient@gmail.com");


            //RECIPIENT PASSWORD
            IWebElement passwordRecipient = driver.FindElement(By.XPath("//input[@type='password']"));
            passwordRecipient.SendKeys("recipient@2024");


            //SUBMIT BUTTON
            IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            submitButton.Submit();

            //admin
            /*  driver.Navigate().GoToUrl("http://localhost:3000/login");

                    IWebElement AdminButton = driver.FindElement(By.XPath("//input[@value='Admin']"));
                      AdminButton.Click();

                      IWebElement Adminemail = driver.FindElement(By.XPath("//input[@type='email']"));
                      Adminemail.SendKeys("admin2024@gmail.com");

                      IWebElement Password = driver.FindElement(By.XPath("//input[@type='password']"));
                      Password.SendKeys("Admin@2024");



                   IWebElement submitButton2 = driver.FindElement(By.XPath("//button[@type='submit']"));
                     submitButton2.Submit();*/
       // }
      /*  

        //RECIPIENT DASHBOARD
        [Test]
          public void TestRecipient()
        
          {
            //LANDING PAGE

            driver.Navigate().GoToUrl("http://localhost:3000/RecipientLandingPage");

            //CLICK PROFILE OPTION/BUTTON
         /*  IWebElement recipientProfile = driver.FindElement(By.XPath("//span[text()='Profile']"));
              recipientProfile.Click();

              driver.Navigate().GoToUrl("http://localhost:3000/foodlisting");
                //CLICK FOOD LIST
                IWebElement foodlist = driver.FindElement(By.XPath("//span[@class='fw-bold']"));
                            foodlist.Click();

            //RECORD


          }*/

        //DONOR SIGNUP
        [Test]

        public void TestDonorSignUp()
        {
         
            //CLICK SIGNUP BUTTON
          
            IWebElement dropdownB = driver.FindElement(By.XPath("//button[contains(@class,'dropdown-toggle btn btn-outline-success')]"));
            dropdownB.Click();

           //SELECT DONOR
               IWebElement selectDonor = driver.FindElement(By.XPath("//a[@href='/signup']"));
               selectDonor.Click();


            //NAVIGATE DONOR PAGE 
            driver.Navigate().GoToUrl("http://localhost:3000/signup");


            //DONOR NAME
            IWebElement donorName = driver.FindElement(By.XPath("//input[@type='text']"));
            donorName.SendKeys("Forgive");

            //EMAIL ADDDRESS
            IWebElement donorEmail = driver.FindElement(By.XPath("//input[@type='email']"));
            donorEmail.SendKeys("makematlhaga@gmail.com");

            //TELPHONE
            IWebElement telphone = driver.FindElement(By.XPath("//input[@type='tel']"));
            telphone.SendKeys("0764399943");

            //PHYSICAL ADDRESS
            IWebElement physicalAddress = driver.FindElement(By.XPath("//input[@type='text1']"));
            physicalAddress.SendKeys("Tshwane");

            //PASSWORD
            IWebElement password = driver.FindElement(By.XPath("//input[@type='password']"));
            password.SendKeys("Makematlhaga@2024");

            //CONFIRM PASSWORD
           IWebElement confirmPassword = driver.FindElement(By.XPath("//input[@placeholder='Confirm password']"));
            confirmPassword.SendKeys("Makematlhaga@2024");

            //SUBMIT BUTTON
            IWebElement signUp = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-dark')]"));
            signUp.Click();
        }

        [Test]

        public void TestDonorLogin()
        {
            //NAVIGATE LOGIN PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/login");




        }

    }
}