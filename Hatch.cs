
namespace Hatchit
{
    using System.Collections.Generic;

    public class Hatch
    {

        public List<Line> LineDefinitions
        {
            get; set;
        }

        public Hatch()
        {
            LineDefinitions = new List<Line>();
        }
    }
}
