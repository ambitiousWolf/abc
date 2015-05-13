using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopQuiz;
namespace WindowsFormsApplication1
{
    class Pyramid : ObjectType
    {
          private double side;
        public double height;
        public Pyramid(double s, double h)
            : base()
        {
            obType = TypeOfObject.Types.Pyramid;
            this.side = s;
            height = h;
        }
        public double Side
        {
            get { return side; }
            set
            {
                if(side<0)
                    side=0;
                else
                    side=value;
            }
        }
        public override double Volume()
        {
            return side*side*height/3;
        }
        public override string StringShape()
        {
            string str = "";
            str+=string.Format("{0,8}","Pyramid");
            str+="\t";
            str += string.Format("{0,8:F2}", side);
            str += "\t";
            str += string.Format("{0,8:F2}", height);
            return str;
        }
    }
}
