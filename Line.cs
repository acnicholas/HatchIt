using System;

namespace Hatchit
{
    using System.Windows.Media;
    using System.Windows.Shapes;
        
    /// <summary>
    /// Description of Hatch.
    /// </summary>
    public class Line
    {
        
        public double Rotation
        {
           get; set;
        }
        
        public double XOrigin
        {
            get; set;
        }
        
        public double YOrigin
        {
            get; set;
        }
        
        public double Shift
        {
            get; set;
        }
        
        public double Offset
        {
            get; set;
        }
        
        public DoubleCollection DashSpaceArray
        {
            get; set;
        }
    
        public Line()
        {
            Rotation = 0;
            XOrigin = 0;
            YOrigin = 0;
            Shift = 0;
            Offset = 0;
            DashSpaceArray = new DoubleCollection();   
        }
        
        public Line(double rotation, double x, double y, double shift, double offset)
        {
            Rotation = rotation;
            XOrigin = x;
            YOrigin = y;
            Shift = shift;
            Offset = offset;
            DashSpaceArray = new DoubleCollection();   
        }
        
        public Line(string lineDefinition)
        {

        }
    }
}
