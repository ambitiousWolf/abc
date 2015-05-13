using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopQuiz
{
    abstract class ObjectType
    {
        private static int amount=0;
        public int order;
        public TypeOfObject.Types obType;
        public ObjectType()
        {
            amount++;
           
        }
        ~ObjectType()
        {
            amount--;
        }
        public static int Amount
        {
            get{return amount;}
            set
            {  }
        }
        public double density;
        public abstract double Volume();
        //{
        //    return 0;
        //}
        public double Mass()
        {
            return Volume() * density;
        }
        public abstract string StringShape();
        //{
        //    return "";
        //}
        public string StringProperties()
        {
            string str = "";
            str += StringShape();
            str += "\t";
            str += density.ToString();
            str += "\t";
            str += string.Format("{0,8:F2}", Volume());
            str += "\t";
            str += string.Format("{0,8:F2}", Mass());
            return str;
        }
    }
    static class TypeOfObject
    {
        public enum Types { Unknown = 0, Ball, Cube, Cylinder, Pyramid }
    }
}

