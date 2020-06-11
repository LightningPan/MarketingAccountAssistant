using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessingDemo1;

namespace Video_generator
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void buttonVideo_Click(object sender, EventArgs e)
        {
           VideoHelper videoForm = new VideoHelper();
            this.Hide();
            videoForm.ShowDialog();
            Application.ExitThread();

        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            Application.ExitThread();
        }
    }
}
