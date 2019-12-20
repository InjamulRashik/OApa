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
        int timeCs, timeSec, timeMin , timeHour;
        bool isActive;
        public static int passValueMin;
        public static int passValueSec;
        public static string passRate;
        Camera camera;
        Timer t;
        BackgroundWorker worker;
        Bitmap CapImage;
        public QRView(dynamic rate)
        {
            InitializeComponent();

            passRate = rate;

            t = new Timer();
            camera = new Camera(pictureBoxQR);
            worker = new BackgroundWorker();

            worker.DoWork += Worker_DoWork;
            t.Tick += T_Tick;
            t.Interval = 1;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            CapImage = camera.GetBitmap();
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

                if(timeCs >= 60)
                {
                    timeSec++;
                    timeCs = 0;

                    if(timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;

                    }
                    if(timeMin >= 60)
                    {
                        timeHour++;
                        timeMin = 0;
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
            passValueMin = timeMin;
            passValueSec = timeSec;
        }

        private void QRView_Load(object sender, EventArgs e)
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;

            isActive = false;

        }

        

        private void jThinButtonDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaySlipView(passValueMin, passValueSec, passRate).Show();
        }

        private void jThinButtonStop_Click(object sender, EventArgs e)
        {
            try
            {
                isActive = false;
                t.Stop();
                camera.Stop();
                jThinButtonStop.Enabled = false;
                jThinButtonStart.Enabled = false;
            }
            catch (Exception ex)
            {
                camera.Stop();
                MessageBox.Show(ex.Message);

            }
        }

        private void jThinButtonStart_Click(object sender, EventArgs e)
        {
            //isActive = true;
            try
            {
                //isActive = true;
                camera.Start();
                t.Start();

                jThinButtonStop.Enabled = true;
                jThinButtonStart.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
