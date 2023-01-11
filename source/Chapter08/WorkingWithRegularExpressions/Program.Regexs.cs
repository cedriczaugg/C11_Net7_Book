using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkingWithRegularExpressions
{
    internal partial class Program
    {
        [GeneratedRegex(digitsOnlyText, RegexOptions.IgnoreCase)]
        private static partial Regex DigitsOnly();

        [GeneratedRegex(commaSeparatorText, RegexOptions.IgnoreCase)]
        private static partial Regex CommaSeparator();
    }
}
