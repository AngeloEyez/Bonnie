using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnie
{
    public static class Helper
    {
        public static string[] SplitCsv(string line, char seperator)
        {
            List<string> result = new List<string>();
            StringBuilder currentStr = new StringBuilder("");
            bool inQuotes = false;
            for (int i = 0; i < line.Length; i++) // For each character
            {
                if (line[i] == '\"') // Quotes are closing or opening
                    inQuotes = !inQuotes;
                else if (line[i] == seperator) // Comma
                {
                    if (!inQuotes) // If not in quotes, end of current string, add it to result
                    {
                        result.Add(currentStr.ToString());
                        currentStr.Clear();
                    }
                    else
                        currentStr.Append(line[i]); // If in quotes, just add it 
                }
                else // Add any other character to current string
                    currentStr.Append(line[i]);
            }
            result.Add(currentStr.ToString());
            return result.ToArray(); // Return array of all strings
        }

        public static string MergeConfig(string str)
        {
            bool flgSame = true;
            string[] sArray = str.Replace("\"", "").Split(',');

            if (sArray.Length == 1)
                return str;

            for (int i = 1; i < sArray.Length; i++)
                if (!sArray[i].Equals(sArray[i - 1]))
                    flgSame = false;

            return (flgSame) ? $"\"{sArray[0]}\"" : str;
        }
    }
}
