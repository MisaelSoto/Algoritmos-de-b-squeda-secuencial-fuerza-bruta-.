using System;
using System.Collections.Generic;
using System.Text;

namespace SotoZaragozamisaelA01
{
    class Circle
    {
        private int x;
        private int y;
        private int radius;
        private int ID;

        public Circle()
        {

        }
        public Circle(int x, int y, int Radius, int id)
        {
            this.x = x;
            this.y = y;
            this.radius = Radius;
            this.ID = id;
        }

        public int getX() 
        { 
            return this.x;
        }
        public void SetX(int x) 
        { 
            this.x = x; 
        }
        
        public int getY() 
        { 
            return this.y;
        }
        public void SetY(int y)
        {
            this.y = y;
        } 
        
        public int getRadius() 
        {
            return this.radius; 
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public int getID()
        {
            return this.ID;
        }
        public void SetID(int id)
        {
            this.ID = id;
        }

    }
}
