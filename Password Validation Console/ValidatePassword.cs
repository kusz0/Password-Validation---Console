using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validation_Console
{
    internal class ValidatePassword
    {
        private char[] chars;
        public ValidatePassword(string password)
        {
            chars = password.ToCharArray(); 
        }
        
        public void Validate()
        {
            bool isSpecialChar = false;
            bool isBigLetter = false;
            bool isSmallLetter = false;
            bool hasDigit = false;
            bool isGoodLength = chars.Length >= 8;

            foreach (char c in chars)
            {
                if (char.IsUpper(c))
                {
                    isBigLetter = true;
                } 
                if(char.IsLower(c))
                {
                    isSmallLetter = true;
                }
                if(char.IsDigit(c))
                {
                    hasDigit = true;
                }
                if(!char.IsLetterOrDigit(c))
                {
                    isSpecialChar = true;
                }
            }
            if(isSpecialChar && isBigLetter && isSmallLetter && hasDigit && isGoodLength)
            {
                Console.WriteLine("Good Password. Login in");
                
            }
            else
            {
                Console.WriteLine("Wrong Password!:");
                if (!isGoodLength) Console.WriteLine("-min length is (8 chars!)");
                if (!isBigLetter) Console.WriteLine("-there is no upper case letter!");
                if (!isSmallLetter) Console.WriteLine("- there is no lower case letter! ");
                if (!hasDigit) Console.WriteLine("- there is no digit!");
                if (!isSpecialChar) Console.WriteLine("-there is no special char!");
                Console.WriteLine("TryAgain!");
            }

        }

    }
}
