using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingDemo1
{
    class Events
    {
        //文本框及文本处理的事件实现
        //文本框及文本处理的事件实现

        public List<RichTextBoxEx> rtbs = new List<RichTextBoxEx>(); //存放已创建的文本框
        public List<FlowLayoutPanel> panels = new List<FlowLayoutPanel>();//工具栏
        public List<Font> fonts = new List<Font>(100);//存放已选文本的字体


        //检查焦点是否在容器内的控件上
        private bool IsFocused(Control fatherControl)
        {
            bool flag = false;
            Control.ControlCollection sonControls = fatherControl.Controls;
            foreach (Control c in sonControls)
            {
                if (c.Focused)
                {
                    flag = true;
                }
            }
            return flag;
        }

        //焦点进入文本框时显示工具栏
        public void rtb_FocusEnter(object sender, EventArgs e)
        {
            RichTextBoxEx rtb = sender as RichTextBoxEx;
            try
            {
                string StrIndex = rtb.Name.Substring(3, 1);
                int index = int.Parse(StrIndex);

                if (rtb.Name == $"rtb{StrIndex}")
                {
                    panels[index - 1].Visible = true;
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //焦点离开文本框时隐藏工具栏
        public void rtb_FocusLeave(object sender, EventArgs e)
        {
            RichTextBoxEx rtb = sender as RichTextBoxEx;
            try
            {
                string StrIndex = rtb.Name.Substring(3, 1);
                int index = int.Parse(StrIndex);

                if (rtb.Name == $"rtb{StrIndex}")
                {
                    if (!IsFocused(panels[index - 1]))
                    {
                        panels[index - 1].Visible = false;
                        rtb.Parent.Controls[0].Visible = false;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //文本框移动时对应的工具栏随之移动
        public void rtb_Move(object sender, EventArgs e)
        {
            RichTextBoxEx rtb = sender as RichTextBoxEx;

            try
            {
                string StrIndex = rtb.Name.Substring(3, 1);
                int index = int.Parse(StrIndex);

                if (rtb.Name == $"rtb{StrIndex}")
                {
                    panels[index - 1].Location = new Point(rtbs[index - 1].Location.X, rtbs[index - 1].Location.Y - 65);
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //点击文本框时工具栏在最前显示
        public void PanelToFront(object sender, EventArgs e)
        {
            RichTextBoxEx rtb = sender as RichTextBoxEx;
            string StrIndex = rtb.Name.Substring(3, 1);
            int index = int.Parse(StrIndex);
            panels[index - 1].BringToFront();

        }

        //选中文本更改时，遍历文本，获取每个字的字体
        public void rtb_SelectionChanged(object sender, EventArgs e)
        {
            fonts = new List<Font>();
            RichTextBoxEx rtb = sender as RichTextBoxEx;

            RichTextBox temp = new RichTextBox();
            int len = rtb.SelectionLength;//选中文本长度
            temp.Rtf = rtb.SelectedRtf;
            for (int i = 0; i < len; i++)
            {
                temp.Select(i, 1); //逐个选中副本中的文字
                fonts.Add(temp.SelectionFont);
            }
        }


        //选中时显示字体和大小
        public void ShowFont(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;

            string StrIndex = rtb.Name.Substring(3, 1);
            int index = int.Parse(StrIndex);//当前文本框及工具栏序号

            ComboBox cbbF = panels[index - 1].Controls[7] as ComboBox;
            ComboBox cbbS = panels[index - 1].Controls[8] as ComboBox;
            Font font = rtb.SelectionFont;
            if (font != null)
            {
                cbbF.SelectedItem = font.FontFamily.Name;
                cbbS.SelectedIndex = (int)font.Size - 6;
            }
            else
            {
                cbbF.SelectedItem = null;
                cbbS.SelectedItem = null;
            }
        }


        //粗体、斜体、下划线、删除线
        public void ChangeStyle(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            FontStyle style = new FontStyle();//当前要修改的格式
            switch (btn.Text)
            {
                case "B":
                    style = FontStyle.Bold;
                    break;
                case "I":
                    style = FontStyle.Italic;
                    break;
                case "U":
                    style = FontStyle.Underline;
                    break;
                case "S":
                    style = FontStyle.Strikeout;
                    break;
                default:
                    return;
            }

            string StrIndex = btn.Name.Substring(4, 1);
            int index = int.Parse(StrIndex);//当前文本框及工具栏序号

            int len = rtbs[index - 1].SelectionLength;//选中文本长度
            int rtbStart = rtbs[index - 1].SelectionStart;//选中文本起始位置
            bool isStyle = false;//判断该字体格式是否为粗体/斜体/下划线/删除线

            //遍历选中部分的每个字
            for (int i = 0; i < fonts.Count; i++)
            {
                switch (style)
                {
                    case FontStyle.Bold:
                        if (fonts[i].Bold) { isStyle = true; }
                        break;
                    case FontStyle.Italic:
                        if (fonts[i].Italic) { isStyle = true; }
                        break;
                    case FontStyle.Underline:
                        if (fonts[i].Underline) { isStyle = true; }
                        break;
                    case FontStyle.Strikeout:
                        if (fonts[i].Strikeout) { isStyle = true; }
                        break;
                    default:
                        break;
                }
                if (isStyle)
                {
                    fonts[i] = new Font(fonts[i], fonts[i].Style ^ style);
                }
                else
                {
                    fonts[i] = new Font(fonts[i], fonts[i].Style | style);
                }
            }

            RichTextBox temp = new RichTextBox();
            temp.Rtf = rtbs[index - 1].SelectedRtf;//将选中部分拷贝到副本中
            for (int i = 0; i < len; i++)
            {
                temp.Select(i, 1); //逐个选中副本中的文字
                temp.SelectionFont = fonts[i];
            }
            temp.Select(0, len);
            rtbs[index - 1].SelectedRtf = temp.SelectedRtf;
            rtbs[index - 1].Select(rtbStart, len);
            rtbs[index - 1].Focus();
        }

        //修改字体颜色
        public void ChangeColor(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "C") { return; }

            string StrIndex = btn.Name.Substring(4, 1);
            int index = int.Parse(StrIndex);//当前文本框及工具栏序号

            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowHelp = true;
            colorDialog.ShowDialog();

            rtbs[index - 1].SelectionColor = colorDialog.Color;
            rtbs[index - 1].Focus();
        }

        //修改字体大小
        public void ChangeSize(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

            string StrIndex = cbb.Name.Substring(4, 1);
            int index = int.Parse(StrIndex);//当前文本框及工具栏序号
            int rtbStart = rtbs[index - 1].SelectionStart;
            int len = rtbs[index - 1].SelectionLength;//选中文本长度
            RichTextBox temp = new RichTextBox();
            temp.Rtf = rtbs[index - 1].SelectedRtf;
            for (int i = 0; i < len; i++)
            {
                temp.Select(i, 1); //逐个选中副本中的文字
                temp.SelectionFont = new Font(fonts[i].FontFamily, (float)cbb.SelectedIndex + 6, fonts[i].Style);
            }
            temp.Select(0, len);
            rtbs[index - 1].SelectedRtf = temp.SelectedRtf;
            rtbs[index - 1].Select(rtbStart, len);
            rtbs[index - 1].Focus();
        }

        //更改字体
        public void ChangeFont(object sender, EventArgs e)
        {
            ComboBox cbb = sender as ComboBox;

            string StrIndex = cbb.Name.Substring(4, 1);
            int index = int.Parse(StrIndex);//当前文本框及工具栏序号
            string font = (string)cbb.SelectedItem;

            int len = rtbs[index - 1].SelectionLength;//选中文本长度
            int rtbStart = rtbs[index - 1].SelectionStart;
            RichTextBox temp = new RichTextBox();
            temp.Rtf = rtbs[index - 1].SelectedRtf;
            for (int i = 0; i < len; i++)
            {
                temp.Select(i, 1); //逐个选中副本中的文字
                temp.SelectionFont = new Font(font, temp.SelectionFont.Size, temp.SelectionFont.Style);
            }
            temp.Select(0, len);
            rtbs[index - 1].SelectedRtf = temp.SelectedRtf;

            rtbs[index - 1].Select(rtbStart, len);
            rtbs[index - 1].Focus();
        }

        //对齐方式
        public void ChangeAlignment(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string StrIndex = btn.Name.Substring(4, 1);
            int index = int.Parse(StrIndex);//当前文本框及工具栏序号

            string style = btn.Name.Substring(3, 1);
            switch (style)
            {
                case "L":
                    rtbs[index - 1].SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case "M":
                    rtbs[index - 1].SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case "R":
                    rtbs[index - 1].SelectionAlignment = HorizontalAlignment.Right;
                    break;
            }
        }
    }
}
