using System;

namespace Prototype_pattern
{

    /// <summary>
    /// Класс наследник Line 
    /// </summary>
    public class Rectangle : Line, ICloneable
    {
        public string RectangleType;

        public Rectangle(string geometryType, string lineType, string rectangleType) : base(geometryType,lineType)
        {
            RectangleType = rectangleType;
        }

        public override Rectangle MyClone()
        {
            Rectangle rect = new Rectangle(GeometryType, LineType, RectangleType);

            return rect;
        }

        public override object Clone()
        {
            return (object) MyClone();
        }
    }
}