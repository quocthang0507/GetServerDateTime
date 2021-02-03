
namespace GetServerDateTime
{
	partial class MainForm
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
			this.cbxTimeServer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.chk24h = new System.Windows.Forms.CheckBox();
			this.tbxLog = new System.Windows.Forms.TextBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxTimeServer
			// 
			this.cbxTimeServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxTimeServer.FormattingEnabled = true;
			this.cbxTimeServer.Location = new System.Drawing.Point(258, 50);
			this.cbxTimeServer.Margin = new System.Windows.Forms.Padding(4);
			this.cbxTimeServer.Name = "cbxTimeServer";
			this.cbxTimeServer.Size = new System.Drawing.Size(187, 24);
			this.cbxTimeServer.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(146, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choose server:";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(528, 44);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 35);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// lblTime
			// 
			this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.lblTime.Location = new System.Drawing.Point(260, 78);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(261, 63);
			this.lblTime.TabIndex = 3;
			this.lblTime.Text = "hh:mm:ss";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk24h
			// 
			this.chk24h.AutoSize = true;
			this.chk24h.Location = new System.Drawing.Point(458, 53);
			this.chk24h.Name = "chk24h";
			this.chk24h.Size = new System.Drawing.Size(51, 21);
			this.chk24h.TabIndex = 2;
			this.chk24h.Text = "24h";
			this.chk24h.UseVisualStyleBackColor = true;
			// 
			// tbxLog
			// 
			this.tbxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbxLog.Location = new System.Drawing.Point(0, 211);
			this.tbxLog.Multiline = true;
			this.tbxLog.Name = "tbxLog";
			this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxLog.Size = new System.Drawing.Size(784, 250);
			this.tbxLog.TabIndex = 4;
			this.tbxLog.TextChanged += new System.EventHandler(this.tbxLog_TextChanged);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(609, 44);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 35);
			this.btnStop.TabIndex = 4;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnStop;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tbxLog);
			this.Controls.Add(this.chk24h);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxTimeServer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxTimeServer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.CheckBox chk24h;
		private System.Windows.Forms.TextBox tbxLog;
		private System.Windows.Forms.Button btnStop;
	}
}

