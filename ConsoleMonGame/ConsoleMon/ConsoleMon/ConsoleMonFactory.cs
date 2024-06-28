using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
                dataMon.energy = int.Parse(consoleMonData[4]);
                dataMon.health = int.Parse(consoleMonData[2]);

                Console.WriteLine(dataMon.name + dataMon.energy + dataMon.health);
            }
       }
        internal void LoadJson(string datafile)
        {
            File.ReadAllText(datafile);
            string json = File.ReadAllText(datafile);
            Console.WriteLine(json);
             
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }

    }

   
}
    