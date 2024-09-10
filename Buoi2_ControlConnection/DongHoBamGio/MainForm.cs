using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace DongHoBamGio
{
    public partial class MainForm : Form
    {
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer timer;
        private int lapCount = 0;

        public MainForm()
        {
            InitializeComponent();

            // Khởi tạo đồng hồ bấm giờ và timer
            stopwatch = new Stopwatch();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1; // Đặt timer cập nhật mỗi mili giây
            timer.Tick += Timer_Tick;
        }

        // Sự kiện khi bấm nút Start/Stop
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timer.Stop();
                btnStartStop.Text = "Start"; 
            }
            else
            {
                stopwatch.Start();
                timer.Start();
                btnStartStop.Text = "Stop"; 
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            lapCount++;
            string currentTime = lblTimer.Text;

            // Ghi vào file số lần Lap và thời gian hiện tại
            using (StreamWriter writer = new StreamWriter("LapTimes.txt", true))
            {
                writer.WriteLine($"Lap {lapCount}: {currentTime}");
            }

            MessageBox.Show($"Lap {lapCount} đã được ghi lại.");
        }

        // Sự kiện cập nhật thời gian mỗi lần Timer tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = stopwatch.Elapsed;
            lblTimer.Text = string.Format("{0:00}:{1:00}:{2:00} {3:000}",
                elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
        }
    }
}
