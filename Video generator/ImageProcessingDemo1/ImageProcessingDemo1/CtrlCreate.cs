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
                Location = new Point(193, 34),
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
        public FlowLayoutPanel CreatePanel(RichTextBox rtb)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Width = 350,
                Height = 30,
                Visible = false,
                Location = new Point(rtb.Location.X, rtb.Location.Y - 35),
                Name = $"panel{count}"
            };
            panel.Controls.Add(CreateBtn("B", new Font("宋体", 9, FontStyle.Bold)));
            panel.Controls.Add(CreateBtn("I", new Font("宋体", 9, FontStyle.Italic)));
            panel.Controls.Add(CreateBtn("U", new Font("宋体", 9, FontStyle.Underline)));
            panel.Controls.Add(CreateBtn("S", new Font("宋体", 9, FontStyle.Strikeout)));
            panel.Controls.Add(CreateCbb());
            panel.Controls.Add(CreateNum());
            panel.Controls.Add(CreateBtn("C", new Font("宋体", 9)));
            panels.Add(panel);
            return panel;
        }

        //创建按钮
        private Button CreateBtn(string text, Font font)
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

        //选择字体控件
        private ComboBox CreateCbb()
        {
            ComboBox cbb = new ComboBox
            {
                Width = 140,
                Height = 25,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = $"cbb{count}"
            };
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                cbb.Items.Add(oneFontFamily.Name);
            }
            cbb.SelectedValueChanged += new EventHandler(events.ChangeFont);
            return cbb;
        }
        //字体大小控件
        private NumericUpDown CreateNum()
        {
            NumericUpDown num = new NumericUpDown
            {
                Width = 35,
                Height = 25,
                Minimum = 6,
                Maximum = 72,
                Name = $"num{count}"
            };
            num.ValueChanged += new EventHandler(events.ChangeSize);
            return num;
        }
    }
}
