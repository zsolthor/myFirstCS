namespace Exercise6
{
    internal class Square
    {
        private int side;
        private int area;

        public Square(int side)  //constructor has no return type
        {
            this.side = side;
            calcArea();         // once the square is created, the area will also be calculated
        }

        private void calcArea()  //private method, not returning anything (void), just setting the area
        {
            area = side * side;
        }

        public int Side
        {
            get
            {
                return side;
            }
        }  //read-only properties

        public int Area
        {
            get
            {
                return area;
            }
        }  //read-only properties
    }
}