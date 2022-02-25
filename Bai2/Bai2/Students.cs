using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Students
    {
        private int id; 
        private string name;
        private float LT;
        private float TH;
        private float TB;

        public void setId(int id)
        {
            if (id < 0)
                this.id = 0;
            else this.id = id;  
        }
        public void setName(string name)
        {
            if(name == null)
                this.name = String.Empty;
            else this.name = name;   
        }
        public void setLT(float LT)
        {
            if(LT < 0.0 || LT > 10.0) 
                this.LT = 0;
            else this.LT = LT;
        }
        public void setTH(float TH)
        {
            if (TH < 0.0 || TH > 10.0)
                this.TH = 0;
            else this.TH = TH;
        }
        public int getID()
        {
            return id; 
        }
        public string getName()
        {
            return name;
        }
        public float getLT()
        {
            return LT;
        }
        public float getTH()
        {
            return TH;
        }

        public Students(int id, string name, float lT, float tH)
        {
            setId(id);
            setName(name);
            setLT(lT);
            setTH(tH);
        }

        public Students()
        {
        }
        public float getTB()
        {
            return ((getLT() + getTH()) / 2.0f);
        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-30} {2,-10:N} {3,-10:N} {4:N}", getID(), getName(), getLT(), getTH(), getTB());
        }

    }

}
