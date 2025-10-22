
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enater a Name ::");
        string input = Console.ReadLine();

        input = input.ToLower();
        int left = 0;
        int right = input.Length-1;
        bool isPlaindrome = true;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                isPlaindrome = false;
                break;
            }
                left--;
                right++;
        }

        if (isPlaindrome)
        {
            Console.WriteLine("Given String is a Palindrome!!");
        }
        else
        {
            Console.WriteLine("Given String is not a Palindrome!!");
        }

        Console.WriteLine(input);
    }
}