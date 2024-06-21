using System.Security.Cryptography.X509Certificates;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string relDir = new FileInfo(typeof(Program).Assembly.Location).Directory.FullName;   
            string path = Path.Combine(relDir, "leesdezefile.txt");
            string[] content = File.ReadAllLines(path);
            
            string path2 = Path.Combine(relDir, "mijnnieuwefile.txt");
            string[] content2 = File.ReadAllLines(path2);


            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }


            
            File.WriteAllText("mijnnieuwetextfile.txt", "nieuwe text"); 
            File.AppendAllText("mijnnieuwetextfile.txt", "nieuwe text");
            string path3 = Path.Combine(relDir, "mijnnieuwefile.txt");
            string[] content3 = File.ReadAllLines("mijnnieuwetextfile.txt");
            Directory.CreateDirectory("output");
         

            for (int i = 0;i < content3.Length; i++)
            {
                Console.WriteLine(content3[i]);
            }
        }
    }
}
