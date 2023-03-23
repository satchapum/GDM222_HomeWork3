class Q2 
{
    public static void Main(string[] args)
    {
        LinearCal();
    }
    
    public static void LinearCal()
    {
        bool CheckInside = true;
        List<Point> FreeFormPoint = new List<Point>();
        while(true)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            if(x == 0 && y == 0) 
            {
                break;
            }
            else
            {
                FreeFormPoint.Add(new Point(x,y));
            }
        }
        Point TargetPoint = new Point(float.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()));

        int i = 0;
        while(i < FreeFormPoint.Count() && CheckInside == true){

            if(i != FreeFormPoint.Count()-1)
            {
                float slope = (FreeFormPoint[i+1].GetY() - FreeFormPoint[i].GetY())/(FreeFormPoint[i+1].GetX() - FreeFormPoint[i].GetX());
                if(slope < 0)
                {
                    if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) <= (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX())) 
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) > (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX()))
                    {
                        break;
                    }
                }
                else
                {
                    if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) >= (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX())) 
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) < (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX()))
                    {
                        CheckInside = false;
                        break;
                    }
                }
                
            }
            else if(i == FreeFormPoint.Count()-1)
            {
                float slope = (FreeFormPoint[i].GetY() - FreeFormPoint[0].GetY())/(FreeFormPoint[i].GetX() - FreeFormPoint[0].GetX());

                if(slope < 0)
                {
                    if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) <= (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX())) 
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) > (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX()))
                    {
                        CheckInside = false;
                        break;
                    }
                }
                else
                {
                    if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) >= (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX())) 
                    {
                        CheckInside = true;
                    }
                    else if(((1 / slope) * TargetPoint.GetY()) - (TargetPoint.GetX()) < (1 / slope) * FreeFormPoint[i].GetY() - (FreeFormPoint[i].GetX()))
                    {
                        CheckInside = false;
                        break;
                    }
                }
            }
            i++;
        }
        if(CheckInside == true) 
        {
            Console.WriteLine("Inside");
        }
        else if(CheckInside == false)
        {
            Console.WriteLine("Outside");
        }
    }
}

 