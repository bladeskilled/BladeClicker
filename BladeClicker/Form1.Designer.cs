
namespace BladeClicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Bind = new ns1.SiticoneButton();
            this.CPSText = new System.Windows.Forms.Label();
            this.Trackbar = new ns1.SiticoneMetroTrackBar();
            this.Checkbox = new ns1.SiticoneCustomCheckBox();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FadeIn = new System.Windows.Forms.Timer(this.components);
            this.FadeOut = new System.Windows.Forms.Timer(this.components);
            this.BindTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneCustomCheckBox1 = new ns1.SiticoneCustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clicksounds = new System.Windows.Forms.Timer(this.components);
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bind
            // 
            this.Bind.BackColor = System.Drawing.Color.White;
            this.Bind.CheckedState.Parent = this.Bind;
            this.Bind.CustomImages.Parent = this.Bind;
            this.Bind.FillColor = System.Drawing.Color.DimGray;
            this.Bind.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bind.ForeColor = System.Drawing.Color.White;
            this.Bind.HoveredState.Parent = this.Bind;
            this.Bind.Location = new System.Drawing.Point(111, 60);
            this.Bind.Name = "Bind";
            this.Bind.ShadowDecoration.Parent = this.Bind;
            this.Bind.Size = new System.Drawing.Size(235, 26);
            this.Bind.TabIndex = 0;
            this.Bind.Text = "Bind = none";
            this.Bind.Click += new System.EventHandler(this.Bind_Click);
            this.Bind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Bind_KeyUp);
            // 
            // CPSText
            // 
            this.CPSText.AutoSize = true;
            this.CPSText.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSText.ForeColor = System.Drawing.Color.White;
            this.CPSText.Location = new System.Drawing.Point(3, 60);
            this.CPSText.Name = "CPSText";
            this.CPSText.Size = new System.Drawing.Size(73, 26);
            this.CPSText.TabIndex = 1;
            this.CPSText.Text = "10 CPS";
            // 
            // Trackbar
            // 
            this.Trackbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Trackbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Trackbar.HoveredState.Parent = this.Trackbar;
            this.Trackbar.Location = new System.Drawing.Point(3, 31);
            this.Trackbar.Maximum = 20;
            this.Trackbar.Minimum = 5;
            this.Trackbar.Name = "Trackbar";
            this.Trackbar.Size = new System.Drawing.Size(343, 26);
            this.Trackbar.TabIndex = 2;
            this.Trackbar.ThumbColor = System.Drawing.Color.Red;
            this.Trackbar.Value = 10;
            this.Trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Trackbar_Scroll);
            // 
            // Checkbox
            // 
            this.Checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Checkbox.CheckedState.BorderRadius = 2;
            this.Checkbox.CheckedState.BorderThickness = 0;
            this.Checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Checkbox.CheckedState.Parent = this.Checkbox;
            this.Checkbox.Location = new System.Drawing.Point(10, 6);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.ShadowDecoration.Parent = this.Checkbox;
            this.Checkbox.Size = new System.Drawing.Size(20, 20);
            this.Checkbox.TabIndex = 4;
            this.Checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Checkbox.UncheckedState.BorderRadius = 2;
            this.Checkbox.UncheckedState.BorderThickness = 0;
            this.Checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Checkbox.UncheckedState.Parent = this.Checkbox;
            // 
            // AutoClicker
            // 
            this.AutoClicker.Enabled = true;
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Tick);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 500;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneButton2);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 45);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(276, 11);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(30, 26);
            this.siticoneButton2.TabIndex = 8;
            this.siticoneButton2.Text = "-";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(312, 11);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(30, 26);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "x";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "BladeClicker";
            // 
            // FadeIn
            // 
            this.FadeIn.Interval = 30;
            this.FadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // FadeOut
            // 
            this.FadeOut.Interval = 30;
            this.FadeOut.Tick += new System.EventHandler(this.FadeOut_Tick);
            // 
            // BindTimer
            // 
            this.BindTimer.Enabled = true;
            this.BindTimer.Interval = 150;
            this.BindTimer.Tick += new System.EventHandler(this.BindTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "AutoClicker";
            // 
            // siticoneCustomCheckBox1
            // 
            this.siticoneCustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCustomCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCustomCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCustomCheckBox1.CheckedState.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.Location = new System.Drawing.Point(10, 6);
            this.siticoneCustomCheckBox1.Name = "siticoneCustomCheckBox1";
            this.siticoneCustomCheckBox1.ShadowDecoration.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.siticoneCustomCheckBox1.TabIndex = 7;
            this.siticoneCustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCustomCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCustomCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCustomCheckBox1.UncheckedState.Parent = this.siticoneCustomCheckBox1;
            this.siticoneCustomCheckBox1.CheckedChanged += new System.EventHandler(this.siticoneCustomCheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(36, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "ClickSounds";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 26);
            this.textBox1.TabIndex = 10;
            // 
            // clicksounds
            // 
            this.clicksounds.Tick += new System.EventHandler(this.clicksounds_Tick);
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.DimGray;
            this.siticoneButton3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(187, 4);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(151, 25);
            this.siticoneButton3.TabIndex = 11;
            this.siticoneButton3.Text = "Open File";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 131);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Bind);
            this.tabPage1.Controls.Add(this.CPSText);
            this.tabPage1.Controls.Add(this.Checkbox);
            this.tabPage1.Controls.Add(this.Trackbar);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AutoClicker";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.siticoneButton3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.siticoneCustomCheckBox1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ClickSounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "File Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(352, 174);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BladeClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneButton Bind;
        private System.Windows.Forms.Label CPSText;
        private ns1.SiticoneMetroTrackBar Trackbar;
        private ns1.SiticoneCustomCheckBox Checkbox;
        private System.Windows.Forms.Timer AutoClicker;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer FadeIn;
        private System.Windows.Forms.Timer FadeOut;
        private ns1.SiticoneButton siticoneButton2;
        private ns1.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Timer BindTimer;
        private System.Windows.Forms.Label label2;
        private ns1.SiticoneCustomCheckBox siticoneCustomCheckBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer clicksounds;
        private ns1.SiticoneButton siticoneButton3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
    }
}

