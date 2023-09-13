namespace ArvPart2
{
    abstract class Shape
    {
        protected int width;
        protected int height;
        public int Width{get{return width;}}
        public int Height{get{return height;}}
        public Shape(int x, int y)
        {
            width = x;
            height = y;
        }

        public abstract int Area();
        public abstract int Circumferance();
    }
}