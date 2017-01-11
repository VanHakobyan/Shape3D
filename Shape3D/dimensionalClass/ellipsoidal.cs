using System;

namespace dimensionalClass
{
    public class ellipsoidal : dimensional, IMovable
    {
        private float x;
        private float y;
        private float z;


        public ellipsoidal(float x, float y, float z, float r)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.r = r;
        }

        public override float massGet()
        {
            return volumeGet() * r;
        }
        public override float volumeGet()
        {
            return (4f / 3f) * (float)Math.PI * x * y * z;
        }

        public override float areaGet()
        {
            return 4 * (float)Math.PI * y * y * (1 + (2f / 3f) * (z * z) / (x * x));
        }
        public void MoveBy(float dx, float dy, float dz)
        {
            var p = new Point3D();

            p.X = this.Location.X + dx;
            p.Y = this.Location.Y + dy;
            p.Z = this.Location.Z + dz;

            this.Location = p;
        }

        public void MoveTo(Point3D p)
        {
            this.Location = p;
        }

        public void MoveTo(float x, float y, float z)
        {
            this.Location = new Point3D(x, y, z);
        }
    }
}
