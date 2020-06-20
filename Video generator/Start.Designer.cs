namespace Video_generator
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVideo = new System.Windows.Forms.Button();
            this.buttonPicture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVideo.Location = new System.Drawing.Point(144, 61);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(170, 324);
            this.buttonVideo.TabIndex = 0;
            this.buttonVideo.Text = "视频";
            this.buttonVideo.UseVisualStyleBackColor = false;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonPicture
            // 
            this.buttonPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPicture.Location = new System.Drawing.Point(485, 61);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(170, 324);
            this.buttonPicture.TabIndex = 1;
            this.buttonPicture.Text = "海报";
            this.buttonPicture.UseVisualStyleBackColor = false;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPicture);
            this.Controls.Add(this.buttonVideo);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button buttonPicture;
    }
}