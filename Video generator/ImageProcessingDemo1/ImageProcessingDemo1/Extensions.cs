using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingDemo1
{
    //实现控件的移动
    public static partial class Extentions
    {
        public static void SetFrame(this Control control)
        {
            FrameControl fControl = null;//边框控件

            //按下鼠标键时
            control.MouseDown += (sender, e) =>
            {
                control.BringToFront();

            //清除所有控件的边框区域，最主要的是清除上次点击控件的边框，恢复原来状态
            foreach (Control ctrl in control.Parent.Controls)
                    if (ctrl is FrameControl)
                        ctrl.Visible = false;

                fControl = new FrameControl(control);
                control.Parent.Controls.Add(fControl);
            };

            //鼠标单击时
            control.MouseClick += (sender, e) =>
            {
                control.BringToFront();
                try
                {
                    RichTextBoxEx rtb = sender as RichTextBoxEx;
                    rtb.BorderStyle = BorderStyle.None;
                }
                catch (NullReferenceException)
                {
                    return;
                }
            };


            //鼠标键释放时
            control.MouseUp += (sender, e) =>
            {
                control.Refresh();

            //显示虚线
            fControl.DrawDottedLines();
            };
        }

    }
}