using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
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
        Point lastPoint;
        private void Trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSText.Text = Trackbar.Value.ToString() + " CPS";
        }

        private void AutoClicker_Tick(object sender, EventArgs e)
        {
            AutoClicker.Interval = 1000 / randomisedCPS;

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (Checkbox.Checked)
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

        int randomisedCPS = 10;
        private void Random_Tick(object sender, EventArgs e)
        {
            randomisedCPS = new Random().Next(Trackbar.Value - 2, Trackbar.Value + 2);
        }

        private void Bind_KeyUp(object sender, KeyEventArgs e)
        {
            if (Bind.Text == "Press Key To Bind")
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
            Bind.Text = "Press Key To Bind";
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                FadeIn.Stop();
            }
            Opacity += .1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                Opacity = 0;
            }

            FadeIn.Start();
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Close();
            }
            Opacity -= .1;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            FadeOut.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        public static KeysConverter Key = new KeysConverter();
        private void BindTimer_Tick(object sender, EventArgs e)
        {
            if (Bind.Text != "Bind = none")
            {
                if (Bind.Text != "Press Key To Bind")
                {
                    Keys key = (Keys)Key.ConvertFromString(Bind.Text);

                    if (GetAsyncKeyState(key) < 0)
                    {
                        Checkbox.Checked = !Checkbox.Checked;
                    }
                }
            }
        }
    }
}
