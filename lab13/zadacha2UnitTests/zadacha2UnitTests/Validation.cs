using System;
using System.Text.RegularExpressions;

namespace zadacha2UnitTests
{
    public class Validation
    {
        public string UsernamePattern = "^[a-z-6-9]{5,8}$";
        public string PasswordPattern = "^[a-z|A-Z|0-9]{3}[?]{1}$";

        public Boolean validateUsername(string username)
        {
            Match match = Regex.Match(username, UsernamePattern);
            return match.Success;
        }

        public Boolean validatePassword(string password)
        {
            Match match = Regex.Match(password, PasswordPattern);
            return match.Success;
        }
    }
}
