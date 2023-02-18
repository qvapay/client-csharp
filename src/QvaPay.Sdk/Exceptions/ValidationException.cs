using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QvaPay.Sdk.Exceptions
{
    public class ValidationErrorException : Exception
    {
        public List<ValidationResult> ValidationResults { get; set; }

        public ValidationErrorException(string message, List<ValidationResult> validationResults)
            : base(message: message)
        {
            ValidationResults = validationResults;
        }
    }
}
