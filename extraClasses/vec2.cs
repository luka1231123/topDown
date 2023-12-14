namespace topDown;

public class vec2
{
    public double[] e;

    public vec2()
    {
        e = new double[2] { 0, 0 };
    }

    public vec2(double e0, double e1)
    {
        e = new double[2] { e0, e1 };
    }
    public double x
    {
        get { return e[0]; }
        set { e[0] = value; }
    }

    public double y
    {
        get { return e[1]; }
        set { e[1] = value; }
    }

    public double this[int i]
    {
        get { return e[i]; }
        set { e[i] = value; }
    }
}