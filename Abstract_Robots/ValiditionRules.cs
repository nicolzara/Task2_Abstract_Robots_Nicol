using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Windows.Controls;

using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Robots_inc
{
    public class NameRule : ValidationRule
    {
        private int minLen;
        private int maxLen;

        public int MinLength
        {
            get { return minLen; }
            set { minLen = value; }
        }

        public int MaxLength
        {
            get { return maxLen; }
            set { maxLen = value; }
        }

        // validation check
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if ((string)value == "")
                return new ValidationResult(false, "User name can not br empty");  // empty incorrect
            try
            {
                string text = (string)value;
                if (text.Length < MinLength || text.Length > MaxLength)
                    return new ValidationResult(false, "User name length must be between " + MinLength 
                        + " and " + MaxLength + " character");
                for (int i = 0; i < text.Length; i++)
                {
                    if (!(char.IsLetterOrDigit(text[i]) || (text[i]!='_'))) // not letter or white space incorrect
                        return new ValidationResult(false, "User name must contain only letters, digits or the underscore character");
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Invalid characters\n" + e.Message); // illegal char incorrect
            }
            return ValidationResult.ValidResult;  // correct
        }
    }

    public class PasswordRule : ValidationRule
    {
        private int minLen;

        public int Length
        {
            get { return minLen; }
            set { minLen = value; }
        }

        // validation check
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if ((string)value == "")
                return new ValidationResult(false, "Password can not be empty");  // empty incorrect
            try
            {
                string text = (string)value;
                if (text.Length < minLen)
                    return new ValidationResult(false, "Minimum password length is " + minLen + " characters");
                for (int i = 0; i < text.Length; i++)
                {
                    if (!(char.IsLetterOrDigit(text[i]))) // only letters and digits
                        return new ValidationResult(false, "Invalid characters");
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Invalid characters\n" + e.Message); // illegal char incorrect
            }
            return ValidationResult.ValidResult;  // correct
        }
    }
}
