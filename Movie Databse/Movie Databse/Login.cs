using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows.Forms;

// (1) Commenting Starts Here, This is the Startup Form for the Program and also the first form i created
// All the comments i write will be numbered for clarity of reading, and also so i can move them around when i inevitably adjust the code
// (2) The Order of Commenting will be, This Form -> Database.cs -> LoginInfo.cs -> program.cs -> Menu.cs -> Menudeep -> AdminMenu.cs -> AdminMenuDeep -> Master Menu//Master Menu Deep -> And then finally the Unit Tests
// I will try to keep the commenting fairly light and straight to the point and will skip over most of the repeated code, of which there isn't much of.
namespace Movie_Databse
{
    public partial class frm_Login : Form
    {
        private Database DB = new Database();

        // (3) This line of code or its close relative "var db = new database();" appear quite frequently throughout the program, this is basically saying every time you need to use the database you have to 
        // Repeat This code ==
        //
        //    private SqlConnection SCNT = new SqlConnection();
        //    private SqlCommand SCMD = new SqlCommand();
        //    private SqlDataAdapter DA = new SqlDataAdapter();
        //    public string ConnectionString = null  
        //    string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Source\Repos\Test-Repo\Movie Databse\blockbusted_config.bin";
        //    ConnectionString = System.IO.File.ReadAllText(ConfigPath);
        //    SCNT.ConnectionString = ConnectionString;
        //    SCMD.Connection = SCNT;
        //
        // Which i found a bit repetitive and unnecessary, but making them static seemed to slow down the program a lot and overall cause problems so i left it in,
        // And the compiler likes to freak out when you declare a public static class so there's that also.
        private string ConfigPath = @".\blockbusted_config.bin";
        // (4) This neat piece of code gets the location of the program if you are using the Team Explorer to view it, I use this to save the connection string to a text file,
        // If i was creating this program for a business i could set the folder path to the current install of the program so that anyone could make use of the saving feature
        // but i am short on time and this solution works perfectly for me so i left it.
        private delegate void SetTextCallback(string text);
        // (5) This is a simple timer program that updates a label every 10 milliseconds to the system.datetime.now.tostring value 
        // i don't think that a delegate is needed in this situation because only one method calls this method, but thats what i have it as in my testing project so it's in now
        // This is just a little feature i put in to make the program look a bit more alive (especially on the main menu)
        public frm_Login()
        {
            InitializeComponent();
            clock();
            ReadConnectionString();
        }

        private void clock()
        {
            var timer = new System.Timers.Timer();
            timer.Elapsed += function;
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Start();
            // (6) The Timer Program
        }

        private void ReadConnectionString()
        {
            DB.ConnectionString = System.IO.File.ReadAllText(ConfigPath);
            // (7) Reading the blockbusted_config.bin and setting the Database connection string to it, note that the database actually does this itself but this is kept in to reduce errors 
            // When initially starting up the program 
        }

        private void function(object sender, ElapsedEventArgs e)
        {
            try
            {
                SetText(DateTime.Now.ToString());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error detected:\n" + ex.Message);
            }
            // (8) More of the Timer
        }

        private void SetText(string text)
        {
            if (this.lbl_Time.InvokeRequired)
            {
                var d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_Time.Text = text;
            }
            // (9) Even More
        }

        private void btn_CheckString_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connection String =  " + DB.ConnectionString);
            TestConnectionFull();
            // (10) Show the Connection String, then test the connection
        }

        private void btn_ChangeString_Click(object sender, EventArgs e)
        {
            do
            {
                ChangeConnection();
            } while (TestConnectionBasic() == false);
            ChangeDefaultString();
            // (11) Let the user change the connection string, then test if it works, then if the connection string is different from the saved string ask the user if they want to set the new string as the default one
        }

        private void TestConnectionFull()
        {
            while (TestConnectionBasic() == false)
            {
                MessageBox.Show("Connection Failed Please Change Connection String");
                ChangeConnection();
            }
            MessageBox.Show("Connected To Database");
            ChangeDefaultString();
            // (12) More stuff of testing the connection, note that if the connection is removed past this initial login state the user will simply be given lots of NO DATA! errors and nothing horrible "should" happen, they will also 
            // Have to logout and log back in to continue working which will reset all of the variables in the system, this is to hopefully create a closed system where no bad user input can ruin everything.
        }

        private void ChangeDefaultString()
        {
            if (DB.ConnectionString != System.IO.File.ReadAllText(ConfigPath))
            {
                DialogResult Result;
                Result = MessageBox.Show(this, "New Connection String Different From Default Connection String Would You Like To Set This String As The Default Connection String?", "Change Default String", MessageBoxButtons.YesNo);
                if (Result.ToString() == "Yes")
                {
                    System.IO.File.WriteAllText(ConfigPath, DB.ConnectionString);
                    MessageBox.Show("Connection String Changed Default Connection String Is Now =   " + DB.ConnectionString);
                }
            }
            // (13) Would you like to change the default string?
        }

        private void ChangeConnection()
        {
            DB.ConnectionString = Interaction.InputBox("Please Enter A New Connection String", "Change Connection String", DB.ConnectionString, -1, -1);
            if (DB.ConnectionString == "")
            {
                ReadConnectionString();
            }
            // (14) this pops up continuously if you keep inputting bad connection strings
        }

