using System;
using System.Drawing;
using CCWin;

namespace S1Hotel
{
    public partial class About : CCSkinMain
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            //label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;
            label1.Parent = skinPictureBox1;//将pictureBox1设为标签的父控件
            label3.Parent = skinPictureBox1;
            label8.Parent = skinPictureBox1;
            label8.ForeColor = Color.Red;
            label6.Parent = skinPictureBox1;
            label4.Parent = skinPictureBox1;
            label4.ForeColor = Color.Red;
            label7.Parent = skinPictureBox1;
            label10.Parent = skinPictureBox1;
            label10.ForeColor = Color.Red;
            label11.Parent = skinPictureBox1;
            label11.ForeColor = Color.Red;
            //pictureBox1.Controls.Add(label1);
            //label1.Location = new Point(161, 49);//重新设定标签的位置，这个位置时相对于父控件的左上角
        }
    }
}
