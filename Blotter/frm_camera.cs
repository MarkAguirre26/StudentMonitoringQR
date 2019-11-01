using Camera_NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camera_NET;
using DirectShowLib;
using DPFP.Capture;
using AForge.Video.DirectShow;
using AForge.Video;


namespace AppSystem
{
    public partial class frm_camera : Form
    {


        //Capture capture = new Capture();        
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice finalFrame;


        public frm_camera()
        {
            InitializeComponent();
            //capture.StartCapture();
            //capture.EventHandler = this;
        }


        private void frm_camera_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            captureDevice = new FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
            foreach (AForge.Video.DirectShow.FilterInfo Device in captureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0;
            
            finalFrame = new VideoCaptureDevice();
            finalFrame = new VideoCaptureDevice(captureDevice[comboBox1.SelectedIndex].MonikerString);
            finalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            finalFrame.Start();


        }


        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                imgCapture.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

        }



        private void frm_camera_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (finalFrame.IsRunning == true)
            {
                finalFrame.Stop();
            }
     
        }

       

        private void cmd_capture_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = true;
            imgCapture.Visible = false;
            pictureBox1.Image = imgCapture.Image;
            cmd_reset.Enabled = true; cmd_save.Enabled = true; cmd_capture.Enabled = false;
        }

        private void cmd_reset_Click(object sender, EventArgs e)
        {
            try
            {

                pictureBox1.Visible = false;
                imgCapture.Visible = true;
                cmd_reset.Enabled = false; cmd_save.Enabled = false; cmd_capture.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     

        private void cmd_save_Click(object sender, EventArgs e)
        {
            var f = (Application.OpenForms["frm_user"] as frm_user);
            //.Image = imgCapture.Image;      
            if (f.wizard1.SelectedTab == f.tabPage3)
            {
                f.pbUser.Image = imgCapture.Image;
            }
            else
            {
                f.pbStudent.Image = imgCapture.Image;
            }
            pictureBox1.Visible = false;
            imgCapture.Visible = true;
            this.Close();
        }

    }
}
