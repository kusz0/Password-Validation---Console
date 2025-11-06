using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validation_Console
{
    internal class ValidationResult
    {

        public IEnumerable<string> Errors { get; }

        public  bool  isValid => !Errors.Any();

        public ValidationResult(IEnumerable<string> errors)
        {
            Errors = errors?.ToList() ?? new List<string>();
        }
        
    
    }


}
