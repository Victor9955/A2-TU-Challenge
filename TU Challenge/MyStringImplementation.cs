using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            string last = "";
            for (int i = 0; i < input.Length; i++)
            {
                if(i % 2 == 0)
                {
                    result += input[i];
                }
                else
                {
                    last += input[i];
                }
            }
            result+= last;
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == "" || input == null)
            {
                return true;
            }
            else
            {
                int space = 0;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if(input[i] != ' ')
                    {
                        space++;
                    }
                    if(input[i] == '\0')
                    {
                        space--;
                    }
                }
                return space <= 0;
            }
        }

        public static string MixString(string a, string b)
        {
            if(a == null) { throw new ArgumentException(); }
            if(b == null) { throw new ArgumentException(); }
            if(a == "") { throw new ArgumentException(); }
            if(b == "") { throw new ArgumentException(); }

            string result = "";
            bool switchString = true;
            int ia = 0;
            int ib = 0;
            
            do
            {
                if(ia > a.Length - 1 && ib > b.Length - 1) { return result; }

                if (ia > a.Length - 1)
                {
                    switchString = false;
                }
                else if(ib > b.Length - 1)
                {
                    switchString = true;
                }

                if (switchString)
                {
                    result += a[ia];
                    ia++;
                }
                else
                {
                    result += b[ib];
                    ib++;
                }

                switchString = !switchString;
            } while (result.Length <= a.Length + b.Length);

            return result;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                int asciiNb = (int)a[i];
                if ((asciiNb >= 65 && asciiNb <= 90) ||
                    (asciiNb >= 192 && asciiNb <= 214) ||
                    (asciiNb >= 216 && asciiNb <= 222))
                {
                    asciiNb += 32;
                }
                result += (char)asciiNb;
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < input.Length/2; i++)
            {
                a += input[i];
            }
            for (int i = input.Length / 2; i < input.Length; i++)
            {
                b += input[i];
            }
            return MixString(a, b);
        }

        public static string Voyelles(string a)
        {
            string voyelles = "aeiouy";
            string result = "";

            foreach (char item1 in a)
            {
                foreach (char item2 in voyelles)
                {
                    if(ToLowerCaseChar(item1) == item2)
                    {
                        
                        bool already = false;
                        foreach (char item in result)
                        {
                            if(item == item1)
                            {
                                already = true;
                            }
                        }
                        if(!already)
                        {
                            result += ToLowerCaseChar(item1);
                        }
                    }
                }
            }
            return result;
        }

        public static char ToLowerCaseChar(char a)
        {
            int asciiNb = (int)a;
            if ((asciiNb >= 65 && asciiNb <= 90) ||
                (asciiNb >= 192 && asciiNb <= 214) ||
                (asciiNb >= 216 && asciiNb <= 222))
            {
                asciiNb += 32;
            }
            return (char)asciiNb;
        }

        public static string Reverse(string a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result+= a[i];
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += ToCesarLetter(input[i],offset);
            }
            return result;
        }

        public static char ToCesarLetter(char input, int shift)
        {
            if (input == ' ')
            {
                return input;
            }
            char offset = char.IsUpper(input) ? 'A' : 'a';
            return (char)((((input + shift) - offset) % 26) + offset);
        }
    }

    
}
