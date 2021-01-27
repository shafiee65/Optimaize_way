using System;
using System.Collections;
using System.Windows.Forms;

namespace fanavar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        int Box_Size;
        int Obj_Size;
        private void btnObj_Click(object sender, EventArgs e)
        {

        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            ArrayList Obj = new ArrayList();
            ArrayList Box = new ArrayList();
            lblresault.Text = "";
            //test start------------------------------------
            Random r = new Random(DateTime.Now.Second);
            int Obj_Count = r.Next(1, 11);
            int Box_Count = r.Next(1, Obj_Count);
            Box_Size = r.Next(1, 11);
            for (int i = 0; i < Obj_Count; i++)
            {
                Obj.Add(r.Next(1, Box_Size));
            }
            for (int i = 0; i < Box_Count; i++)
            {
                Box.Add(Box_Size);
            }
            foreach (int item in Obj)
            {
                lblresault.Text += item + ",";
            }
            lblresault.Text += " Count Of Box : " + Box_Count + " Size Of Box : " + Box_Size + " Counr Obj : " + Obj_Count;
            //test end------------------------------------
            int Sum = 0;
            int count = 0;
            for (int i = 0; i < Box.Count; i++)
            {
                int Save_Box = Box_Size;
                for (int j = Obj.Count-1; j >= 0; j--)
                {
                    if (Save_Box - Convert.ToInt32(Obj[j]) < 0)
                        break;
                    Save_Box = Save_Box - Convert.ToInt32(Obj[j]);
                    count++;
                    Sum++;
                }
                Obj.RemoveRange(Obj.Count - count, count);
                count = 0;
            }
            lblresault.Text +="\n \n" +"Resault : "+ Sum.ToString();
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            //Box.Add(Box_Size);
        }

        private void textBoxall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar== 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
