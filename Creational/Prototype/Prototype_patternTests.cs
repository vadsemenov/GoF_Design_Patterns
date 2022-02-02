using System;
using Xunit;
using Xunit.Sdk;

namespace Prototype_pattern.Tests
{
    public class Prototype_patternTests
    {
        [Fact]
        public void Clone_Geometry_Object_With_IMyCloneable()
        {
            string _geometryType = "GeometryType1";
            Geometry geometry = new(_geometryType);
            
            Geometry geometry2 = geometry.MyClone();

            Assert.NotSame(geometry,geometry2);
            Assert.Equal(geometry.GeometryType, geometry2.GeometryType);
        }

        [Fact]
        public void Clone_Line_Object_With_IMyCloneable()
        {
            string _geometryType = "GeometryType1";
            string _lineType = "LineType1";
            Line line = new(_geometryType,_lineType);
         
            Line line2 = line.MyClone();

            Assert.NotSame(line, line2);
            Assert.Equal(line.LineType, line2.LineType);
        }

        [Fact]
        public void Clone_Rectangle_Object_With_IMyCloneable()
        {
            string _geometryType = "GeometryType1";
            string _lineType = "LineType1";
            string _rectangleType = "RectangleType1";
            Rectangle rect = new(_geometryType, _lineType,_rectangleType);

            Rectangle rect2 = rect.MyClone();

            Assert.NotSame(rect, rect2);
            Assert.Equal( rect.RectangleType, rect2.RectangleType);
        }


        [Fact]
        public void Clone_Geometry_Object_With_ICloneable()
        {
            string _geometryType = "GeometryType1";
            Geometry geometry = new(_geometryType);

            Geometry geometry2 = (Geometry)geometry.Clone();

            Assert.NotSame(geometry, geometry2);
            Assert.Equal(geometry.GeometryType, geometry2.GeometryType);
        }

        [Fact]
        public void Clone_Line_Object_With_ICloneable()
        {
            string _geometryType = "GeometryType1";
            string _lineType = "LineType1";
            Line line = new(_geometryType, _lineType);

            Line line2 = (Line)line.Clone();

            Assert.NotSame(line, line2);
            Assert.Equal(line.LineType, line2.LineType);
        }

        [Fact]
        public void Clone_Rectangle_Object_With_ICloneable()
        {
            string _geometryType = "GeometryType1";
            string _lineType = "LineType1";
            string _rectangleType = "RectangleType1";
            Rectangle rect = new(_geometryType, _lineType, _rectangleType);

            Rectangle rect2 = (Rectangle)rect.Clone();

            Assert.NotSame(rect, rect2);
            Assert.Equal(rect.RectangleType, rect2.RectangleType);
        }

    }
}
