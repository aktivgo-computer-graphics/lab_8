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

        private const int K = 25;
        
        public Form1()
        {
            InitializeComponent();
            MyPen = new Pen(Color.Black);
            points = new List<Point>();
            
            InitStartSpline();
        }

        private void InitStartSpline()
        {
            textBoxP1X.Text = @"-25";
            textBoxP1Y.Text = @"20";
            textBoxP2X.Text = @"30";
            textBoxP2Y.Text = @"-40";
            textBoxP3X.Text = @"-60";
            textBoxP3Y.Text = @"-30";
            textBoxP4X.Text = @"30";
            textBoxP4Y.Text = @"15";
            
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            DrawOxy(e.Graphics);
            DrawSpline(e.Graphics);
        }

        private void DrawOxy(Graphics graph)
        {
            var maxX = ClientSize.Width;
            var maxY = ClientSize.Height;
            var centerX = maxX / 2;
            var centerY = maxY / 2;
            
            // Оси
            graph.DrawLine(MyPen, 0, centerY, maxX, centerY);
            graph.DrawLine(MyPen, centerX, 0, centerX, maxY);
            
            // Стрелки оси X
            graph.DrawLine(MyPen, maxX, centerY, maxX - 10, centerY + 5);
            graph.DrawLine(MyPen, maxX, centerY, maxX - 10, centerY - 5);
            
            // Стрелки оси Y
            graph.DrawLine(MyPen, centerX, 0, centerX + 5, 10);
            graph.DrawLine(MyPen, centerX, 0, centerX - 5, 10);
            
            // 0
            graph.DrawString("0", new Font("Arial", 10), new SolidBrush(Color.Black),centerX + 5, centerY + 5);

            for (var x = centerX + K; x < maxX; x += K)
            {
                // Черта
                graph.DrawLine(MyPen, x, centerY - 5, x, centerY + 5);
                // Подпись
                graph.DrawString(((x - centerX) / K).ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x - 5, centerY + 5);
            }
            
            for (var x = centerX - K; x > 0; x -= K)
            {
                // Черта
                graph.DrawLine(MyPen, x, centerY - 5, x, centerY + 5);
                // Подпись
                graph.DrawString(((x - centerX) / K).ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), x - 10, centerY + 5);
            }
            
            for (var y = centerY + K; y < maxY; y += K)
            {
                // Черта
                graph.DrawLine(MyPen, centerX - 5, y, centerX + 5, y);
                // Подпись
                graph.DrawString(((y - centerY) / -K).ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), centerX + 7, y - 7);
            }
            
            for (var y = centerY - K; y > 0; y -= K)
            {
                // Черта
                graph.DrawLine(MyPen, centerX - 5, y, centerX + 5, y);
                // Подпись
                graph.DrawString(((y - centerY) / -K).ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), centerX + 7, y - 7);
            }
        }

        private void DrawSpline(Graphics graph)
        {
            try
            {
                var p1X = int.Parse(textBoxP1X.Text);
                var p1Y = int.Parse(textBoxP1Y.Text);
                var p2X = int.Parse(textBoxP2X.Text);
                var p2Y = int.Parse(textBoxP2Y.Text);
                var p3X = int.Parse(textBoxP3X.Text);
                var p3Y = int.Parse(textBoxP3Y.Text);
                var p4X = int.Parse(textBoxP4X.Text);
                var p4Y = int.Parse(textBoxP4Y.Text);

                errorLabel.Text = textBoxP1X.Text;
                
                points.Add(ToScreenCoordinates(p1X, p1Y));
                points.Add(ToScreenCoordinates(p2X, p2Y));
                points.Add(ToScreenCoordinates(p3X, p3Y));
                points.Add(ToScreenCoordinates(p4X, p4Y));
            }
            catch (Exception e)
            {
                errorLabel.Text = e.Message;
                return;
            }

            errorLabel.Text = points[0].ToString();
            graph.DrawBezier(MyPen,points[0], points[1], points[2], points[3]);
        }

        private Point ToScreenCoordinates(int x, int y)
        {
            var centerX = ClientSize.Width / 2;
            var centerY = ClientSize.Height / 2;

            return new Point((centerX + K * x), (centerY - K * y));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyPen.Dispose();
        }
    }
}