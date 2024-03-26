public class Circle : Shape
{
    private float _radius;

    public Circle(string color, float radius) : base(color)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
        return (float)(Math.Pow(_radius,2) * (22/7) );
    }
}