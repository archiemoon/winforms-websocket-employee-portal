using System;
using System.Text;

public class Password_Hasher_Class
{
    // PRIVATE Key embedded within the project 
    // This is what the password is XOR'd against to generate the hashed output
    private static string KEY = "cYl9jS}9b#Xdm=CtHy(sDN:qTNW6U4b9";

    public static string HashPassword(string Password, string salt)
    {
        // appends the salt to the password this ensures the hash generated is completely unique 
        Password = salt + Password;

        StringBuilder hashedPassword = new StringBuilder();

        //If the lenght of the password is more than the length of the key the key will be doubled in length 
        while (KEY.Length < Password.Length)
        {
            KEY += KEY;
        }

        // Loops for however many characters are in the password 
        for (int i = 0; i < Password.Length; i++)
        {
            //generates the ascii code of the XOR of the password character and the character of the key at the same index 
            int hashedChar = Password[i] ^ KEY[i];

            //converts the ascii into Hexadecimal and appends it to the hashedPassword string
            hashedPassword.Append(hashedChar.ToString("X2"));
        }

        // returns the hashed password
        return hashedPassword.ToString();
    }

    public static bool VerifyPassword(string Password, string Salt, string HashedPassword)
    {
        // appends the users salt to the password the user entered 
        Password = Salt + Password;

        StringBuilder UnhashedPassword = new StringBuilder();

        //If the lenght of the password is more than the length of the key the key will be doubled in length 
        while (KEY.Length < Password.Length)
        {
            KEY += KEY;
        }

        // loops for the number of characters in the hashed password 
        for (int x = 0; x < HashedPassword.Length; x += 2)
        {
            // gets the current hexadecimal value to be 'un-hashed'
            string hexChar = HashedPassword.Substring(x, 2);

            //converts that hex value into the ascii value  
            int charValue = Convert.ToInt32(hexChar, 16);

            // Performs an XOR on the password and key ascii values to find the original character 
            UnhashedPassword.Append(Convert.ToChar(charValue ^ KEY[x / 2]));
        }

        //returns the bool of the unhashed password compared to the one they entered
        return UnhashedPassword.ToString() == Password;
    }

    public static string GenerateRandomSalt()
    {
        Random rnd = new Random();

        // all possible values used in the salt
        const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{};:,.<>?";
       
        // specifies the length of the salt
        int SaltLength = 32;

        StringBuilder Salt = new StringBuilder();

        // loops for the salt length 
        for (int i = 0; i < SaltLength; i++)
        {
            // gets a random index from the array of characters 
            int index = rnd.Next(Characters.Length);

            // appends the corrosponding character to the salt
            Salt.Append(Characters[index]);
        }

        // returns the salt
        return Salt.ToString();
    }
}
