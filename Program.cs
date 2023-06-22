using RegexProblem;

namespace RegexPattern
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Pattern Problem!");
            Console.WriteLine("Enter your Choice from below:-");
            Console.WriteLine("1.Regex pattern for a followed by 2 or 3 b.\n2.Regex pattern to find sequences of lowercase letters joined by an underscore.");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    ValidateRegex.Match();
                    break;
                case 2:
                    ValidateRegex.FindSequencewithUnderscore();
                    break;
            }
        }
    }
}
