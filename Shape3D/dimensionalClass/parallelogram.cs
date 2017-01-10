namespace dimensionalClass
{
    public class parallelogram : dimensional
    {
        private float a;
        private float b;
        private float h;
        public parallelogram(float a, float b, float h, float r)
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
        public override float volumeGet()
        {
            return a * b * h;
        }


    }
}
