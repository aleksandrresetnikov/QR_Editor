using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pro_code_editor
{
    public partial class StartForm : Form
    {
        MainForm MainFormMissing;
        public StartForm()
        {
            MainFormMissing = new MainForm();
            this.CenterToScreen();
            InitializeComponent();
            MainFormMissing.Show();
            MainFormMissing.Visible = false;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = this.Left + e.X - lastPoint.X;
                this.Top = this.Top + e.Y - lastPoint.Y;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void timerCloseAtStart_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            pictureBox1.Image = null;
            pictureBox1.Dispose();
            GC.Collect();
            MainFormMissing.Visible = true;
            timerCloseAtStart.Enabled = false;
        }
    }
}
