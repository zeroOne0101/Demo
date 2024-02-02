using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paddy.Demo.Animation.Clock
{
    public partial class UserControlClock : UserControl
    {
        int gIndex = 0;
        public UserControlClock()
        {
            InitializeComponent();
        }

        private void UserControlClock_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; 
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void UserControlClock_Paint(object sender, PaintEventArgs e)
        {
            Draw(e);
        }

        private void Draw(PaintEventArgs e)
        {
            DrawEllipse(e);
            DrawScale(e);
        }
        private void DrawEllipse(PaintEventArgs e)
        {
            //获得画布对象
            Graphics g = e.Graphics;

            //新建笔
            Pen pen = new Pen(Color.Red, 5);

            //定义参数
            Point point = new Point(10, 10);
            Size size = new Size(200, 200);
            Rectangle rectangle = new Rectangle(point, size);
            //绘制圆形（空心）
            g.DrawEllipse(pen, rectangle);
        }

        //画刻度
        private void DrawScale(PaintEventArgs e)
        {
            //获得画布对象
            Graphics g = e.Graphics;
            //新建画笔
            Pen pen = new Pen(Color.Red);

            Point pointStart= new Point(107, 107);
            for (int i = 0; i < 3; i++)
            {
                double degrees = i * 30;
                Point pointEnd = GetScalePoint(degrees, 100,pointStart);
                g.DrawLine(pen, pointStart, pointEnd);
            }

            //画线方法一,直接写入坐标
            //g.DrawLine(pen, 107, 107, x1, y1);
            ////画线方法二，使用点类型对象
            //Point p1 = new Point(100, 100);
            //Point p2 = new Point(200, 450);
            //g.DrawLine(pen, p1, p2);
        }

        //获取对应刻度值的点
        private Point GetScalePoint(double degrees, double radius,Point pointStart)
        {
            double angle = Math.PI * degrees / 180.0;
            Point point = new Point();
            point.X =Convert.ToInt32(radius * Math.Cos(angle))+pointStart.X;
            point.Y =Convert.ToInt32(radius * Math.Sin(angle))+pointStart.Y;
            

            return point;   
        }

    }
}
