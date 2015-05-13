using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopQuiz;
namespace WindowsFormsApplication1
{
    class Cube : ObjectType
    {
        private double side;
        public Cube(double s)
            : base()
        {
            obType = TypeOfObject.Types.Cube;
            this.side = s;
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
            return side*side*side;
        }
        public override string StringShape()
        {
            string str = "";
            str+=string.Format("{0,8}","Cube");
            str+="\t";
            str += string.Format("{0,8:F2}", side);
            str += "\t";
            return str;
        }
    }
}
