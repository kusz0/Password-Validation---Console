using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validation_Console
{
    internal class ValidatePassword
    {
        private readonly string _password;
        public ValidatePassword(string password)
        {
            _password = password ?? throw new AbandonedMutexException(nameof(password));
        }
        
        public ValidationResult Validate()
        {
            List<string> errors = new List<string>();

            if(_password.Length < 8)
            {
                errors.Add("Password must be at least 8 characters long.");
            }
            if(!_password.Any(char.IsUpper))
            {
                errors.Add("Pasowrd have to contain at least one uppercase letter");
            }
            if(!_password.Any(char.IsLower))
            {
                errors.Add("Password have to contain at least one lowercase letter");
            }
            if(!_password.Any(char.IsDigit))
            {
                errors.Add("Passoword have to contain at least one digit");
            }
            if(_password.All(char.IsLetterOrDigit))
            {
                errors.Add("Password have to contain at least one special character");
            }
                return new ValidationResult(errors);
        }






    }
}
