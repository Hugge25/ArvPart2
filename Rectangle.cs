namespace ArvPart2
{
    class Rectangle: Shape
    {
        public Rectangle(int x, int y) : base(x, y){
            
        }

        public override int Area()
        {
            int area = width*height;
            return area;
        }
        public override int Circumferance()
        {
            int circ = (width*2) + (height*2);
            return circ;
        }
    }
}