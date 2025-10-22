internal class Program
{
    private static void Main(string[] args)
    {
        //Reverse String ::
        Console.WriteLine("Enter a string to reverse:");

        /*John  lenghth = 4-1 = 3
         3 2 1 0
         nhoJ
         J o h n
         0 1 2 3
         
         0 < 4
         1 < 4
         2 < 4
         3 < 4
         
         i = 3; i >=0; i--
            */
        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
    }
}