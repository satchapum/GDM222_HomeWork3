class Q3
{
    public static void Main()
    {
        Calculate();
    }
    public static void Calculate()
    {
        bool CheckCut = false;
        Point p1 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        Point p2 = new Point(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
        float radius1 = float.Parse(Console.ReadLine());
        float radius2 = float.Parse(Console.ReadLine());

        float distanceOfTwoPoint = (float)Math.Sqrt((Math.Pow(p2.GetX() - p1.GetX(),2f)) + Math.Pow(p2.GetY() - p1.GetY(), 2f));
        if(distanceOfTwoPoint <= radius1 + radius2)
        {
            CheckCut = true;
        }

        if(CheckCut == true)
        {
            float a = (radius1 * radius1 - radius2 * radius2 + distanceOfTwoPoint * distanceOfTwoPoint)/(2*distanceOfTwoPoint);
            float h = (float)Math.Sqrt(radius1 * radius1 - a * a);
 
            // Find P2.
            float cx2 = p1.GetX() + a * (p2.GetX() - p1.GetX()) / distanceOfTwoPoint;
            float cy2 = p1.GetY() + a * (p2.GetY() - p1.GetY()) / distanceOfTwoPoint;
 
            // Get the points P3.
            Point intersectionPoint1 = new Point((float)(cx2 + h * (p2.GetY() - p1.GetY()) / distanceOfTwoPoint),(float)(cy2 - h * (p2.GetX() - p1.GetX()) / distanceOfTwoPoint));
            Point intersectionPoint2 = new Point((float)(cx2 - h * (p2.GetY() - p1.GetY()) / distanceOfTwoPoint),(float)(cy2 + h * (p2.GetX() - p1.GetX()) / distanceOfTwoPoint));

            Console.WriteLine("{0} \n{1} \n{2} \n{3}",intersectionPoint1.GetX(), intersectionPoint1.GetY(), intersectionPoint2.GetX(), intersectionPoint2.GetY());
            
        }

        
    }
}