using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopQuiz;
using WindowsFormsApplication1;

namespace Team2_Quiz5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ObjectType> objectArr = new List<ObjectType>();
        double[] densityArr = { 2.7, 7.87, 11.3 };
        int Order = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int amount = ObjectType.Amount;
            if (cboxMaterial.Text == "")
            {
                MessageBox.Show("請選擇一種材料");
                return;
            }
            if (cboxShape.Text == "")
            {
                MessageBox.Show("請選擇一種形狀");
                return;
            }
 
            switch (cboxShape.SelectedIndex)
            {
                case 0:
                    Ball ball= new Ball(Convert.ToDouble(txtParameter.Text));
                    ball.density = densityArr[cboxMaterial.SelectedIndex];
                    ball.order =objectArr.Count;
                    objectArr.Add(ball);
                    break;
                case 1:
                    Cube cube= new Cube(Convert.ToDouble(txtParameter.Text));
                    cube.density = densityArr[cboxMaterial.SelectedIndex];
                    cube.order = objectArr.Count;
                    objectArr.Add(cube);
                    break;
                case 2:
                    Cylinder cylinder = new Cylinder(Convert.ToDouble(txtParameter.Text), Convert.ToDouble(txtHeight.Text));
                    cylinder.density = densityArr[cboxMaterial.SelectedIndex];
                    cylinder.order = objectArr.Count;
                    objectArr.Add(cylinder);
                    break;
                case 3:
                    Pyramid pyramid = new Pyramid(Convert.ToDouble(txtParameter.Text), Convert.ToDouble(txtHeight.Text));
                    pyramid.density = densityArr[cboxMaterial.SelectedIndex];
                    pyramid.order = objectArr.Count;
                    objectArr.Add(pyramid);
                    break;
            }
            txtConstant.AppendText(objectArr[amount].StringShape()+"\r\n");
            txtAmount.Text = ObjectType.Amount.ToString();
        }

        private void cboxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxShape.SelectedIndex)
            { 
                case 0:
                    label3.Text = "半徑";
                    label4.Visible = false;
                    txtHeight.Visible = false;
                    break;
                case 1:
                    label3.Text = "邊長";
                    label4.Visible = false;
                    txtHeight.Visible = false;
                    break;
                case 2:
                    label3.Text = "半徑";
                    label4.Text = "高";
                    label4.Visible = true;
                    txtHeight.Visible = true;
                    break;
                case 3:
                    label3.Text = "底邊";
                    label4.Text = "高";
                    label4.Visible = true;
                    txtHeight.Visible = true;
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            sort();
            for (int i = 0; i < objectArr.Count; i++)
            {
                txtResult.AppendText(objectArr[i].StringProperties()+"\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            objectArr[0] = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            objectArr.RemoveAt(0);
            for (int i = 0; i < objectArr.Count; i++)
            {
                txtResult.AppendText(objectArr[i].StringProperties() + "\r\n");
            }
            txtAmount.Text = ObjectType.Amount.ToString();
        }
        private bool comparebyorder(ObjectType a, ObjectType b)
        {
            if(a.order > b.order)
                return true;
            else
                return false; 
        }
        private bool comparebyType(ObjectType a, ObjectType b)
        {
            return ((int)a.obType > (int)b.obType);
        }
        private delegate bool compareFunc(ObjectType a,ObjectType b);
        private void bubblesort(List<ObjectType> arr,compareFunc cmp)
        {
            for(int i=0;i<arr.Count;i++)
            {
                for(int j=0;j<arr.Count-1;j++)
                {
                    if(cmp(arr[j],arr[j+1]))
                    {
                        ObjectType temp;
                        temp=arr[j+1];
                        arr[j+1]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
        }
        public void sort()
        {
            switch (compare.SelectedIndex)
            { 
                case 0:
                    bubblesort(objectArr, comparebyorder);
                    break;
                case 1:
                    bubblesort(objectArr, comparebyType);
                    break;
                default:
                    break;
            }
        }

        //private void txtParameter_TextChanged(object sender, EventArgs e)
        //{

        //    if (cboxShape.SelectedIndex == 2 || cboxShape.SelectedIndex == 3)
        //    {
        //        if (txtParameter.Text != "" && txtHeight.Text != "")
        //            btnAdd.Enabled = true;
        //        else
        //            btnAdd.Enabled = false;
        //    }
        //    else
        //    {
        //        if (txtParameter.Text != "")
        //            btnAdd.Enabled = true;
        //        else
        //            btnAdd.Enabled = false;
        //    }

        //}

        //private void txtHeight_TextChanged(object sender, EventArgs e)
        //{
            

        //        if (cboxShape.SelectedIndex == 2 || cboxShape.SelectedIndex == 3)
        //        {
        //            if (txtParameter.Text != "" && txtHeight.Text != "")
        //                btnAdd.Enabled = true;
        //            else
        //                btnAdd.Enabled = false;
        //        }

        //}
        
    }
}
