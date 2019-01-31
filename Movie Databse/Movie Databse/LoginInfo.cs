using System;

namespace Movie_Databse
{
    public class LoginInfo
    {
        public static String User { get; set; }
        public static String Password { get; set; }
        public static String Security { get; set; }
        public static String NewPassword { get; set; }
        // (31) All of these globals could be put into program.cs, but they are so integral to the overall operation of the program that i decided that they deserved their own class
        // NewPassword is simply a placeholder for the password changing Form that is used by multiple different other forms (like a delegate!)
        // It "could" be put into a static on newpass.cs but i moved it here because of newpass_forced.cs (PasswordInput(Forced).cs currently) so i only needed to make 1 static instead of 2.
        // Onto Program.cs!
    }
}