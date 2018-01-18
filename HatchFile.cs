using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hatchit
{
    class HatchFile
    {
        public static List<Hatch> ReadHatchFile(string fileName)
        {
            string line;
            var result = new List<Hatch>();
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null) {
                if (line[0] == '*') {
                    ReadHatchDefinitions(file, line);
                }
            }
            file.Close();
            return null;
        }

        private static void ReadHatchDefinitions(System.IO.StreamReader file, string line)
        {
            var name = line.Substring(1, line.IndexOf(@",")).Trim();
            var definition = line.Substring(line.IndexOf(@","), line.Length);
            Hatch hatch = new Hatch(name, definition);
            while ((line = file.ReadLine()) != null) {
                if (line[0] == '*') {
                    ReadHatchDefinitions(file, line);
                } else {
                    hatch.LineDefinitions.Add(new Line());
                }
            }
        }
    }
}
