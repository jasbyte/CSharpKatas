using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static void Start(string[] args)
        {
            for (int i = 1; i <= GetAmount(args); i++)
            {
                Console.WriteLine(DetermineStringValue(i));
            }
        }

        private static int GetAmount(string[] args)
        {
            if (args.Length != 1)
                throw new ArgumentException($"Expected 1 argument but received {args.Length}");

            if (!int.TryParse(args[0], out int amount))
                throw new ArgumentException($"{args[0]} can not be parsed to a number");

            return amount;
        }

        public static string DetermineStringValue(int value)
        {
            StringBuilder stringValue = new();

            if (value % 3 == 0)
                stringValue.Append("Fizz");

            if (value % 5 == 0)
                stringValue.Append("Buzz");

            return stringValue.Length > 0
                ? stringValue.ToString()
                : value.ToString();
        }
    }
}
