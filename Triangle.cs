namespace ArvPart2
{
    class Triangle: Shape
    {
        public Triangle(int x, int y) : base(x, y)
        {

        }
        public override int Area()
        {
            int area = (width*height)/2;
            return area;
        }
        public override int Circumferance()
        {
            int c = (int)Math.Sqrt(Math.Pow(width,2) + Math.Pow(height, 2));
            int circ = width+height+c;
            return circ;
        }
    }
}