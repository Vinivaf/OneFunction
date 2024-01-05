using SimpleBase;
using System.Security.Cryptography;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string to hash:");
        StringBuilder input = new StringBuilder();

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                string inputString = input.ToString();
                HandleInput(inputString);

                Console.WriteLine();
                Console.WriteLine("Do you wish to see the input string? (Y|N)");
                var response = Console.ReadLine();

                if (!string.IsNullOrEmpty(response) &&
                    (response.Equals("y", StringComparison.InvariantCultureIgnoreCase)
                    || response.Equals("ye", StringComparison.InvariantCultureIgnoreCase)
                    || response.Equals("yes", StringComparison.InvariantCultureIgnoreCase)))
                {
                    Console.WriteLine($"Input String: {input}");
                }

                input.Clear();
                Console.WriteLine();
                Console.WriteLine("Enter the string to hash:");
            }
            else if (keyInfo.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input.Remove(input.Length - 1, 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                input.Append(keyInfo.KeyChar);
                Console.Write("*");
            }
        }
    }

    private static void HandleInput(string inputString)
    {
        if (!string.IsNullOrWhiteSpace(inputString))
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                string hashedString = Convert.ToBase64String(hashBytes);
                Console.WriteLine($"Result [ASCII64]: {hashedString}");
                
                hashedString = Base85.Ascii85.Encode(hashBytes);
                Console.WriteLine($"Result [ASCII85]: {hashedString}");

                hashedString = Base85.Z85.Encode(hashBytes);
                Console.WriteLine($"Result [Z85]: {hashedString}");
            }
        }
        else
        {
            Console.WriteLine("Please provide a valid string to hash.");
        }
    }
}