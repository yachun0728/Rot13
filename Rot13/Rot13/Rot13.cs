using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rot13
{
    public class Kata
    {
        static Dictionary<string, string> _CharMapping = new Dictionary<string, string>()
        {
            {"A", "N" },{"B", "O"},{"C", "P"},{"D", "Q"},{"E", "R"},{"F", "S"},{"G", "T"},{"H", "U"},
            {"I", "V"},{"J", "W"},{"K", "X"},{"L", "Y"},{"M", "Z"},{"N", "A"},{"O", "B"},{"P", "C"},
            {"Q", "D"},{"R", "E"},{"S", "F"},{"T", "G"},{"U", "H"},{"V", "I"},{"W", "J"},{"X", "K"},
            {"Y", "L"},{"Z", "M"}

        };
        public static string Rot13(string input)
        {
            var inputArray = input.ToCharArray();
            string output = string.Empty;
            foreach (var a in inputArray)
            {
                if (_CharMapping.ContainsKey(a.ToString()) || _CharMapping.ContainsKey(a.ToString().ToUpper()))
                {
                    if (_CharMapping.ContainsKey(a.ToString()))
                    {
                        output += _CharMapping[a.ToString()];
                    }
                    else
                    {
                        output += _CharMapping[a.ToString().ToUpper()].ToLower();
                    }
                }
                else
                {
                    output += a.ToString();
                }
            }
            return output;
        }
        
    }
}