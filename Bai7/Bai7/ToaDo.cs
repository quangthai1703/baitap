using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class ToaDo
    {
        string ten;
        float x;
        float y;

        public ToaDo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public ToaDo()
        {
        }

    
        public void setName(string ten) { this.ten = ten; }
        public void setX(float x) { this.x = x; }
        public void setY(float y) { this.y = y; }

        public float getX() { return this.x; }
        public float getY() { return this.y; }
        public override string ToString()
        {
            return $"{this.ten}({this.x},{this.y})";
        }
    }
}
