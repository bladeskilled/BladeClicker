
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
            this.Enable = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CPSText = new System.Windows.Forms.Label();
            this.Click = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.Bind = new System.Windows.Forms.Button();
            this.BindTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enable
            // 
            this.Enable.AutoSize = true;
            this.Enable.Font = new System.Drawing.Font("Aspekta 500", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enable.Location = new System.Drawing.Point(6, 5);
            this.Enable.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(106, 34);
            this.Enable.TabIndex = 0;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-1, 40);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(383, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // CPSText
            // 
            this.CPSText.AutoSize = true;
            this.CPSText.Font = new System.Drawing.Font("Aspekta 500", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSText.Location = new System.Drawing.Point(0, 85);
            this.CPSText.Name = "CPSText";
            this.CPSText.Size = new System.Drawing.Size(99, 34);
            this.CPSText.TabIndex = 2;
            this.CPSText.Text = "10 CPS";
            // 
            // Click
            // 
            this.Click.Enabled = true;
            this.Click.Tick += new System.EventHandler(this.Click_Tick);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Bind
            // 
            this.Bind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Bind.Font = new System.Drawing.Font("Aspekta 500", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bind.Location = new System.Drawing.Point(105, 82);
            this.Bind.Name = "Bind";
            this.Bind.Size = new System.Drawing.Size(277, 40);
            this.Bind.TabIndex = 3;
            this.Bind.Text = "Bind = none";
            this.Bind.UseVisualStyleBackColor = false;
            this.Bind.Click += new System.EventHandler(this.Bind_Click);
            this.Bind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Bind_KeyUp);
            // 
            // BindTimer
            // 
            this.BindTimer.Enabled = true;
            this.BindTimer.Interval = 150;
            this.BindTimer.Tick += new System.EventHandler(this.BindTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(382, 131);
            this.Controls.Add(this.Bind);
            this.Controls.Add(this.CPSText);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Enable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BladeClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Enable;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label CPSText;
        private System.Windows.Forms.Timer Click;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.Button Bind;
        private System.Windows.Forms.Timer BindTimer;
    }
}

