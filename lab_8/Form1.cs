using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form1 : Form
    {
        private Pen MyPen;
        private List<Point> points;
        
        public Form1()
        {
            InitializeComponent();
            MyPen = new Pen(Color.Black);
            points = new List<Point>();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            
            points.Add(new Point(100, 100));
            points.Add(new Point(1000, 1000));
            points.Add(new Point(500, 500));
            points.Add(new Point(700, 300));
            
            e.Graphics.DrawBezier(MyPen,points[0], points[1], points[2], points[3]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyPen.Dispose();
        }
    }
}