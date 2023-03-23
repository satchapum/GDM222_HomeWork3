class Q1 
{
    public static void lineFromPoints(Point p1, Point p2, ref float a, ref float b, ref float c)
    {
        a = p2.GetY() - p1.GetY();
        b = p1.GetX() - p2.GetX();
        c = a * (p1.GetX()) + b * (p1.GetY());
    }
 
    public static void perpendicularBisectorFromLine(Point p1, Point p2, ref float a, ref float b, ref float c)
    {
        Point midPoint = new Point((p1.GetX() + p2.GetX()) / 2, (p1.GetY() + p2.GetY()) / 2);
 
        c = -b * (midPoint.GetX()) + a * (midPoint.GetY());
 
        float temp = a;
        a = -b;
        b = temp;
    }

    public static Point lineLineIntersection(float a1, float b1, float c1, float a2, float b2, float c2)
    {
        Point ans;
        float determinant = a1 * b2 - a2 * b1;
        if (determinant == 0) {
            ans = new Point(float.MaxValue,float.MaxValue);
        }
 
        else {
            float x = (b2 * c1 - b1 * c2) / determinant;
            float y = (a1 * c2 - a2 * c1) / determinant;
            ans = new Point(x, y);
        }
        return ans;
    }
 
    public static void findCircumCenter(Point p1, Point p2, Point p3)
    {
        float a = 0;
        float b = 0;
        float c = 0;
        lineFromPoints(p1, p2, ref a, ref b, ref c);
 
        float e = 0;
        float f = 0;
        float g = 0;
        lineFromPoints(p2, p3, ref e, ref f, ref g);
 
        perpendicularBisectorFromLine(p1, p2, ref a, ref b, ref c);
        perpendicularBisectorFromLine(p2, p3, ref e, ref f, ref g);
 
        Point circumcenter = lineLineIntersection(a, b, c, e, f, g);
 
        Console.Write("");
        Console.Write("(");
        Console.Write(circumcenter.GetX());
        Console.Write(", ");
        Console.Write(circumcenter.GetY());
        Console.WriteLine(")");
        Console.Write("Radius : {0}", Math.Sqrt(Math.Pow(p1.GetX()-circumcenter.GetX(),2) + Math.Pow(p1.GetY()-circumcenter.GetY(),2)));

    }
 
    public static void Main()
    {
        Point p1 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        Point p2 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        Point p3 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));

        findCircumCenter(p1, p2, p3);
    }
}