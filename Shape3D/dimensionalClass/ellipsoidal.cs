using System;

namespace dimensionalClass
{
    public class ellipsoidal : dimensional
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
    }


}
