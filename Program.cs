namespace ReverseString
{
    class Program
    {
        public static void Main (String[] args)
        {
            Console.WriteLine("Enter string to be reversed: ");
            string? input = Console.ReadLine();

            string reversedString = "";

            // Method 1
            for(int i=0; i<input.Length; i++)
            {
                string charAti = Char.ToString(input[i]);
                reversedString = charAti + reversedString;
            }

            Console.WriteLine(reversedString);

            // Method 2

            char[] inputArray = input.ToCharArray();

            for(int i=0, j=input.Length - 1; i<j; i++, j--)
            {
                char temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;
            }

            reversedString = new string(inputArray);

            Console.WriteLine(reversedString);

            // Method 3

            reversedString = ReverseMyString(input);

            Console.WriteLine(reversedString);
        }

        public static string ReverseMyString(string input)
        {
            if(input.Length <= 1) return input;

            return ReverseMyString(input.Substring(1)) + Char.ToString(input[0]);
        }
    }
}