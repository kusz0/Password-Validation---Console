using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validation_Console
{
    internal class Display  
    {
        public void Print()
        {
            bool isValid = false;
            while(!isValid)
            {
                Console.WriteLine("==================");
                Console.Write("Enter password: ");
                string input = Console.ReadLine();

                ValidatePassword  validator = new ValidatePassword(input);

                ValidationResult result = validator.Validate();
                
                if(result.isValid)
                {
                    Console.Clear();
                    Console.WriteLine("Password is valid!");
                    Console.WriteLine("Login in...");
                    isValid = true;
                }else
                {
                    Console.WriteLine("Password is invalid! Try again");
                    Console.WriteLine("Errors: ");
                    foreach (string error in result.Errors)
                    {
                        Console.WriteLine($"- {error}");
                    }
                }



            }
        
        }

    }
}
