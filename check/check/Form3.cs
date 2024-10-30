using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace check
{
    internal partial class Form3 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private Teacher Teacher;
        public Form3(Teacher teacher)
        {
            InitializeComponent();
            this.Teacher = teacher;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
            Application.Exit();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                comboBox1.Items.Add(filter.Name);
            }
            comboBox1.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1(Teacher).Show();
        }
    }
}
