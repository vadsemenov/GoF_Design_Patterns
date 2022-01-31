using System;

namespace Prototype_pattern
{
    /// <summary>
    /// Класс наследник Geometry, родитель Rectangle
    /// </summary>
    public class Line : Geometry, ICloneable
    {
        public string LineType; 

        public Line(string geometryType, string lineType ) : base(geometryType)
        {
            LineType = lineType;
        }

        public override Line MyClone()
        { 
            Line line = new Line(GeometryType,LineType);
            
            return line;
        }

        public override object Clone()
        {
            return (object)MyClone();
        }
    }
}