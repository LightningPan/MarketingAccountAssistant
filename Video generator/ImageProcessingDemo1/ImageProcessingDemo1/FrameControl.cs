using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ImageProcessingDemo1
{
    //边框控件
    //便于边框内控件的移动/调整大小


    public partial class FrameControl : UserControl
    {

        Control control;//边框内的控件
        Point lPoint = new Point();//上一个鼠标坐标
        Point cPoint = new Point();//鼠标当前坐标

        public FrameControl()
        {
            InitializeComponent();
        }
        public FrameControl(Control control)
        {
            this.control = control;

            MouseDown += (sender, e) =>
            {
                lPoint = Cursor.Position;
                Visible = false;
            };

            MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    //移动时刷新实线
                    DrawSolids();

                    //调整控件
                    MoveAndAdjust();
                }
                else
                {
                    //改变鼠标状态
                    SetCursor(e.X, e.Y);
                }
            };

            MouseUp += (sender, e) =>
            {
                control.Refresh();

                //显示虚线
                DrawDottedLines();
            };

            Leave += (sender, e) =>
            {
                Visible = false;
            };
        }

        Rectangle controlRect;//包括边框的局域
        Rectangle[] borderRects = new Rectangle[4];//四条底边
        Point[] linePoints = new Point[5];//四条虚线的端点
        Rectangle[] smallRects = new Rectangle[8];//8个矩形按钮
        const int size = 6;
        Size smallRectSize = new Size(size, size);//矩形按钮的大小

        //绘制虚线和矩形小按钮
        public void DrawDottedLines()
        {
            Visible = true;

            BringToFront();

            //设置边框控件的区域
            int x = control.Bounds.X - smallRectSize.Width;
            int y = control.Bounds.Y - smallRectSize.Height;
            int width = control.Bounds.Width + (smallRectSize.Width * 2);
            int height = control.Bounds.Height + (smallRectSize.Height * 2);
            Bounds = new Rectangle(x, y, width, height);

            controlRect = new Rectangle(new Point(0, 0), Bounds.Size);

            Graphics g = CreateGraphics();
            g.Clear(control.Parent.BackColor);//清除之前绘制的

            //四条底边

            GraphicsPath path = new GraphicsPath();

            //上底边
            borderRects[0] = new Rectangle(0, 0, Width + size * 2, smallRectSize.Height + 1);
            //左底边
            borderRects[1] = new Rectangle(0, size + 1, smallRectSize.Width + 1, Height - size * 2 - 2);
            //下底边
            borderRects[2] = new Rectangle(0, Height - size - 1, Width + size * 2, smallRectSize.Height + 1);
            //右底边
            borderRects[3] = new Rectangle(Width - size - 1, size + 1, smallRectSize.Width + 1, Height - size * 2 - 2);
            path.AddRectangle(borderRects[0]);
            path.AddRectangle(borderRects[1]);
            path.AddRectangle(borderRects[2]);
            path.AddRectangle(borderRects[3]);

            Region = new Region(path);

            //绘制虚线

            //左上
            linePoints[0] = new Point(3, 3);
            //右上
            linePoints[1] = new Point(Width - 3 - 1, 3);
            //右下
            linePoints[2] = new Point(Width - 3 - 1, Height - 3 - 1);
            //左下
            linePoints[3] = new Point(3, Height - 3 - 1);
            //左上
            linePoints[4] = new Point(3, 3);

            Pen pen = new Pen(Color.Black, 1) { DashStyle = DashStyle.Dot };

            g.DrawLines(pen, linePoints);

            //8个矩形按钮

            //左上
            smallRects[0] = new Rectangle(new Point(0, 0), smallRectSize);
            //右上
            smallRects[1] = new Rectangle(new Point(Width - size - 1, 0), smallRectSize);
            //左下
            smallRects[2] = new Rectangle(new Point(0, Height - size - 1), smallRectSize);
            //右下
            smallRects[3] = new Rectangle(new Point(Width - size - 1, Height - size - 1), smallRectSize);
            //上
            smallRects[4] = new Rectangle(new Point(Width / 2 - 1, 0), smallRectSize);
            //下
            smallRects[5] = new Rectangle(new Point(Width / 2 - 1, Height - size - 1), smallRectSize);
            //左
            smallRects[6] = new Rectangle(new Point(0, Height / 2 - size / 2), smallRectSize);
            //右
            smallRects[7] = new Rectangle(new Point(Width - size - 1, Height / 2 - size / 2), smallRectSize);

            //填充矩形内部为白色
            g.FillRectangles(Brushes.White, smallRects);
            //绘制矩形
            g.DrawRectangles(Pens.Black, smallRects);

        }

        //绘制实线
        public void DrawSolids()
        {
            Visible = false;

            Graphics g = control.CreateGraphics();
            int width = control.Width;
            int height = control.Height;
            Point[] points = new Point[5] { new Point(0,0),new Point(width - 1,0),
                    new Point(width - 1,height-1),new Point(0,height-1),new Point(0,0)};
            g.DrawLines(new Pen(Color.Gray, 3), points);
        }

        //鼠标在当前控件中的位置
        enum MousePos
        {
            None,
            Top,
            Right,
            Bottom,
            Left,
            LeftTop,
            LeftBottom,
            RightTop,
            RightBottom,
            Border
        }
        MousePos mousePos;

        //根据鼠标位置改变光标形态
        private void SetCursor(int x, int y)
        {
            Point point = new Point(x, y);

            if (!controlRect.Contains(point))//不在边框局域内直接退出
            {
                Cursor.Current = Cursors.Arrow;
                return;
            }
            else
            if (smallRects[0].Contains(point))//左上
            {
                Cursor.Current = Cursors.SizeNWSE;
                mousePos = MousePos.LeftTop;
            }
            else if (smallRects[1].Contains(point))//右上
            {
                Cursor.Current = Cursors.SizeNESW;
                mousePos = MousePos.RightTop;
            }
            else if (smallRects[2].Contains(point))//左下
            {
                Cursor.Current = Cursors.SizeNESW;
                mousePos = MousePos.LeftBottom;
            }
            else if (smallRects[3].Contains(point))//右下
            {
                Cursor.Current = Cursors.SizeNWSE;
                mousePos = MousePos.RightBottom;
            }

            else if (smallRects[4].Contains(point))//上
            {
                Cursor.Current = Cursors.SizeNS;
                mousePos = MousePos.Top;
            }
            else if (smallRects[6].Contains(point))//左
            {
                Cursor.Current = Cursors.SizeWE;
                mousePos = MousePos.Left;
            }
            else if (smallRects[5].Contains(point))//下
            {
                Cursor.Current = Cursors.SizeNS;
                mousePos = MousePos.Bottom;
            }
            else if (smallRects[7].Contains(point))//右
            {
                Cursor.Current = Cursors.SizeWE;
                mousePos = MousePos.Right;
            }
            else if (borderRects[0].Contains(point) || borderRects[1].Contains(point) || borderRects[2].Contains(point) || borderRects[3].Contains(point))
            {
                Cursor.Current = Cursors.SizeAll;
                mousePos = MousePos.Border;
            }
            else
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        const int MinHeight = 10;//控件的最小高度
        const int MinWeight = 10;//控件的最小宽度

        //鼠标在相应位置点击并拖动时，调整大小或位置
        private void MoveAndAdjust()
        {
            cPoint = Cursor.Position;
            int x = cPoint.X - lPoint.X;
            int y = cPoint.Y - lPoint.Y;
            switch (mousePos)
            {
                case MousePos.None:
                    break;
                case MousePos.Top://上，调整
                    if (control.Height - y > MinHeight)
                    {
                        control.Top += y;
                        control.Height -= y;
                    }
                    break;
                case MousePos.Right:
                    if (control.Width + x > MinWeight)
                    {
                        control.Width += x;
                    }
                    break;
                case MousePos.Bottom:
                    if (control.Height + y > MinHeight)
                    {
                        control.Height += y;
                    }
                    break;
                case MousePos.Left:
                    if (control.Width - x > MinWeight)
                    {
                        control.Left += x;
                        control.Width -= x;
                    }
                    break;
                case MousePos.LeftTop://左上
                    if (control.Width - x > MinWeight)
                    {
                        control.Left += x;
                        control.Width -= x;
                    }
                    if (control.Height - y > MinHeight)
                    {
                        control.Top += y;
                        control.Height -= y;
                    }
                    break;
                case MousePos.LeftBottom:
                    if (control.Width - x > MinWeight)
                    {
                        control.Left += x;
                        control.Width -= x;
                    }
                    if (control.Height + y > MinHeight)
                    {
                        control.Height += y;
                    }
                    break;
                case MousePos.RightTop:
                    if (control.Width + x > MinWeight)
                    {
                        control.Width += x;
                    }
                    if (control.Height - y > MinHeight)
                    {
                        control.Top += y;
                        control.Height -= y;
                    }
                    break;
                case MousePos.RightBottom:
                    if (control.Width + x > MinWeight)
                    {
                        control.Width += x;
                    }
                    if (control.Height + y > MinHeight)
                    {
                        control.Height += y;
                    }
                    break;
                case MousePos.Border:
                    cPoint = Cursor.Position;
                    control.Location = new Point(control.Location.X + cPoint.X - lPoint.X,
                        control.Location.Y + cPoint.Y - lPoint.Y);

                    //移动时刷新实线
                    DrawSolids();

                    break;
                default:
                    break;
            }
            lPoint = Cursor.Position;
        }
    }

}
