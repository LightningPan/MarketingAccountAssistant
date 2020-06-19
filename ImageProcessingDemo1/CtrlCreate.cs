using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingDemo1
{
    class CtrlCreate
    {
        public List<RichTextBoxEx> rtbs = new List<RichTextBoxEx>();//存放已创建的文本框
        public List<FlowLayoutPanel> panels = new List<FlowLayoutPanel>();//存放已创建的工具栏
        public int count = 0;//增加的文本框数量
        Events events = new Events();

        //创建文本框
        public RichTextBoxEx CreateRtb()
        {
            count++;
            RichTextBoxEx rtb = new RichTextBoxEx
            {
                Width = 60,
                Height = 30,
                Location = new Point(50, 260),
                BorderStyle = BorderStyle.Fixed3D,
                Name = $"rtb{count}"
            };
            rtbs.Add(rtb);
            rtb.Enter += new EventHandler(events.rtb_FocusEnter);
            rtb.Leave += new EventHandler(events.rtb_FocusLeave);
            rtb.Move += new EventHandler(events.rtb_Move);
            rtb.SelectionChanged += new EventHandler(events.rtb_SelectionChanged);
            //rtb.SelectionChanged += new EventHandler(events.ShowFont);
            rtb.MouseDown += new MouseEventHandler(events.PanelToFront);
            rtb.MouseClick += new MouseEventHandler(events.PanelToFront);
            events.rtbs = rtbs;
            events.panels = panels;
            rtb.SetFrame();
            return rtb;
        }

        //创建工具栏
        //创建工具栏
        public FlowLayoutPanel CreatePanel(RichTextBox rtb)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Width = 280,
                Height = 55,
                Visible = false,
                Location = new Point(rtb.Location.X, rtb.Location.Y - 65),
                Name = $"panel{count}",
                BorderStyle = BorderStyle.FixedSingle
            };
            panel.Controls.Add(CreateBtn1("B", new Font("宋体", 9, FontStyle.Bold)));
            panel.Controls.Add(CreateBtn1("I", new Font("宋体", 9, FontStyle.Italic)));
            panel.Controls.Add(CreateBtn1("U", new Font("宋体", 9, FontStyle.Underline)));
            panel.Controls.Add(CreateBtn1("S", new Font("宋体", 9, FontStyle.Strikeout)));
            panel.Controls.Add(CreateBtn2("左对齐", new Size(50, 20)));
            panel.Controls.Add(CreateBtn2("居中", new Size(40, 20)));
            panel.Controls.Add(CreateBtn2("右对齐", new Size(50, 20)));
            panel.Controls.Add(CreateCbb1());
            panel.Controls.Add(CreateCbb2());
            panel.Controls.Add(CreateBtn1("C", new Font("宋体", 9)));
            panel.Controls.Add(CreateBtn2("删除×", new Size(50, 20)));
            panels.Add(panel);
            return panel;
        }
        //创建按钮
        private Button CreateBtn1(string text, Font font)
        {
            Button btn = new Button
            {
                Width = 20,
                Height = 20,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = font,
                Name = $"btn{text}{count}"
            };
            btn.Click += new EventHandler(events.ChangeStyle);
            btn.Click += new EventHandler(events.ChangeColor);
            return btn;
        }

        private Button CreateBtn2(string text, Size size)
        {
            Button btn = new Button
            {
                Width = size.Width,
                Height = size.Height,
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter
            };
            switch (text)
            {
                case "左对齐":
                    btn.Name = $"btnL{count}";
                    break;
                case "居中":
                    btn.Name = $"btnM{count}";
                    break;
                case "右对齐":
                    btn.Name = $"btnR{count}";
                    break;
                case "删除×":
                    btn.Name = $"btnD{count}";
                    btn.ForeColor = Color.Red;
                    break;
            }
            btn.Click += new EventHandler(events.ChangeAlignment);
            btn.Click += (sender, e) =>
            {
                Button btnD = sender as Button;
                string btnName = btnD.Name.Substring(0, 4);
                if (btnName != "btnD")
                {
                    return;
                }
                string StrIndex = btn.Name.Substring(4, 1);
                int index = int.Parse(StrIndex);//当前文本框及工具栏序号
                rtbs[index - 1].Visible = false;
                panels[index - 1].Visible = false;
                foreach (Control ctrl in rtbs[index - 1].Parent.Controls)
                    if (ctrl is FrameControl)
                        ctrl.Visible = false;
            };
            return btn;
        }
        //选择字体
        private ComboBox CreateCbb1()
        {
            ComboBox cbb = new ComboBox
            {
                Width = 140,
                Height = 25,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = $"cbbF{count}"
            };
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                cbb.Items.Add(oneFontFamily.Name);
            }
            cbb.SelectedValueChanged += new EventHandler(events.ChangeFont);
            return cbb;
        }

        //字体大小
        private ComboBox CreateCbb2()
        {
            ComboBox cbb = new ComboBox
            {
                Width = 40,
                Height = 25,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = $"cbbS{count}"
            };
            for (int i = 6; i < 72; i++)
            {
                cbb.Items.Add(i);
            }
            cbb.SelectedValueChanged += new EventHandler(events.ChangeSize);
            return cbb;
        }
    }
}
