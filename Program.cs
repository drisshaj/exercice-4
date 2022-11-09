using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace exercice_4
{
    public class Point
    {
        public float x;
        public float y;
        public int Getx()
        {
            return x;


        }
        public void Setx(float ax)
        {
            this.x = x;

        }
        public int Gety()
        {
            return y;
        }
        public void Sety(float ay)
        {
            this.y = y;

        }
        public Point(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public float distance(Point p1)
        {
            float dis = (float)Math.Sqrt(Math.Pow(x - p1.x, 2) + Math.Pow(y - p1.x, 2));
            return dis;
        }
        public bool comparer(Point p1)
        {
            if (x == p1.x && y == p1.y)
                return true;

            return false;
        }
        public void translation(float a)
        {
            x += a;
            y += a;
        }
        public bool liniarite(Point p1, Point p2)
        {
            float li = (p2.y - y) * (p1.x - x) - (p1.y - y) * (p2.x - x);

            if (li == 0)
                return true;
            else return false;

        }


    }

    public class cercle:Point
    {
        Point centre;
        double rayon;
        public cercle()
        {
            centre = new Point();
            rayon = 0;
        }
        public void setCentre(float x , float y)
        {
            centre.x = x;
            centre.y = y;
        }
        public void setRayon(double d)
        {
            rayon = d;
        }
        public bool Egalite(cercle c1)
        {
            if ((c1.centre == centre )&& (c1.rayon == rayon)) return true;
            else
            {
                return false;
            }
        }
        public float intersection (cercle c1 ,cercle c2)
        {
            float r, R, d, dx, dy, cx, cy, Cx, Cy;

            if (c1.rayon < c2.rayon)
            {
                rayon = c1.rayon; R = c2.rayon;
                cx = c1.x; cy = c1.y;
                Cx = c2.x; Cy = c2.y;
            }
            else
            {
                rayon = c2.rayon; 
                R = c1.rayon;
                Cx = c1.x; Cy = c1.y;
                cx = c2.x; cy = c2.y;
            }

            dx = cx - Cx;
            dy = cy - Cy;
            d = Math.Sqrt(dx * dx + dy * dy,1);

            if (d < Math.EPS && Math.abs(R - r) < EPS) return [];
            else if (d < EPS) return;
            var x = (dx / d) * R + Cx;
            var y = (dy / d) * R + Cy;
            var P = new Point(x, y);
            if (Math.Abs((R + r) - d) < EPS || Math.Abs(R - (r + d)) < EPS) return [P];
            if ((d + r) < R || (R + r < d)) return [];

            
        }
    
    public bool perpendacularite(cercle c1)
    {
        int dis = (int)((x-c1.x)*(x-c1.x)+(y-c1.y)* (y - c1.y));
            if (dis == (rayon * rayon) + (c1.rayon + c1.rayon))
                return true;
            else
            {
                return false;
            }

    }
    public double calcir()
        {
            double c = 0;
            c = 2 * Math.PI * rayon;
            return c;   
        }
    public double air()
        {
            double air = 0;
            air=Math.PI * rayon*rayon;
            return air; 
        }

    }
    public class droite:Point
    {
        Point p1;
        Point p2;
        public droite(Point a , Point b)
        {
            a = p1;
            b = p2; 
                 
        }
        public void setpoints( )
        {

        }
        public Tuple<Point,Point>  getpoints()
        {
            return Tuple.Create(p1,p2) ;
            
        }
        public bool egalite(droite d1)
        {
            if (d1.p1 == p1 && d1.p2 == p2) return true;
            else return false;  

        }
        public bool parallele(droite d1)
        {
            if (x * d1.y == d1.x * y) return true;
            else
            {
                return false;
            }
        }
        int direction(Point p1, Point p2, Point c)
        {
            float val = (p2.y - p1.y) * (c.x - p2.x) - (p1.x - p2.x) * (c.y - p2.y);
            if (val == 0)
                return 0;     
            else if (val < 0)
                return 2;    
            return 1;    
        }
        public bool surlaligne(droite d1 , Point p)
        {   
            if (p.x <= Math.Max(d1.p1.x, d1.p2.x) && p.x <= Math.Min(d1.p1.x, d1.p2.x) &&
               (p.y <= Math.Max(d1.p1.y, d1.p2.y) && p.y <= Math.Min(d1.p1.y, d1.p2.y)))
                return true;

            return false;
        }

         public bool Intersecte(droite d1 , droite d2)
        {
            
            int dir1 = direction(d2.p1, d2.p2, d1.p1);
            int dir2 = direction(d2.p1, d2.p2, d1.p2);
            int dir3 = direction(d1.p1, d1.p2, d2.p1);
            int dir4 = direction(d1.p1, d1.p2, d2.p2);

            if (dir1 != dir2 && dir3 != dir4)
                return true; 

            if (dir1 == 0 ) 
                return true;

            if (dir2 == 0 && surlaligne(d2, d1.p2)) 

            if (dir3 == 0 && surlaligne(d2, d1.p1)) 

            if (dir4 == 0 && surlaligne(d1, d2.p2)) 

            return false;
        }
        public bool perpendiculaire()
        {
            // pas de resolution
        }


    }




}

internal class Program
    {
        static void Main(string[] args)
        {
        }
    
}

