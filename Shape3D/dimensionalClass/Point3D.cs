namespace dimensionalClass
{
    public struct Point3D
    {
        public Point3D(float x, float y, float z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }

}