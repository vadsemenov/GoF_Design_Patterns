using System;

namespace Prototype_pattern
{
    /// <summary>
    /// Базовый класс для классов Line и Rectangle
    /// </summary>
    public class Geometry  : IMyCloneable<Geometry>, ICloneable
    {
        public string GeometryType;
       
        public Geometry(string geometryType)
        {
            GeometryType = geometryType;
        }

        public virtual Geometry MyClone()
        {
            Geometry geom = new Geometry(GeometryType);
            return geom;
        }

        public virtual object Clone()
        {
            return (object)MyClone();
        }
    }

}