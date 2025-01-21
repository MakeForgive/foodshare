
  using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;


namespace TestFoodShare
{
    public class Tests
    {


        IWebDriver driver;
        //WebDriverWait wait;
        [SetUp]
        public void Setup()

        {
            driver = new ChromeDriver();
            // wait =  new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Window.Maximize();
            //navigate the HOME PAGE

            driver.Navigate().GoToUrl("http://localhost:3000/");


        }

        //TEST LOGIN FOR ADMIN

        [Test]
        public void TestAdmin()
        {
            //LOGIN PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/login");

            //CLICKING ADMIN BUTTON
            IWebElement AdminButton = driver.FindElement(By.XPath("//input[@value='Admin']"));
            AdminButton.Click();

            //ADMIN EMAIL
            IWebElement Adminemail = driver.FindElement(By.XPath("//input[@type='email']"));
            Adminemail.SendKeys("admin@gmail.com");

            //PASSWORD
            IWebElement Password = driver.FindElement(By.XPath("//input[@type='password']"));
            Password.SendKeys("password");

            //SHOW button
            //  IWebElement showButton = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-outline-secondary')]"));
            // showButton.Click();


            //SUBMIT BUTTON
            IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            submitButton.Submit();



            // Wait for the Dashboard page to load and the button to be visible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(10));

            //CLICK dashboard
            IWebElement dashboard = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(@class, 'mb-2 text-start btn btn-outline-secondary')]")));
            dashboard.Click();

            //CLICK DONOR ACCOUNT
            IWebElement donorAccount = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Donor Accounts']")));
            donorAccount.Click();


            //CLICK REIPIENT ACCOUNT

            IWebElement recipientAccount = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Recipient Accounts']")));
            recipientAccount.Click();

            /* //REMOVE RECIPIENT ACCOUNT
             IWebElement removeRecipient = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-outline-danger btn-sm')]"));
             removeRecipient.Click();*/



            //CLICK DONATION HISTORY

            IWebElement donationHistory = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Donation History']")));
            donationHistory.Click();

            //CLICK RECIPIENT HISTORY
            IWebElement recipientHistory = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Recipient History']")));
            recipientHistory.Click();

            //REASON FOR ERROR:same element name

            IWebElement profile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()=' Profile']")));
            profile.Click();

            //edit
            IWebElement edit = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Edit']")));
            edit.Click();

