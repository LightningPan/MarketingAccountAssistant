using System;
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
            Image form = new Image();
            this.Hide();
            form.ShowDialog();
            Application.ExitThread();
        }
    }
}
