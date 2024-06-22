using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMonFactory
    {
       internal void Load(string datafile)
       {
            string[] lines = File.ReadAllLines(datafile);

            for (int i = 0; i < lines.Length; i++) 
            {
                Console.WriteLine(lines[i]);
            }
            
           
       }
       
    }

   
}