            IWebElement username = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("username")));
            //remove text and write new one 
            username.Clear();
            username.SendKeys("Forgive");
            //click save
           IWebElement save = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Save']")));
            save.Click();


            //click homepage
            IWebElement homepage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()=' Home']")));
            homepage.Click();


            IWebElement notification = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()=' Notifications']")));
            notification.Click();

            /* IWebElement logout = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()=' Logout']")));
             logout.Click();*/



        }




        //TESTING DASHBOARD


        // TEST SIGNUP RECIPIENT
        [Test]

        public void TestRecipientSignUp()
        {



            //CLICK SIGNUP BUTTON

            IWebElement dropdownB = driver.FindElement(By.XPath("//button[contains(@class,'dropdown-toggle btn btn-outline-success')]"));
            dropdownB.Click();

            //SELECT RECIPIENT
            IWebElement recipientOptionr = driver.FindElement(By.XPath("//a[@href='/verification']"));
            recipientOptionr.Click();


            //VERIFY REGISTERED ORGANIZATION NUMBER


            IWebElement organizationnumber = driver.FindElement(By.XPath("//input[@placeholder='Enter registration number']"));
            organizationnumber.SendKeys("112233");


            //click verify
            IWebElement verify = driver.FindElement(By.XPath("//button[text()='Verify']"));
            verify.Click();


            driver.Navigate().GoToUrl("http://localhost:3000/recepientsignup");
            //INSERTING THE ELEMENTS DITAILS 

            //organisation_name
            IWebElement organization_name = driver.FindElement(By.XPath("//input[@type='text']"));
            organization_name.SendKeys("forgive");


            //EMAIL
            IWebElement recipientEmail = driver.FindElement(By.XPath("//input[@type='email']"));
            recipientEmail.SendKeys("recipient@gmail.com");

            //TELPHONE
            IWebElement telphone = driver.FindElement(By.XPath("//input[@type='tel']"));
            telphone.SendKeys("0723456789");

            //BUSSINESS ADDRESS
            IWebElement bussinessAdress = driver.FindElement(By.XPath("//input[@placeholder='Enter Street Address']"));
            bussinessAdress.SendKeys("TUT");

            //PASSWORD
            IWebElement recipientPassword = driver.FindElement(By.XPath("//input[@type='password']"));
            recipientPassword.SendKeys("recipient@2024");

            //CONFIRM PASSWORD
            IWebElement confirmPassword = driver.FindElement(By.XPath("//input[@placeholder='Confirm Password']"));
            confirmPassword.SendKeys("recipient@2024");

            //CLICK TERMS AND CONDITIONS CHECK BOX 
            IWebElement checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            checkbox.Click();

            //SUBMIT
            IWebElement signUp = driver.FindElement(By.XPath("//button[@type='submit']"));
            signUp.Submit();
        }

        //RECIPIENT LOGIN
        [Test]

        public void TestRecipient()

        {


            //LOGIN PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/login");


            //CLICK RECIPIENT BUTTON
            IWebElement recipientButton = driver.FindElement(By.XPath("//input[@value='Recipient']"));
            recipientButton.Click();


            //RECIPIENT EMAIL
            IWebElement recipientemail = driver.FindElement(By.XPath("//input[@type='email']"));
            recipientemail.SendKeys("recipient@gmail.com");
            // recipientemail.SendKeys("Forgive@gmail.com");


            //RECIPIENT PASSWORD
            IWebElement passwordRecipient = driver.FindElement(By.XPath("//input[@type='password']"));
            passwordRecipient.SendKeys("recipient@2024");


            //SUBMIT BUTTON
            IWebElement submitButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            submitButton.Submit();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            //CLICK PROFILE OPTION/BUTTON
            IWebElement recipientProfile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Profile']")));
            recipientProfile.Click();

            //CLICK EDIT
            IWebElement edit = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()=' Edit']")));
            edit.Click();

            //ENTER NEW USERNAME
            IWebElement username = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("recipientName")));
            username.Clear();
            username.SendKeys("Forgive");

            //ENTER NEW EMAIL
            IWebElement newEmail = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("recipientEmail")));
            newEmail.Clear();
            newEmail.SendKeys("Forgive@gmail.com");

            //ENTER NEW TELEPHONE 
            IWebElement telephone = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("recipientPhoneNum")));
            telephone.Clear();
            telephone.SendKeys("0764399943");

            //ENTER NEW ADDRESS 
            IWebElement address = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("recipientAddress")));
            address.Clear();
            address.SendKeys("soshanguve l");

            /*/click save
            IWebElement save = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()=' Save']")));
            save.Click();

            //OR

            //CANCEL
           IWebElement cancel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Cancel']")));
            cancel.Click();


            //click delete
            IWebElement delete = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()=' Delete']")));
                  delete.Click();/


            //CLICK FOOD LIST
            IWebElement foodlist = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='FoodList']")));
            foodlist.Click();

            //search
            IWebElement search = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Search by address']")));
            search.SendKeys("north");
            search.SendKeys(Keys.Enter);

            // Request Food
            IWebElement request = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(@class, 'btn btn-primary mt-2 align-self-end')]")));
            request.Click();

            // Click YES
            IWebElement yes = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()= 'Yes']")));
            yes.Click();

            // Click CONFIRM
            IWebElement confirmation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Confirm']")));
            confirmation.Click();

            // Handle any unexpected alert
            try
            {
                // Wait for the alert to appear and switch to it
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

                // Switch to the alert and accept it
                IAlert Ok = driver.SwitchTo().Alert();
                Ok.Accept(); // You can also use `alert.Dismiss()` if you want to dismiss it instead of accepting
            }
            catch (WebDriverTimeoutException)
            {
                // If no alert appears, we catch the exception and move on
                Console.WriteLine("No alert appeared.");
            }

            // Wait for the modal to disappear (if applicable) after confirmation
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@role='dialog' and @aria-modal='true']")));

            
                // Wait for the 'Record' button to become visible
          //  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Record']")));

            // Click the 'Record' button
            IWebElement records = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Record']")));
            //when hidden element dont wanna click use IJSE//((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", records);
           // ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", records);
           records.Click();


            //CLICK DISTANCE
              IWebElement distance = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Distance']")));
              distance.Click();
            //CLICK RECIPIENT LOCATION  
            IWebElement recipientAccept = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Accept Recipient Location']")));
            recipientAccept.Click();

            //CHOOSE REQUEST DECISION
            IWebElement accept = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Accept']")));
                      accept.Click();
            //   DECLINE BUTTON NOT RESPONDING     OR
            IWebElement decline = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Decline']")));
            decline.Click();//

          
            //CLICK MAP
            IWebElement map = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Map']")));
            map.Click();

            //enter (MAP) FROM LOCATION
            IWebElement fromLocation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='From location']")));
             fromLocation.SendKeys("soshanguve crossing");

            //CLICK SEARCH FROM
            IWebElement searchFrom = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Search From']")));
            searchFrom.Click();

            //enter (MAP) TO LOCATION
             IWebElement toLocation = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='To location']")));
             toLocation.SendKeys("mathaga primary school");

            //CLICK SEARCH FROM
            IWebElement searchTo = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Search To']")));
            searchTo.Click();

            //CLICK UPDATE PASSWORD
             IWebElement UpdatePassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Update Password']")));
            UpdatePassword.Click();

            IWebElement oldPassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("oldPassword")));
             oldPassword.SendKeys("recipient@2024");

             //ENTER NEW PASSWORD
             IWebElement Password = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("newPassword")));
             Password.SendKeys("recipient@2022");

             //CONFIRM PASSWORD
             IWebElement ConfirmPassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("confirmPassword")));
             ConfirmPassword.SendKeys("recipient@2022");

             //UPDATE PASSWORD
             IWebElement updatePassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Update Password']")));
             updatePassword.Click();*/



        }
        




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


            //DONOR NAME Forgive
            IWebElement donorName = driver.FindElement(By.XPath("//input[@type='text']"));
            donorName.SendKeys("forgive");

            //EMAIL ADDDRESS
            IWebElement donorEmail = driver.FindElement(By.XPath("//input[@type='email']"));
            donorEmail.SendKeys("makematlhaga@gmail.com");

            //TELPHONE
            IWebElement telphone = driver.FindElement(By.XPath("//input[@type='tel']"));
            telphone.SendKeys("0764399943");

            //PHYSICAL ADDRESS
            IWebElement physicalAddress = driver.FindElement(By.XPath("//input[@placeholder='Enter Physical Address']"));
            physicalAddress.SendKeys("Tshwane");

            //PASSWORD
            IWebElement password = driver.FindElement(By.XPath("//input[@type='password']"));
            password.SendKeys("Makematlhaga@2024");

            //CONFIRM PASSWORD
            IWebElement confirmPassword = driver.FindElement(By.XPath("//input[@placeholder='Confirm password']"));
            confirmPassword.SendKeys("Makematlhaga@2024");

            //CHECKBOX
            IWebElement checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            checkbox.Click();


            //SUBMIT BUTTON
            IWebElement signUp = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-dark')]"));
            signUp.Click();
        }


        [Test]

        public void TestDonor()
        {
            //NAVIGATE LOGIN PAGE
            driver.Navigate().GoToUrl("http://localhost:3000/login");

            //SECECTING DONOR OPTION
            IWebElement donor = driver.FindElement(By.XPath("//input[@value='Donor']"));
            donor.Click();

            //EMAIL ADDRESS
            IWebElement email = driver.FindElement(By.XPath("//input[@type='email']"));
            //email.SendKeys("makematlhaga@gmail.com");
            email.SendKeys("katlego@gmail.com");
            //PASSWORD
            IWebElement password = driver.FindElement(By.XPath("//input[@type='password']"));
            password.SendKeys("Makematlhaga@2024");



            //SUBMIT BUTTON 

            IWebElement submit = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-dark')]"));
            submit.Click();






            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //CLICK DASHBOARD BUTTON
            IWebElement dashboard = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Dashboard']")));
            dashboard.Click();


            //CLICK PROFILE
            IWebElement profile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Profile']")));
            profile.Click();

            //click edit
            IWebElement edit = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()=' Edit']")));
            edit.Click();
            //change username
            IWebElement username = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("donorName")));
            username.Clear();
            username.SendKeys("katlego");

            //change email
            IWebElement useremail = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("donorEmail")));
            useremail.Clear();
            useremail.SendKeys("katlego@gmail.com");

            //change telphone
            IWebElement usertelphone = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("donorPhoneNum")));
            usertelphone.Clear();
            usertelphone.SendKeys("0822533923");

            //change address
            IWebElement useraddress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("donorAddress")));
            useraddress.Clear();
            useraddress.SendKeys("crossing");

            //click save and delete
            //IWebElement save = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()=' Save']")));
            //save.Click();

            //cancel
            IWebElement cancel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Cancel']")));
            cancel.Click();

            //CLICK DONATE BUTTON
            IWebElement donate = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Donate']")));
            donate.Click();



            //ENTER FOOD TYPE
            IWebElement foodtype = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("foodType")));
            foodtype.SendKeys("samp");

            //ENTER QUANTITY
            IWebElement quantity = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("quantity")));
            quantity.SendKeys("30");

            //ENTER DESCRIPTION
            IWebElement description = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("description")));
            description.SendKeys("creamy soup");

            //ENTER TIME COOKED
            IWebElement timeCooked = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Enter time prepared']")));
            timeCooked.SendKeys("16-01-2025 09:00");

            //ENTER PHYSICAL ADDRESS
            IWebElement physicalAdress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Enter your address']")));
            physicalAdress.SendKeys("north campus");

            //CONTACT INFO OR EMAIL ADDRESS
            IWebElement emailAddress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Enter your email address']")));
            emailAddress.SendKeys("makematlhaga@gmail.com");


            //CLICK TERMS AND CONDITIONS
            IWebElement checkbox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='checkbox']")));
            checkbox.Click();


            //CLICK ADD ITEM 
            IWebElement donatebutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(@class, 'mt-3 btn-block btn-lg btn btn-dark')]")));

        //INITIATING JAVA EXECUTOR
       IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
          js.ExecuteScript("arguments[0].click();", donatebutton);




            /*/CLICK RECORD BUTTON
            IWebElement record = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Record']")));
            record.Click();

            //CLICK UPDATE PASSWORD
            IWebElement UpdatePassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Update Password']")));
            UpdatePassword.Click();

            /*IWebElement oldPassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("oldPassword")));
             oldPassword.SendKeys("Makematlhaga@2024");

            //ENTER NEW PASSWORD
            IWebElement Password = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("newPassword")));
            Password.SendKeys("Makematlhaga@2022");

            //CONFIRM PASSWORD
            IWebElement ConfirmPassword = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("confirmPassword")));
             ConfirmPassword.SendKeys("Makematlhaga@2022");

            //CLICK UPDATE PASSWORD(system doesnt update new passowrd)
             IWebElement update = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Update Password']")));
               update.Click();*/


        

            /*/CLICK ACCEPTED ITEM
            IWebElement acceptedItem = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Accepted Item']")));
            acceptedItem.Click();
            //CLICK LOGOUT
            IWebElement logout = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Logout']")));
            logout.Click();*/
        }

        [Test]

        public void TestRequest()

        {
            //request page 

            driver.Navigate().GoToUrl("http://localhost:3000/request/4");


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            IWebElement accept = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Accept']"))); 
                   accept.Click(); 
        }




    }
}

