public class Rectangle : Shape
{
    private float _length;
    private float _breath;

    public Rectangle(string color, float length, float breath) : base(color)
    {
        _length = length;
        _breath = breath;
    }

    public override float GetArea()
    {
        return (float)(_length * _breath);
    }
}