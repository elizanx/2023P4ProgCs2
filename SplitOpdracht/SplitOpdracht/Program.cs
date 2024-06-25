namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");

            string[] keyvalue = content.Split(".");
            Console.WriteLine(string.Join(" ", keyvalue));
        }
    }
}