        private bool TestConnectionBasic()
        {
            DialogResult Result;
            DataTable Login_DT = new DataTable();
            try
            {
                Login_DT = DB.Fill();
            }
            catch (Exception ExceptionMessage)
            {
                MessageBox.Show("Connection Failed");
                Result = MessageBox.Show(this, "Would You Like To Show The Error Message?", "Show Error Message?", MessageBoxButtons.YesNo);
                if (Result.ToString() == "Yes")
                {
                    MessageBox.Show(ExceptionMessage.ToString());
                }
                return false;
            }
            return true;
            // (15) Create a shadow data table, then try to fill it with data, pretty much a unit test
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // (16) Ok this is a large chunk of code, so the next few lines will all be (16) for my own ease of typing
            TestConnectionFull();
            // Test the connection
            DB.CheckLogin(txt_User.Text);
            // Test if the user has entered a correct user name (with a stored procedure)
            MD5 Hash = MD5.Create();
            // Create a Hasher (a password encryption tool)
            DialogResult Result;
            // Create a Dialog Result (used later on)
            if (LoginInfo.User == null)
                // if we entered in a bad user name then we dont get to go to the circus
            {
                MessageBox.Show("You Have Not Entered A Correct Username");
            }
            else if (LoginInfo.Password == "FORCECHANGEPASSWORD")
                // if we are a fresh new employee we get forced to change our password
                // I go into all the code in the {}'s below in further sections of the project so hold on for that
            {
                MessageBox.Show("No Password Set\nPlease Set A Password");
                DialogResult DR = new DialogResult();
                var Force = new MenuDeep.PasswordInput_Forced_();
                DR = Force.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    string str_Username = LoginInfo.User;
                    string str_NewPassword = GetHash(Hash, LoginInfo.NewPassword);
                    DB.ChangePassword(str_Username, str_NewPassword);
                    MessageBox.Show("Password Set\nPlease Login Again");
                    LoginInfo.NewPassword = null;
                }
                else
                {
                    MessageBox.Show("Something Went Horrible!!!!");
                }
            }
            else if (GetHash(Hash, txt_Password.Text) == LoginInfo.Password.ToString())
                // if we have made it this far lets actually see if our user inputted password matches our stored encrypto password, what we do is simply encrypt the user's password and check them against each other
            {
                MessageBox.Show("Login Complete");
                // Yay
                switch (LoginInfo.Security)
                    // now we check the users Security level, or Privileges
                    // E = Employee
                    // A = Admin
                    // M = Master
                    // T = Terminated
                    // T can be anything really, it just means the employee will get the default setting in the switch statement and be DENIED access!
                {
                    case "M":
                        MessageBox.Show("Launching Master Menu");
                        LaunchMenu("M");
                        break;

                    case "A":
                        Result = MessageBox.Show(this, "Would You Like To Login As An Admin?", "Admin Login?", MessageBoxButtons.YesNo);
                        // Admins can logon as Employees 
                        // And Masters can logon as Admins 
                        // Employees can only be Employees
                        // And Masters cannot be Employees
                        // This is to separate the office work from the floor work, so that an admin running a shift can do a few employee jobs, but a master account is for highest level activities and shouldn't be used in day to day situations
                        // In a real scenario there would only be one master account available to the store owner that would be used solely to overrule admin commands (such as Demoting an admin)
                        if (Result.ToString() == "Yes")
                        {
                            MessageBox.Show("Launching Admin Menu");
                            LaunchMenu("A");
                        }
                        else
                        {
                            MessageBox.Show("Launching Menu");
                            LaunchMenu("E");
                        }
                        break;

                    case "E":
                        MessageBox.Show("Launching Menu");
                        LaunchMenu("E");
                        break;

                    default:
                        MessageBox.Show("No Privileges Found!");
                        // note that this could be "case "T"" without any errors because of the stored procedures that the program uses, but default simply protects the code from any unknown errors that might occur
                        break;
                }
            }
            else
            {
                MessageBox.Show("Logon Failed, Incorrect Password");
                // Oh no
            }
        }

        private static string GetHash(MD5 Hash, string Input)
            // (17) This Section of Code is another one that appears frequently throughout the program, and also another one that i wish was confined to a global class to reduce repetitiveness, i left the comments throughout just so i 
            // wouldn't have to explain any of it, but even without the comments it is an extremely straight forward method 
            // I Contemplated randomizing the X2 and saving it along with the config file, it would then be loaded up at runtime and used like a variable to decode the passwords so that they would be different every time you loaded the program,
            // But i chalked it up to one of those things that i didn't have time to do.
            // After typing the above comment i would also like point out that the x2 could be saved to the database instead of the config file and read as a table, just leaving this comment here for future josiah if i want to come back and do it.
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] Data = Hash.ComputeHash(Encoding.UTF8.GetBytes(Input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder SBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < Data.Length; i++)
            {
                SBuilder.Append(Data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return SBuilder.ToString();
        }

        private void LaunchMenu(string MenuType)
        {
            // (18) launch the menu corresponding to your security level and also clear out the input boxes on the login form so that someone cant walk over to your machine and press login after you have left and compromise the system.
            ClearTextboxes();
            switch (MenuType)
            {
                case "E":
                    var MainMenu = new Menu();
                    MainMenu.ShowDialog();
                    break;

                case "A":
                    var AdminMenu = new AdminMenu();
                    AdminMenu.ShowDialog();
                    break;

                case "M":
                    var MasterMenu = new MasterMenu();
                    MasterMenu.ShowDialog();
                    break;
            }
        }

        private void ClearTextboxes()
        {
            txt_User.Text = "";
            txt_Password.Text = "";
        }
        // (19) Clear the input boxes CONTINUE ON TO DATABASE.CS 
    }
}