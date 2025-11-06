using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validation_Console
{
    internal class Display
    {
        private ValidatePassword validePassword;
        public static bool isValidPassword = true;
        public void DisplayProgram()
        {
            while (isValidPassword)
            {
                validePassword.Validate(Console.ReadLine());

            }
        }

    }
}
