using System;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace GetServerDateTime
{
	public partial class MainForm : Form
	{
		private DateTime now;
		private Timer timer;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadServer();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void LoadServer()
		{
			cbxTimeServer.DataSource = TimeServer.Servers;
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (timer != null)
				btnStop.PerformClick();
			now = TimeServer.GetServerTime(cbxTimeServer.Text).ToLocalTime();
			tbxLog.Text += $"Time-server is {now.ToString()}\r\n";
			SetTimer();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer.Stop();
			timer.Dispose();
			tbxLog.Clear();
		}

		private void SetTimer()
		{
			// Create a timer with a one second interval.
			tbxLog.Text += "Timer is starting up...\r\n";
			timer = new Timer(1000);
			// Hook up the tick event for the timer. 
			timer.Elapsed += TimerSecond_Elapsed;
			timer.AutoReset = true;
			timer.Enabled = true;
			tbxLog.Text += "Timer has started up\r\n";
		}

		private void TimerSecond_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			now = now.AddSeconds(1);
			if (chk24h.Checked)
			{
				lblTime.Text = now.ToString("dd/MM/yyyy\nHH:mm:ss");
				tbxLog.Text += string.Format("The Elapsed event was raised at {0:HH:mm:ss.fff}\r\n", now);
			}
			else
			{
				lblTime.Text = now.ToString("dd/MM/yyyy\nhh:mm:ss");
				tbxLog.Text += string.Format("The Elapsed event was raised at {0:hh:mm:ss.fff}\r\n", now);
			}
		}

		private void tbxLog_TextChanged(object sender, EventArgs e)
		{
			tbxLog.SelectionStart = tbxLog.TextLength;
			tbxLog.ScrollToCaret();
		}

	}
}
