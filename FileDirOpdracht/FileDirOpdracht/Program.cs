namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\MA\periode 4\PROG\2023P4ProgCs2");


            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine(file.FullName);
            }

            
        }
    }
}
