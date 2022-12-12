
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
            this.label1 = new System.Windows.Forms.Label();
            this.FadeIn = new System.Windows.Forms.Timer(this.components);
            this.FadeOut = new System.Windows.Forms.Timer(this.components);
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.BindTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bind
            // 
            this.Bind.BackColor = System.Drawing.Color.White;
            this.Bind.CheckedState.Parent = this.Bind;
            this.Bind.CustomImages.Parent = this.Bind;
            this.Bind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Bind.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bind.ForeColor = System.Drawing.Color.White;
            this.Bind.HoveredState.Parent = this.Bind;
            this.Bind.Location = new System.Drawing.Point(105, 107);
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
            this.CPSText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CPSText.Location = new System.Drawing.Point(12, 107);
            this.CPSText.Name = "CPSText";
            this.CPSText.Size = new System.Drawing.Size(73, 26);
            this.CPSText.TabIndex = 1;
            this.CPSText.Text = "10 CPS";
            // 
            // Trackbar
            // 
            this.Trackbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Trackbar.HoveredState.Parent = this.Trackbar;
            this.Trackbar.Location = new System.Drawing.Point(12, 75);
            this.Trackbar.Maximum = 20;
            this.Trackbar.Minimum = 5;
            this.Trackbar.Name = "Trackbar";
            this.Trackbar.Size = new System.Drawing.Size(328, 26);
            this.Trackbar.TabIndex = 2;
            this.Trackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.Checkbox.Location = new System.Drawing.Point(17, 49);
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
            this.Random.Interval = 1100;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "BladeClicker";
            // 
            // FadeIn
            // 
            this.FadeIn.Interval = 40;
            this.FadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // FadeOut
            // 
            this.FadeOut.Interval = 40;
            this.FadeOut.Tick += new System.EventHandler(this.FadeOut_Tick);
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
            // BindTimer
            // 
            this.BindTimer.Enabled = true;
            this.BindTimer.Interval = 150;
            this.BindTimer.Tick += new System.EventHandler(this.BindTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(352, 145);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Trackbar);
            this.Controls.Add(this.CPSText);
            this.Controls.Add(this.Bind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BladeClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

