using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using BasselTech_CamCapture;

namespace Oapa_final_project.Views
{
    public partial class QRView : Form
    {
        int timeCs, timeSec, timeMin;
        bool isActive;

        Camera cam;
        Timer t;
        BackgroundWorker worker;
        Bitmap CapImage;
        public QRView()
        {
            InitializeComponent();

            t = new Timer();
            cam = new Camera(pictureBox1);
            worker = new BackgroundWorker();

            worker.DoWork += Worker_DoWork;
            t.Tick += T_Tick;
            t.Interval = 1;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            CapImage = cam.GetBitmap();
            if (CapImage != null && !worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            QRCodeDecoder Decoder = new QRCodeDecoder();

            try
            {
                DialogResult result = MessageBox.Show(Decoder.decode(new QRCodeBitmapImage(CapImage)));

                if(result == DialogResult.OK)
                {
                    isActive = true;
                }
            }
            catch(Exception)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCs++;

                if(timeCs >= 100)
                {
                    timeSec++;
                    timeCs = 0;

                    if(timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;

                    }
                }

            }

            DrawTime();

        }

        private void DrawTime()
        {
            labelCs.Text = String.Format("{0:00}", timeCs);
            labelSec.Text = String.Format("{0:00}", timeSec);
            labelMin.Text = String.Format("{0:00}", timeMin);
        }

        private void QRView_Load(object sender, EventArgs e)
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;

            isActive = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //isActive = true;

            try
            {

                cam.Start();
                t.Start();
                
                button2.Enabled = true;
                button1.Enabled = false;
            }
            catch(Exception ex)
            {
                cam.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                isActive = false;
                t.Stop();
                cam.Stop();
                button2.Enabled = false;
                button1.Enabled = true;
            }
            catch(Exception ex)
            {
                cam.Stop();
                MessageBox.Show(ex.Message);
               
            }
        }

    }
}
