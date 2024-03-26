public class Square : Shape
{
    private double _side;

    public Square(string color, float side) : base(color)
    {
        _side = side;
    }

    public override float GetArea()
    {
        return (float)_side * (float)_side;
    }

}