using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopQuiz;
namespace WindowsFormsApplication1
{
    class Cylinder : ObjectType
    { 
        private double radius;
        public double height;
        public Cylinder(double s, double h)
            : base()
        {
            obType = TypeOfObject.Types.Cylinder;
            this.radius = s;
            height = h;
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if(radius<0)
                    radius=0;
                else
                    radius=value;
            }
        }
        public override double Volume()
        {
            
            return Constant.pi*radius*radius*height;
        }
        public override string StringShape()
        {
            string str = "";
            str+=string.Format("{0,8}","Cylinder");
            str+="\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            str += string.Format("{0,8:F2}", height);
            return str;
        }
    }
}
