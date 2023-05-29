using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UshtrimeProvim1B.Validations
{
    public class ApplicationIdValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string strValue = value as string;
            var currDate = DateTime.Now;
            string firstSixChars = currDate.ToString("ddMMyy");

            if(strValue.Length >= 6)
            {
                for (int i = 0; i < firstSixChars.Length; i++)
                {
                    if (strValue[i] != firstSixChars[i])
                    {
                        return false;
                    }
                }


                List<string> CreditType = new List<string>() { "KON", "BLE", "MAK", "BLA" };

                if (strValue.Length >= 9)
                {
                    var last3Chars = strValue.Substring(6, 3);
                    if (CreditType.Contains(last3Chars))
                    {
                        var next5Chars = strValue.Substring(9, 5);
                        var isNumber = next5Chars.ToArray().All(x => char.IsNumber(x));

                        if (isNumber)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
