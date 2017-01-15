using System;

namespace dimensionalClass
{
    public class parallelepiped : dimensional,IMovable
    {
        private float a;
        private float b;
        private float h;
        public parallelepiped(float a, float b, float h, float r)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            this.r = r;
        }
        public override float areaGet()
        {
            return 2 * ((a + b) * h + a * b);
        }
        public override float massGet()
        {
            return volumeGet() * r;
        }

        public void MoveBy(float dx, float dy, float dz)
        {
            var k = new Point3D();
            k.X = this.Location.X + dx;
            k.Y = this.Location.Y + dy;
            k.Z = this.Location.Z + dz;
        }

        public void MoveTo(Point3D k)
        {
            this.Location = k;
        }

        public void MoveTo(float x, float y, float z)
        {

            this.Location = new Point3D(x, y, z);
        }

        public override float volumeGet()
        {
            return a * b * h;
        }

        


    }
}
