﻿
using Geometry;

namespace dimensionalClass
{
    public static class ShapeMover
    {
        public static void MoveByAxis(IMovable shape, Axis axis, float d)
        {
            switch (axis)
            {
                case Axis.X:
                    shape.MoveBy(d, 0, 0);
                    break;
                case Axis.Y:
                    shape.MoveBy(0, d, 0);
                    break;
                case Axis.Z:
                    shape.MoveBy(0, 0, d);
                    break;
                default:
                    break;
            }
        }
    }
}
