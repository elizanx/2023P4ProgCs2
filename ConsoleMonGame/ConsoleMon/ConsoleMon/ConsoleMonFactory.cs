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
                string[] typeSplit = lines[i].Split("|");
                string[] consoleMonData = typeSplit[0].Split(",");
                Console.WriteLine(consoleMonData[i]);

                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.energy = int.Parse(consoleMonData[3]);
                dataMon.health = int.Parse(consoleMonData[1]);

                Console.WriteLine(dataMon.name + dataMon.energy + dataMon.health);
            }
            
           
       }
       
    }

   
}
