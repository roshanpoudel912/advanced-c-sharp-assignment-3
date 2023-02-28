namespace Extension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Welcome to Advanced C# class";

            int wordCount = myString.GetWordCount();

            Console.WriteLine($"String value: {myString}");
            Console.WriteLine($"Word count: {wordCount}");
        }
    }
}