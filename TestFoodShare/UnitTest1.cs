using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Runtime.Serialization;

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

           
        }

        //TEST LOGIN FOR ADMIN

         [Test]
            public void TestAdminLoginAndDashboard()
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

               //SHOW button
                IWebElement showButton = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-outline-secondary')]"));
                 showButton.Click();
              

               //SUBMIT BUTTON
              IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
               submitButton.Submit();




          //DASHBOARD PAGE //
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

            //REMOVE RECIPIENT ACCOUNT: not removing 
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

            //REASON FOR ERROR:same element name
           // driver.Navigate().GoToUrl("http://localhost:3000/adminDash/profile");
            // IWebElement profile = driver.FindElement(By.LinkText("#"));
          //   profile.Click();

           //CLICK LOGOUT BUTTON ://REASON FOR ERROR:same element name
          // IWebElement logout = driver.FindElement(By.CssSelector("a.text-white  nav-link"));
           //logout.Click();


        }


        /*  [TearDown]
            public void TearDown()
            {
                driver.Close();
            }


           */

        //TESTING DASHBOARD
        

        // TEST SIGNUP RECIPIENT
        [Test]

         public void TestRecipientSignUp()
         {

            driver.Navigate().GoToUrl("http://localhost:3000/recepientsignup");

            //CLICK SIGNUP BUTTON

            IWebElement dropdownB = driver.FindElement(By.XPath("//button[contains(@class,'dropdown-toggle btn btn-outline-success')]"));
            dropdownB.Click();

            //SELECT RECIPIENT
            IWebElement recipientOptionr = driver.FindElement(By.XPath("//a[@href='/recepientsignup']"));
             recipientOptionr.Click();
            
        
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

            //SHOW BUTTON 
            //IWebElement showButton = driver.FindElement(by(""));

             //SUBMIT
           IWebElement signUp = driver.FindElement(By.XPath("//button[@type='submit']"));
          signUp.Submit();
         }

        //RECIPIENT LOGIN
        [Test]

         public void TestRecipientLogin()

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

           
         }
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

        public void TestDonorLoginaAndDashboard()
        {
            //NAVIGATE LOGIN PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/login");

            //SECECTING DONOR OPTION
            IWebElement donor = driver.FindElement(By.XPath("//input[@value='Donor']"));
            donor.Click();

            //EMAIL ADDRESS
            IWebElement email = driver.FindElement(By.XPath("//input[@type='email']"));
            email.SendKeys("makematlhaga@gmail.com");

            //PASSWORD
            IWebElement password = driver.FindElement(By.XPath("//input[@type='password']"));
            password.SendKeys("Makematlhaga@2024");

            //SHOW
            IWebElement showButton = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-outline-secondary')]"));
            showButton.Click();


            //SUBMIT BUTTON 
            IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            submitButton.Click();

            //DONOR DASHBOARD
            //NAVIGATE HOME PAGE FOR DASHBOARD
            driver.Navigate().GoToUrl("http://localhost:3000/home");

            //CLICK DASHBOARD
            IWebElement dashboard = driver.FindElement(By.XPath("//a[@href='/Donordashboard']"));
            dashboard.Click();

            //NAVIGATE DASHBOAR PAGE 

            driver.Navigate().GoToUrl("http://localhost:3000/Donordashboard");
            //ERROR SAME MANES 

            //CLICK USER PROFILE
            IWebElement userProfile = driver.FindElement(By.XPath(""));
            userProfile.Click();

            //CLICK DONATION HISTORY
            IWebElement donationHistory = driver.FindElement(By.XPath(""));
            donationHistory.Click();

            //CLICK PENDING REQUEST
            IWebElement pendingRequest = driver.FindElement(By.XPath(""));
            pendingRequest.Click();

            //CLICK FEEDBACK
            IWebElement feedback = driver.FindElement(By.XPath(""));
            feedback.Click();

            //CLICK PROFILE SETTING 
            IWebElement profileSetting = driver.FindElement(By.XPath(""));
            profileSetting.Click();


           /* //DASHBOARD
            //NAVIGATE HOME PAGE FOR DASHBOARD
            driver.Navigate().GoToUrl("http://localhost:3000/home");

            //CLICK DONATE BUTTON
            IWebElement donate = driver.FindElement(By.XPath("//a[@href='/foodform']"));
            donate.Click();

           /* //NAVIGATE DONATION PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/foodform");

            //ENTER FOOD TYPE
            IWebElement foodtype = driver.FindElement(By.Id("foodType"));
            foodtype.SendKeys("fish");

            //ENTER QUANTITY
            IWebElement quantity = driver.FindElement(By.Id("quantity"));
            quantity.SendKeys("8");

            //ENTER DESCRIPTION
            IWebElement description = driver.FindElement(By.Id("description"));
            description.SendKeys("eggs,salt,6 gun-spice");

            //ENTER TIME COOKED
            IWebElement timeCooked = driver.FindElement(By.XPath("//input[@placeholder='Enter time cooked']"));
            timeCooked.SendKeys("12-08-2024 09:00");

            //ENTER PHYSICAL ADDRESS
            IWebElement physicalAdress = driver.FindElement(By.XPath("//input[@placeholder='Enter your address']"));
            physicalAdress.SendKeys("south campus main gate");

            //CONTACT INFO OR EMAIL ADDRESS
            IWebElement emailAddress = driver.FindElement(By.XPath("//input[@placeholder='Enter your email address']"));
            emailAddress.SendKeys("makematlhaga@gmail.com");

            //CLICK TERMS AND CONDITIONS
            IWebElement checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            checkbox.Click();

            //CLICK ADD ITEM    
          //  IWebElement addItem = driver.FindElement(By.XPath("//button[contains(@class, 'mt-3 btn-block btn-lg btn btn-dark')]"));
          //  addItem.Click();*/
        }
        [Test]

        public void TestDonorDashboard()

        {
            //NAVIGATE HOME PAGE FOR DASHBOARD
            driver.Navigate().GoToUrl("http://localhost:3000/home");

            //CLICK DASHBOARD
            IWebElement dashboard = driver.FindElement(By.XPath("//a[@href='/Donordashboard']"));
           dashboard.Click();

            //NAVIGATE DASHBOAR PAGE 

            driver.Navigate().GoToUrl("http://localhost:3000/Donordashboard");
            //ERROR SAME MANES 

            //CLICK USER PROFILE
            IWebElement userProfile = driver.FindElement(By.XPath(""));
            userProfile.Click();

            //CLICK DONATION HISTORY
            IWebElement donationHistory = driver.FindElement(By.XPath(""));
            donationHistory.Click();

            //CLICK PENDING REQUEST
            IWebElement pendingRequest = driver.FindElement(By.XPath(""));
            pendingRequest.Click();

            //CLICK FEEDBACK
            IWebElement feedback = driver.FindElement(By.XPath(""));
            feedback.Click();

            //CLICK PROFILE SETTING 
            IWebElement profileSetting = driver.FindElement(By.XPath(""));
            profileSetting.Click();
        }


        [Test]
        public void TestDonate() 
        {
        
        //NAVIGATE RECIPIENT HOME PAGE
        driver.Navigate().GoToUrl("http://localhost:3000/home");

            //CLICK DONATE BUTTON
            IWebElement donate = driver.FindElement(By.XPath("//a[@href='/foodform']"));
            donate.Click();

            //NAVIGATE DONATION PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/foodform");

            //ENTER FOOD TYPE
            IWebElement foodtype = driver.FindElement(By.Id("foodType"));
            foodtype.SendKeys("fish");

            //ENTER QUANTITY
            IWebElement quantity = driver.FindElement(By.Id("quantity"));
            quantity.SendKeys("8");

            //ENTER DESCRIPTION
            IWebElement description = driver.FindElement(By.Id("description"));
            description.SendKeys("eggs,salt,6 gun-spice");

            //ENTER TIME COOKED
            IWebElement timeCooked = driver.FindElement(By.XPath("//input[@placeholder='Enter time cooked']"));
            timeCooked.SendKeys("12-08-2024 09:00");

            //ENTER PHYSICAL ADDRESS
            IWebElement physicalAdress = driver.FindElement(By.XPath("//input[@placeholder='Enter your address']"));
            physicalAdress.SendKeys("south campus main gate");

            //CONTACT INFO OR EMAIL ADDRESS
            IWebElement emailAddress = driver.FindElement(By.XPath("//input[@placeholder='Enter your email address']"));
            emailAddress.SendKeys("makematlhaga@gmail.com");

            //CLICK TERMS AND CONDITIONS
            IWebElement checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            checkbox.Click();

            //CLICK ADD ITEM    
            IWebElement addItem = driver.FindElement(By.XPath("//button[contains(@class, 'mt-3 btn-block btn-lg btn btn-dark')]"));
            addItem.Click();

        }

        [Test]
        public void TestContact()
        { 
        //NAVIGATE 
        
        }



    }
}