using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace davidketner.Data.Extensions
{
    public static class ClassExtensions
    {
        public static string LatinToAscii(this string inputText)
        {
            var newString = string.Empty;

            for (var i = 0; i < inputText.Length; i++)
            {
                var charString = inputText.Substring(i, 1);
                charString = charString.Normalize(System.Text.NormalizationForm.FormKD);
                if (charString.Length == 1)
                    newString += charString;
                else
                {
                    var charsCopied = 0;
                    for (var j = 0; j < charString.Length; j++)
                    {
                        var ch = charString[j];
                        if (ch < 128)
                        {
                            newString += ch;
                            charsCopied++;
                        }
                    }
                    if (charsCopied == 0)
                        newString += inputText.Substring(i, 1);
                }
            }
            return newString?.ToLower()?.Trim();
        }

        public static string ToSeoFriendly(this string inputText)
        {
            if (string.IsNullOrEmpty(inputText?.Trim()))
                return "";

            var maxLength = 500;
            inputText = inputText.LatinToAscii();
            var match = Regex.Match(inputText.ToLower(), "[\\w]+");
            var result = new StringBuilder("");
            var maxLengthHit = false;
            while (match.Success && !maxLengthHit)
            {
                if (result.Length + match.Value.Length <= maxLength)
                {
                    result.Append(match.Value + "-");
                }
                else
                {
                    maxLengthHit = true;
                    if (result.Length == 0) result.Append(match.Value.Substring(0, maxLength));
                }
                match = match.NextMatch();
            }
            if (result[result.Length - 1] == '-') result.Remove(result.Length - 1, 1);
            return result.ToString();
        }
    }
}
