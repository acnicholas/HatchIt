
namespace Hatchit
{
    using System.Collections.Generic;

    public class Hatch
    {
        public string Name
        {
            get; set;
        }

        public string Definition
        {
            get; set;
        }

        public List<Line> LineDefinitions
        {
            get; set;
        }

        public Hatch()
        {
            LineDefinitions = new List<Line>();
        }

        public Hatch(string name) : this(name, name)
        {
        }

        public Hatch(string name, string definition)
        {
            Name = name;
            Definition = name;
            LineDefinitions = new List<Line>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
