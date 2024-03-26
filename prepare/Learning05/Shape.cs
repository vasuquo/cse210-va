public class Shape
{
    private string _color;

    public Shape(string color)
    {
        SetColor(color);
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual float GetArea()
    {
        return 0f;
    }
}