using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BladeClicker
{
    public partial class Form1 : Form
    {
        #region dlls
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CPSText.Text = $"{trackBar1.Value} CPS";
        }

        private void Click_Tick(object sender, EventArgs e)
        {
            Click.Interval = 1000 / trackBar1.Value;

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (Enable.Checked)
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Task.Delay(20).Wait();
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                }
            }
        }

        int RandomisedCPS = 10;
        private void Random_Tick(object sender, EventArgs e)
        {
            RandomisedCPS = new Random().Next(trackBar1.Value - 3, trackBar1.Value + 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bind.FlatStyle = FlatStyle.Flat;
            Bind.FlatAppearance.BorderSize = 0;
        }

        private void Bind_KeyUp(object sender, KeyEventArgs e)
        {
            if (Bind.Text == "Press a key to bind")
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    Bind.Text = "Bind = none";
                }
                else
                {
                    Bind.Text = e.KeyCode.ToString();
                }
            }
        }

        private void Bind_Click(object sender, EventArgs e)
        {
            Bind.Text = "Press a key to bind";
        }

        public static KeysConverter Key = new KeysConverter();
        private void BindTimer_Tick(object sender, EventArgs e)
        {
            if (Bind.Text != "Bind = none")
            {
                if (Bind.Text != "Press a key to bind")
                {
                    Keys key = (Keys)Key.ConvertFromString(Bind.Text);

                    if (GetAsyncKeyState(key) < 0)
                    {
                        Enable.Checked = !Enable.Checked;
                    }
                }
            }
        }
    }
}
