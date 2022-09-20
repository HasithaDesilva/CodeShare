using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Insurance.ApplicationCore.Utils
{
    public class CommonValidator
    {
        /// <summary>
        /// This method is used to validate number in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ValidateCharacter(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            Regex rgx = new Regex(@"^[0-9]*$");
            if (rgx.Match(str).Success) return true;
            return false;
        }
    }
}
