using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class ValidateRegex
    {
        public static void Match()
        {
            string pattern = "^[a]{1}[b]{2,3}$";
            string[] inputs = { "ab", "abb", "abbb", "abbbb" };
            ValidatePattern(inputs, pattern);
        }
        public static void FindSequencewithUnderscore()
        {
            string pattern = "^[a-z]+_[a-z]+$";
            string[] inputs = { "sne_ha", "sneh_a", "SNe_hA", "S_neha" };
            ValidatePattern(inputs, pattern);
        }
        public static void ValidatePattern(string[] inputs, string pattern)
        {
            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid.", input);
                }
                else
                {
                    Console.WriteLine("{0} is invalid.", input);
                }
            }
        }

        public static void ValidateHTMLTags(string inputString)
        {
            Regex regex = new Regex(@"<[^>]+>");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void CountOccurence(string inputString)
        {
            Regex regex = new Regex(@"fox(es)?");

            MatchCollection matches = regex.Matches(inputString);
            Console.WriteLine("The Count of given Pattern in given String " + matches.Count);

        }

        public static void FileExtension()
        {
            Regex regex = new Regex(@"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)");

            Console.WriteLine("Enter filename with image file extension : ");
            string filename = Console.ReadLine();
            if (regex.IsMatch(filename))
            {
                Console.WriteLine("Valid file name");
            }
            else
            {
                Console.WriteLine("Invalid file name");
            }
        }
    }
}
