using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopQuiz;
namespace WindowsFormsApplication1
{
    class Ball:ObjectType
    { 
        private double radius;
        public Ball(double s):base()
        {
            obType = TypeOfObject.Types.Ball;
            this.radius = s;
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
            
            return 4.0/3*Constant.pi*radius*radius*radius;
        }
        public override string StringShape()
        {
            string str = "";
            str+=string.Format("{0,8}","Ball");
            str+="\t";
            str += string.Format("{0,8:F2}", radius);
            str += "\t";
            return str;
        }
    }
}
