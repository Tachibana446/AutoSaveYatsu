using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaveMan
{
    public partial class Form1 : Form
    {
        List<System.Diagnostics.Process> processes = new List<System.Diagnostics.Process>();
        bool start = false;
        int interval = 1000;

        public Form1()
        {
            InitializeComponent();
            reloadButton_Click(this, null);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            processComboBox.Items.Clear();
            processes = System.Diagnostics.Process.GetProcesses().OrderBy(p => p.MainWindowTitle).ToList();
            //processes.RemoveAll(p => p.MainWindowTitle == "");
            foreach (var p in processes)
            {
                processComboBox.Items.Add(p.ProcessName + " " + p.MainWindowTitle);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private void onOffButton_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                // Check
                if(timeTextBox.Text == "") { MessageBox.Show("時間を入力して下さい"); return; }
                try
                {
                    interval = int.Parse(timeTextBox.Text);
                    if(interval < 5)
                    {
                        MessageBox.Show("5分以上にしてください");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("入力内容が正しくありません。\n" + ex.Message);
                    return;
                }
                // Enable
                onOffButton.Text = "停止";
                processComboBox.Enabled = false;
                timeTextBox.Enabled = false;
                // Timer Start
                timer1.Interval = interval * 60 * 1000;
                timer1.Start();
                // CountDown
                minLabel.Text = interval.ToString().PadLeft(2,'0'); secLabel.Text = "00";
                CountDownTimer.Start();

                start = true;
            }
            else
            {
                onOffButton.Text = "開始";
                timer1.Stop();
                CountDownTimer.Stop();
                start = false;
                timeTextBox.Enabled = true;
                processComboBox.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = processComboBox.SelectedIndex;
            var p = processes[i];
            // Active
            SetForegroundWindow(p.MainWindowHandle);
            // Send Key
            SendKeys.Send("^s");
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            int min = int.Parse(minLabel.Text);
            int sec = int.Parse(secLabel.Text);
            sec -= 1;
            if (sec < 0)
            {
                sec = 59;
                min -= 1;
                if (min < 0)
                {
                    min = interval - 1;
                }
            }
            minLabel.Text = min.ToString().PadLeft(2, '0');
            secLabel.Text = sec.ToString().PadLeft(2, '0');
        }

        private void countDownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (countDownCheckBox.Checked)
            {
                countDownFlowLayoutPanel.Visible = true;
            }
            else
            {
                countDownFlowLayoutPanel.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("製作者：@Shiso_no_ha\nこのソフトウェアによるいかなる損害に対しても製作者は責任を負いかねます。\n使用には自己責任でお願いします。");
        }
    }
}
